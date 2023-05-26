namespace Studying
{
    public partial class MainForm : Form
    {
        private HouseAggregate _houseAggregate = new();
        private HouseIterator _houseIterator;

        private int added = 0;
        private int deleted = 0;
        private int transitions = 0;

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
                _houseAggregate.AddHouse(HouseGenerator.Generate());
            _houseIterator = (HouseIterator) _houseAggregate.CreateIterator();
            _houseIterator.Next();

            Index.Maximum = _houseAggregate.GetCount();
            UpdateLogInfo();
            ShowCurrentHouse();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_houseIterator.HasNext())
                _houseIterator.Next();
            ShowCurrentHouse();
            UpdateLogInfo();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (_houseAggregate.GetCount() > 0)
            {
                _houseIterator.Prev();
                ShowCurrentHouse();
            }
            UpdateLogInfo();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_houseIterator.HasCurrent())
            {
                _houseAggregate.RemoveHouse(_houseIterator.GetCurrent());
                deleted++;
                if (_houseAggregate.GetCount() > 0)
                {
                    if (!_houseIterator.HasNext())
                        _houseIterator.Prev();
                    ShowCurrentHouse();
                }
                else 
                {
                    _houseIterator = (HouseIterator)_houseAggregate.CreateIterator();
                    listBoxCurrentHouse.Items.Clear();
                }

                Index.Maximum = _houseAggregate.GetCount();
                UpdateLogInfo();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var amount = (ushort)Amount.Value;
            added += amount;
            for (int i = 0; i < amount; ++i)
                _houseAggregate.AddHouse(HouseGenerator.Generate());

            if (!_houseIterator.HasCurrent())
            {
                _houseIterator.Next();
                ShowCurrentHouse();
            }

            Index.Maximum = _houseAggregate.GetCount();
            Index.Minimum = 1;
            UpdateLogInfo();
            MessageBox.Show(this, "Успешное добавление");
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var index = (ushort) Index.Value;
            if (index != 0 && index != _houseIterator.GetPosiiton() + 1)
            {
                transitions++;
                _houseIterator.MoveToPosition(index - 1);
                ShowCurrentHouse();
            }
            UpdateLogInfo();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            deleted += _houseAggregate.GetCount();
            _houseAggregate.Clear();
            _houseIterator = (HouseIterator)_houseAggregate.CreateIterator();
            listBoxCurrentHouse.Items.Clear();
            Index.Maximum = _houseAggregate.GetCount();
            UpdateLogInfo();
            MessageBox.Show(this, "Успешная очистка");
        }

        private void buttonExit_Click(object sender, EventArgs e) => Close();

        private void ShowCurrentHouse()
        {
            if (_houseIterator.HasCurrent())
            {
                var house = _houseIterator.GetCurrent();

                listBoxCurrentHouse.Items.Clear();
                listBoxCurrentHouse.Items.Add($"Городо:             {house.City}");
                listBoxCurrentHouse.Items.Add($"Улица:              {house.Street}");
                listBoxCurrentHouse.Items.Add($"Тип:                {house.Type}");
                listBoxCurrentHouse.Items.Add($"Номер:              {house.Number}");
                listBoxCurrentHouse.Items.Add($"Год постройки:      {house.YearBuilt}");
                listBoxCurrentHouse.Items.Add($"Количество этажей:  {house.NumberOfFloors}");
                listBoxCurrentHouse.Items.Add($"Количество квартир: {house.NumberOfApartments}");
            }
        }

        public void UpdateLogInfo() {
            labelForCurrentHouseIndex.Text = "Номер текущего здания: " + (_houseIterator.GetPosiiton() + 1);
            labelForHousesAmount.Text = "Кол-во зданий  в списке: " + _houseAggregate.GetCount();
            labelForAmountOfAdded.Text = "Кол-во добавленных зданий: " + added;
            labelForAmountOfDeleted.Text = "Кол-во удаленных зданий: " + deleted;
            labelForAmountOfTransitions.Text = "Кол-во переходов: " + transitions;
        }
    }
}