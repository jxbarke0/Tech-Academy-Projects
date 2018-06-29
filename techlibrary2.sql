create table tbl_publisher (
	PubName VARCHAR(50) PRIMARY KEY NOT NULL,
	PubAddress VARCHAR(50),
	PubPhone VARCHAR(50)
	);


CREATE TABLE tbl_books (
	BookID INT PRIMARY KEY NOT NULL IDENTITY (1000,1),
	Title VARCHAR(50),
	PubName VARCHAR(50) FOREIGN KEY REFERENCES tbl_publisher(PubName)
	);

CREATE TABLE tbl_authors (
	BookID INT FOREIGN KEY REFERENCES tbl_books(BookID),
	AuthorName VARCHAR(50)
	);

CREATE TABLE tbl_branch (
	BranchID INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	BranchName VARCHAR(50),
	BranchAddress VARCHAR(50)
	);

CREATE TABLE tbl_copies (
	BookID INT FOREIGN KEY REFERENCES tbl_books(BookID),
	BranchID INT FOREIGN KEY REFERENCES tbl_branch(BranchID),
	CopyCount INT
	);

CREATE TABLE tbl_borrowers (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY (10000,5),
	CardName VARCHAR(50),
	CardAddress VARCHAR(50),
	CardPhone VARCHAR(50)
	);

CREATE TABLE tbl_loans (
	BookID INT FOREIGN KEY REFERENCES tbl_books(BookID),
	BranchID INT FOREIGN KEY REFERENCES tbl_branch(BranchID),
	CardNo INT FOREIGN KEY REFERENCES tbl_borrowers(CardNo),
	DateOut DATE,
	DueDate DATE
	)


	INSERT INTO tbl_publisher
	(PubName, PubAddress, PubPhone)
	VALUES
	('Simon and Schuster', '400 Schuster Way, Albany, NY 10167', '345-456-5678'),
	('Random House LLC', '22 E 5th Ave, New York, NY 10187', '308-879-7897'),
	('Macmillan', '2500 Book Blvd, Faketown, MA 02134', '555-890-2300'),
	('HarperCollins', '45 Oprah Ln, Los Angeles, CA 93028', '800-878-9000'),
	('Scholastic', '5671 W Blue St, Fairfax, VA 37898', '800-543-2040'),
	('Del Rey', '1500 Polgara Pl, Redmond, WA 96154', '206-434-9800'),
	('Kindle Press', '123 South St, Philadelphia, PA 08345', '215-450-5000'),
	('Tor Books', '40 Lan Cir, Seattle, WA 96224', '206-898-5000'),
	('Widdershins Press', '3013 Hawtown Blvd, Porland, OR 97202', '888-545-3333'),
	('Anchor', '45000 Nightmare Rd, Dallas, TX 54432', '535-678-8989')
	;
	
	SELECT * FROM tbl_publisher;
	SELECT * FROM tbl_books

	INSERT INTO tbl_books
	(Title, PubName)
	VALUES
	('The Gunslinger', 'Simon and Schuster'),
	('The Drawing of the Three', 'Simon and Schuster'),
	('The Waste Lands', 'Simon and Schuster'),
	('Wizard and Glass', 'Simon and Schuster'),
	('Wolves of the Calla', 'Simon and Schuster'),
	('Song of Susannah', 'Simon and Schuster'),
	('The Dark Tower', 'Simon and Schuster'),
	('Underworld', 'Random House LLC'),
	('Fingerprints of the Gods', 'Random House LLC'),
	('Supernatural', 'Random House LLC'),
	('Magicians of the Gods', 'Random House LLC'),
	('Carry On', 'Macmillan'),
	('The Song of Achilles', 'HarperCollins'),
	('Shards of Time', 'Random House LLC'),
	('The Dream Thieves', 'Scholastic'),
	('The Raven King', 'Scholastic'),
	('The Belgariad', 'Del Rey'),
	('The Lost Tribe', 'Kindle Press'),
	('The Wheel of Time', 'Tor Books'),
	('Whyborne and Griffin', 'Widdershins Press'),
	('The Handmaids Tale', 'Anchor')
	;

	INSERT INTO tbl_authors
	(BookID, AuthorName)
	VALUES
	(1000, 'Stephen King'),
	(1001, 'Stephen King'),
	(1002, 'Stephen King'),
	(1003, 'Stephen King'),
	(1004, 'Stephen King'),
	(1005, 'Stephen King'),
	(1006, 'Stephen King'),
	(1007, 'Graham Hancock'),
	(1008, 'Graham Hancock'),
	(1009, 'Graham Hancock'),
	(1010, 'Graham Hancock'),
	(1011, 'Rainbow Rowell'),
	(1012, 'Madeline Miller'),
	(1013, 'Lynn Flewelling'),
	(1014, 'Maggie Stiefvater'),
	(1015, 'Maggie Stiefvater'),
	(1016, 'David Eddings'),
	(1017, 'Matthew Caldwell'),
	(1018, 'Robert Jordan'),
	(1019, 'Jordan Hawk'),
	(1020, 'Margaret Atwood')
	;

	INSERT INTO tbl_branch
	(BranchName, BranchAddress)
	VALUES
	('Anatole', '12100 SE Powell St, Portland, OR 97102'),
	('Dysis', '10150 NW Cornell St, Portland, OR 97232'),
	('Sharpstown', '300 SE Grand Ave, Portland, OR 97211'),
	('Central', '500 SW 10th Ave, Portland, OR 97204')
	;

