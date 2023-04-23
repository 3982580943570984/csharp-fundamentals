House house1 = House.GetInstance();
house1.Street = "Main Street";
house1.Number = 123;
house1.YearBuilt = 1990;
house1.NumberOfApartments = 10;
house1.PrintDetails();

House house2 = House.GetInstance();
house2.Street = "Second Street";
house2.Number = 456;
house2.YearBuilt = 2000;
house2.NumberOfApartments = 20;
house2.PrintDetails();
