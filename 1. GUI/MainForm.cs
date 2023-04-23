using System.Windows.Forms;

namespace Studying
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); DrawBuildingsItems(); }

        private void DrawBuildingsItems()
        {
            BuildingsItems.Items.Clear();
            int counter = 0;
            foreach (Building building in Program.buildings)
                BuildingsItems.Items.Add((counter++).ToString() + ": " + building.ToString());
        }

        private void Exit_Click(object sender, System.EventArgs e) => Close();

        private void CreateBuilding_Click(object sender, System.EventArgs e)
        {
            Hide();
            CreateBuildingForm createBuildingForm = new CreateBuildingForm();
            createBuildingForm.ShowDialog();
            DrawBuildingsItems();
            Show();
        }

        private void DeleteBuilding_Click(object sender, System.EventArgs e)
        {
            if (BuildingsItems.SelectedItem != null)
            {
                Program.buildings.RemoveAt(BuildingsItems.SelectedIndex);
                DrawBuildingsItems();
                MessageBox.Show("Здание удалено");
            } else
            {
                MessageBox.Show("Не выбрано здание для удаления");
            }
        }

        private void ExceptionGenerator_Click(object sender, System.EventArgs e)
        {
            try {
                throw new MyStackOverflowException();
            } catch (System.Exception exception) {
                Win32.MessageBox(0, exception.ToString(), exception.Message, 0);
            }
        }

        private void ModifyBuilding_Click(object sender, System.EventArgs e)
        {
            if (BuildingsItems.SelectedItem != null)
            {
                Hide();
                ModifyBuildingForm modifyBuildingForm = new ModifyBuildingForm(BuildingsItems.SelectedIndex);
                modifyBuildingForm.ShowDialog();
                DrawBuildingsItems();
                Show();
            }
            else
            {
                MessageBox.Show("Не выбрано здание для изменения");
            }
        }
    }
}
