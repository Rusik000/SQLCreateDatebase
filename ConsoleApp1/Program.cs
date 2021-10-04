

//CREATE DATABASE University;

//USE University;


//CREATE TABLE Students(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	FirstName NVARCHAR(255) NOT NULL,
//	LastName NVARCHAR(255),
//	Birthdate DATE,
//	Gender TINYINT NOT NULL,
//	[Address]  NVARCHAR(255),
//	Email NVARCHAR(255),
//	Phone NVARCHAR(255),
//);

//CREATE TABLE Teachers(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	FirstName NVARCHAR(255) NOT NULL,
//	LastName NVARCHAR(255),
//	Birthdate DATE,
//	Gender TINYINT NOT NULL,
//	Salary FLOAT,
//	[Address]  NVARCHAR(255),
//	Email NVARCHAR(255),
//	Phone NVARCHAR(255),
//);

//CREATE TABLE Workers(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	FirstName NVARCHAR(255) NOT NULL,
//	LastName NVARCHAR(255),
//	Birthdate DATE,
//	Gender TINYINT NOT NULL,
//	Salary FLOAT,
//	[Address]  NVARCHAR(255),
//	Email NVARCHAR(255),
//	Phone NVARCHAR(255),
//);


//CREATE TABLE Departments(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[Name] NVARCHAR(255) UNIQUE NOT NULL,
//);


//CREATE TABLE Faculties(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[Name] NVARCHAR(255) UNIQUE NOT NULL,
//	DepartmentId INT,
//	FOREIGN KEY(DepartmentId) REFERENCES Departments(Id),
//);


//CREATE TABLE Groups(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[Name] NVARCHAR(255) UNIQUE NOT NULL,
//	FacultyId INT,
//	FOREIGN KEY (FacultyId) REFERENCES Faculties(Id),
//);


//CREATE TABLE Subjects(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[Name] NVARCHAR(255) UNIQUE NOT NULL,
//	[Language] NVARCHAR(255) NOT NULL,
//);


//CREATE TABLE Sectors(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[Name] NVARCHAR(255) UNIQUE NOT NULL,
//);


//CREATE TABLE Rooms(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	[No] NVARCHAR(255) UNIQUE NOT NULL,
//	[Name] NVARCHAR(255),
//);


//CREATE TABLE SubjectSchedules(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	SubjectId INT,
//	RoomId INT,
//	SubjectStartDate DATETIME,
//	SubjectEndDate DATETIME,
//	UNIQUE(SubjectId, RoomId, SubjectStartDate, SubjectEndDate),
//	FOREIGN KEY(SubjectId) REFERENCES Subjects(Id),
//	FOREIGN KEY(RoomId) REFERENCES Rooms(Id),
//);


//CREATE TABLE TuitionFees(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	FacultyId INT,
//	TuitionFee FLOAT,
//	FOREIGN KEY(FacultyId) REFERENCES Faculties(Id), 
//);


//CREATE TABLE PayrollSchedules(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	StudentId INT,
//	[Date] DATE,
//	TuitionFeeId INT,
//	FOREIGN KEY(StudentId) REFERENCES Students(Id),
//	FOREIGN KEY(TuitionFeeId) REFERENCES TuitionFees(Id),
//);



//--Many To Many relations

//CREATE TABLE StudentsWithGroups(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	StudentId INT NOT NULL,
//	GroupId INT NOT NULL,
//	UNIQUE(StudentId, GroupId),
//	FOREIGN KEY(StudentId) REFERENCES Students(Id),
//	FOREIGN KEY(GroupId) REFERENCES Groups(Id),
//);


//CREATE TABLE TeachersWithGroups(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	GroupId INT,
//	TeacherID INT,
//	UNIQUE(GroupId, TeacherId),
//	FOREIGN KEY(GroupId) REFERENCES Groups(Id),
//	FOREIGN KEY(TeacherId) REFERENCES Teachers(Id),
//);


//CREATE TABLE TeachersWithDepartments(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	DepartmentId INT,
//	TeacherId INT,
//	UNIQUE(DepartmentId, TeacherId),
//	FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
//	FOREIGN KEY(TeacherId) REFERENCES Teachers(Id),
//);


