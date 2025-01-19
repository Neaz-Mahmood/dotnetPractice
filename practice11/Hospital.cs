using System.Security.Cryptography.X509Certificates;

public enum MedicineType {
    Antibiotic,
    Anticoagulant,
    AntiInflammatory,
    MuscleRelaxant,
    CNSDepressant,
    Statin
}

public class Hospital {
    public List<Treatment> Treatments { get; set; }

    public Hospital() {
        Treatments = new List<Treatment>();
    }

    public List<Medicine> GetMedicineList(Treatment treatment) {
        return treatment.Prescription;
    }

    public void AddTreatment(Treatment treatment) {
        Treatments.Add(treatment);
    }
    
    public List<(MedicineType, MedicineType)> GetForbiddenCombinations() {
        return new List<(MedicineType, MedicineType)> {
            (MedicineType.Antibiotic, MedicineType.Statin),
            (MedicineType.MuscleRelaxant, MedicineType.CNSDepressant),
            (MedicineType.AntiInflammatory, MedicineType.Anticoagulant)
        };
    }

    public void AddMedicine (Medicine medicine, Treatment treatment) {
        List<(MedicineType, MedicineType)> forbiddenCombination = GetForbiddenCombinations();
        List<Medicine> prescription = GetMedicineList(treatment);
        foreach (var forbidden in forbiddenCombination) {
            if (medicine.Type == forbidden.Item1) {
                foreach (var medicine2 in prescription) {
                    if (medicine2.Type == forbidden.Item2) {
                        throw new Exception("Forbidden combination detected");
                    }
                }
            }
        }
        treatment.Prescription.Add(medicine);
    }



   
}