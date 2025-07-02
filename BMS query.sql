DROP DATABASE BMS;
USE BMS;
CREATE TABLE login(
login_as varchar(50),
username varchar(100),
password varchar (150)
);
INSERT INTO login (login_as, username, password) VALUES
('admin', 'haram zainab', 'admin123'),
('admin', 'muhammad', 'admin123'),
('user', 'ayesha khan', 'user123'),
('user', 'ali raza', 'user123');

select * from login;