//CREATE TABLE WorkersWithDepartments(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	DepartmentId INT,
//	WorkerId INT,
//	UNIQUE(DepartmentId, WorkerId),
//	FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
//	Foreign KEY(WorkerId) REFERENCES Workers(Id),
//);


//CREATE TABLE WorkersWithSectors(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	SectorID INT,
//	WorkerId INT,
//	UNIQUE(SectorId, WorkerId),
//	FOREIGN KEY (SectorID) REFERENCES Sectors(Id),
//	Foreign KEY(WorkerId) REFERENCES Workers(Id),
//);



//CREATE TABLE GroupsWithSubjectSchedules(
//	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
//	GroupId INT NOT NULL,
//	SubjectScheduleId INT NOT NULL,
//	UNIQUE(GroupId, SubjectScheduleId),
//	FOREIGN KEY(GroupId) REFERENCES Groups(Id),
//	FOREIGN KEY(SubjectScheduleId) REFERENCES SubjectSchedules(Id),
//);


//--Mockup datas




//INSERT INTO Students VALUES(
//	'Ruslan',
//	'Mustafayev',
//	'12-15-2000',
//	1,
//	'Baku',
//	'Rusik00@gmail.com',
//	'055-528-00-08'
//);


//INSERT INTO Students VALUES(
//	'Kamran',
//	'Aliyev',
//	'10-16-1997',
//	1,
//	'Sulutepe',
//	'aliyev009@gmail.com',
//	'070-220-20-20'
//);


//INSERT INTO Students VALUES(
//	'Huseyn',
//	'Rustemli',
//	'01-18-2001',
//	1,
//	'Ecemi',
//	'huseyn123@gmail.com',
//	'070-859-69-31'
//);


//INSERT INTO Students VALUES(
//	'Refael',
//	'Xelilzade',
//	'10-30-2015',
//	1,
//	'Mastaga',
//	'Rafo333@gmail.com',
//	'055-555-55-55'
//);


//INSERT INTO Students VALUES(
//	'Teymur',
//	'Novruzov',
//	'02-10-2002',
//	1,
//	'Elet yolu',
//	'ipekyolu1200@gmail.com',
//	'050-505-60-87'
//);


//INSERT INTO Students VALUES(
//	'Omer',
//	'Haci',
//	'02-04-2012',
//	1,
//	'Sulutepenin bir yeri',
//	'omer32@gmail.com',
//	'055-879-65-45'
//);


//INSERT INTO Students VALUES(
//	'Lale',
//	'Muradova',
//	'10-21-1995',
//	2,
//	'Baku',
//	'lale02@gmail.com',
//	'055-698-98-98'
//);




//INSERT INTO Departments VALUES(
//	'Information Technology'
//);

//INSERT INTO Departments VALUES(
//	'Engineering'
//);

//INSERT INTO Departments VALUES(
//	'Finance and Accounting'
//);

//INSERT INTO Departments VALUES(
//	'Computer Science and Mathematics'
//);

//INSERT INTO Faculties VALUES(
//	'Information Technology',
//	1
//);

//INSERT INTO Faculties VALUES(
//	'Computer Science',
//	4
//);

//INSERT INTO Faculties VALUES(
//	'Mechanical Engineering',
//	2
//);

//INSERT INTO Faculties VALUES(
//	'Electrical Engineering',
//	2
//);


//INSERT INTO Faculties VALUES(
//	'Mathematics and Physics',
//	4
//);


//INSERT INTO Faculties VALUES(
//	'Finance',
//	3
//);

//INSERT INTO Faculties VALUES(
//	'Economics',
//	3
//);

//INSERT INTO Faculties VALUES(
//	'Marketing',
//	3
//);


//INSERT INTO Groups VALUES(
//	'TXER_5393',
//	1
//);

//INSERT INTO Groups VALUES(
//	'NAFQ_7316',
//	2
//);

//INSERT INTO Groups VALUES(
//	'DDVK_4021',
//	3
//);


//INSERT INTO Groups VALUES(
//	'OLMU_9423',
//	4
//);


