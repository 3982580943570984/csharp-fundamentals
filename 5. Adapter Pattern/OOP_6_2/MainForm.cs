using Timer = System.Windows.Forms.Timer;

namespace Studying;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        dataGridViewOfHouses.DataSource = HouseData.houses;
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        CreationForm creationForm = new();
        creationForm.ShowDialog(this);
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow selectedRow in dataGridViewOfHouses.SelectedRows)
        {
            // Получаем объект House, соответствующий выбранной строке
            House selectedHouse = (House)selectedRow.DataBoundItem;

            // Удаляем выбранную строку из источника данных DataGridView
            dataGridViewOfHouses.Rows.RemoveAt(selectedRow.Index);

            // Удаляем выбранный элемент из списка houses
            Studying.HouseData.houses.Remove(selectedHouse);
        }

        DeletionSignal.Visible = true;

        Timer timer = new() { Interval = 2500 };
        timer.Tick += (sender, e) =>
        {
            DeletionSignal.Visible = false;
            timer.Stop();
            timer.Dispose();
        };
        timer.Start();
    }

    private void buttonGetJSON_Click(object sender, EventArgs e)
    {
        if (dataGridViewOfHouses.SelectedRows.Count > 0)
        {
            House selectedHouse = (House)dataGridViewOfHouses.SelectedRows[0].DataBoundItem;
            HouseData.houseAdapter.SetHouse(selectedHouse);
            CustomMessageBox customMessageBox = new();
            customMessageBox.textBoxResult.Text = HouseData.houseAdapter.GetJSON();
            customMessageBox.ShowDialog(this);
        }
    }

    private void buttonGetXML_Click(object sender, EventArgs e)
    {
        if (dataGridViewOfHouses.SelectedRows.Count > 0)
        {
            House selectedHouse = (House)dataGridViewOfHouses.SelectedRows[0].DataBoundItem;
            HouseData.houseAdapter.SetHouse(selectedHouse);
            CustomMessageBox customMessageBox = new();
            customMessageBox.textBoxResult.Text = HouseData.houseAdapter.GetXML();
            customMessageBox.ShowDialog(this);
        }
    }

    private void buttonGetYAML_Click(object sender, EventArgs e)
    {
        if (dataGridViewOfHouses.SelectedRows.Count > 0)
        {
            House selectedHouse = (House)dataGridViewOfHouses.SelectedRows[0].DataBoundItem;
            HouseData.houseAdapter.SetHouse(selectedHouse);
            CustomMessageBox customMessageBox = new();
            customMessageBox.textBoxResult.Text = HouseData.houseAdapter.GetYAML();
            customMessageBox.ShowDialog(this);
        }
    }

    private void buttonGetCSV_Click(object sender, EventArgs e)
    {
        if (dataGridViewOfHouses.SelectedRows.Count > 0)
        {
            House selectedHouse = (House)dataGridViewOfHouses.SelectedRows[0].DataBoundItem;
            HouseData.houseAdapter.SetHouse(selectedHouse);
            CustomMessageBox customMessageBox = new();
            customMessageBox.textBoxResult.Text = HouseData.houseAdapter.GetCSV();
            customMessageBox.ShowDialog(this);
        }
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void dataGridViewOfHouses_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        MessageBox.Show(this, "Некорректное значение параметра");
    }
}