SELECT * FROM tbl_branch
SELECT * FROM tbl_books

	INSERT INTO tbl_copies
	(BookID, BranchID, CopyCount)
	VALUES
	(1000, 1, 10),
	(1000, 2, 10),
	(1000, 3, 10),
	(1000, 4, 10),
	(1001, 1, 10),
	(1001, 2, 10),
	(1001, 3, 10),
	(1001, 4, 10),
	(1002, 1, 10),
	(1002, 2, 10),
	(1002, 3, 10),
	(1002, 4, 10),
	(1003, 1, 10),
	(1003, 2, 10),
	(1003, 3, 10),
	(1003, 4, 10),
	(1004, 1, 10),
	(1004, 2, 10),
	(1004, 3, 10),
	(1004, 4, 10),
	(1005, 1, 10),
	(1005, 2, 10),
	(1005, 3, 10),
	(1005, 4, 10),
	(1006, 1, 10),
	(1006, 2, 10),
	(1006, 3, 10),
	(1006, 4, 10),
	(1007, 1, 10),
	(1007, 2, 10),
	(1007, 3, 10),
	(1007, 4, 10),
	(1008, 1, 10),
	(1008, 2, 10),
	(1008, 3, 10),
	(1008, 4, 10),
	(1009, 1, 10),
	(1009, 2, 10),
	(1009, 3, 10),
	(1009, 4, 10),
	(1010, 1, 10),
	(1010, 2, 10),
	(1010, 3, 10),
	(1010, 4, 10),
	(1011, 1, 10),
	(1011, 2, 10),
	(1011, 3, 10),
	(1011, 4, 10),
	(1012, 1, 10),
	(1012, 2, 10),
	(1012, 3, 10),
	(1012, 4, 10),
	(1013, 1, 10),
	(1013, 2, 10),
	(1013, 3, 10),
	(1013, 4, 10),
	(1014, 1, 10),
	(1014, 2, 10),
	(1014, 3, 10),
	(1014, 4, 10),
	(1015, 1, 10),
	(1015, 2, 10),
	(1015, 3, 10),
	(1015, 4, 10),
	(1016, 1, 10),
	(1016, 2, 10),
	(1016, 3, 10),
	(1016, 4, 10),
	(1017, 1, 10),
	(1017, 2, 10),
	(1017, 3, 10),
	(1017, 4, 10),
	(1018, 1, 10),
	(1018, 2, 10),
	(1018, 3, 10),
	(1018, 4, 10),
	(1019, 1, 10),
	(1019, 2, 10),
	(1019, 3, 10),
	(1019, 4, 10),
	(1020, 1, 10),
	(1020, 2, 10),
	(1020, 3, 10),
	(1020, 4, 10)
;

