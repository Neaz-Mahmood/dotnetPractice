using System.Security.Cryptography.X509Certificates;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }

    public double BasePrice { get; set; }

    public Vehicle( string brand, string model, int yearOfManufacture, double basePrice )
    {
        Brand = brand;
        Model = model;
        YearOfManufacture = yearOfManufacture;
        BasePrice = basePrice;
    }

    public int getYearCount ()
    {
        return DateTime.Now.Year - YearOfManufacture;
    }

    public virtual double  CalculatePrice(int numOFDaysForRent)
    {
        return BasePrice * numOFDaysForRent;
    }
}