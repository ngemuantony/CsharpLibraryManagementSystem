--THE FIRST TWO LINES HIGHLIGHT AND EXECUTE THEM ONE BY ONE
CREATE DATABASE LibraryDB;
USE LibraryDB;

--HIGHLIGHT THE REST OF THE CODE AND EXECUTE
-- Create Login Table
CREATE TABLE Login(
	UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Username VARCHAR(30) NOT NULL,
	UserPassword VARCHAR(256) NOT NULL,
	IsAdmin BIT NOT NULL
);
-- Create Books Table

CREATE TABLE Books (
    BookID INT PRIMARY KEY,
    Title NVARCHAR(50),
    Author NVARCHAR(50),
    Publisher NVARCHAR(50),
    YearOfPublication INT,
    Genres NVARCHAR(25)
);

-- Create Users Table
CREATE TABLE Borrower(
    BorrowerID INT PRIMARY KEY NOT NULL,
    FullName NVARCHAR(30) NOT NULL,
    UserAddress NVARCHAR(25),
    Phone NVARCHAR(18),
    Email NVARCHAR(50) NOT NULL
   
);

-- Create IssuedBooks Table
CREATE TABLE IssuedBooks (
    IssueID INT IDENTITY(1,1) PRIMARY KEY,
    BookID INT FOREIGN KEY REFERENCES Books(BookID),
    BorrowerID INT FOREIGN KEY REFERENCES Borrower(BorrowerID),
    DateIssued DATETIME,
    ReturnDate DATETIME
);


--THE UserID FIELD IT AUTO_INCREMENT SO THERE IS NO NEED OF INSERTING DATA INTO IT
INSERT INTO Login (UserName,UserPassword, IsAdmin)VALUES('admin','admin',1);
INSERT INTO Login (UserName,UserPassword, IsAdmin)VALUES('user','user',0);





--CHECKING IF THE DEFAULT LOGIN CREDENTIALS EXISTS IN THE TABLE Login
--SELECT * FROM Login;

--ALTER TABLE Users
--ALTER COLUMN isAdmin BIT NOT NULL;
-- Execute the sp_help stored procedure for the Users table


-- Querying the system catalog views for table structure
--SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
--FROM INFORMATION_SCHEMA.COLUMNS
--WHERE TABLE_NAME = 'Books'

-- Alter IssuedBooks Table to add Identity Property to IssueID


