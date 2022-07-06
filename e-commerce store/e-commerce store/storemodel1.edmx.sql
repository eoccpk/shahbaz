
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/06/2022 21:15:56
-- Generated from EDMX file: D:\shahbaz\e-commerce store\e-commerce store\storemodel1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [e-commerce store];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [customername] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [phone] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NULL,
    [balance] int  NOT NULL
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
    [bill_Id] int  NOT NULL
);
GO

-- Creating table 'bills'
CREATE TABLE [dbo].[bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [generationtime] datetime  NOT NULL,
    [ispaid] bit  NOT NULL,
    [amount] float  NOT NULL,
    [billpayment] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [productname] nvarchar(max)  NOT NULL,
    [code] nvarchar(max)  NOT NULL,
    [catagory] nvarchar(max)  NOT NULL,
    [unitprice] int  NOT NULL,
    [catagory2] nvarchar(max)  NOT NULL,
    [image] nvarchar(max)  NOT NULL,
    [seller] nvarchar(max)  NOT NULL,
    [ratting] int  NOT NULL
);
GO

-- Creating table 'orderproduct'
CREATE TABLE [dbo].[orderproduct] (
    [orders_Id] int  NOT NULL,
    [products_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'bills'
ALTER TABLE [dbo].[bills]
ADD CONSTRAINT [PK_bills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [orders_Id], [products_Id] in table 'orderproduct'
ALTER TABLE [dbo].[orderproduct]
ADD CONSTRAINT [PK_orderproduct]
    PRIMARY KEY CLUSTERED ([orders_Id], [products_Id] ASC);
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

-- Creating foreign key on [bill_Id] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [FK_orderbill]
    FOREIGN KEY ([bill_Id])
    REFERENCES [dbo].[bills]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_orderbill'
CREATE INDEX [IX_FK_orderbill]
ON [dbo].[orders]
    ([bill_Id]);
GO

-- Creating foreign key on [orders_Id] in table 'orderproduct'
ALTER TABLE [dbo].[orderproduct]
ADD CONSTRAINT [FK_orderproduct_order]
    FOREIGN KEY ([orders_Id])
    REFERENCES [dbo].[orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [products_Id] in table 'orderproduct'
ALTER TABLE [dbo].[orderproduct]
ADD CONSTRAINT [FK_orderproduct_product]
    FOREIGN KEY ([products_Id])
    REFERENCES [dbo].[products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_orderproduct_product'
CREATE INDEX [IX_FK_orderproduct_product]
ON [dbo].[orderproduct]
    ([products_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------