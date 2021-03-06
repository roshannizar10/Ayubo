-- SQL CREATE DATABASE Statement
CREATE DATABASE Ayubo_Travels;  


-- The SQL DROP DATABASE Statement
DROP DATABASE Ayubo_Travels; 


-- The SQL CREATE TABLE Statement (Login)
CREATE TABLE Login (    
    ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    USERNAME varchar(255),
    PASSWORD varchar(255),
    EMAIL varchar(255),
    MOBILE varchar(255) 
);

-- The SQL SELECT TABLE Statement (Login)
SELECT * FROM Login;  


-- The SQL INSERT INTO Statement (Login)
INSERT INTO Login (USERNAME,PASSWORD,EMAIL,MOBILE)
VALUES ('RamzanLanka','RamzanLanka','Admin@gmail.com','0775399531');



-- The SQL CREATE TABLE Statement (Vehicles)
CREATE TABLE Vehicles (    
    ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    VEHICLE_TYPE varchar(25),
    VEHICLE_MODEL varchar(25),
    VEHICLE_NUMBER varchar(25),
    DAY_RATE int, 
    WEEK_RATE int, 
    MONTH_RATE int 
);


-- The SQL SELECT TABLE Statement (Vehicles)
SELECT * FROM Vehicles;


-- The SQL INSERT INTO Statement (Vehicles)
INSERT INTO Vehicles (VEHICLE_TYPE,VEHICLE_MODEL,VEHICLE_NUMBER,DAY_RATE,WEEK_RATE,MONTH_RATE)
VALUES ('Car','BMW','EP-KGF 0000','3000','18000','60000');


CREATE TABLE Package (    
    ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    PACKAGE_NAME varchar(25),
    MAXIMUM_KM varchar(25),
    MAXIMUM_HOURS varchar(25),
	EXTRA_KM_CHARG varchar(25),
	WAITITING_CHARG varchar(25),
	DRIVER_OVERNIGHT_CHARG varchar(25),
	VEHICLE_PARK_CHARG varchar(25),
	DRIVER_CHARG varchar(25)
);


SELECT * FROM Package;

INSERT INTO Package (PACKAGE_NAME,MAXIMUM_KM,MAXIMUM_HOURS,EXTRA_KM_CHARG,WAITITING_CHARG,DRIVER_OVERNIGHT_CHARG,VEHICLE_PARK_CHARG,DRIVER_CHARG)
VALUES ('CAR','2K','2H','1000','500','100','5000','700');