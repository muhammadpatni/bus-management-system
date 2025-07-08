use BMS;
CREATE TABLE Bus (
    RegistrationNo VARCHAR(50) NOT NULL,
    BusName VARCHAR(100) NOT NULL,
    DriverName VARCHAR(100) NOT NULL,
    Route VARCHAR(200) NOT NULL,  -- e.g. Lahore to Karachi
    TravelDate DATE NOT NULL,
    TravelTime TIME NOT NULL,
    NumberOfSeats INT NOT NULL,
    BusType VARCHAR(50),          -- e.g., AC, Non-AC, Sleeper
    Fare DECIMAL(10,2)            -- Route ka fare
);

drop table Bus;
select * from Bus;
INSERT INTO Bus (RegistrationNo, BusName, DriverName, Route, TravelDate, TravelTime, NumberOfSeats, BusType, Fare)
VALUES
('PK-1732-LHR', 'Daewoo Express', 'Ali Raza', 'Lahore to Karachi', '2025-07-10', '04:15', 45, 'AC', 3200.00),
('PK-2984-ISB', 'Faisal Movers', 'Ahmed Khan', 'Islamabad to Multan', '2025-07-13', '08:40', 40, 'Sleeper', 2800.50),
('PK-3376-KHI', 'Skyways', 'Usman Ghani', 'Karachi to Lahore', '2025-07-18', '10:20', 50, 'Non-AC', 2500.75),
('PK-4551-MLT', 'Niazi Express', 'Salman Butt', 'Multan to Faisalabad', '2025-07-15', '06:30', 42, 'AC', 1900.00),
('PK-5832-LHR', 'Kainat Travels', 'Farhan Ali', 'Lahore to Quetta', '2025-07-20', '09:45', 38, 'Sleeper', 4200.99),
('PK-1725-KHI', 'Daewoo Express', 'Junaid Jamshed', 'Karachi to Peshawar', '2025-07-25', '07:10', 55, 'AC', 4600.00),
('PK-9209-ISB', 'Skyways', 'Tariq Mehmood', 'Islamabad to Bahawalpur', '2025-07-11', '05:25', 35, 'Non-AC', 2100.75),
('PK-8765-LHR', 'Faisal Movers', 'Imran Abbas', 'Faisalabad to Sialkot', '2025-07-28', '06:50', 30, 'Sleeper', 1450.00),
('PK-1209-KHI', 'Niazi Express', 'Rashid Latif', 'Hyderabad to Lahore', '2025-07-13', '12:10', 48, 'AC', 3100.80),
('PK-7144-MLT', 'Kainat Travels', 'Noman Shah', 'Multan to Karachi', '2025-07-17', '14:55', 47, 'Sleeper', 2700.00);
