CREATE TABLE [dbo].[Customer] (
    [id] UNIQUEIDENTIFIER NOT NULL,
    [FirstName] NVARCHAR NULL,
    [LastName] NVARCHAR NULL,
    [FullName] NVARCHAR NULL,
    [DateOfBirth] DATETIME NULL,
    [Gender] NVARCHAR NULL,
    [Address] NVARCHAR NULL,
 
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Address] (
    [id] UNIQUEIDENTIFIER NOT NULL,
    [HouseNumber] NVARCHAR NULL,
    [StreetName] NVARCHAR NULL,
    [PostCode] NVARCHAR NULL,
    [City] NVARCHAR NULL,

    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([id] ASC)

);

CREATE TABLE [dbo].[Customer_Address] (
    [CustomerId] UNIQUEIDENTIFIER NOT NULL,
    [AddressId] UNIQUEIDENTIFIER NOT NULL,
);

Alter TABLE [dbo].[CustomerAddress]
add CONSTRAINT FK_Customer FOREIGN KEY (CustomerId) REFERENCES Customer(Id);

Alter TABLE [dbo].[CustomerAddress]
add CONSTRAINT FK_Address FOREIGN KEY (AddressId) REFERENCES Address(Id);



