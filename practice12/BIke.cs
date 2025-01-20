class Bike : Vehicle
{
    public Bike( string brand, string model, int yearOfManufacture, double basePrice ) : base(brand, model, yearOfManufacture, basePrice)
    {
        Brand = brand;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        BasePrice = basePrice;
    }

     public override double CalculatePrice(int numOFDaysForRent) {
        int yearUsedCount = getYearCount();
        if(yearUsedCount <= 5)
        {
            return (BasePrice - (BasePrice * 0.1) * numOFDaysForRent);
        }
        else
        {
            return BasePrice * numOFDaysForRent;
        }
    }
}