using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Studying
{
    public partial class CreateBuildingForm : Form
    {
        private event BuildingHandler.Creation CreationResult;

        public CreateBuildingForm()
        {
            InitializeComponent();

            NoParameters.Checked = true;
            CityTextBox.Validating += CityTextBox_Validating;
            StreetTextBox.Validating += StreetTextBox_Validating;
            TypeTextBox.Validating += TypeTextBox_Validating;
            YearTextBox.Validating += YearTextBox_Validating;
            NumberTextBox.Validating += NumberTextBox_Validating;
            WidthTextBox.Validating += WidthTextBox_Validating;
            LengthTextBox.Validating += LengthTextBox_Validating;
            HeightTextBox.Validating += HeightTextBox_Validating;

            CreationResult += MessageBox.Show;
        }

        private void Cancel_Click(object sender, System.EventArgs e) => Close();

        private void NoParameters_CheckedChanged(object sender, System.EventArgs e)
        {
            CityTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            TypeTextBox.Enabled = false;
            YearTextBox.Enabled = false;
            NumberTextBox.Enabled = false;
            WidthTextBox.Enabled = false;
            LengthTextBox.Enabled = false;
            HeightTextBox.Enabled = false;
        }

        private void OneParameter_CheckedChanged(object sender, System.EventArgs e)
        {
            CityTextBox.Enabled = true;
            StreetTextBox.Enabled = false;
            TypeTextBox.Enabled = false;
            YearTextBox.Enabled = false;
            NumberTextBox.Enabled = false;
            WidthTextBox.Enabled = false;
            LengthTextBox.Enabled = false;
            HeightTextBox.Enabled = false;
        }

        private void TwoParameters_CheckedChanged(object sender, System.EventArgs e)
        {
            CityTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            TypeTextBox.Enabled = false;
            YearTextBox.Enabled = false;
            NumberTextBox.Enabled = false;
            WidthTextBox.Enabled = false;
            LengthTextBox.Enabled = false;
            HeightTextBox.Enabled = false;
        }

        private void AllParameters_CheckedChanged(object sender, System.EventArgs e)
        {
            CityTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            TypeTextBox.Enabled = true;
            YearTextBox.Enabled = true;
            NumberTextBox.Enabled = true;
            WidthTextBox.Enabled = true;
            LengthTextBox.Enabled = true;
            HeightTextBox.Enabled = true;
        }

        private void CityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CityTextBox.Text))
                errorProvider.SetError(CityTextBox, "Не указан город");
            else if (!Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$"))
                errorProvider.SetError(CityTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void StreetTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(StreetTextBox.Text))
                errorProvider.SetError(StreetTextBox, "Не указана улица");
            else if (!Regex.IsMatch(StreetTextBox.Text, @"^[А-Я]{1}[ёа-я]+$"))
                errorProvider.SetError(StreetTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void TypeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TypeTextBox.Text))
                errorProvider.SetError(TypeTextBox, "Не указан тип здания");
            else if (!Regex.IsMatch(TypeTextBox.Text, @"^[А-Я]{1}[ёа-я]+$"))
                errorProvider.SetError(TypeTextBox, "Неверный формат (Только русский алфавит и с заглавной буквы)");
            else
                errorProvider.Clear();
        }

        private void YearTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(YearTextBox.Text))
                errorProvider.SetError(YearTextBox, "Не указан год постройки");
            else if (!Regex.IsMatch(YearTextBox.Text, @"^[0-9]{1,4}$"))
                errorProvider.SetError(YearTextBox, "Неверный формат (От 1 до 4 цифр включительно)");
            else
                errorProvider.Clear();
        }

        private void NumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NumberTextBox.Text))
                errorProvider.SetError(NumberTextBox, "Не указан номер здания");
            else if (!Regex.IsMatch(NumberTextBox.Text, @"^[0-9]{1,5}$"))
                errorProvider.SetError(NumberTextBox, "Неверный формат (От 1 до 5 цифр включительно)");
            else
                errorProvider.Clear();
        }

        private void WidthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(WidthTextBox.Text))
                errorProvider.SetError(WidthTextBox, "Не указана ширина здания");
            else if (!Regex.IsMatch(WidthTextBox.Text, @"^([0-9]*[.])?[0-9]+$"))
                errorProvider.SetError(WidthTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private void LengthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LengthTextBox.Text))
                errorProvider.SetError(LengthTextBox, "Не указана длина здания");
            else if (!Regex.IsMatch(LengthTextBox.Text, @"^([0-9]*[.])?[0-9]+$"))
                errorProvider.SetError(LengthTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private void HeightTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(HeightTextBox.Text))
                errorProvider.SetError(HeightTextBox, "Не указана высота здания");
            else if (!Regex.IsMatch(HeightTextBox.Text, @"^([0-9]*[.])?[0-9]+$"))
                errorProvider.SetError(HeightTextBox, "Неверный формат (целое или вещественное число)");
            else
                errorProvider.Clear();
        }

        private bool IsValidated()
        {
            if (NoParameters.Checked)
                return true;
            else if (OneParameter.Checked
                     && Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$"))
                return true;
            else if (TwoParameters.Checked
                     && Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$")
                     && Regex.IsMatch(StreetTextBox.Text, @"^[А-Я]{1}[ёа-я]+$"))
                return true;
            else if (AllParameters.Checked
                     && Regex.IsMatch(CityTextBox.Text, @"^[А-Я]{1}[ёа-я]+$")
                     && Regex.IsMatch(StreetTextBox.Text, @"^[А-Я]{1}[ёа-я]+$")
                     && Regex.IsMatch(TypeTextBox.Text, @"^[А-Я]{1}[ёа-я]+$")
                     && Regex.IsMatch(YearTextBox.Text, @"^[0-9]{1,4}$")
                     && Regex.IsMatch(NumberTextBox.Text, @"^[0-9]{1,5}$")
                     && Regex.IsMatch(WidthTextBox.Text, @"^([0-9]*[.])?[0-9]+$")
                     && Regex.IsMatch(LengthTextBox.Text, @"^([0-9]*[.])?[0-9]+$")
                     && Regex.IsMatch(HeightTextBox.Text, @"^([0-9]*[.])?[0-9]+$"))
                return true;
            return false;
        }

        private void Insert_Click(object sender, System.EventArgs e)
        {
            if (IsValidated())
            {
                if (NoParameters.Checked)
                {
                    Building building = new Building();
                    BuildingHandler.buildings.Add(building.GetHashCode(), building);
                }
                else if (OneParameter.Checked)
                {
                    Building building = new Building(city: CityTextBox.Text);
                    BuildingHandler.buildings.Add(building.GetHashCode(), building);
                }
                else if (TwoParameters.Checked)
                {
                    Building building = new Building(
                        city: CityTextBox.Text,
                        street: StreetTextBox.Text);
                    BuildingHandler.buildings.Add(building.GetHashCode(), building);
                }
                else if (AllParameters.Checked)
                {
                    Building building = new Building(
                        city: CityTextBox.Text,
                        street: StreetTextBox.Text,
                        type: TypeTextBox.Text,
                        constructionYear: Convert.ToUInt16(YearTextBox.Text),
                        number: Convert.ToUInt32(NumberTextBox.Text),
                        width: Convert.ToUInt32(WidthTextBox.Text),
                        length: Convert.ToUInt32(LengthTextBox.Text),
                        height: Convert.ToUInt32(HeightTextBox.Text));
                    BuildingHandler.buildings.Add(building.GetHashCode(), building);
                }

                CreationResult("Здание создано");
            }
            else
            {
                CreationResult("Выбранные параметры отсутствуют или введены некорректно");
            }
        }

        private void LengthTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void WidthTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void YearTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TypeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void StreetTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CityTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HeightTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
