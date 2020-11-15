USE [master]
GO
/****** Object:  Database [RecipesDB]    Script Date: 15/11/2020 02:29:36 ******/
CREATE DATABASE [RecipesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RecipesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RecipesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RecipesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RecipesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RecipesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RecipesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RecipesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RecipesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RecipesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RecipesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RecipesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [RecipesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RecipesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RecipesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RecipesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RecipesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RecipesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RecipesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RecipesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RecipesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RecipesDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RecipesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RecipesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RecipesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RecipesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RecipesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RecipesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RecipesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RecipesDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RecipesDB] SET  MULTI_USER 
GO
ALTER DATABASE [RecipesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RecipesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RecipesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RecipesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RecipesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RecipesDB] SET QUERY_STORE = OFF
GO
USE [RecipesDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryRecipe]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryRecipe](
	[CategoryRecipeID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[RecipeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryRecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommentsRecipe]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentsRecipe](
	[CommentsRecipeID] [int] IDENTITY(1,1) NOT NULL,
	[CommentID] [int] NOT NULL,
	[RecipeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentsRecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IngredientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredientsRecipe]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientsRecipe](
	[IngredientsRecipeID] [int] IDENTITY(1,1) NOT NULL,
	[RecipeID] [int] NOT NULL,
	[IngredientID] [int] NOT NULL,
	[IngredientQuantity] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IngredientsRecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructions]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructions](
	[InstructionID] [int] IDENTITY(1,1) NOT NULL,
	[RecipeID] [int] NOT NULL,
	[InstructionText] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[InstructionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfRatings] [int] NOT NULL,
	[Score] [decimal](3, 2) NOT NULL,
	[SumRatings] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipe]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipe](
	[RecipeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[LongDescription] [text] NOT NULL,
	[PictureLocation] [nvarchar](500) NULL,
	[RatingID] [int] NOT NULL,
	[PrepTime] [int] NOT NULL,
	[CookTime] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subcategory]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subcategory](
	[SubcategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubcategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubcategoryRecipe]    Script Date: 15/11/2020 02:29:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubcategoryRecipe](
	[SubcategoryRecipeID] [int] IDENTITY(1,1) NOT NULL,
	[SubcategoryID] [int] NOT NULL,
	[RecipeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubcategoryRecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CategoryRecipe]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[CategoryRecipe]  WITH CHECK ADD FOREIGN KEY([RecipeID])
REFERENCES [dbo].[Recipe] ([RecipeID])
GO
ALTER TABLE [dbo].[CommentsRecipe]  WITH CHECK ADD FOREIGN KEY([CommentID])
REFERENCES [dbo].[Comments] ([CommentID])
GO
ALTER TABLE [dbo].[CommentsRecipe]  WITH CHECK ADD FOREIGN KEY([RecipeID])
REFERENCES [dbo].[Recipe] ([RecipeID])
GO
ALTER TABLE [dbo].[IngredientsRecipe]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[IngredientsRecipe]  WITH CHECK ADD FOREIGN KEY([RecipeID])
REFERENCES [dbo].[Recipe] ([RecipeID])
GO
ALTER TABLE [dbo].[Instructions]  WITH CHECK ADD FOREIGN KEY([RecipeID])
REFERENCES [dbo].[Recipe] ([RecipeID])
GO
ALTER TABLE [dbo].[Recipe]  WITH CHECK ADD FOREIGN KEY([RatingID])
REFERENCES [dbo].[Ratings] ([RatingID])
GO
ALTER TABLE [dbo].[SubcategoryRecipe]  WITH CHECK ADD FOREIGN KEY([RecipeID])
REFERENCES [dbo].[Recipe] ([RecipeID])
GO
ALTER TABLE [dbo].[SubcategoryRecipe]  WITH CHECK ADD FOREIGN KEY([SubcategoryID])
REFERENCES [dbo].[Subcategory] ([SubcategoryID])
GO
USE [master]
GO
ALTER DATABASE [RecipesDB] SET  READ_WRITE 
GO
