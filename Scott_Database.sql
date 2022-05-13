USE [master]
GO

CREATE DATABASE [FinalLMS]
GO
USE [FinalLMS]
GO
SET QUOTED_IDENTIFIER ON
GO

--Customer Table
CREATE TABLE dbo.Courses
(
	Course_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Course_Name VARCHAR(28),
	Course VARCHAR(28),
	Instructor_Id INT NOT NULL
)
GO

--Employees Table
CREATE TABLE dbo.Registration
(
	Registration_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Course_Id INT NOT NULL,
	Student_Id INT NOT NULL
)
GO

--Orders Table
CREATE TABLE dbo.Assignments
(
	Assignment_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Assignment_Name VARCHAR(28),
	Course_Id INT NOT NULL,
	Due_Date DATETIME
)
GO

CREATE TABLE dbo.Students
(
	Student_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Student_Firstname CHAR(28),
	Student_Lastname CHAR(28),
)
GO

CREATE TABLE dbo.Instructors
(
	Instructor_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Instructor_Firstname CHAR(28),
	Instructor_Lastname CHAR(28),
)
GO

INSERT INTO Courses(Course_Name, Course, Instructor_Id)
VALUES ('System Analysis', 'CMSC 2279', 1), 
('C# Programming II', 'CMSC 2240', 2), 
('Client-Side Programming', 'CMSC 1228', 3), 
('College Algebra', 'Math 1300', 4),
('Statistics', 'CMSC 1400', 5), 
('Speech', 'ENG 1320', 6), 
('Writing', 'ENG 1200', 7), 
('Structured Programming Language', 'CMSC 1500', 8),
('Web Markup Language', 'CMSC 1280', 9), 
('Java Programming', 'CMSC 2270', 10)
GO

INSERT INTO Students(Student_Firstname, Student_Lastname)
VALUES ('Dustin', 'Massey'),
('Monique', 'Fox'),
('Roxanne', 'Bennett'),
('Samuel', 'Peterson'),
('Dewey', 'Myers'),
('Marguerite', 'Henderson'),
('Beverly', 'Meyer'),
('Deanna', 'Howard'),
('Dominick ', 'Lee'),
('Sophia', 'Walters')
GO

INSERT INTO Instructors(Instructor_Firstname, Instructor_Lastname)
VALUES ('John', 'Wood'),
('Kevin', 'Gutierrez'),
('Dylan', 'Edwards'),
('John', 'Green'),
('Joe', 'Silman'),
('Sophie', 'Henry'),
('Bob', 'Schultz'),
('Mary', 'Wenkels'),
('Timothy', 'Wienstein'),
('Stephanie', 'Houdek')

GO

INSERT INTO Assignments(Assignment_Name, Course_Id, Due_Date)
VALUES ('Group Essay', '1', '2022-05-4 11:59:59'),
('Algebraic Functions', '4', '2022-05-7 11:59:59'),
('Week 2 Assignment', '2', '2022-05-8 11:59:59'),
('Final', '4', '2022-05-10 11:59:59'),
('Speech 1', '6', '2022-05-10 11:59:59'),
('Essay 1', '7', '2022-05-10 11:59:59'),
('Ch. 3 Assignment', '5', '2022-05-10 11:59:59'),
('Python Assignment', '8', '2022-05-10 11:59:59'),
('Final', '9', '2022-05-10 11:59:59'),
('Final Project', '10', '2022-05-10 11:59:59')

GO

INSERT INTO Registration(Course_Id,Student_Id)
VALUES (1,1),
(2,2),
(3,3),
(4,4),
(1,5),
(2,6),
(3,7),
(4,8),
(1,9),
(2,10)
