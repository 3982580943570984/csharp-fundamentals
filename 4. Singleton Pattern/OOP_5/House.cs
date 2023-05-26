
/*
 * public - класс может быть использован внутри текущего проекта и в других проектах
 * sealed - запрет на наследование от класса и предотвращение создания дополнительных экземпляров класса
 * */

using System;

public sealed class House
{
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public ushort Number { get; set; } = 0;
    public ushort YearBuilt { get; set; } = 0;
    public ushort NumberOfApartments { get; set; } = 0;
    public ushort NumberOfFloors { get; set; } = 0;
    public static bool IsCreated { get; set; } = false;

    // readonly - поле может быть установлено один раз и после этого его значение не меняется
    private static readonly Lazy<House> lazy = new Lazy<House>(() => new House());

    // static - поле принадлежит классу, а не его экземпляру
    public static House Instance => lazy.Value;

    private House() => NumberOfFloors = 1;

    public string GetYearBuiltInHex() => YearBuilt.ToString("X");

    public override string ToString() => $"House: {City}, {Street}, {Type}, {Number}, {YearBuilt}, {NumberOfApartments}, {NumberOfFloors}";
}
