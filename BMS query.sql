use BMS;
select * from login;

drop table login;

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Phone_No VARCHAR(15),
    CNIC VARCHAR(15),
    Gmail VARCHAR(100),
    Profile_pic VARBINARY(MAX),
    Role VARCHAR(50),
    Username VARCHAR(50),
    Password VARCHAR(255)
);