SELECT * FROM tbl_copies

	INSERT INTO tbl_borrowers
	(CardName, CardAddress, CardPhone)
	VALUES
	('Jeff Barker', '3013 SE Hawthorne Blvd, Portland, OR 97214', '856-453-5300'),
	('Stupid Corndog', '123 SE Fake St, Gresham, OR 97300', '503-345-3434'),
	('Oryx Crake', '300 SE None Rd, Portland, OR 97212', '503-304-3234'),
	('Egwene Lan', '125 NW 20th Ave, Portland, OR 97204', '503-345-6454'),
	('Gary Un', '8940 NW Forest Dr, Portland, OR 97202', '503-222-7876'),
	('Ser Eagle', '4567 NE Alberta St, Portland, OR 97207', '503-789-8999'),
	('Adam Ronan', '12100 NE Airport Wy, Portland, OR 97209', '503-452-4001'),
	('Eddie Jacobs', '3430 SE Belmont Ave, Portland, OR 97209', '503-343-0081'),
	('Roland Deschain', '2300 SE 12th Ave, Portland, OR 97204', '215-242-0099')
	;

SELECT * FROM tbl_borrowers
SELECT * FROM tbl_loans

	INSERT INTO tbl_loans
	(BookID, BranchID, CardNo, DateOut, DueDate)
	VALUES
/*	(1000, 3, 10000, '2018-06-13', '2018-06-27'), already done */
	(1001, 3, 10000, '2018-06-13', '2018-06-27'),
	(1002, 3, 10000, '2018-06-13', '2018-06-27'),
	(1003, 3, 10000, '2018-06-13', '2018-06-27'),
	(1004, 3, 10000, '2018-06-13', '2018-06-27'),
	(1005, 3, 10000, '2018-06-13', '2018-06-27'),
	(1006, 3, 10000, '2018-06-13', '2018-06-27'),
	(1011, 3, 10000, '2018-06-15', '2018-06-29'),
	(1012, 3, 10000, '2018-06-16', '2018-06-30'),
	(1019, 2, 10000, '2018-06-17', '2018-07-01'),
	(1017, 1, 10005, '2018-06-17', '2018-07-01'),
	(1019, 1, 10005, '2018-06-17', '2018-07-01'),
	(1020, 4, 10010, '2018-06-18', '2018-07-02'),
	(1018, 2, 10015, '2018-06-13', '2018-06-27'),
	(1019, 2, 10015, '2018-06-13', '2018-06-27'),
	(1012, 2, 10015, '2018-06-13', '2018-06-27'),
	(1016, 2, 10015, '2018-06-13', '2018-06-27'),
	(1008, 4, 10025, '2018-06-16', '2018-06-30'),
	(1009, 4, 10025, '2018-06-16', '2018-06-30'),
	(1010, 4, 10025, '2018-06-16', '2018-06-30'),
	(1007, 4, 10025, '2018-06-16', '2018-06-30'),
	(1016, 4, 10025, '2018-06-16', '2018-06-30'),
	(1019, 4, 10025, '2018-06-16', '2018-06-30'),
	(1000, 3, 10030, '2018-06-13', '2018-06-27'),
	(1001, 3, 10030, '2018-06-13', '2018-06-27'),
	(1002, 3, 10030, '2018-06-13', '2018-06-27'),
	(1003, 3, 10030, '2018-06-13', '2018-06-27'),
	(1004, 3, 10030, '2018-06-13', '2018-06-27'),
	(1005, 3, 10030, '2018-06-13', '2018-06-27'),
	(1006, 3, 10030, '2018-06-13', '2018-06-27'),
	(1014, 3, 10030, '2018-06-13', '2018-06-27'),
	(1015, 3, 10030, '2018-06-13', '2018-06-27'),
	(1000, 2, 10035, '2018-06-13', '2018-06-27'),
	(1001, 2, 10035, '2018-06-13', '2018-06-27'),
	(1002, 2, 10035, '2018-06-13', '2018-06-27'),
	(1003, 2, 10035, '2018-06-13', '2018-06-27'),
	(1004, 2, 10035, '2018-06-13', '2018-06-27'),
	(1005, 2, 10035, '2018-06-13', '2018-06-27'),
	(1006, 2, 10035, '2018-06-13', '2018-06-27'),
	(1012, 2, 10035, '2018-06-13', '2018-06-27'),
	(1020, 2, 10035, '2018-06-13', '2018-06-27'),
	(1007, 1, 10040, '2018-06-17', '2018-07-01'),
	(1008, 1, 10040, '2018-06-17', '2018-07-01'),
	(1009, 1, 10040, '2018-06-17', '2018-07-01'),
	(1010, 1, 10040, '2018-06-17', '2018-07-01'),
	(1011, 1, 10040, '2018-06-17', '2018-07-01'),
	(1012, 1, 10040, '2018-06-17', '2018-07-01'),
	(1013, 1, 10040, '2018-06-17', '2018-07-01'),
	(1014, 1, 10040, '2018-06-17', '2018-07-01'),
	(1015, 1, 10040, '2018-06-17', '2018-07-01'),
	(1016, 1, 10040, '2018-06-17', '2018-07-01'),
	(1020, 1, 10040, '2018-06-17', '2018-07-01')
	;