//INSERT INTO Groups VALUES(
//	'RVAE_2562',
//	5
//);

//INSERT INTO Groups VALUES(
//	'PMGM_5450',
//	6
//);

//INSERT INTO Groups VALUES(
//	'YIRA_6521',
//	7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	1, 1
//);

//INSERT INTO StudentsWithGroups VALUES(
//	2, 1
//);

//INSERT INTO StudentsWithGroups VALUES(
//	3, 1
//);

//INSERT INTO StudentsWithGroups VALUES(
//	4, 1
//);

//INSERT INTO StudentsWithGroups VALUES(
//	5, 1
//);


//INSERT INTO StudentsWithGroups VALUES(
//	6, 2
//);

//INSERT INTO StudentsWithGroups VALUES(
//	7, 2
//);

//INSERT INTO StudentsWithGroups VALUES(
//	8, 2
//);

//INSERT INTO StudentsWithGroups VALUES(
//	9, 2
//);

//INSERT INTO StudentsWithGroups VALUES(
//	10, 2
//);

//INSERT INTO StudentsWithGroups VALUES(
//	11, 3
//);

//INSERT INTO StudentsWithGroups VALUES(
//	12, 3
//);

//INSERT INTO StudentsWithGroups VALUES(
//	13, 3
//);

//INSERT INTO StudentsWithGroups VALUES(
//	14, 3
//);

//INSERT INTO StudentsWithGroups VALUES(
//	15, 3
//);

//INSERT INTO StudentsWithGroups VALUES(
//	16, 4
//);

//INSERT INTO StudentsWithGroups VALUES(
//	17, 4
//);

//INSERT INTO StudentsWithGroups VALUES(
//	18, 4
//);

//INSERT INTO StudentsWithGroups VALUES(
//	19, 4
//);

//INSERT INTO StudentsWithGroups VALUES(
//	20, 4
//);

//INSERT INTO StudentsWithGroups VALUES(
//	21, 5
//);

//INSERT INTO StudentsWithGroups VALUES(
//	22, 5
//);

//INSERT INTO StudentsWithGroups VALUES(
//	23, 5
//);

//INSERT INTO StudentsWithGroups VALUES(
//	24, 5
//);

//INSERT INTO StudentsWithGroups VALUES(
//	25, 5
//);

//INSERT INTO StudentsWithGroups VALUES(
//	26, 6
//);

//INSERT INTO StudentsWithGroups VALUES(
//	27, 6
//);

//INSERT INTO StudentsWithGroups VALUES(
//	28, 6
//);

//INSERT INTO StudentsWithGroups VALUES(
//	29, 6
//);

//INSERT INTO StudentsWithGroups VALUES(
//	30, 6
//);


//INSERT INTO StudentsWithGroups VALUES(
//	5, 7
//);
//INSERT INTO StudentsWithGroups VALUES(
//	11, 7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	8, 7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	17, 7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	25, 7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	30, 7
//);

//INSERT INTO StudentsWithGroups VALUES(
//	9, 7
//);

//INSERT INTO Subjects VALUES(
//	'Business & Management',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Computing and IT',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Engineering',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Mathematics & Statistics',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Economics',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Finance',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Physics',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Computer Architecture',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Networking',
//	'English'
//);

//INSERT INTO Subjects VALUES(
//	'Software design',
//	'English'
//);

//INSERT INTO Rooms VALUES('11', 'IT');
//INSERT INTO Rooms VALUES('12', 'Economics');
//INSERT INTO Rooms VALUES('13', 'Computer Science And Mathematics');
//INSERT INTO Rooms VALUES('14', 'Marketing');
//INSERT INTO Rooms VALUES('15', 'Design');
//INSERT INTO Rooms VALUES('16', 'Engineering');
//INSERT INTO Rooms VALUES('17', 'IT LAB');
//INSERT INTO Rooms VALUES('18', 'Physics lab');
//INSERT INTO Rooms VALUES('19', 'Chemistry lab');
//INSERT INTO Rooms VALUES('21', 'Design');
//INSERT INTO Rooms VALUES('22', 'Engineering');
//INSERT INTO Rooms VALUES('23', 'IT LAB');
//INSERT INTO Rooms VALUES('24', 'IT');
//INSERT INTO Rooms VALUES('25', 'Economics');
//INSERT INTO Rooms VALUES('26', 'Computer Science And Mathematics');
//INSERT INTO Rooms VALUES('27', 'Marketing');
//INSERT INTO Rooms VALUES('28', 'Physics lab');
//INSERT INTO Rooms VALUES('29', 'Chemistr lab');

