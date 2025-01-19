public class Vehicle 
{
    public string id{get;set;}
    public string type {get;set;}

    public bool available {get;set;}
    public double rentAmount {get;set;}
    public DateOnly maintenanceStartDate {get;set;}
    public DateOnly maintenanceEndDate {get;set;}
    public Vehicle(string id, string type, bool available, double rentAmount, DateOnly maintenanceStartDate, DateOnly maintenanceEndDate)
    {
        this.id = id;
        this.type = type;
        this.rentAmount = rentAmount;
        this.available = available;
        this.maintenanceStartDate = maintenanceStartDate;
        this.maintenanceEndDate = maintenanceEndDate;
    }
    
    public bool IsAvailable()
    { 
        return available;
    }

    public void SetAvailable(bool available)
    {
        this.available = available;
    }

    public double GetRentAmount()
    {
        return rentAmount;
    }

    public void SetRentAmount(double rent)
    {
        this.rentAmount = rent;
    }

    public DateOnly GetMaintenanceStartDate()
    {
        return maintenanceStartDate;
    }

    public void SetMaintenanceStartDate(DateOnly maintenanceStartDate)
    {
        this.maintenanceStartDate = maintenanceStartDate;
    }

    public DateOnly GetMaintenanceEndDate()
    {
        return maintenanceEndDate;
    }

    public void SetMaintenanceEndDate(DateOnly maintenanceEndDate)
    {
        this.maintenanceEndDate = maintenanceEndDate;
    }

    //method for renting a vehicle
    public void RentVehicle( string id, DateOnly startDate, DateOnly endDate)
    {

        if(IsAvailable())
        {
            Console.WriteLine("Vehicle is not available for rent");
        }
        else
        {
            Console.WriteLine("Vehicle is available for rent");
        }
       // check if maintained
        if(startDate < maintenanceStartDate || endDate > maintenanceEndDate)
        {
            Console.WriteLine("Vehicle is under maintenance");
        }
        else
        {
            Console.WriteLine("Vehicle is not under maintenance");
        }
    }



    //method for maintenance of a vehicle
    public void MaintenanceVehicle(DateOnly startDate, DateOnly endDate)
    {
        SetMaintenanceStartDate(startDate);
        SetMaintenanceEndDate(endDate);
    }
}
