using System.Collections;

namespace Studying;

public partial class MainForm : Form
{
    private readonly CollectionType<House> houses = new();
    private ArrayList collections = new();

    public MainForm()
    {
        InitializeComponent();

        comboBoxQueries.SelectedIndex = 0;
        comboBoxSortings.SelectedIndex = 0;
        comboBoxCollectionType.SelectedIndex = 0;
    }

    private void TableLayoutPanelHousesManipulators_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (e.Row % 2 == 0)
        {
            var brush = new SolidBrush(Color.FromArgb(227, 208, 216));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
        else
        {
            var brush = new SolidBrush(Color.FromArgb(255, 240, 245));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
    }
    private void TableLayoutPanelStringManipulators_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (e.Row % 2 == 0)
        {
            var brush = new SolidBrush(Color.FromArgb(227, 208, 216));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
        else
        {
            var brush = new SolidBrush(Color.FromArgb(255, 240, 245));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
    }
    private void TableLayoutPanelCollectionsManipulators_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (e.Row % 2 == 0)
        {
            var brush = new SolidBrush(Color.FromArgb(227, 208, 216));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
        else
        {
            var brush = new SolidBrush(Color.FromArgb(255, 240, 245));
            e.Graphics.FillRectangle(brush, e.CellBounds);
        }
    }

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        houses.Clear();
        for (int i = 0; i < (int)numericUpDownHousesNumber.Value; ++i)
            houses.Add(HouseGenerator.Generate());

        listBoxHouses.Items.Clear();
        listBoxHouses.Items.AddRange(houses.ToArray());
    }
    private void ButtonExecuteRequest_Click(object sender, EventArgs e)
    {
        if (comboBoxQueries.SelectedItem.ToString() == "Дома после 2000 г.")
        {
            var query = from house in houses
                        where house.YearBuilt > 2000
                        orderby house.YearBuilt
                        select house;

            string result = string.Join(Environment.NewLine + Environment.NewLine, query.Select(house => house.ToString()));
            MessageBox.Show(result, "Дома после 2000 г.");
        }
        else if (comboBoxQueries.SelectedItem.ToString() == "Кол-во домов с 10+ кв.")
        {
            var query = (from house in houses
                         where house.NumberOfApartments > 10
                         select house)
                        .Count();

            string result = $"Количество домов с более 10 квартирами: {query}";
            MessageBox.Show(result, "Кол-во домов с 10+ кв.");
        }
        else if (comboBoxQueries.SelectedItem.ToString() == "На улице Орджоникидзе")
        {
            var query = from house in houses
                        where house.Street == "Орджоникидзе" && house.NumberOfFloors > 2
                        orderby house.NumberOfApartments descending
                        select house;

            string result = string.Join(Environment.NewLine + Environment.NewLine, query.Select(house => house.ToString()));
            MessageBox.Show(result, "На улице Орджоникидзе");
        }
        else if (comboBoxQueries.SelectedItem.ToString() == "Банки в Москве")
        {
            var query = from house in houses
                        where house.City == "Москва" && house.Type == "Банк"
                        orderby house.Number
                        select house;

            string result = string.Join(Environment.NewLine + Environment.NewLine, query.Select(house => house.ToString()));
            MessageBox.Show(result, "Банки в Москве");
        }
        else if (comboBoxQueries.SelectedItem.ToString() == "Квартиры 2020 г.")
        {
            var query = from house in houses
                        where house.YearBuilt == 2020
                        select house.NumberOfApartments;

            var totalNumberOfApartments = query.Sum(apartments => apartments);
            string result = $"Количество квартир в домах 2020 года: {totalNumberOfApartments}";
            MessageBox.Show(result, "Квартиры 2020 г.");
        }
    }
    private void ButtonCreateCollections_Click(object sender, EventArgs e)
    {
        collections = new();

        var collectionNumber = (uint)numericUpDownCollectionsNumber.Value;
        var collectionSize = (uint)numericUpDownCollectionsSize.Value;

        Random random = new();

        for (int i = 0; i < collectionNumber; i++)
        {
            var numberOfHouses = random.Next((int)collectionSize) + 1;
            collections.Add(new CollectionType<House>(Enumerable.Range(1, numberOfHouses)
                                                                .Select(_ => HouseGenerator.Generate())));
        }

        listBoxCollections.Items.Clear();

        int index = 0;
        foreach (CollectionType<House> collection in collections)
            listBoxCollections.Items.Add($"Номер: {index++}, Размер: {collection.Count}, Квартиры: {collection.Sum(house => house.NumberOfApartments)}");
    }
    private void ButtonCollectionsAmount_Click(object sender, EventArgs e)
    {
        if (collections.Count != 0)
        {
            var value = numericUpDownSumValue.Value;
            int count = collections.Cast<CollectionType<House>>()
                                   .Where(collection => collection.Sum(house => house.NumberOfApartments) > value)
                                   .Count();
            MessageBox.Show($"Количество коллекций с суммарным числом квартир более {value}: {count}");
        }
        else
        {
            MessageBox.Show("Коллекции не созданы");
        }
    }
    private void ButtonStringAdd_Click(object sender, EventArgs e)
    {
        if (textBoxStringInput.Text.Length != 0)
            listBoxStrings.Items.Add(textBoxStringInput.Text);
    }
    private void ButtonStringSave_Click(object sender, EventArgs e)
    {
        using StreamWriter writer = new("input.txt");
        foreach (string item in listBoxStrings.Items)
            writer.WriteLine(item);
        writer.Close();
    }
    private void ButtonStringFind_Click(object sender, EventArgs e)
    {
        string searchString = textBoxStringFind.Text;
        List<string> matchList = new();

        foreach (string item in listBoxStrings.Items)
            if (item.Contains(searchString))
                matchList.Add(item);

        string result = string.Join(Environment.NewLine, matchList);
        MessageBox.Show(result);
    }
    private void ButtonStringLengthCount_Click(object sender, EventArgs e)
    {
        int count = listBoxStrings.Items
            .Cast<string>()
            .Count(item => item.Length >= (int)numericUpDownStringLength.Value);

        MessageBox.Show(count.ToString());
    }
    private void ButtonStringSort_Click(object sender, EventArgs e)
    {
        if (comboBoxSortings.SelectedItem.ToString() == "По возрастанию")
        {
            var items = listBoxStrings.Items.Cast<string>().ToList();
            listBoxStrings.Items.Clear();
            listBoxStrings.Items.AddRange(items.OrderBy(item => item).ToArray());
        }
        else
        {
            var items = listBoxStrings.Items.Cast<string>().ToList();
            listBoxStrings.Items.Clear();
            listBoxStrings.Items.AddRange(items.OrderByDescending(item => item).ToArray());
        }
    }
    private void ButtonCollectionsFind_Click(object sender, EventArgs e)
    {
        if (comboBoxCollectionType.SelectedItem.ToString() == "Минимальная")
        {
            if (collections.Count != 0)
            {
                int minCount = collections.Cast<CollectionType<House>>().Min().Count;
                MessageBox.Show($"Минимальное количество домов в коллекциях: {minCount}");
            }
            else
            {
                MessageBox.Show("Коллекции не созданы");
            }
        }
        else if (comboBoxCollectionType.SelectedItem.ToString() == "Максимальная")
        {
            if (collections.Count != 0)
            {
                int maxCount = collections.Cast<CollectionType<House>>().Max().Count;
                MessageBox.Show($"Максимальное количество домов в коллекциях: {maxCount}");
            }
            else
            {
                MessageBox.Show("Коллекции не созданы");
            }
        }
    }
    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}