CREATE TABLE [dbo].[Weeks] (
    [WeekId]          INT IDENTITY (1, 1) NOT NULL,
    [WeekNumber]      INT NOT NULL,
    [WeekOrderNumber] INT NOT NULL,
    [UserId]          INT NOT NULL,
    PRIMARY KEY CLUSTERED ([WeekId] ASC)
);

