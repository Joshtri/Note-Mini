CREATE TABLE [dbo].[Users] (
    [Name]         VARCHAR (50) NOT NULL,
    [Password]     CHAR (10)    NOT NULL,
    [Email]        VARCHAR (30) NOT NULL,
    [Phone Number] VARCHAR (50) NOT NULL,
    [Gender]       VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

