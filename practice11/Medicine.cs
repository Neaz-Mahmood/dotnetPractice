public class Medicine {
    private string Name { get; set; }

    public MedicineType Type { get; set; }


    public Medicine(string name, MedicineType type) {
        Name = name;
        Type = type;
    }
 
}