//INSERT INTO SubjectSchedules VALUES(
//	1,
//	4,
//	'20210607 09:00',
//	'20210607 10:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	2,
//	1,
//	'20210607 10:00',
//	'20210607 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	3,
//	6,
//	'20210607 13:00',
//	'20210607 14:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	4,
//	3,
//	'20210607 10:00',
//	'20210607 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	5,
//	2,
//	'20210607 15:00',
//	'20210607 16:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	6,
//	13,
//	'20210607 17:00',
//	'20210607 18:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	7,
//	15,
//	'20210607 11:00',
//	'20210607 12:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	8,
//	11,
//	'20210607 10:00',
//	'20210607 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	9,
//	7,
//	'20210607 13:00',
//	'20210607 14:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	10,
//	13,
//	'20210607 10:00',
//	'20210607 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	1,
//	14,
//	'20210608 09:00',
//	'20210608 10:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	2,
//	7,
//	'20210608 10:00',
//	'20210608 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	3,
//	9,
//	'20210608 13:00',
//	'20210608 14:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	4,
//	13,
//	'20210608 10:00',
//	'20210608 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	5,
//	12,
//	'20210608 15:00',
//	'20210608 16:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	6,
//	3,
//	'20210608 17:00',
//	'20210608 18:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	7,
//	17,
//	'20210608 11:00',
//	'20210608 12:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	8,
//	7,
//	'20210608 10:00',
//	'20210608 11:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	9,
//	11,
//	'20210608 13:00',
//	'20210608 14:00'
//);

//INSERT INTO SubjectSchedules VALUES(
//	10,
//	13,
//	'20210608 10:00',
//	'20210608 11:00'
//);


//INSERT INTO GroupsWithSubjectSchedules VALUES(1, 2);
//INSERT INTO GroupsWithSubjectSchedules VALUES(1, 4);

//INSERT INTO GroupsWithSubjectSchedules VALUES(2, 12);
//INSERT INTO GroupsWithSubjectSchedules VALUES(2, 14);
//INSERT INTO GroupsWithSubjectSchedules VALUES(2, 7);

//INSERT INTO GroupsWithSubjectSchedules VALUES(3, 3);
//INSERT INTO GroupsWithSubjectSchedules VALUES(3, 4);
//INSERT INTO GroupsWithSubjectSchedules VALUES(3, 7);

//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 3);
//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 4);
//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 7);

//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 13);
//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 14);
//INSERT INTO GroupsWithSubjectSchedules VALUES(4, 17);

//INSERT INTO GroupsWithSubjectSchedules VALUES(5, 14);
//INSERT INTO GroupsWithSubjectSchedules VALUES(5, 17);

//INSERT INTO Teachers VALUES(
//	'Elvin',
//	'Camalzade',
//	'10-15-1999',
//	1,
//	16000,
//	'Xirdalan',
//	'Elvin1999@gmail.com',
//	'050-211-11-11'
//);

//INSERT INTO Teachers VALUES(
//	'Tural',
//	'Novruzov',
//	'5-10-1990',
//	1,
//	15000,
//	'Nizami',
//	'tural123@gmail.com',
//	'055-582-89-69'
//);

//INSERT INTO Teachers VALUES(
//	'Pasa',
//	'Pasayev',
//	'3-5-1989',
//	1,
//	1200,
//	'Neftciler',
//	'Pasa123@gmail.com',
//	'050-255-55-55'
//);



//INSERT INTO Teachers VALUES(
//	'Elican',
//	'Mustafali',
//	'4-16-1984',
//	1,
//	2500,
//	'Elmler ',
//	'Elcan66@gmail.com',
//	'070-321-21-21'
//);

