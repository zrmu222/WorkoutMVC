CREATE TABLE [dbo].[Exercises] (
    [UserId]         INT          NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [ExerciseNumber] INT          NOT NULL,
    [Weight]         DECIMAL (18) NOT NULL,
    [Sets]           INT          NOT NULL,
    [Reps]           INT          NOT NULL,
    [LastSetReps]    INT          NULL,
    [ExerciseId]     INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Exercises] PRIMARY KEY CLUSTERED ([ExerciseId] ASC)
);

