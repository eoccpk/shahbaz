
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/09/2022 23:58:33
-- Generated from EDMX file: D:\shahbaz\e-commercestore\e-commercestore\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [e-commercestore];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_customerorder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orders] DROP CONSTRAINT [FK_customerorder];
GO
IF OBJECT_ID(N'[dbo].[FK_orderorderproduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orderproducts] DROP CONSTRAINT [FK_orderorderproduct];
GO
IF OBJECT_ID(N'[dbo].[FK_productorderproduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[orderproducts] DROP CONSTRAINT [FK_productorderproduct];
GO
IF OBJECT_ID(N'[dbo].[FK_orderbill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[bills] DROP CONSTRAINT [FK_orderbill];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customers];
GO
IF OBJECT_ID(N'[dbo].[orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orders];
GO
IF OBJECT_ID(N'[dbo].[orderproducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[orderproducts];
GO
IF OBJECT_ID(N'[dbo].[products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[products];
GO
IF OBJECT_ID(N'[dbo].[bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bills];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [phone] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL,
    [balance] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'orders'
CREATE TABLE [dbo].[orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ordertime] datetime  NOT NULL,
    [isconfirmed] bit  NOT NULL,
    [isdispatched] bit  NOT NULL,
    [dispatchtime] datetime  NOT NULL,
    [isdelievered] bit  NOT NULL,
    [delieverytime] datetime  NOT NULL,
    [customerId] int  NOT NULL,
    [productId] int  NOT NULL
);
GO

-- Creating table 'orderproducts'
CREATE TABLE [dbo].[orderproducts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [quantity] int  NOT NULL,
    [orderId] int  NOT NULL,
    [productId] int  NOT NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [code] nvarchar(max)  NOT NULL,
    [catagory] nvarchar(max)  NOT NULL,
    [unitprice] int  NOT NULL,
    [stockquantity] int  NOT NULL,
    [rating] int  NOT NULL,
    [seller] nvarchar(max)  NOT NULL,
    [image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'bills'
CREATE TABLE [dbo].[bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [generationtime] datetime  NOT NULL,
    [ispaid] bit  NOT NULL,
    [amount] int  NOT NULL,
    [paymentmethod] nvarchar(max)  NOT NULL,
    [orderId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [PK_orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'orderproducts'
ALTER TABLE [dbo].[orderproducts]
ADD CONSTRAINT [PK_orderproducts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'bills'
ALTER TABLE [dbo].[bills]
ADD CONSTRAINT [PK_bills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [customerId] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [FK_customerorder]
    FOREIGN KEY ([customerId])
    REFERENCES [dbo].[customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_customerorder'
CREATE INDEX [IX_FK_customerorder]
ON [dbo].[orders]
    ([customerId]);
GO

-- Creating foreign key on [orderId] in table 'orderproducts'
ALTER TABLE [dbo].[orderproducts]
ADD CONSTRAINT [FK_orderorderproduct]
    FOREIGN KEY ([orderId])
    REFERENCES [dbo].[orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_orderorderproduct'
CREATE INDEX [IX_FK_orderorderproduct]
ON [dbo].[orderproducts]
    ([orderId]);
GO

-- Creating foreign key on [productId] in table 'orderproducts'
ALTER TABLE [dbo].[orderproducts]
ADD CONSTRAINT [FK_productorderproduct]
    FOREIGN KEY ([productId])
    REFERENCES [dbo].[products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_productorderproduct'
CREATE INDEX [IX_FK_productorderproduct]
ON [dbo].[orderproducts]
    ([productId]);
GO

-- Creating foreign key on [orderId] in table 'bills'
ALTER TABLE [dbo].[bills]
ADD CONSTRAINT [FK_orderbill]
    FOREIGN KEY ([orderId])
    REFERENCES [dbo].[orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_orderbill'
CREATE INDEX [IX_FK_orderbill]
ON [dbo].[bills]
    ([orderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------