
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/07/2022 22:03:19
-- Generated from EDMX file: D:\shahbaz\PRACTICE_ado\PRACTICE_ado\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [practice_ado];
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
    [name] nvarchar(max)  NOT NULL,
    [phone_no] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [balance] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'orders'
CREATE TABLE [dbo].[orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [customerid] nvarchar(max)  NOT NULL,
    [ordertime] datetime  NOT NULL,
    [isconfirmed] bit  NOT NULL,
    [isdeleivered] bit  NOT NULL,
    [delieverytime] datetime  NOT NULL,
    [customerId1] int  NOT NULL,
    [bill_Id] int  NOT NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [productcode] nvarchar(max)  NOT NULL,
    [catagory] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [stockquantity] nvarchar(max)  NOT NULL,
    [unitprice] nvarchar(max)  NOT NULL,
    [image] nvarchar(max)  NOT NULL,
    [selller] nvarchar(max)  NOT NULL,
    [rating] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'bills'
CREATE TABLE [dbo].[bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [generationtime] nvarchar(max)  NOT NULL,
    [ispaid] nvarchar(max)  NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [paymentmethod] nvarchar(max)  NOT NULL
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

-- Creating primary key on [orders_Id], [products_Id] in table 'orderproduct'
ALTER TABLE [dbo].[orderproduct]
ADD CONSTRAINT [PK_orderproduct]
    PRIMARY KEY CLUSTERED ([orders_Id], [products_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [customerId1] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [FK_customerorder]
    FOREIGN KEY ([customerId1])
    REFERENCES [dbo].[customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_customerorder'
CREATE INDEX [IX_FK_customerorder]
ON [dbo].[orders]
    ([customerId1]);
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