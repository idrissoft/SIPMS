USE [master]
GO
/****** Object:  Database [SIPMS]    Script Date: 08/11/2023 22:41:11 ******/
CREATE DATABASE [SIPMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SIPMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIPMS.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SIPMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIPMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SIPMS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIPMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIPMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIPMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIPMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIPMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIPMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIPMS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SIPMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIPMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIPMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIPMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIPMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIPMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIPMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIPMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIPMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SIPMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIPMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIPMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIPMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIPMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIPMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIPMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIPMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SIPMS] SET  MULTI_USER 
GO
ALTER DATABASE [SIPMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIPMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIPMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIPMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SIPMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIPMS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SIPMS] SET QUERY_STORE = ON
GO
ALTER DATABASE [SIPMS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SIPMS]
GO
/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_Company] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[Contact] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[TIN] [nvarchar](50) NULL,
	[ST] [nvarchar](50) NULL,
	[CIN] [nvarchar](50) NULL,
	[photo] [image] NULL,
 CONSTRAINT [PK_Table_CompanyInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustAcc]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustAcc](
	[Cust_id] [int] NOT NULL,
	[Cust_Name] [nvarchar](50) NULL,
	[Detail] [date] NULL,
	[inv] [nvarchar](max) NULL,
	[debit] [decimal](18, 2) NULL,
	[credit] [decimal](18, 3) NULL,
	[Balance] [decimal](18, 3) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_id] [int] NOT NULL,
	[Customer_Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip Code] [nvarchar](50) NULL,
	[Contacte N°] [nvarchar](50) NULL,
	[Email ID] [nvarchar](50) NULL,
	[Notes] [nvarchar](200) NULL,
	[photo] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Code_item] [nvarchar](50) NOT NULL,
	[Name_item] [nvarchar](100) NULL,
	[image] [image] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Code_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [int] NULL,
	[Product_Name] [nvarchar](50) NULL,
	[Item] [nvarchar](50) NULL,
	[Min_record] [decimal](18, 2) NULL,
	[Quantity] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Sales_Code] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Code_fct] [int] NOT NULL,
	[Code_facture] [nvarchar](50) NULL,
	[Date_purchase] [nvarchar](50) NULL,
	[Code_Sup] [int] NULL,
	[Name_Sup] [nvarchar](50) NULL,
	[Code_Pt] [int] NULL,
	[Name_Pt] [nvarchar](50) NULL,
	[Quantity_Pt] [decimal](18, 2) NULL,
	[Price_Pt] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Notes] [nvarchar](max) NULL,
	[Total_Payement] [decimal](18, 2) NULL,
	[Rest_NonPayement] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[Code_fct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock_Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock_Product](
	[StockID] [int] NULL,
	[ProductID] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Qty] [decimal](18, 2) NULL,
	[Price] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppAcc]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppAcc](
	[Sup_id] [int] NOT NULL,
	[Sup_Name] [nvarchar](50) NULL,
	[Detail] [date] NULL,
	[inv] [nvarchar](max) NULL,
	[debit] [decimal](18, 2) NULL,
	[credit] [decimal](18, 3) NULL,
	[Balance] [decimal](18, 3) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] NOT NULL,
	[Supplier Name ] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip Code] [int] NULL,
	[Contacte N°] [int] NULL,
	[Email ID] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL,
	[photo] [image] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[d1] [bit] NULL,
	[d2] [bit] NULL,
	[d3] [bit] NULL,
	[d4] [bit] NULL,
	[d5] [bit] NULL,
	[d6] [bit] NULL,
	[d7] [bit] NULL,
	[d8] [bit] NULL,
	[d9] [bit] NULL,
	[d10] [bit] NULL,
	[d11] [bit] NULL,
	[d12] [bit] NULL,
	[d13] [bit] NULL,
	[d14] [bit] NULL,
	[d15] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[_Stock]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[_Stock]
