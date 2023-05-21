CREATE DATABASE InteractiveMapDb
GO

USE InteractiveMapDb;

CREATE TABLE Markers
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    MarkerName NVARCHAR(50) NOT NULL,
    MarkerDescription NVARCHAR(200),
    Latitude FLOAT NOT NULL,
    Longitude FLOAT NOT NULL,
    ColorNum INT DEFAULT 31
)
GO

INSERT Markers VALUES (N'СБУ 35ЛС', N'САМОХОДНАЯ', 55.05399192728481, 82.53397666448681, 31)
INSERT Markers VALUES (N'ГБУ 24ЛП стандарт', N'ПЕРЕНОСНАЯ', 55.06341234093957, 82.6475278800866, 21)
INSERT Markers VALUES (N'СБУ УРБ МИНИ', N'САМОХОДНАЯ', 54.9908851567758, 82.54798727690564, 8)