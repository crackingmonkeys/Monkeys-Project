USE [master]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'monkeys_expenses')
DROP DATABASE [monkeys_expenses]
GO

CREATE DATABASE [monkeys_expenses]
GO

USE [monkeys_expenses]
GO

CREATE TABLE [MasterRole]
(
	[RoleID] [varchar](10) NOT NULL,
	[RoleName] [varchar](50) NULL,
	[IsActive] [bit],
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_DbRole] PRIMARY KEY ([RoleID])
)
GO

CREATE TABLE [MasterPrefix]
(
	[PrefixID] [varchar](10) NOT NULL,
	[PrefixName] [varchar](50) NULL,
	[IsActive] [bit],
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_DbPrefix] PRIMARY KEY ([PrefixID])
)
GO

CREATE TABLE [MasterUser]
(
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[PrefixID] [varchar](10) NULL,
	[FirstName] [varchar](100) NULL,
	[MidName] [varchar](20) NULL,
	[LastName] [varchar](100) NULL,
	[BirthOfDate] [datetime] NULL,
	[CurrentAddress] [varchar](1000) NULL,
	[Email] [varchar](100) NULL,
	[Tel] [varchar](20) NULL,
	[RoleID] [varchar](10) NULL,
	[IsActive] [bit],
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_DbUser] PRIMARY KEY ([UserName]),
	CONSTRAINT [FK_DbPrefix] FOREIGN KEY ([PrefixID]) REFERENCES [MasterPrefix] ([PrefixID]),
	CONSTRAINT [FK_DbRole] FOREIGN KEY ([RoleID]) REFERENCES [MasterRole] ([RoleID])
)
GO

CREATE TABLE [MasterReceiveType]
(
	[ReceiveTypeCode] [varchar](20) NOT NULL,
	[ReceiveTypeName] [varchar](100) NULL,
	[IsActive] [bit],
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_DbReceiveType] PRIMARY KEY ([ReceiveTypeCode])
)
GO

CREATE TABLE [MasterReceive]
(
	[ID] [bigint] IDENTITY(1, 1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[ReceiveTypeCode] [varchar](20) NOT NULL,
	[ReceiveDesc] [varchar](500) NULL,
	[ReceiveAmount] [numeric](18, 2) NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_MasterReceive] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_DbUser_MasterReceive] FOREIGN KEY ([UserName]) REFERENCES [MasterUser] ([UserName]),
	CONSTRAINT [FK_DbReceiveType_MasterReceive] FOREIGN KEY ([ReceiveTypeCode]) REFERENCES [MasterReceiveType] ([ReceiveTypeCode])
)
GO

CREATE TABLE [MasterPaymentType]
(
	[PaymentTypeCode] [varchar](20) NOT NULL,
	[PaymentTypeName] [varchar](100) NULL,
	[IsActive] [bit],
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_DbPaymentType] PRIMARY KEY ([PaymentTypeCode])
)
GO

CREATE TABLE [MasterPayment]
(
	[ID] [bigint] IDENTITY(1, 1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[PaymentTypeCode] [varchar](20) NOT NULL,
	[PaymentDesc] [varchar](500) NULL,
	[PaymentAmount] [numeric](18, 2) NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [varchar](20) NULL,
	[UpdatedDate] [datetime] NULL
	CONSTRAINT [PK_MasterPayment] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_DbUser_MasterPayment] FOREIGN KEY ([UserName]) REFERENCES [MasterUser] ([UserName]),
	CONSTRAINT [FK_DbPaymentType_MasterPayment] FOREIGN KEY ([PaymentTypeCode]) REFERENCES [MasterPaymentType] ([PaymentTypeCode])
)
GO