@TYPE nvarchar(50),
@Code_fct int,
@Code_Stocktble nvarchar(50),
@InvoiceDate nvarchar(50),
@Code_Supplier int,
@Name_Supplier nvarchar(50),
@Code_Product int,
@Name_Product nvarchar(50),
@Quantity_Pt decimal(18,2),
@Price_Pt decimal(18,2),
@Totalmount decimal(18,2),
@Notes nvarchar(max),
@Total_Payement decimal(18,2),
@Rest_NonPayement decimal(18,2)
AS
BEGIN
  IF @TYPE ='INSERT'
  BEGIN
    INSERT INTO [dbo].[Stock]
           ([Code_fct],[Code_facture],[Date_purchase],[Code_Sup],[Name_Sup],[Code_Pt],[Name_Pt],[Quantity_Pt]
           ,[Price_Pt],[Total],[Notes],[Total_Payement],[Rest_NonPayement])
     VALUES
        (  @Code_fct,@Code_Stocktble, @InvoiceDate, @Code_Supplier, @Name_Supplier, @Code_Product, @Name_Product, @Quantity_Pt 
           ,@Price_Pt, @Totalmount, @Notes, @Total_Payement, @Rest_NonPayement ) 
  END
  IF @TYPE ='UPDATE'
  BEGIN
    UPDATE [dbo].[Stock]
    SET [Date_purchase] = @InvoiceDate,
        [Code_Sup] = @Code_Supplier,
        [Name_Sup] = @Name_Supplier,
        [Code_Pt] = @Code_Product,
        [Name_Pt] = @Name_Product,
        [Quantity_Pt] = @Quantity_Pt,
        [Price_Pt] = @Price_Pt,
        [Total] = @Totalmount,
        [Notes] = @Notes,
        [Total_Payement] = @Total_Payement,
        [Rest_NonPayement] = @Rest_NonPayement
    WHERE [Code_fct] = @Code_fct 
  END
END