/* 1. How many copies of the book titled "The Lost Tribe" are owned by 
	the library branch whose name is "Sharpstown"? */


SELECT tbl_branch.BranchName, tbl_books.Title, tbl_copies.CopyCount
FROM tbl_branch
	INNER JOIN tbl_copies ON tbl_branch.BranchID = tbl_copies.BranchID
		INNER JOIN tbl_books ON tbl_copies.BookID = tbl_books.BookID
			WHERE tbl_books.Title IN ('The Lost Tribe') AND tbl_branch.BranchName IN ('Sharpstown')


EXEC question1; -- created procedure for each question


/* 2. How many copies of the book titled "The Lost Tribe" are owned by each library branch? */


SELECT tbl_branch.BranchName, tbl_books.Title, tbl_copies.CopyCount
FROM tbl_branch
	INNER JOIN tbl_copies ON tbl_branch.BranchID = tbl_copies.BranchID
		INNER JOIN tbl_books ON tbl_copies.BookID = tbl_books.BookID
			WHERE tbl_books.Title IN ('The Lost Tribe')

EXEC question2


/* 3. Retrieve the names of all borrowers who do not have any books checked out. */


SELECT tbl_borrowers.CardName
FROM tbl_borrowers
	LEFT JOIN tbl_loans ON tbl_loans.CardNo = tbl_borrowers.CardNo
	WHERE tbl_loans.CardNo IS NULL


EXEC question3


/* 4. For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, 
	retrieve the book title, the borrower's name, and the borrower's address. */


SELECT tbl_books.Title, tbl_borrowers.CardName, tbl_borrowers.CardAddress
FROM tbl_loans
	INNER JOIN tbl_borrowers ON tbl_loans.CardNo = tbl_borrowers.CardNo
	INNER JOIN tbl_books ON tbl_books.BookID = tbl_loans.BookID
	INNER JOIN tbl_branch ON tbl_loans.BranchID = tbl_branch.BranchID
	WHERE tbl_branch.BranchName IN ('Sharpstown') AND tbl_loans.DueDate IN ('2018-06-27')

EXEC question4


/* 5. For each library branch, retrieve the branch name and the total number of books 
	loaned out from that branch. */


SELECT b.BranchName, (
	SELECT COUNT(*) AS loan_count
	FROM tbl_loans
	WHERE tbl_loans.BranchID = b.BranchID
	GROUP BY BranchID
	) AS loan_count
FROM tbl_branch b
ORDER BY BranchName

EXEC question5

 -- and again without the unnecessary inner query:
SELECT tbl_branch.BranchName, COUNT(*) AS loan_count
FROM tbl_branch
INNER JOIN tbl_loans ON tbl_loans.BranchID = tbl_branch.BranchID
GROUP BY tbl_branch.BranchID, tbl_branch.BranchName

EXEC question5a

/* 6. Retrieve the names, addresses, and number of books checked out 
	for all borrowers who have more than five books checked out. */


SELECT tbl_borrowers.CardName, tbl_borrowers.CardAddress, COUNT(*) AS loan_count 
FROM tbl_borrowers 
INNER JOIN tbl_loans ON tbl_loans.CardNo = tbl_borrowers.CardNo
GROUP BY tbl_borrowers.CardName, tbl_borrowers.CardAddress
HAVING COUNT(*) >5

EXEC question6

/* 7. For each book authored (or co-authored) by "Stephen King", retrieve the title and the number 
	of copies owned by the library branch whose name is "Central". */


SELECT tbl_books.Title, tbl_copies.CopyCount
FROM tbl_books
	INNER JOIN tbl_copies ON tbl_books.BookID = tbl_copies.BookID
	INNER JOIN tbl_branch ON tbl_copies.BranchID = tbl_branch.BranchID
	INNER JOIN tbl_authors ON tbl_books.BookID = tbl_authors.BookID
	WHERE BranchName IN ('CENTRAL') AND AuthorName IN ('Stephen King')

EXEC question7