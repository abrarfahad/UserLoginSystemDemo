CREATE TABLE [ScoolManagementSystemDb].[dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (50) NOT NULL,
    [UserType] INT NOT NULL,
    [ContactNumber]  NVARCHAR(16) NOT NULL,
	[Address]  NVARCHAR(16) NOT NULL,
    [Password]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

