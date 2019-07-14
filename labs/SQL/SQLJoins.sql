drop database CollegeDB
create database CollegeDB
go
drop TABLE Courses
drop TABLE Students
create TABLE Courses (CourseID INT IDENTITY PRIMARY KEY,
CourseName NVARCHAR(50))
create TABLE Students (StudentID INT ,
StudentName NVARCHAR(50),
CourseID INT IDENTITY PRIMARY KEY,
SecondCourseID INT)

SET IDENTITY_INSERT Courses ON
INSERT INTO Courses (CourseID, CourseName) VALUES (1, 'FoodTechnology')
INSERT INTO Courses (CourseID, CourseName) VALUES (2, 'Maths')
INSERT INTO Courses (CourseID, CourseName) VALUES (3, 'GraphicDesign')
INSERT INTO Courses (CourseID, CourseName) VALUES (4, 'PhysicalEducation')
INSERT INTO Courses (CourseID, CourseName) VALUES (5, 'English')
SET IDENTITY_INSERT Courses OFF

SET IDENTITY_INSERT Students ON
INSERT INTO Students (StudentID, StudentName, CourseID, SecondCourseID) VALUES (12345, 'Sam Ige', 1, 4)
INSERT INTO Students (StudentID, StudentName, CourseID, SecondCourseID) VALUES (23456, 'Gerald McCoy', 2, 5)
INSERT INTO Students (StudentID, StudentName, CourseID, SecondCourseID) VALUES (34567, 'John Magnus', 3, 2)
INSERT INTO Students (StudentID, StudentName, CourseID, SecondCourseID) VALUES (45678, 'Billy Jone', 4, 1)
INSERT INTO Students (StudentID, StudentName, CourseID, SecondCourseID) VALUES (56789, 'Jerome White', 5, 3)
SET IDENTITY_INSERT Students OFF

select*from Students inner JOIN Courses ON Students.CourseID = Courses.CourseID
