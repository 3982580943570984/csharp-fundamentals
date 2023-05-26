using System.Text.RegularExpressions;

namespace Studying
{
    public partial class CreationForm : Form
    {

        private bool CityTextBoxValidated = false;
        private bool StreetTextBoxValidated = false;
        private bool TypeTextBoxValidated = false;
        private bool NumberTextBoxValidated = false;
        private bool YearBuiltTextBoxValidated = false;
        private bool NumberOfApartmentsTextBoxValidated = false;
        private bool NumberOfFloorsTextBoxValidated = false;

        public CreationForm() => InitializeComponent();

        private void Exit_Click(object sender, System.EventArgs e) => Close();

        private void CityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string city = CityTextBox.Text.Trim();
            if (!IsValidCity(city))
            {
                errorProvider.SetError(CityTextBox, "Некорректное название города");
                CityTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(CityTextBox, "");
                CityTextBoxValidated = true;
            }
        }

        private void StreetTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string street = StreetTextBox.Text.Trim();
            if (!IsValidStreet(street))
            {
                errorProvider.SetError(StreetTextBox, "Некорректное название улицы");
                StreetTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(StreetTextBox, "");
                StreetTextBoxValidated = true;
            }
        }

        private void TypeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string type = TypeTextBox.Text.Trim();
            if (!IsValidType(type))
            {
                errorProvider.SetError(TypeTextBox, "Некорректный тип здания");
                TypeTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(TypeTextBox, "");
                TypeTextBoxValidated = true;
            }
        }

        private void NumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string number = NumberTextBox.Text.Trim();
            if (!IsValidNumber(number))
            {
                errorProvider.SetError(NumberTextBox, "Некорректный номер здания");
                NumberTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(NumberTextBox, "");
                NumberTextBoxValidated = true;
            }
        }

        private void YearBuiltTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string year = YearBuiltTextBox.Text.Trim();
            if (!IsValidYear(year))
            {
                errorProvider.SetError(YearBuiltTextBox, "Некорректный год постройки");
                YearBuiltTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(YearBuiltTextBox, "");
                YearBuiltTextBoxValidated = true;
            }
        }

        private void NumberOfApartmentsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string number = NumberOfApartmentsTextBox.Text.Trim();
            if (!IsValidNumberOfApartments(number))
            {
                errorProvider.SetError(NumberOfApartmentsTextBox, "Некорректное количество квартир");
                NumberOfApartmentsTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(NumberOfApartmentsTextBox, "");
                NumberOfApartmentsTextBoxValidated = true;
            }
        }

        private void NumberOfFloorsTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string number = NumberOfFloorsTextBox.Text.Trim();
            if (!IsValidNumberOfFloors(number))
            {
                errorProvider.SetError(NumberOfFloorsTextBox, "Некорректное количество этажей");
                NumberOfFloorsTextBoxValidated = false;
            }
            else
            {
                errorProvider.SetError(NumberOfFloorsTextBox, "");
                NumberOfFloorsTextBoxValidated = true;
            }
        }

        private bool IsValidCity(string city)
        {
            Regex regex = new Regex("^[а-яА-Я]{4,}$");
            if (regex.IsMatch(city))
                return true;
            return false;
        }

        private bool IsValidStreet(string street)
        {
            Regex regex = new Regex("^[а-яА-Я]{4,}$");
            if (regex.IsMatch(street))
                return true;
            return false;
        }

        private bool IsValidType(string type)
        {
            Regex regex = new Regex("^[а-яА-Я]{3,}$");
            if (regex.IsMatch(type))
                return true;
            return false;
        }

        private bool IsValidNumber(string number)
        {
            Regex regex = new Regex("^(?!0)\\d{1,5}$|100000");
            if (regex.IsMatch(number))
                return true;
            return false;
        }

        private bool IsValidYear(string year)
        {
            Regex regex = new Regex("^(?!0)\\d{1,3}$|^[1-9]0{1,2}[1-9]$|^1\\d{3}$|^20[0-2]\\d$|^202[0-3]$");
            if (regex.IsMatch(year))
                return true;
            return false;
        }

        private bool IsValidNumberOfApartments(string numberOfApartments)
        {
            Regex regex = new Regex("^(?!0)\\d{1,5}$|100000");
            if (regex.IsMatch(numberOfApartments))
                return true;
            return false;
        }

        private bool IsValidNumberOfFloors(string numberOfFloors)
        {
            Regex regex = new Regex("^(?!0)\\d{1,3}$|10000");
            if (regex.IsMatch(numberOfFloors))
                return true;
            return false;
        }

        private bool IsValidTextBoxes() =>
            CityTextBoxValidated & StreetTextBoxValidated & TypeTextBoxValidated &
            NumberTextBoxValidated & YearBuiltTextBoxValidated & NumberOfApartmentsTextBoxValidated &
            NumberOfFloorsTextBoxValidated;

        private void PerformCreation_Click(object sender, System.EventArgs e)
        {
            if (IsValidTextBoxes())
            {
                var City = CityTextBox.Text;
                var Street = StreetTextBox.Text;
                var Type = TypeTextBox.Text;
                var Number = ushort.Parse(NumberTextBox.Text);
                var YearBuilt = ushort.Parse(YearBuiltTextBox.Text);
                var NumberOfApartments = ushort.Parse(NumberOfApartmentsTextBox.Text);
                var NumberOfFloors = ushort.Parse(NumberOfFloorsTextBox.Text);
                HouseData.houses.Add(new House(City, Street, Type, Number, YearBuilt, NumberOfApartments, NumberOfFloors));
                MessageBox.Show("Здание добавлено");

            }
            else
            {
                MessageBox.Show("Некоторые поля не прошли валидацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ushort amount = (ushort)Amount.Value;
            for (int i = 0; i < amount; ++i)
                HouseData.houses.Add(HouseGenerator.Generate());
            MessageBox.Show(this, "Успешная генерация");
        }
    }
}
