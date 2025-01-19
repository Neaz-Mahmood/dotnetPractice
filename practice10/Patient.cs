using System.Globalization;

public class Patient {
    public string Name { get; set; }

    private double Age { get; set; }
    private string Address { get; set; }
    private string Phone { get; set; }
    private string Email { get; set; }
    
    private string OngoingTreatment { get; set; }
    private string MedicalHistory { get; set; }
 
    public Patient(string name, double age) {
        Name = name;
        Age = age;
        Address = "";
        Phone = "";
        Email = "";
        OngoingTreatment = "";
        MedicalHistory = "";
    }


    public void SetOngoingTreatment(string treatment) {
        OngoingTreatment = treatment;
    }

    public string GetOngoingTreatment() {
        return OngoingTreatment;
    }

    public string GetMedicalHistory() {
        return MedicalHistory;
    }

}