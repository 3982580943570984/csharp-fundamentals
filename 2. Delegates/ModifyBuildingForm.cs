using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Studying
{
    public partial class ModifyBuildingForm : Form
    {
        private readonly int index;
        private event BuildingHandler.Modification ModificationResult;

        public ModifyBuildingForm()
        {
            InitializeComponent();
            CityTextBox.Validating += CityTextBox_Validating;
            StreetTextBox.Validating += StreetTextBox_Validating;
            TypeTextBox.Validating += TypeTextBox_Validating;
            YearTextBox.Validating += YearTextBox_Validating;
            NumberTextBox.Validating += NumberTextBox_Validating;
            WidthTextBox.Validating += WidthTextBox_Validating;
            LengthTextBox.Validating += LengthTextBox_Validating;
            HeightTextBox.Validating += HeightTextBox_Validating;

            ModificationResult += MessageBox.Show;
        }

        public ModifyBuildingForm(int index) : this()
        {
            this.index = index;
            Building building = (Building) BuildingHandler.buildings[index];
            CityTextBox.Text = building.City;
            StreetTextBox.Text = building.Street;
            TypeTextBox.Text = building.Type;
            YearTextBox.Text = building.ConstructionYear.ToString();
            NumberTextBox.Text = building.Number.ToString();
            WidthTextBox.Text = building.Width.ToString();
            LengthTextBox.Text = building.Length.ToString();
            HeightTextBox.Text = building.Height.ToString();
        }

        private void CityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") && !string.IsNullOrEmpty(CityTextBox.Text))
                errorProvider.SetError(CityTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void StreetTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(StreetTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") && !string.IsNullOrEmpty(StreetTextBox.Text))
                errorProvider.SetError(StreetTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void TypeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(TypeTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") && !string.IsNullOrEmpty(TypeTextBox.Text))
                errorProvider.SetError(TypeTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void YearTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(YearTextBox.Text, @"^[0-9]{1,4}$") && !string.IsNullOrEmpty(YearTextBox.Text))
                errorProvider.SetError(YearTextBox, "Неверный формат (От 1 до 4 цифр включительно)");
            else
                errorProvider.Clear();
        }

        private void NumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(NumberTextBox.Text, @"^[0-9]{1,5}$") && !string.IsNullOrEmpty(NumberTextBox.Text))
                errorProvider.SetError(NumberTextBox, "Неверный формат (От 1 до 5 цифр включительно)");
            else
                errorProvider.Clear();
        }

        private void WidthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(WidthTextBox.Text, @"^([0-9]*[.])?[0-9]+$") && !string.IsNullOrEmpty(WidthTextBox.Text))
                errorProvider.SetError(WidthTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private void LengthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(LengthTextBox.Text, @"^([0-9]*[.])?[0-9]+$") && !string.IsNullOrEmpty(LengthTextBox.Text))
                errorProvider.SetError(LengthTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private void HeightTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(HeightTextBox.Text, @"^([0-9]*[.])?[0-9]+$") && !string.IsNullOrEmpty(HeightTextBox.Text))
                errorProvider.SetError(HeightTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private bool IsValidated()
        {
            if ((Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") || string.IsNullOrEmpty(CityTextBox.Text))
                && (Regex.IsMatch(StreetTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") || string.IsNullOrEmpty(StreetTextBox.Text))
                && (Regex.IsMatch(TypeTextBox.Text, @"^[А-Я]{1}[ёа-я]+$") || string.IsNullOrEmpty(TypeTextBox.Text))
                && (Regex.IsMatch(YearTextBox.Text, @"^[0-9]{1,4}$") || string.IsNullOrEmpty(YearTextBox.Text))
                && (Regex.IsMatch(NumberTextBox.Text, @"^[0-9]{1,5}$") || string.IsNullOrEmpty(NumberTextBox.Text))
                && (Regex.IsMatch(WidthTextBox.Text, @"^([0-9]*[.])?[0-9]+$") || string.IsNullOrEmpty(WidthTextBox.Text))
                && (Regex.IsMatch(LengthTextBox.Text, @"^([0-9]*[.])?[0-9]+$") || string.IsNullOrEmpty(LengthTextBox.Text))
                && (Regex.IsMatch(HeightTextBox.Text, @"^([0-9]*[.])?[0-9]+$") || string.IsNullOrEmpty(HeightTextBox.Text)))
                return true;
            return false;
        }

        private void Insert_Click(object sender, System.EventArgs e)
        {
            if (IsValidated())
            {
                BuildingHandler.buildings[index] = new Building(city: CityTextBox.Text,
                            street: StreetTextBox.Text,
                            type: TypeTextBox.Text,
                            constructionYear: System.Convert.ToUInt16(YearTextBox.Text),
                            number: System.Convert.ToUInt32(NumberTextBox.Text),
                            width: System.Convert.ToUInt32(WidthTextBox.Text),
                            length: System.Convert.ToUInt32(LengthTextBox.Text),
                            height: System.Convert.ToUInt32(HeightTextBox.Text));
                ModificationResult("Здание изменено");
            }
            else
            {
                ModificationResult("Введенные параметры введены некорректно");
            }
        }

        private void Cancel_Click(object sender, System.EventArgs e) => Close();
    }
}
