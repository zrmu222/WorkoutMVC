CREATE TABLE [dbo].[Days] (
    [DayId]          INT IDENTITY (1, 1) NOT NULL,
    [DayNumber]      INT NOT NULL,
    [DayOrderNumber] INT NOT NULL,
    [UserId]         INT NOT NULL,
    [WeekId]         INT NOT NULL,
    PRIMARY KEY CLUSTERED ([DayId] ASC)
);

