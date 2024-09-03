CREATE TABLE Owners (
    OwnerID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    ContactInfo NVARCHAR(255)
);

CREATE TABLE Animals (
    AnimalID INT PRIMARY KEY IDENTITY(1,1),
    OwnerID INT FOREIGN KEY REFERENCES Owners(OwnerID),
    Name NVARCHAR(100),
    Species NVARCHAR(100),
    Breed NVARCHAR(100),
    Age INT,
    MedicalHistory NVARCHAR(MAX)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    AnimalID INT FOREIGN KEY REFERENCES Animals(AnimalID),
    Date DATETIME,
    Reason NVARCHAR(255)
);

CREATE TABLE Treatments (
    TreatmentID INT PRIMARY KEY IDENTITY(1,1),
    AppointmentID INT FOREIGN KEY REFERENCES Appointments(AppointmentID),
    TreatmentDescription NVARCHAR(MAX),
    Date DATETIME
);

CREATE TABLE Staff (
    StaffID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Role NVARCHAR(100),
    ContactInfo NVARCHAR(255)
);

