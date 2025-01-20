
Patient patient1 = new Patient("John Doe");

Treatment treatment1 = new Treatment(patient1);

Medicine medicine1 = new Medicine("test", MedicineType.Antibiotic);
Medicine medicine2 = new Medicine("test2",MedicineType.Statin);

treatment1.Prescription.Add(medicine1);
treatment1.Prescription.Add(medicine2);

Hospital hospital = new Hospital();

hospital.AddTreatment(treatment1);
hospital.AddMedicine(medicine1, treatment1);    
hospital.AddMedicine(medicine2, treatment1);