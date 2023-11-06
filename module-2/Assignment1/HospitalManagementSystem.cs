using System;
using System.Collections.Generic;

// Base class representing a Person
class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(int personId, string name, string address, string phoneNumber, DateTime dateOfBirth)
    {
        PersonId = personId;
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
    }
}

// Derived class representing a Doctor
class Doctor : Person
{
    public string Specialization { get; set; }
    public List<Appointment> Appointments { get; set; }

    public Doctor(int doctorId, string name, string address, string phoneNumber, DateTime dateOfBirth, string specialization)
        : base(doctorId, name, address, phoneNumber, dateOfBirth)
    {
        Specialization = specialization;
        Appointments = new List<Appointment>();
    }

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }
}

// Derived class representing a Nurse
class Nurse : Person
{
    public string Department { get; set; }

    public Nurse(int nurseId, string name, string address, string phoneNumber, DateTime dateOfBirth, string department)
        : base(nurseId, name, address, phoneNumber, dateOfBirth)
    {
        Department = department;
    }
}

// Class representing a Patient
class Patient : Person
{
    public List<MedicalRecord> MedicalRecords { get; set; }
    public List<Appointment> Appointments { get; set; }

    public Patient(int patientId, string name, string address, string phoneNumber, DateTime dateOfBirth)
        : base(patientId, name, address, phoneNumber, dateOfBirth)
    {
        MedicalRecords = new List<MedicalRecord>();
        Appointments = new List<Appointment>();
    }

    public void AddMedicalRecord(MedicalRecord medicalRecord)
    {
        MedicalRecords.Add(medicalRecord);
    }

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }
}

// Class representing an Appointment
class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }

    public Appointment(int appointmentId, DateTime appointmentDate, Doctor doctor, Patient patient)
    {
        AppointmentId = appointmentId;
        AppointmentDate = appointmentDate;
        Doctor = doctor;
        Patient = patient;
    }
}

// Class representing a Department
class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public List<Nurse> Nurses { get; set; }

    public Department(int departmentId, string name)
    {
        DepartmentId = departmentId;
        Name = name;
        Nurses = new List<Nurse>();
    }

    public void AddNurse(Nurse nurse)
    {
        Nurses.Add(nurse);
    }
}

// Class representing a Medical Record
class MedicalRecord
{
    public int MedicalRecordId { get; set; }
    public string Diagnosis { get; set; }
    public Patient Patient { get; set; }

    public MedicalRecord(int medicalRecordId, string diagnosis, Patient patient)
    {
        MedicalRecordId = medicalRecordId;
        Diagnosis = diagnosis;
        Patient = patient;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Doctor, Nurse, Patient, Appointment, Department, and MedicalRecord
        Department department1 = new Department(1, "Cardiology");
        Nurse nurse1 = new Nurse(1, "Nurse1", "Address1", "123-456-7890", new DateTime(1980, 1, 15), department1.Name);
        department1.AddNurse(nurse1);

        Doctor doctor1 = new Doctor(1, "Doctor1", "Address2", "987-654-3210", new DateTime(1975, 5, 10), "Cardiologist");
        doctor1.AddAppointment(new Appointment(1, DateTime.Now, doctor1, new Patient(1, "Patient1", "Address3", "555-123-4567", new DateTime(1990, 3, 20))));
        
        Patient patient1 = new Patient(2, "Patient2", "Address4", "555-987-6543", new DateTime(1985, 7, 5));
        patient1.AddMedicalRecord(new MedicalRecord(1, "Hypertension", patient1));
        patient1.AddAppointment(new Appointment(2, DateTime.Now.AddDays(1), doctor1, patient1));
        
        // Display information
        Console.WriteLine("Department: " + department1.Name);
        Console.WriteLine("Nurse: " + nurse1.Name);
        Console.WriteLine("Doctor: " + doctor1.Name);
        Console.WriteLine("Patient: " + patient1.Name);
        Console.WriteLine("Appointment Date: " + patient1.Appointments[0].AppointmentDate);
        Console.WriteLine("Diagnosis: " + patient1.MedicalRecords[0].Diagnosis);
    }
}
