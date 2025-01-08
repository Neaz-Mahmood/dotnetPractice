public class Ward {
    private const int MAX_CAPACITY = 50;
    private string Name { get; set; }

    private string Specialization { get; set; }

    private string HeadNurse { get; set; }

    public List<Patient> Patients { get; set; }

    


 
    public Ward(string name, string specialization, string headNurse) {
        Patients = new List<Patient>();
        Name = name;
        HeadNurse = headNurse;
        Specialization = specialization;
    }



    public void AddPatient(Patient patient) {
        if(Patients.Count >= MAX_CAPACITY) {
            throw new Exception("Ward is full");
        }
        Patients.Add(patient);
    }

    public void DischargePatient(Patient patient) {
        Patients.Remove(patient);
    }   

    public List<Patient> GetPatients() {
        return Patients;
    }



}