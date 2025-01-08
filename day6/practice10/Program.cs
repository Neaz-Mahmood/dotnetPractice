Patient patient1 = new Patient("John Doe", 55.0);

Patient patient2 = new Patient("John cena", 59.0);

Ward ward = new Ward("Cardiology", "Dr. Smith", "Cardiology");

ward.AddPatient(patient1);
ward.AddPatient(patient2);

List<Patient> patients = ward.GetPatients();

foreach(Patient patient in patients) {
    Console.WriteLine(patient.Name);
}