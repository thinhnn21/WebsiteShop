-- Tạo cơ sở dữ liệu
CREATE DATABASE ClothingStore;
GO

-- Sử dụng cơ sở dữ liệu mới tạo
USE ClothingStore;
GO

-- Tạo bảng Danh mục (Categories)
CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY,
    CategoryName NVARCHAR(300),
    CategoryPhoto NVARCHAR(300),
    CategoryOrder INT
);
GO

-- Tạo bảng kích cỡ (Sizes)
CREATE TABLE Sizes (
    SizeId INT PRIMARY KEY,
    SizeName NVARCHAR(10)
);
GO

-- Tạo bảng Màu sắc (Colors)
CREATE TABLE Colors (
    ColorId INT PRIMARY KEY,
    ColorName NVARCHAR(30)
);
GO

-- Tạo bảng Sản phẩm (Products)
CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName NVARCHAR(150) NOT NULL,
    ProductDescription NVARCHAR(MAX),
    CategoryId INT,
    ProductPrice DECIMAL(8,2),
    ProductDiscount DECIMAL(2,2),
    ProductPhoto NVARCHAR(300),
    SizeId INT,
    ColorId INT,
    IsTrendy BIT,
    IsArrived BIT,
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    FOREIGN KEY (SizeId) REFERENCES Sizes(SizeId),
    FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
);
GO
