using OOP_3;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Studying
{
    public partial class MainForm : Form
    {
        private event BuildingHandler.Deletion DeletionResult = str => { return MessageBox.Show(str); };

        public MainForm() {
            InitializeComponent();
            DrawBuildingsItems();
        }

        private void DrawBuildingsItems()
        {
            BuildingsItems.Items.Clear();
            int counter = 0;
            foreach (DictionaryEntry pair in BuildingHandler.buildings)
                BuildingsItems.Items.Add((counter++).ToString() + ": " + pair.Value.ToString());
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
                Building building = (Building) GetBuilding();
                BuildingHandler.buildings.Remove((building).GetHashCode());
                DrawBuildingsItems();
                DeletionResult("Здание удалено");
            }
            else
            {
                DeletionResult("Не выбрано здание для удаления");
            }
        }

        private void ExceptionGenerator_Click(object sender, System.EventArgs e)
        {
            try
            {
                throw new MyStackOverflowException();
            }
            catch (System.Exception exception)
            {
                Win32.MessageBox(0, exception.ToString(), exception.Message, 0);
            }
        }

        private void ModifyBuilding_Click(object sender, System.EventArgs e)
        {
            if (BuildingsItems.SelectedItem != null)
            {
                Hide();
                Building building = (Building) GetBuilding();
                ModifyBuildingForm modifyBuildingForm = new ModifyBuildingForm(building.GetHashCode());
                modifyBuildingForm.ShowDialog();
                DrawBuildingsItems();
                Show();
            }
            else
            {
                MessageBox.Show("Не выбрано здание для изменения");
            }
        }

        private object GetBuilding()
        {
            int counter = 0;
            foreach (DictionaryEntry pair in BuildingHandler.buildings)
            {
                if (counter != BuildingsItems.SelectedIndex)
                    ++counter;
                else
                    return pair.Value;
            }
            return new object();
        }

        private void PerfomEvaluation_Click(object sender, EventArgs e)
        {
            Hide();
            PerfomanceEvaluationForm perfomanceEvaluationForm = new PerfomanceEvaluationForm();
            perfomanceEvaluationForm.ShowDialog();
            DrawBuildingsItems();
            Show();
        }
    }
}
