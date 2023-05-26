using System.Collections;
using System.Diagnostics;

namespace Studying;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        AppData.houses.HouseCollectionChanged += AppData.housesListener.OnHouseCollectionChanged;

        Collection.Width = listViewPerfomanceEvaluation.Width / 4;
        GenerationResult.Width = listViewPerfomanceEvaluation.Width / 4;
        SequentialSearchResult.Width = listViewPerfomanceEvaluation.Width / 4;
        RandomSearchResult.Width = listViewPerfomanceEvaluation.Width / 4;
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        Collection.Width = listViewPerfomanceEvaluation.Width / 4;
        GenerationResult.Width = listViewPerfomanceEvaluation.Width / 4;
        SequentialSearchResult.Width = listViewPerfomanceEvaluation.Width / 4;
        RandomSearchResult.Width = listViewPerfomanceEvaluation.Width / 4;
    }

    private void ButtonHouseCollectionAdd_Click(object sender, EventArgs e)
    {
        CreationForm creationForm = new();
        creationForm.ShowDialog(this);

        listBoxHouses.Items.Clear();
        foreach (DictionaryEntry houseEntry in AppData.houses)
            listBoxHouses.Items.Add(houseEntry.Value);
    }
    private void ButtonHouseCollectionGenerate_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < numericUpDownHousesAmount.Value; i++)
        {
            var house = HouseGenerator.Generate();
            AppData.houses.Add(house);
            listBoxHouses.Items.Add(house);
        }
    }
    private void ButtonHouseCollectionRemove_Click(object sender, EventArgs e)
    {
        if (listBoxHouses.SelectedItem != null)
        {
            AppData.houses.Remove((House)listBoxHouses.SelectedItem);
            listBoxHouses.Items.Remove(listBoxHouses.SelectedItem);
        }
    }
    private void ButtonTest_Click(object sender, EventArgs e)
    {
        var arrayItem = listViewPerfomanceEvaluation.Items[0];
        var hashtableItem = listViewPerfomanceEvaluation.Items[1];

        GenerateUniqueHouses();
        Random rnd = new();
        AppData.indexes = AppData.indexes.OrderBy(x => rnd.Next()).ToList();

        foreach (House house in AppData.uniqueHousesList)
            listBoxHousesGenerated.Items.Add(house);

        // Генерация элементов
        Stopwatch stopwatch = Stopwatch.StartNew();
        GenerateArrayHouses();
        arrayItem.SubItems[1].Text = $"{stopwatch.Elapsed.TotalNanoseconds} нс";

        stopwatch.Restart();
        GenerateHashtableHouses();
        hashtableItem.SubItems[1].Text = ($"{stopwatch.Elapsed.TotalNanoseconds} нс");

        // Последовательная выборка элементов
        stopwatch.Restart();
        SequentialSearchArrayHouses();
        arrayItem.SubItems[2].Text = ($"{stopwatch.Elapsed.TotalNanoseconds} нс");

        stopwatch.Restart();
        SequentialSearchHashtableHouses();
        hashtableItem.SubItems[2].Text = ($"{stopwatch.Elapsed.TotalNanoseconds} нс");

        // Случайная выборка элементов
        stopwatch.Restart();
        RandomSearchArrayHouses();
        arrayItem.SubItems[3].Text = ($"{stopwatch.Elapsed.TotalNanoseconds} нс");

        stopwatch.Restart();
        RandomSearchHashtableHouses();
        hashtableItem.SubItems[3].Text = ($"{stopwatch.Elapsed.TotalNanoseconds} нс");
    }

    private static void GenerateUniqueHouses()
    {
        AppData.uniqueHousesHashtable.Clear();
        AppData.uniqueHousesList.Clear();

        for (int i = 0; i < AppData.amountHouses; i++)
        {
            var house = HouseGenerator.Generate();
            if (!AppData.uniqueHousesHashtable.Contains(house.GetHashCode()))
            {
                AppData.uniqueHousesHashtable.Add(house.GetHashCode(), house);
                AppData.uniqueHousesList.Add(house);
            }
            else
            {
                --i;
            }
        }
    }
    private static void GenerateArrayHouses()
    {
        Array.Clear(AppData.arrayHouses);
        int count = 0;
        foreach (House house in AppData.uniqueHousesList)
            AppData.arrayHouses[count++] = house;
    }
    private static void GenerateHashtableHouses()
    {
        AppData.hashtableHouses.Clear();
        foreach (House house in AppData.uniqueHousesList)
            AppData.hashtableHouses.Add(house.GetHashCode(), house);
    }
    private static void SequentialSearchArrayHouses()
    {
        foreach (House house in AppData.uniqueHousesList)
            AppData.arrayHouses.Contains(house);
    }
    private static void SequentialSearchHashtableHouses()
    {
        foreach (DictionaryEntry house in AppData.uniqueHousesHashtable)
            AppData.hashtableHouses.Contains(house.Key);
    }
    private static void RandomSearchArrayHouses()
    {
        foreach (int index in AppData.indexes)
            AppData.arrayHouses.Contains(AppData.uniqueHousesList[index]);
    }
    private static void RandomSearchHashtableHouses()
    {
        foreach (int index in AppData.indexes)
            AppData.hashtableHouses.Contains(AppData.uniqueHousesList[index]);
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}