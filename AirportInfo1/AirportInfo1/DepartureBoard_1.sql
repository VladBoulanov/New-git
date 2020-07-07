CREATE TABLE [dbo].[DepartureBoard]
(
[NumberRace] [int]  NOT NULL,
[CityAndCounntry] [VARCHAR] (500) NOT NULL,
[Dates] [datetime]  NOT NULL,
[Dateflight] [date]  NOT NULL,
[Aviacompany] [varchar] (50) NOT NULL,
[PaneModel] [varchar] (50) NOT NULL,
	[Id] [int] NOT NULL PRIMARY KEY
);
GO
INSERT INTO [dbo].[DepartureBoard] VALUES (23, 'Moscow,Russia-Paris,France', '2019-03-20T11:25:32,2019-03-20T13:15:28', '01:49:56', 'Aeroflot', 'Boing 777', 23);
GO
INSERT INTO [dbo].[DepartureBoard] VALUES (23,'Tula,Russia-Berlin,Germany','2018-04-20T12:25:32,2018-04-20T15:15:28','01:49:56','Aeroflot','Boing 777');
GO
SELECT*FROM [dbo].[DepartureBoard];
GO
DROP DATABASE AirportInfo1