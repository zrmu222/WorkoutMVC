CREATE TABLE [dbo].[Users] (
    [UserId]      INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (50) NOT NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [CurrentDay]  INT          NOT NULL,
    [CurrentWeek] INT          NOT NULL,
    [UserName]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC, [UserName] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);