//INSERT INTO Teachers VALUES(
//	'Murad',
//	'Ismayilzade',
//	'1-6-1978',
//	1,
//	1360,
//	'28 May',
//	'Murad44@gmail.com',
//	'050-879-65-32'
//);

//INSERT INTO Teachers VALUES(
//	'Semi',
//	'Semistanli',
//	'1-3-1995',
//	1,
//	2400,
//	'Genclik',
//	'semo69@gmail.com',
//	'070-700-70-70'
//);

//INSERT INTO Teachers VALUES(
//	'Leyla',
//	'Namazova',
//	'5-15-1990',
//	2,
//	2000,
//	'Xalqlar Dostlugu',
//	'LeyLey34@gmail.com',
//	'055-698-45-62'
//);

//INSERT INTO TeachersWithDepartments VALUES(
//	1, 1
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	1, 2
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	1, 3
//);

//INSERT INTO TeachersWithDepartments VALUES(
//	2, 4
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	2, 5
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	2, 6
//);

//INSERT INTO TeachersWithDepartments VALUES(
//	3, 7
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	3, 8
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	3, 9
//);

//INSERT INTO TeachersWithDepartments VALUES(
//	4, 10
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	4, 11
//);
//INSERT INTO TeachersWithDepartments VALUES(
//	4, 12
//);

//INSERT INTO TeachersWithGroups VALUES(
//	1, 1
//);

//INSERT INTO TeachersWithGroups VALUES(
//	1, 3
//);

//INSERT INTO TeachersWithGroups VALUES(
//	1, 5
//);

//INSERT INTO TeachersWithGroups VALUES(
//	2, 7
//);

//INSERT INTO TeachersWithGroups VALUES(
//	2, 9
//);

//INSERT INTO TeachersWithGroups VALUES(
//	2, 11
//);

//INSERT INTO TeachersWithGroups VALUES(
//	3, 2
//);

//INSERT INTO TeachersWithGroups VALUES(
//	3, 4
//);

//INSERT INTO TeachersWithGroups VALUES(
//	3, 6
//);

//INSERT INTO TeachersWithGroups VALUES(
//	4, 8
//);

//INSERT INTO TeachersWithGroups VALUES(
//	4, 10
//);

//INSERT INTO TeachersWithGroups VALUES(
//	4, 12
//);

//INSERT INTO TeachersWithGroups VALUES(
//	5, 2
//);

//INSERT INTO TeachersWithGroups VALUES(
//	5, 5
//);

//INSERT INTO TeachersWithGroups VALUES(
//	5, 8
//);

//INSERT INTO TeachersWithGroups VALUES(
//	6, 1
//);

//INSERT INTO TeachersWithGroups VALUES(
//	6, 3
//);

//INSERT INTO TeachersWithGroups VALUES(
//	6, 9
//);

//INSERT INTO TeachersWithGroups VALUES(
//	7, 1
//);

//INSERT INTO TeachersWithGroups VALUES(
//	7, 3
//);

//INSERT INTO TeachersWithGroups VALUES(
//	7, 9
//);

//INSERT INTO TuitionFees VALUES(
//	1, 40000
//);

//INSERT INTO TuitionFees VALUES(
//	2, 50000
//);

//INSERT INTO TuitionFees VALUES(
//	3, 35000
//);

//INSERT INTO TuitionFees VALUES(
//	4, 45000
//);

//INSERT INTO TuitionFees VALUES(
//	5, 25000
//);

//INSERT INTO TuitionFees VALUES(
//	6, 60000
//);

//INSERT INTO TuitionFees VALUES(
//	7, 55000
//);

//INSERT INTO TuitionFees VALUES(
//	8, 40000
//);

//INSERT INTO PayrollSchedules VALUES(
//	1,
//	'20200901',
//	1
//);

//INSERT INTO PayrollSchedules VALUES(
//	2,
//	'20200901',
//	2
//);

//INSERT INTO PayrollSchedules VALUES(
//	5,
//	'20200901',
//	3
//);


//INSERT INTO PayrollSchedules VALUES(
//	3,
//	'20200901',
//	1
//);

//INSERT INTO PayrollSchedules VALUES(
//	4,
//	'20200901',
//	1
//);
