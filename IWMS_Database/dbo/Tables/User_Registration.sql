CREATE TABLE [dbo].[User_Registration] (
    [FullName] VARCHAR (50)  NOT NULL,
    [UserName] VARCHAR (10)  NOT NULL,
    [Password] VARCHAR (50)  NOT NULL,
    [Email]    VARCHAR (30)  NOT NULL,
    [Phone]    VARCHAR (15)  NOT NULL,
    [Address]  VARCHAR (250) NOT NULL,
    [DOB]      DATE          NOT NULL,
    [Gender]   VARCHAR (30)  NOT NULL,
    [Role]     VARCHAR (30)  NOT NULL
);

