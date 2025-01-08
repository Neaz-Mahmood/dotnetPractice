public class Treatment {
    public Patient TreatmentTo { get; set; }
    public List<Medicine> Prescription { get; set; }

    public Treatment(Patient patient) {
        TreatmentTo = patient;
        Prescription = new List<Medicine>();
    }


}