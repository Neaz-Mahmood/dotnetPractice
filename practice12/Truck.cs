class Truck : Vehicle
{
    public Truck( string brand, string model, int yearOfManufacture, double basePrice ) : base(brand, model, yearOfManufacture, basePrice)
    {
        Brand = brand;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        BasePrice = basePrice;
    }

     public override double CalculatePrice(int numOFDaysForRent) {
        int yearUsedCount = getYearCount();
        return (BasePrice * numOFDaysForRent) + 100;
    }
}