GO
/****** Object:  StoredProcedure [dbo].[_Stock_Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_Stock_Product]
    @d1 INT = NULL
   
AS
BEGIN
    IF @d1 IS NOT NULL
    BEGIN
        SELECT * FROM [dbo].[Stock]
        WHERE [Code_fct] = @d1
    END
   
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Company]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_Company]
@Name_Company NVARCHAR(50)
as
DELETE FROM [dbo].[Table_CompanyInfo]
      WHERE ([Name_Company] =@Name_Company)
GO
/****** Object:  StoredProcedure [dbo].[Deletedata]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Deletedata]
@type NVARCHAR(50),
@d1 INT= null 
AS
BEGIN
     IF @type = 'items'
     BEGIN
	
        DELETE FROM [dbo].[Items]
        WHERE Code_item = @d1
    END

    IF @type = 'Customer'
    BEGIN
	
        DELETE FROM [dbo].[Customer]
        WHERE Customer_id = @d1
    END

    IF @type = 'Product'
    BEGIN
       DELETE FROM [dbo].[Product]
      WHERE [Product_ID] = @d1
    END

	if @type = 'Supplier'
	BEGIN

        DELETE FROM [dbo].[Supplier]
       WHERE [SupplierId] =@D1
	  END

	  if @type = 'STOCK'
	BEGIN

	    DELETE FROM [dbo].[Stock]
     where ( [Code_fct] = @D1 )
	 END

	 END

GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteUser]
    @username NVARCHAR(50)  -- or the appropriate data type and size for the username column
AS
BEGIN
DELETE FROM [dbo].[User]
      WHERE [username] = @username
	  end
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerSalesSummary]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerSalesSummary]
    @d1 NVARCHAR(255) = NULL ,
	@TYPE NVARCHAR (50) =''
AS
BEGIN
    SELECT 
        'C° ' + CAST(MIN([Cust_id]) AS NVARCHAR(50)) AS [Id Customer],
        [Cust_Name] AS [Name Custumer],
        SUM([debit]) AS [Debit],
        SUM([credit]) AS [Credit],
        SUM([Balance]) AS [Balance]
    FROM [dbo].[CustAcc]
    WHERE (@d1 IS NULL OR [Cust_Name] LIKE '%' + @d1 + '%')
    GROUP BY [Cust_Name]
END

GO
/****** Object:  StoredProcedure [dbo].[GetProductStockSummary]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetProductStockSummary]
as
begin
  SELECT 
  
  'P °' + cast (min ([ProductID]) as nvarchar (50)) as [Id Product],
    [ProductName] as [Name Product] ,
    cast(SUM([qty]) as  nvarchar(50) )+ ' Unit'as  [Total Quantity]
FROM [SIPMS].[dbo].[Stock_Product]
GROUP BY [ProductName]
ORDer BY ( [Id Product])
end
GO
/****** Object:  StoredProcedure [dbo].[GetSupplierSummary]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[GetSupplierSummary]

  as
  select 
  min([Sup_id]) as [ID Supplier]
  , [Sup_Name] as [Name Supplier]
    ,sum([debit]) as Debit
      ,sum([credit]) as Credit
	  ,[balance] = sum([debit])- sum([credit])
	from [SIPMS].[dbo].[SuppAcc]
	  group by   [Sup_Name]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Company]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_Company]
   
    @Name_Company NVARCHAR(50),
    @Adress NVARCHAR(50),
    @Contact nvarchar(50),
    @Email NVARCHAR(50),
    @TIN NVARCHAR(50),
    @ST NVARCHAR(50),
    @CIN NVARCHAR(50),
    @photo IMAGE
AS
BEGIN
    INSERT INTO [dbo].[Table_CompanyInfo]
    (
     
        [Name_Company],
        [Adress],
        [Contact],
        [Email],
        [TIN],
        [ST],
        [CIN],
        [photo]
    )
    VALUES
    (
      
        @Name_Company,
        @Adress,
        @Contact,
        @Email,
        @TIN,
        @ST,
        @CIN,
        @photo
    )
END
GO
/****** Object:  StoredProcedure [dbo].[insert_custacc]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_custacc]
@d1 int,
@d2 nvarchar(50) = null,
@d3 date,
@d4 nvarchar(50),
@d5 decimal(18,3),
@d6 decimal(18,3),
@d7 decimal(18,3)
as
begin
INSERT INTO [dbo].[CustAcc]
           ([Cust_id]
           ,[Cust_Name]
           ,[Detail]
           ,[inv]
           ,[debit]
           ,[credit]
           ,[Balance])
     VALUES
         (@d1 ,@d2,@d3,@d4 ,@d5,@d6,@d7)
		   end
GO
/****** Object:  StoredProcedure [dbo].[Insert_Customer]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_Customer]
@Customerid int ,
@CustomerName nvarchar(50) ,
@Gender nvarchar(50),
@adress nvarchar(50),
@city nvarchar(50),
@state nvarchar(50),
@zip nvarchar(50),
@contact nvarchar(50),
@email nvarchar(50),
@notes nvarchar(200),
@photo image

as

INSERT INTO [dbo].[Customer]
           ([Customer_id]
		   ,[Customer_Name]
           ,[Gender]
           ,[Adress]
           ,[City]
           ,[State]
           ,[Zip Code]
           ,[Contacte N°]
           ,[Email ID]
           ,[Notes]
           ,[photo]
           )
     VALUES
           ( @Customerid ,
		   @CustomerName ,
@Gender ,
@adress ,
@city ,
@state ,
@zip ,
@contact ,
@email,
@notes ,
@photo
)
GO
/****** Object:  StoredProcedure [dbo].[Insert_Items]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_Items]
@d1  int,
@d2  nvarchar(100),
@d3 image
as

INSERT INTO [dbo].[Items]
           ([Code_item]
           ,[Name_item]
		   ,[image]
          )
     VALUES
	 (@d1, 
	 @d2,
	 @d3)
GO
/****** Object:  StoredProcedure [dbo].[Insert_Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_Product]
       @Product_ID int,
       @Product_Name  nvarchar(50),
       @Item  nvarchar(50),
       @Min_record decimal(18,2),
       @Quantity decimal(18,2)

as

INSERT INTO [dbo].[Product]
           ([Product_ID]
           ,[Product_Name]
           ,[Item]
           ,[Min_record]
           ,[Quantity])
     VALUES (
	  @Product_ID ,
       @Product_Name  ,
       @Item  ,
       @Min_record,
       @Quantity 
       
	 )
GO
/****** Object:  StoredProcedure [dbo].[insert_Sales]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insert_Sales]
@type nvarchar(50),
@saleCode int
AS
BEGIN
    IF @type = 'insert'
    BEGIN
        INSERT INTO [dbo].[Sales] ([Sales_Code])
        VALUES (@saleCode)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_SuppAcc]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_SuppAcc]
@Sup_id int,
@Sup_Name nvarchar(50),
@Detail date,
@inv nvarchar(max),
@debit decimal(18,2),
@credit decimal(18,3)
AS
BEGIN
    INSERT INTO [dbo].[SuppAcc]
           ([Sup_id]
           ,[Sup_Name]
           ,[Detail]
           ,[inv]
           ,[debit]
           ,[credit]
           ,[balance])
     VALUES
           (@Sup_id
           ,@Sup_Name 
           ,@Detail 
           ,@inv 
           ,@debit 
           ,@credit
           ,@credit - @debit) 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Supplier]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[Insert_Supplier]
@supplierid int ,
@supplierName nvarchar(50) ,
@Gender nvarchar(50),
@adress nvarchar(50),
@city nvarchar(50),
@state nvarchar(50),
@zip int,
@contact int,
@email nvarchar(50),
@notes nvarchar(max),
@photo image
as

INSERT INTO [dbo].[Supplier]
           ([SupplierId]
           ,[Supplier Name ]
           ,[Gender]
           ,[Adress]
           ,[City]
           ,[State]
           ,[Zip Code]
           ,[Contacte N°]
           ,[Email ID]
           ,[Notes]
           ,[photo])
     VALUES
         
          ( @supplierid ,
@supplierName ,
@Gender ,
@adress ,
@city ,
@state ,
@zip ,
@contact ,
@email,
@notes ,
@photo)
GO
/****** Object:  StoredProcedure [dbo].[insertuser]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertuser]
    @Username NVARCHAR(50),
    @Password NVARCHAR(50),
    @d1 BIT,
    @d2 BIT,
    @d3 BIT,
    @d4 BIT,
    @d5 BIT,
    @d6 BIT,
    @d7 BIT,
    @d8 BIT,
    @d9 BIT,
    @d10 BIT,
    @d11 BIT,
    @d12 BIT,
    @d13 BIT,
    @d14 BIT,
    @d15 BIT
AS
BEGIN
    INSERT INTO [dbo].[User]
    (
        [Username],
        [PassWord],
        [d1],
        [d2],
        [d3],
        [d4],
        [d5],
        [d6],
        [d7],
        [d8],
        [d9],
        [d10],
        [d11],
        [d12],
        [d13],
        [d14],
        [d15]
    )
    VALUES
    (
        @Username,
        @Password,
        @d1,
        @d2,
        @d3,
        @d4,
        @d5,
        @d6,
        @d7,
        @d8,
        @d9,
        @d10,
        @d11,
        @d12,
        @d13,
        @d14,
        @d15
    )
END
GO
/****** Object:  StoredProcedure [dbo].[Search_Customer]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_Customer]
@CustomerName nvarchar(50)
as

SELECT [Customer_id] as [Customer ID]
      ,[Customer_Name] as [Customer Name]
      ,[Gender]
      ,[Adress]
      ,[City]
      ,[State]
      ,[Zip Code]
      ,[Contacte N°]
      ,[Email ID]
      ,[Notes]
      ,[photo]
  FROM [dbo].[Customer]
  where( [Customer_Name] like '%' + CAST(@CustomerName AS NVARCHAR(100)) + '%')
GO
/****** Object:  StoredProcedure [dbo].[Search_item]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_item]
@d2 nvarchar(100) 
as

SELECT [Code_item] as  [Code item]
      ,[Name_item] as [Name item]
      ,[image]
  FROM [dbo].[Items]
  where ( [Name_item] LIKE '%' + CAST(@d2 AS NVARCHAR(100)) + '%')
GO
/****** Object:  StoredProcedure [dbo].[Select_Company]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_Company]

as 

SELECT 
      [Name_Company] as[ Name Company]
      ,[Adress]
      ,[Contact] as [Contact N°]
      ,[Email] as [Email ID]
      ,[TIN]
      ,[ST] AS [ST N°]
      ,[CIN]
	   ,[photo]
  FROM [dbo].[Table_CompanyInfo]
GO
/****** Object:  StoredProcedure [dbo].[Select_Customers]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_Customers]
as
SELECT [Customer_id] as [Customer ID ]
      ,[Customer_Name] as [Customer Name ]
      ,[Gender]
      ,[Adress]
      ,[City]
      ,[State]
      ,[Zip Code]
      ,[Contacte N°]
      ,[Email ID]
      ,[Notes]
      ,[photo]
  FROM [dbo].[Customer] ORDER BY [Customer ID ]
GO
/****** Object:  StoredProcedure [dbo].[select_items]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[select_items]

as

SELECT [Code_item] as [Code item] 
      ,[Name_item] as [Name Item]
      ,[image]
  FROM [dbo].[Items]
GO
/****** Object:  StoredProcedure [dbo].[Select_Items_name]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Select_Items_name]
as
SELECT 
      [Name_item] 
  
  FROM [dbo].[Items]
  ORDER BY  [Code_item]
GO
/****** Object:  StoredProcedure [dbo].[Select_Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_Product] 

as
 SELECT        dbo.Product.*, dbo.Temp_Stock.Quantity AS [Qty final]
FROM            dbo.Temp_Stock CROSS JOIN
                         dbo.Product
						 where dbo.Temp_Stock.Product_ID =dbo.Product.Product_ID
  ORDER BY ( [Product_ID])
GO
/****** Object:  StoredProcedure [dbo].[Select_Pt]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_Pt]
as
SELECT        dbo.Product.*
FROM            dbo.Product
GO
/****** Object:  StoredProcedure [dbo].[Select_StockProductSum]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Select_StockProductSum]
AS
SELECT TOP (1000) 
      'P°' + CAST([ProductID] AS NVARCHAR(50)) AS [ProductID], 
      [ProductName] AS [Product Name],
      SUM([Qty]) AS [Total Quantity]
FROM [SIPMS].[dbo].[Stock_Product]
GROUP BY [ProductID], [ProductName];
GO
/****** Object:  StoredProcedure [dbo].[Select_SuppAccId]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_SuppAccId]
@Sup_id int
as
SELECT [Sup_id]
      ,[Sup_Name]
      ,[Detail]
      ,[inv]
      ,[debit]
      ,[credit]
  FROM [dbo].[SuppAcc]
  where  [Sup_id] = @Sup_id
GO
/****** Object:  StoredProcedure [dbo].[Select_Supplier]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_Supplier]
as
SELECT [SupplierId] as [Supplier ID ]
      ,[Supplier Name ]
      ,[Gender]
      ,[Adress]
      ,[City]
      ,[State]
      ,[Zip Code]
      ,[Contacte N°]
      ,[Email ID]
      ,[Notes]
      ,[photo]
  FROM [dbo].[Supplier]

GO
/****** Object:  StoredProcedure [dbo].[Select_Supplier_Vue]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_Supplier_Vue]
as

 SELECT 'S°' + Cast (min([Sup_id]) as nvarchar(50) )[Id Supplier] , [Sup_Name] as [Name Supplier], cast(SUM([debit]) as nvarchar (50)) +' €' as TotalDebit
      , cast(SUM([credit]) as nvarchar(50)) + ' €' as TotalCredit, cast(SUM([Balance]) as varchar(50))+ ' €' as TotalBalance
FROM [SIPMS].[dbo].[SuppAcc]
GROUP BY [Sup_Name]
ORDER BY TotalBalance DESC;
GO
/****** Object:  StoredProcedure [dbo].[Select_SupplierNAME]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[Select_SupplierNAME]
@Supplier_Name  as nvarchar
as
SELECT [Supplier ID ]
      
     
  FROM [dbo].[Supplier]
  where ( [Supplier Name ] = @Supplier_Name )
GO
/****** Object:  StoredProcedure [dbo].[Select_User]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_User]
as
SELECT TOP (1000) [Username]
      ,[PassWord]
     
  FROM [SIPMS].[dbo].[User]
GO
/****** Object:  StoredProcedure [dbo].[Select_user1]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_user1]

@username as nvarchar (50) 
as
begin
SELECT [Username]
      ,[PassWord]
      ,[d1]
      ,[d2]
      ,[d3]
      ,[d4]
      ,[d5]
      ,[d6]
      ,[d7]
      ,[d8]
      ,[d9]
      ,[d10]
      ,[d11]
      ,[d12]
      ,[d13]
      ,[d14]
      ,[d15]
  FROM [dbo].[User]
  where  [Username]=@Username
  end
GO
/****** Object:  StoredProcedure [dbo].[Selecte_Stock]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Selecte_Stock]
AS 
SELECT [Code_facture] as [Code facture ]
      ,[Date_purchase] as [Date purchase]
      ,[Code_Sup] as [Code Sup]
      ,[Name_Sup] as [Name Sup]
      ,[Code_Pt] as [Code Product]
      ,[Name_Pt] as [Name product]
      ,[Quantity_Pt] as [Quantity Product]
      ,[Price_Pt] as [Price Product]
      ,[Total] 
      ,[Notes]
      
      ,[Total_Payement] as [Total Payement] 
      ,[Rest_NonPayement] as [Rest Non Payement]
  FROM [dbo].[Stock]
  ORDER BY [Code_fct]
GO
/****** Object:  StoredProcedure [dbo].[Selectlogin]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Selectlogin]
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    -- Assuming you have a column named 'PasswordHash' that stores hashed passwords
    SELECT [Username],[Password],[d1], [d2], [d3], [d4], [d5], [d6], [d7], [d8], [d9], [d10], 
           [d11], [d12], [d13], [d14], [d15]
    FROM [dbo].[User]
    WHERE [Username] = @Username AND [Password] = @Password
END

GO
/****** Object:  StoredProcedure [dbo].[SelectStock]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


  create proc [dbo].[SelectStock]
  as
  begin
  select  TOP (1000)
 
'P°'+ cast( min([ProductID]) as nvarchar(50) ) as [ID Product] ,
  [ProductName] as [Name Product],
  cast(sum([Qty]) as nvarchar (50)) + ' Unit' as [Quantity]
   FROM [SIPMS].[dbo].[Stock_Product]
   group by ([ProductName])
   end
GO
/****** Object:  StoredProcedure [dbo].[SelectViewProduct]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectViewProduct]
as
SELECT TOP (1000) 
'P°' + cast([Product_ID] as nvarchar(50) )as [Product Id]
      ,[Product_Name]
      ,cast([TotalQuantity] as nvarchar(50)) +' Unit' as [Total Quantity]
  FROM [SIPMS].[dbo].[View_Ptstock]
GO
/****** Object:  StoredProcedure [dbo].[sellect]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sellect]
as
SELECT TOP (1000) [Username]
      ,[PassWord]
      ,[d1]
      ,[d2]
      ,[d3]
      ,[d4]
      ,[d5]
      ,[d6]
      ,[d7]
      ,[d8]
      ,[d9]
      ,[d10]
      ,[d11]
      ,[d12]
      ,[d13]
      ,[d14]
      ,[d15]
  FROM [SIPMS].[dbo].[User]
GO
/****** Object:  StoredProcedure [dbo].[Srlrct_StockCF]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Srlrct_StockCF]
@d1 int
as
SELECT [Code_fct] ,
   [Code_facture]
      ,[Date_purchase]
      ,[Code_Sup]
      ,[Name_Sup]
      ,[Code_Pt]
      ,[Name_Pt]
      ,[Quantity_Pt]
      ,[Price_Pt]
      ,[Total]
      ,[Notes]
      ,[Total_Payement]
      ,[Rest_NonPayement]
  FROM [dbo].[Stock]
 
  WHERE [Code_fct] = @d1
GO
/****** Object:  StoredProcedure [dbo].[StockProduct]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[StockProduct]

@d1 int,
@d2 int,
@d3 nvarchar(50) ,
@d4 decimal,
@d5 decimal,
@d6 decimal

as 
begin

INSERT INTO [dbo].[Stock_Product]
           ([StockID]
           ,[ProductID]
           ,[ProductName]
           ,[Qty]
           ,[Price]
           ,[TotalAmount])
     VALUES
          (@d1,@d2,@d3,@d4,@d5,@d6)

		   end
GO
/****** Object:  StoredProcedure [dbo].[StockProducta]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[StockProducta]


@d1 int,
@d2 nvarchar(50) ,
@d3 decimal


as 
begin

INSERT INTO [dbo].[Stock_Product]
           ([ProductID]
           ,[ProductName]
           ,[Qty])
     VALUES
          (@d1,@d2,@d3)

		   end
GO
/****** Object:  StoredProcedure [dbo].[TempStock]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TempStock]
@TYPE nvarchar,
@Product_ID INT ,
@Quantity decimal = null
as
BEGIN
IF @TYPE = 'INSERT'
BEGIN
INSERT INTO [dbo].[Temp_Stock]
           ([Product_ID]
           , [Quantity] )
     VALUES
           (@Product_ID ,
           @Quantity)
END

IF @TYPE = 'UPDATE'
BEGIN
       UPDATE [dbo].[Temp_Stock]
   SET 
      [Quantity] = [Quantity]  + @Quantity
 WHERE ([Product_ID] = @Product_ID)
        

END

IF @TYPE = 'SELECT'
BEGIN

 SELECT* FROM [dbo].[Temp_Stock]
  where [Product_ID] = @Product_ID
END

IF @TYPE = 'DELETE'
BEGIN
  DELETE FROM [dbo].[Temp_Stock]
  where [Product_ID] = @Product_ID
END

END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_Company]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_Company]
    @Name_Company NVARCHAR(50),
    @Adress NVARCHAR(50),
    @Contact INT,
    @Email NVARCHAR(50),
    @TIN NVARCHAR(50),
    @ST NVARCHAR(50),
    @CIN NVARCHAR(50),
    @photo IMAGE
AS
BEGIN
    UPDATE [dbo].[Table_CompanyInfo]
    SET
        [Adress] = @Adress,
        [Contact] = @Contact,
        [Email] = @Email,
        [TIN] = @TIN,
        [ST] = @ST,
        [CIN] = @CIN,
        [photo] = @photo
    WHERE [Name_Company] = @Name_Company
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Customer]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Customer]


@Customerid int ,
@CustomerName nvarchar(50) ,
@Gender nvarchar(50),
@adress nvarchar(50),
@city nvarchar(50),
@state nvarchar(50),
@zip int,
@contact int,
@email nvarchar(50),
@notes nvarchar(max),
@photo image

as

UPDATE [dbo].[Customer]
   SET 
      [Customer_Name]  = @CustomerName ,
      [Gender] = @Gender ,
      [Adress] = @adress ,
      [city] =@city ,
      [State] = @state , 
      [Zip Code] =  @zip ,
      [Contacte N°] =@contact ,
      [Email ID] = @email ,
      [Notes]= @notes ,
      [photo] = @photo

 WHERE
 [Customer_id]  = @Customerid
GO
/****** Object:  StoredProcedure [dbo].[Update_Items]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Items]
@d1 int,
@d2 nvarchar(100)
as

UPDATE [dbo].[Items]
   SET [Code_item] =@d1
      ,[Name_item] =@d2
      
 WHERE ( Code_item =@d1 )
GO
/****** Object:  StoredProcedure [dbo].[Update_Product]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Product]
     @Product_ID int,
       @Product_Name  nvarchar(50),
       @Item  nvarchar(50),
       @Min_record decimal(18,2),
       @Quantity decimal(18,2)



as

UPDATE [dbo].[Product]
   SET 
      [Product_Name] = @Product_Name
      ,[Item] = @Item
      ,[Min_record] = @Min_record
      ,[Quantity] =@Quantity
 WHERE ( [Product_ID] = @Product_ID )
GO
/****** Object:  StoredProcedure [dbo].[Update_Supplier]    Script Date: 08/11/2023 22:41:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_Supplier]
@supplierid int ,
@supplierName nvarchar(50) ,
@Gender nvarchar(50),
@adress nvarchar(50),
@city nvarchar(50),
@state nvarchar(50),
@zip int,
@contact int,
@email nvarchar(50),
@notes nvarchar(max),
@photo image

as

UPDATE [dbo].[Supplier]
   SET 
      [Supplier Name ] = @supplierName ,
      [Adress] = @adress ,
      [city] =@city ,
      [State] = @state , 
      [Zip Code] =  @zip ,
      [Contacte N°] =@contact ,
      [Email ID] = @email ,
      [Notes]= @notes ,
      [photo] = @photo

 WHERE
 [SupplierId] = @supplierid


GO
USE [master]
GO
ALTER DATABASE [SIPMS] SET  READ_WRITE 
GO
