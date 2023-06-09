USE [master]
GO
/****** Object:  Database [db_qr_code_system]    Script Date: 29/04/2023 09:20:00 ص ******/
CREATE DATABASE [db_qr_code_system]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_qr_code_system', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MURTADANAZAR\MSSQL\DATA\db_qr_code_system.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_qr_code_system_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MURTADANAZAR\MSSQL\DATA\db_qr_code_system_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_qr_code_system] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_qr_code_system].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_qr_code_system] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_qr_code_system] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_qr_code_system] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_qr_code_system] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_qr_code_system] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_qr_code_system] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_qr_code_system] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_qr_code_system] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_qr_code_system] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_qr_code_system] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_qr_code_system] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_qr_code_system] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_qr_code_system] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_qr_code_system] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_qr_code_system] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_qr_code_system] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_qr_code_system] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_qr_code_system] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_qr_code_system] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_qr_code_system] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_qr_code_system] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_qr_code_system] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_qr_code_system] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_qr_code_system] SET  MULTI_USER 
GO
ALTER DATABASE [db_qr_code_system] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_qr_code_system] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_qr_code_system] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_qr_code_system] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_qr_code_system] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_qr_code_system] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_qr_code_system] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_qr_code_system] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_qr_code_system]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discounts](
	[DiscountID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[DiscountExtent] [decimal](10, 2) NULL,
	[PriceBefore] [decimal](10, 2) NULL,
	[PriceAfter] [decimal](10, 2) NULL,
	[Duration] [varchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrintedQRCodes]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrintedQRCodes](
	[PrintedQRCodeID] [int] IDENTITY(1,1) NOT NULL,
	[QRCodeID] [int] NULL,
	[DateOfPrinting] [date] NULL,
	[QuantityPrinted] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrintedQRCodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrintedReports]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrintedReports](
	[PrintedReportID] [int] IDENTITY(1,1) NOT NULL,
	[ReportID] [int] NULL,
	[DateOfPrinting] [date] NULL,
	[QuantityPrinted] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrintedReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](255) NOT NULL,
	[product_price] [decimal](15, 2) NOT NULL,
	[product_production_Date] [date] NOT NULL,
	[product_expiry_Date] [date] NOT NULL,
	[category_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QrCode]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QrCode](
	[qr_code_id] [int] IDENTITY(1,1) NOT NULL,
	[qr_code_value] [varbinary](max) NOT NULL,
	[product_id] [int] NOT NULL,
	[created_at] [datetime] NULL,
	[qr_code_name] [varchar](125) NULL,
PRIMARY KEY CLUSTERED 
(
	[qr_code_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[DateOfReportGeneration] [date] NULL,
	[ReportFormat] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Discounts]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([product_id])
GO
ALTER TABLE [dbo].[PrintedQRCodes]  WITH CHECK ADD FOREIGN KEY([QRCodeID])
REFERENCES [dbo].[QrCode] ([qr_code_id])
GO
ALTER TABLE [dbo].[PrintedReports]  WITH CHECK ADD FOREIGN KEY([ReportID])
REFERENCES [dbo].[Reports] ([ReportID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([category_id])
GO
ALTER TABLE [dbo].[QrCode]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
GO
/****** Object:  StoredProcedure [dbo].[AutoComplete]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AutoComplete]
    @ColumnName NVARCHAR(50),
    @SearchTerm NVARCHAR(50),
    @TableName  VARCHAR(50)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT ' + QUOTENAME(@ColumnName) + ' FROM ' + QUOTENAME(@TableName) + ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%' + @SearchTerm + '%'''

    EXEC sp_executesql @SQL
END
GO
/****** Object:  StoredProcedure [dbo].[CreateQrCodeRecord]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateQrCodeRecord]
    @qr_code_value VARBINARY(MAX),
    @product_id INT,
    @qr_code_name varchar(125)
AS
BEGIN
    SET NOCOUNT ON;
    -- Insert a new record into the QrCode table with the given QR code value, product ID, and timestamp
    DECLARE @sql NVARCHAR(MAX) = N'
        INSERT INTO QrCode (qr_code_value, created_at, product_id, qr_code_name)
        VALUES (@qr_code_value, GETDATE(), @product_id, @qr_code_name)
    '
    EXEC sp_executesql @sql,
        N'@qr_code_value VARBINARY(MAX), @product_id INT, @qr_code_name varchar(125)',
        @qr_code_value, @product_id, @qr_code_name
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCategory]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREATE Procedure to Delete Category
CREATE PROCEDURE [dbo].[DeleteCategory]
    (@CategoryID int)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Category
    WHERE category_id = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteDiscount]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDiscount]
    @discountId int
AS
BEGIN
    DELETE FROM Discounts WHERE DiscountID = @discountId;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREATE Procedure to Delete Product
create PROCEDURE [dbo].[DeleteProduct]
    (@ProductID int)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Product
WHERE product_id = @ProductID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteQRCode]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteQRCode]
    @qrCodeId INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete all records from PrintedQRCodes that reference the QR code
    DELETE FROM PrintedQRCodes
    WHERE QRCodeID = @qrCodeId;

    -- Delete the QR code
    DELETE FROM QrCode
    WHERE qr_code_id = @qrCodeId;
END
GO
/****** Object:  StoredProcedure [dbo].[get_column_names]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_column_names]
    @table_name sysname
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if table exists
    IF NOT EXISTS (
        SELECT 1 
        FROM INFORMATION_SCHEMA.TABLES 
        WHERE TABLE_NAME = @table_name AND TABLE_TYPE = 'BASE TABLE'
    )
    BEGIN
        RAISERROR('Table does not exist', 16, 1);
        RETURN;
    END

    DECLARE @sql nvarchar(max);
    SET @sql = N'SELECT COLUMN_NAME
                 FROM INFORMATION_SCHEMA.COLUMNS
                 WHERE TABLE_NAME = @table_name';

    DECLARE @params nvarchar(max) = N'@table_name sysname';
    
    -- Execute dynamic SQL
    EXEC sp_executesql @sql, @params, @table_name = @table_name;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllDiscounts]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllDiscounts]
AS
BEGIN
    SELECT * FROM Discounts;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllQrCodes]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllQrCodes]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT qr_code_id, qr_code_value, created_at, product_id,qr_code_name
    FROM QrCode;
END
GO
/****** Object:  StoredProcedure [dbo].[GetDatabaseStatistics]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDatabaseStatistics]
AS
BEGIN
    SELECT 
        (SELECT COUNT(product_id) FROM Product) AS TotalProducts,
        (SELECT COUNT(qr_code_id) FROM QrCode) AS TotalQRCodes,
        (SELECT COUNT(category_id) FROM Category) AS TotalCategories,
        (SELECT SUM(QuantityPrinted) FROM PrintedQRCodes) AS TotalPrintedQRCodes,
        (SELECT SUM(QuantityPrinted) FROM PrintedReports) AS TotalPrintedReports,
        (SELECT COUNT(DiscountID) FROM Discounts) AS TotalDiscounts,
        (SELECT COUNT(ReportID) FROM Reports) AS TotalReports
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCategory]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[InsertCategory]
    (
    @CategoryName varchar(255)
    )
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Category
        (
        category_name
        )
    VALUES
        (
            @CategoryName
        );
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertDiscount]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDiscount]
    @productID int,
    @discountExtent decimal(10, 2),
    @quantity int,
    @priceBefore decimal(10, 2),
    @priceAfter decimal(10, 2),
    @duration varchar(125)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Discounts (ProductID, DiscountExtent, PriceBefore, PriceAfter, Duration)
    VALUES (@productID, @discountExtent, @priceBefore, @priceAfter, @duration);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertProduct]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREATE Procedure to Insert Product
create PROCEDURE [dbo].[InsertProduct]
    (
    @ProductName varchar(255),
    @ProductPrice decimal(15, 2),
    @ProductProductionDate date,
    @ProductExpiryDate date,
    @CategoryID int
)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Product
        (
        product_name,
        product_price,
        product_production_date,
        product_expiry_date,
        category_id
        )
    VALUES
        (
            @ProductName,
            @ProductPrice,
            @ProductProductionDate,
            @ProductExpiryDate,
            @CategoryID
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertQrCode]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertQrCode]
    @qr_code_value varbinary(max),
    @product_id int ,
    @qr_code_name varchar(125)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO QrCode (qr_code_value, product_id,qr_code_name)
    VALUES (@qr_code_value, @product_id,@qr_code_name);
END
GO
/****** Object:  StoredProcedure [dbo].[SearchData]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchData]
    @TableName NVARCHAR(128),
    @ColumnName NVARCHAR(128),
    @SearchValue NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @SQL NVARCHAR(MAX);

    -- Validate that the provided table name and column name are valid
    IF NOT EXISTS(SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(@TableName) AND name = @ColumnName)
    BEGIN
        RAISERROR('Invalid table or column name', 16, 1);
        RETURN;
    END
    
    -- Build the dynamic SQL statement
    SET @SQL = N'SELECT * FROM ' + QUOTENAME(@TableName) + ' WHERE ' + QUOTENAME(@ColumnName) + ' LIKE ''%'' + @SearchValue + ''%''';

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL, N'@SearchValue NVARCHAR(100)', @SearchValue;
END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllCategories]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllCategories]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Category
    ORDER BY category_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllProducts]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREATE Procedure to Select All Products
create PROCEDURE [dbo].[SelectAllProducts]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Product;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectCategoryByID]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SelectCategoryByID]
    (@CategoryID int)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Category
    WHERE category_id = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectProductByID]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREATE Procedure to Select Product by ID
create PROCEDURE [dbo].[SelectProductByID]
    (@ProductID int)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM Product
    WHERE product_id = @ProductID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCategory]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateCategory]
    (
    @CategoryID int,
    @CategoryName varchar(255) = NULL
    )
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Category
    SET 
        category_name = ISNULL(@CategoryName, category_name)
    WHERE category_id = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 29/04/2023 09:20:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateProduct]
    (
    @ProductID int,
    @ProductName varchar(255) = NULL,
    @ProductPrice decimal(15, 2) = NULL,
    @ProductProductionDate date = NULL,
    @ProductExpiryDate date = NULL,
    @CategoryID int = NULL
)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Product
    SET 
        product_name = ISNULL(@ProductName, product_name),
        product_price = ISNULL(@ProductPrice, product_price),
        product_production_date = ISNULL(@ProductProductionDate, product_production_date),
        product_expiry_date = ISNULL(@ProductExpiryDate, product_expiry_date),
        category_id = ISNULL(@CategoryID, category_id)
    WHERE product_id = @ProductID;
END;
GO
USE [master]
GO
ALTER DATABASE [db_qr_code_system] SET  READ_WRITE 
GO
