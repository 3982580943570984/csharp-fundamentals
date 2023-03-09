namespace Studying
{
    internal class Dialog
    {
        private static readonly List<Building> buildings = new();
        private static bool isWorking = true;
        private static bool isCreating = true;
        private static bool isUsingBuilding = false;
        private static bool isChangingBuilding = false;

        public static void ActionMenu() => Console.Write(
            "Определите действие: " +
            "\n\t1 -> Создать здание" +
            "\n\t2 -> Действие со зданием" +
            "\n\t3 -> Выход из программы" +
            "\nДействие: "
        );

        public static void CreationMenu() => Console.Write(
            "Определите количество параметров конструктора здания:" +
            "\n\t1 -> Город," +
            "\n\t2 -> Город, Улица" +
            "\n\t3 -> Город, Улица, Тип здания, Год постройки, Номер здания, Ширина, Длина, Высота" +
            "\n\t4 -> Отмена" +
            "\nКоличество параметров: "
        );

        public static void BuildingMenu() => Console.Write(
            "Определите действие: " +
            "\n\t1 -> Изменить здание" +
            "\n\t2 -> Вывести параметры здания" +
            "\n\t3 -> Вывести год здания в формате \"Hex\"" +
            "\n\t4 -> Отмена" +
            "\nДействие: "
        );

        public static void ChangeMenu() => Console.Write(
            "Определите действие: " +
            "\n\t1 -> Изменить город" +
            "\n\t2 -> Изменить улицу" +
            "\n\t3 -> Изменить тип" +
            "\n\t4 -> Изменить год постройки" +
            "\n\t5 -> Изменить номер" +
            "\n\t6 -> Изменить ширину" +
            "\n\t7 -> Изменить длину" +
            "\n\t8 -> Изменить высоту" +
            "\n\t9 -> Отмена" +
            "\nДействие: "
        );

        public static void WrongParameter() => Console.WriteLine(
            "Введенный номер действия не определен"
        );

        public static void ExitProgram()
        {
            isWorking = false;
            Console.WriteLine("Выход из программы");
        }

        private static void ExitCreation()
        {
            isCreating = false;
            Console.WriteLine("Выход из меню создания");
        }

        private static void ExitUsing()
        {
            isUsingBuilding = false;
            Console.WriteLine("Выход из меню действий");
        }

        private static void ExitChanging()
        {
            isChangingBuilding = false;
            Console.WriteLine("Выход из меню изменения");
        }

        public static void Start()
        {
            while (isWorking)
            {
                ActionMenu();
                switch (GetAction())
                {
                    case 1: CreateBuilding(); break;
                    case 2: ActionsBuilding(); break;
                    case 3: ExitProgram(); break;
                    default: WrongParameter(); break;
                }
            }
        }

        public static void CreateBuilding()
        {
            isCreating = true;
            while (isCreating)
            {
                CreationMenu();
                switch (GetAction())
                {
                    case 1:
                        buildings.Add(new Building(GetCity()));
                        Console.WriteLine("Здание добавлено");
                        ExitCreation();
                        break;
                    case 2:
                        buildings.Add(new Building(GetCity(), GetStreet()));
                        Console.WriteLine("Здание добавлено");
                        ExitCreation();
                        break;
                    case 3:
                        buildings.Add(
                            new Building(GetCity(), GetStreet(), GetBuildingType(), GetConsrtuctionYear(), GetNumber(),
                                         GetWidth(), GetLength(), GetHeight())
                        );
                        Console.WriteLine("Здание добавлено");
                        ExitCreation();
                        break;
                    case 4: ExitCreation(); break;
                    default: WrongParameter(); break;
                }
            }
        }

        private static void ActionsBuilding()
        {
            if (buildings.Count != 0)
            {
                ListBuildings();
                Building building = GetBuilding();
                while (isUsingBuilding)
                {
                    BuildingMenu();
                    switch (GetAction())
                    {
                        case 1:
                            isChangingBuilding = true;
                            ChangeBuilding(building);
                            break;
                        case 2:
                            Console.WriteLine(building.ToString());
                            break;
                        case 3:
                            Console.WriteLine(building.YearToHex());
                            break;
                        case 4:
                            ExitUsing();
                            break;
                        default:
                            WrongParameter();
                            break;
                    }
                }
            }
            else
                Console.WriteLine("Отсутсвуют созданные здания");
        }

        private static void ChangeBuilding(Building building)
        {
            while (isChangingBuilding)
            {
                ChangeMenu();
                switch (GetAction())
                {
                    case 1:
                        building.City = GetCity();
                        Console.WriteLine("Город изменен");
                        break;
                    case 2: 
                        building.Street = GetStreet();
                        Console.WriteLine("Улица изменена");
                        break;
                    case 3: 
                        building.Type = GetBuildingType();
                        Console.WriteLine("Тип изменен");
                        break;
                    case 4: 
                        building.ConstructionYear = GetConsrtuctionYear();
                        Console.WriteLine("Год постройки изменен");
                        break;
                    case 5: 
                        building.Number = GetNumber();
                        Console.WriteLine("Номер изменен");
                        break;
                    case 6: 
                        building.Width = GetWidth();
                        RecalcVolume(building);
                        Console.WriteLine("Ширина изменена");
                        break;
                    case 7: 
                        building.Length = GetLength();
                        RecalcVolume(building);
                        Console.WriteLine("Длина изменена");
                        break;
                    case 8: 
                        building.Height = GetHeight();
                        RecalcVolume(building);
                        Console.WriteLine("Высота изменена");
                        break;
                    case 9: ExitChanging(); break;
                    default: WrongParameter(); break;
                }
            }
        }

        private static Building GetBuilding()
        {
            uint Index;
            Console.Write("Введите номер интересующего здания: ");
            while (!uint.TryParse(Console.ReadLine(), out Index) || Index > buildings.Count - 1)
                Console.Write("Ошибка: введенное значение невалидно! Введите номер интересующего здания: ");
            isUsingBuilding = true;
            return buildings[Convert.ToInt32(Index)];
        }

        private static void ListBuildings()
        {
            Console.WriteLine("Доступные здания");
            var Counter = 0;
            foreach (Building building in buildings)
                Console.WriteLine($"Здание {Counter++}: {building}");
        }

        private static uint GetAction() 
        {
            uint Action;
            while (!uint.TryParse(Console.ReadLine(), out Action))
                Console.Write("Ошибка! Значение находится вне допустимого диапазона [0, 4 294 967 296)\nДействие: ");
            return Action;
        }

        private static string GetCity()
        {
            Console.Write("Введите название города: ");
            return Console.ReadLine();
        }

        private static string GetStreet()
        {
            Console.Write("Введите название улицы: ");
            return Console.ReadLine();
        }

        private static string GetBuildingType()
        {
            Console.Write("Введите тип здания: ");
            return Console.ReadLine();
        }

        private static ushort GetConsrtuctionYear()
        {
            ushort CreationYear;
            Console.Write("Введите год постройки (значение в диапазоне [0, 65 536): ");
            while (!ushort.TryParse(Console.ReadLine(), out CreationYear))
                Console.Write("Ошибка! Введите год постройки (значение в диапазоне [0, 65 536): ");
            return CreationYear;
        }

        private static uint GetNumber()
        {
            uint Number;
            Console.Write("Введите номер здания (значение в диапазоне [0, 4 294 967 296): ");
            while (!uint.TryParse(Console.ReadLine(), out Number))
                Console.Write("Ошибка! Введите номер здания (значение в диапазоне [0, 4 294 967 296): ");
            return Number;
        }

        private static uint GetWidth()
        {
            uint Width;
            Console.Write("Введите ширину здания (значение в диапазоне [0, 4 294 967 296): ");
            while (!uint.TryParse(Console.ReadLine(), out Width))
                Console.Write("Ошибка! Введите ширину здания (значение в диапазоне [0, 4 294 967 296): ");
            return Width;
        }

        private static uint GetLength()
        {
            uint Length;
            Console.Write("Введите длину здания (значение в диапазоне [0, 4 294 967 296): ");
            while (!uint.TryParse(Console.ReadLine(), out Length))
                Console.Write("Ошибка! Введите длину здания (значение в диапазоне [0, 4 294 967 296): ");
            return Length;
        }

        private static uint GetHeight()
        {
            uint Height;
            Console.Write("Введите высоту здания (значение в диапазоне [0, 4 294 967 296): ");
            while (!uint.TryParse(Console.ReadLine(), out Height))
                Console.Write("Ошибка! Введите высоту здания (значение в диапазоне [0, 4 294 967 296): ");
            return Height;
        }

        private static void RecalcVolume(Building building) => building.Volume = building.Height * building.Length * building.Width;
    }
}
