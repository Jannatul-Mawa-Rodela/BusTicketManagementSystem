USE [master]
GO
/** Object:  Database [BusTicketManagementSystem]    Script Date: 9/14/2026 12:27:51 PM **/
CREATE DATABASE [BusTicketManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusTicketManagementSystem', FILENAME = N'C:\Users\HP\BusTicketManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusTicketManagementSystem_log', FILENAME = N'C:\Users\HP\BusTicketManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BusTicketManagementSystem] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusTicketManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusTicketManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BusTicketManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusTicketManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusTicketManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BusTicketManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusTicketManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusTicketManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [BusTicketManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusTicketManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusTicketManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusTicketManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusTicketManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusTicketManagementSystem] SET QUERY_STORE = OFF
GO
USE [BusTicketManagementSystem]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [BusTicketManagementSystem]
GO
/** Object:  Table [dbo].[Bookings]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ScheduleID] [int] NOT NULL,
	[BookingDate] [datetime] NOT NULL,
	[TotalSeats] [int] NOT NULL,
	[TotalAmount] [decimal](10, 2) NOT NULL,
	[BookingStatus] [nvarchar](20) NOT NULL,
	[PaymentStatus] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[BookingSeats]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingSeats](
	[BookingSeatID] [int] IDENTITY(1,1) NOT NULL,
	[BookingID] [int] NOT NULL,
	[SeatID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingSeatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_BookingSeats] UNIQUE NONCLUSTERED 
(
	[BookingID] ASC,
	[SeatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Buses]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses](
	[BusID] [int] IDENTITY(1,1) NOT NULL,
	[OperatorID] [int] NOT NULL,
	[BusNumber] [nvarchar](30) NOT NULL,
	[BusType] [nvarchar](20) NOT NULL,
	[TotalSeats] [int] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[BusNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Customers]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Address] [nvarchar](255) NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Notifications]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[OperatorID] [int] NULL,
	[Title] [varchar](150) NOT NULL,
	[Message] [varchar](500) NOT NULL,
	[NotificationType] [varchar](50) NULL,
	[IsRead] [bit] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[OperatorPayments]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatorPayments](
	[OperatorPaymentID] [int] IDENTITY(1,1) NOT NULL,
	[OperatorID] [int] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[PaymentMethod] [varchar](30) NULL,
	[TransactionID] [varchar](100) NULL,
	[PaymentStatus] [varchar](20) NOT NULL,
	[PaymentDate] [datetime] NULL,
	[DueDate] [date] NULL,
	[Notes] [varchar](500) NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OperatorPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Operators]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operators](
	[OperatorID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
	[CompanyAddress] [nvarchar](255) NULL,
	[LicenseNumber] [nvarchar](50) NULL,
	[CommissionRate] [decimal](5, 2) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[Phone] [varchar](30) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[OperatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Payments]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[BookingID] [int] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[PaymentMethod] [varchar](30) NOT NULL,
	[PaymentStatus] [varchar](20) NOT NULL,
	[TransactionID] [varchar](100) NULL,
	[PaymentDate] [datetime] NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Reviews]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[BookingID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [varchar](500) NULL,
	[ReviewDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Reviews_Booking] UNIQUE NONCLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Routes]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Routes](
	[RouteID] [int] IDENTITY(1,1) NOT NULL,
	[FromLocation] [nvarchar](100) NOT NULL,
	[ToLocation] [nvarchar](100) NOT NULL,
	[DistanceKM] [decimal](8, 2) NULL,
	[EstimatedTime] [nvarchar](50) NULL,
	[RouteFare] [decimal](10, 2) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RouteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Schedules]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[BusID] [int] NOT NULL,
	[RouteID] [int] NOT NULL,
	[TravelDate] [date] NOT NULL,
	[DepartureTime] [time](7) NOT NULL,
	[ArrivalTime] [time](7) NOT NULL,
	[Fare] [decimal](10, 2) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Seats]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[SeatID] [int] IDENTITY(1,1) NOT NULL,
	[BusID] [int] NOT NULL,
	[SeatNumber] [nvarchar](10) NOT NULL,
	[SeatType] [nvarchar](20) NOT NULL,
	[RowNumber] [int] NOT NULL,
	[ColumnNumber] [int] NOT NULL,
	[Deck] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SeatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Seats_Bus_SeatNumber] UNIQUE NONCLUSTERED 
(
	[BusID] ASC,
	[SeatNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Users]    Script Date: 9/14/2026 12:27:51 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[Role] [nvarchar](20) NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT (getdate()) FOR [BookingDate]
GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT ('Confirmed') FOR [BookingStatus]
GO
ALTER TABLE [dbo].[Bookings] ADD  DEFAULT ('Pending') FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[Buses] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Buses] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Notifications] ADD  DEFAULT ((0)) FOR [IsRead]
GO
ALTER TABLE [dbo].[Notifications] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[OperatorPayments] ADD  DEFAULT ('Pending') FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[OperatorPayments] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Operators] ADD  DEFAULT ((10.00)) FOR [CommissionRate]
GO
ALTER TABLE [dbo].[Operators] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Operators] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT ('Pending') FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[Payments] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Reviews] ADD  DEFAULT (getdate()) FOR [ReviewDate]
GO
ALTER TABLE [dbo].[Routes] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Schedules] ADD  DEFAULT ('Scheduled') FOR [Status]
GO
ALTER TABLE [dbo].[Schedules] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ('Regular') FOR [SeatType]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ('Lower') FOR [Deck]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('Active') FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Customers]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Schedules] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedules] ([ScheduleID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Schedules]
GO
ALTER TABLE [dbo].[BookingSeats]  WITH CHECK ADD  CONSTRAINT [FK_BookingSeats_Bookings] FOREIGN KEY([BookingID])
REFERENCES [dbo].[Bookings] ([BookingID])
GO
ALTER TABLE [dbo].[BookingSeats] CHECK CONSTRAINT [FK_BookingSeats_Bookings]
GO
ALTER TABLE [dbo].[BookingSeats]  WITH CHECK ADD  CONSTRAINT [FK_BookingSeats_Seats] FOREIGN KEY([SeatID])
REFERENCES [dbo].[Seats] ([SeatID])
GO
ALTER TABLE [dbo].[BookingSeats] CHECK CONSTRAINT [FK_BookingSeats_Seats]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Operators] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[Operators] ([OperatorID])
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [FK_Buses_Operators]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Users]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Customers]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Operators] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[Operators] ([OperatorID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Operators]
GO
ALTER TABLE [dbo].[OperatorPayments]  WITH CHECK ADD  CONSTRAINT [FK_OperatorPayments_Operators] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[Operators] ([OperatorID])
GO
ALTER TABLE [dbo].[OperatorPayments] CHECK CONSTRAINT [FK_OperatorPayments_Operators]
GO
ALTER TABLE [dbo].[Operators]  WITH CHECK ADD  CONSTRAINT [FK_Operators_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Operators] CHECK CONSTRAINT [FK_Operators_Users]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Bookings] FOREIGN KEY([BookingID])
REFERENCES [dbo].[Bookings] ([BookingID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Bookings]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Bookings] FOREIGN KEY([BookingID])
REFERENCES [dbo].[Bookings] ([BookingID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Bookings]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Customers]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Buses] FOREIGN KEY([BusID])
REFERENCES [dbo].[Buses] ([BusID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Buses]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Routes] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Routes] ([RouteID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Routes]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [FK_Seats_Buses] FOREIGN KEY([BusID])
REFERENCES [dbo].[Buses] ([BusID])
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [FK_Seats_Buses]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [CK_Bookings_BookingStatus] CHECK  (([BookingStatus]='Completed' OR [BookingStatus]='Cancelled' OR [BookingStatus]='Confirmed'))
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [CK_Bookings_BookingStatus]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [CK_Bookings_PaymentStatus] CHECK  (([PaymentStatus]='Refunded' OR [PaymentStatus]='Paid' OR [PaymentStatus]='Pending'))
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [CK_Bookings_PaymentStatus]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [CK_Bookings_TotalAmount] CHECK  (([TotalAmount]>=(0)))
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [CK_Bookings_TotalAmount]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [CK_Bookings_TotalSeats] CHECK  (([TotalSeats]>(0)))
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [CK_Bookings_TotalSeats]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [CK_Buses_BusType] CHECK  (([BusType]='Sleeper' OR [BusType]='Non-AC' OR [BusType]='AC'))
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [CK_Buses_BusType]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [CK_Buses_Status] CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [CK_Buses_Status]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [CK_Buses_TotalSeats] CHECK  (([TotalSeats]>(0)))
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [CK_Buses_TotalSeats]
GO
ALTER TABLE [dbo].[Operators]  WITH CHECK ADD  CONSTRAINT [CK_Operators_CommissionRate] CHECK  (([CommissionRate]>=(0) AND [CommissionRate]<=(100)))
GO
ALTER TABLE [dbo].[Operators] CHECK CONSTRAINT [CK_Operators_CommissionRate]
GO
ALTER TABLE [dbo].[Operators]  WITH CHECK ADD  CONSTRAINT [CK_Operators_Status] CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Operators] CHECK CONSTRAINT [CK_Operators_Status]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [CK_Reviews_Rating] CHECK  (([Rating]>=(1) AND [Rating]<=(5)))
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [CK_Reviews_Rating]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [CK_Routes_Distance] CHECK  (([DistanceKM] IS NULL OR [DistanceKM]>(0)))
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [CK_Routes_Distance]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [CK_Routes_Fare] CHECK  (([RouteFare]>=(0)))
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [CK_Routes_Fare]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [CK_Routes_Status] CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [CK_Routes_Status]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [CK_Schedules_Fare] CHECK  (([Fare]>=(0)))
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [CK_Schedules_Fare]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [CK_Schedules_Status] CHECK  (([Status]='Cancelled' OR [Status]='Completed' OR [Status]='Scheduled'))
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [CK_Schedules_Status]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [CK_Seats_ColumnNumber] CHECK  (([ColumnNumber]>(0)))
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [CK_Seats_ColumnNumber]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [CK_Seats_Deck] CHECK  (([Deck]='Upper' OR [Deck]='Lower'))
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [CK_Seats_Deck]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [CK_Seats_RowNumber] CHECK  (([RowNumber]>(0)))
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [CK_Seats_RowNumber]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [CK_Seats_SeatType] CHECK  (([SeatType]='Sleeper' OR [SeatType]='VIP' OR [SeatType]='Regular'))
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [CK_Seats_SeatType]
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD  CONSTRAINT [CK_Seats_Status] CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Seats] CHECK CONSTRAINT [CK_Seats_Status]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_Users_Role] CHECK  (([Role]='Customer' OR [Role]='Operator' OR [Role]='SuperAdmin'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_Users_Role]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_Users_Status] CHECK  (([Status]='Inactive' OR [Status]='Active'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_Users_Status]
GO
USE [master]
GO
ALTER DATABASE [BusTicketManagementSystem] SET  READ_WRITE 
GO