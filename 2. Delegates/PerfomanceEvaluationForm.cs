using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Studying
{
    public partial class PerfomanceEvaluationForm : Form
    {
        private readonly List<Building> Buildings = new List<Building>();
        private readonly List<Building> BuildingArray = new List<Building>();
        private readonly Hashtable BuildingHashtable = new Hashtable();

        public PerfomanceEvaluationForm() {
            InitializeComponent();
            listView1.Items[0].SubItems.Add("");
            listView1.Items[1].SubItems.Add("");
        }

        private void Cancel_Click(object sender, EventArgs e) => Close();

        private void Generation_Click(object sender, EventArgs e)
        {
            Buildings.Clear();
            BuildingArray.Clear();
            BuildingHashtable.Clear();

            Random rnd = new Random();
            for (int i = 0; i < 100_00; ++i) {
                Building b = new Building(
                    city: string.Empty,
                    street: string.Empty,
                    type: string.Empty,
                    constructionYear: (ushort) rnd.Next(ushort.MaxValue),
                    number: (uint) rnd.Next(int.MaxValue),
                    width: (uint)rnd.Next(int.MaxValue),
                    length: (uint) rnd.Next(int.MaxValue),
                    height: (uint) rnd.Next(int.MaxValue)
                );

                Buildings.Add(b);
                BuildingArray.Add(b);
                BuildingHashtable.Add(b.ToString().GetHashCode(), b);
            }

            MessageBox.Show("Генерация завершена");
        }

        private void SequentialSearch_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();   
            foreach (Building building in Buildings)
                BuildingArray.Contains(building);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            listView1.Items[0].SubItems[1].Text = elapsedMs.ToString();

            watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Building building in Buildings)
                BuildingHashtable.Contains(building.ToString().GetHashCode());
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;

            listView1.Items[1].SubItems[1].Text = elapsedMs.ToString();

            MessageBox.Show("Последовательный поиск завершен");
        }

        private void RandomSearch_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Building[] RandomBuildings = Buildings.OrderBy(x => rnd.Next()).ToArray();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Building building in RandomBuildings)
                BuildingArray.Contains(building);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            listView1.Items[0].SubItems[1].Text = elapsedMs.ToString();

            watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Building building in RandomBuildings)
                BuildingHashtable.Contains(building.ToString().GetHashCode());
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;

            listView1.Items[1].SubItems[1].Text = elapsedMs.ToString();

            MessageBox.Show("Случайный поиск завершен");
        }
    }
}
