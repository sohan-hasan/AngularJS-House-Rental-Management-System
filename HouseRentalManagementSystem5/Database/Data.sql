USE [HouseRentalManagementSystemAngularJS]
GO
SET IDENTITY_INSERT [dbo].[ApartmentBuildings] ON 

INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (2, N'asd', N'ASF', N'SDF', N'DFS', N'FDS', N'SDF', N'DFS', N'c87a7744.jpg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (4, N'dfs', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', NULL)
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (5, N'dfs', N'sdf', N'sfd', N'sdf', N'sdf', N'sdf', N'sdf', N'4481ec86-1af5-4966-8947-3ba692f3e215_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (6, N'sd', N'sd', N'sd', N'sd', N'sd', N'sd', N'sd', N'e177a3e3-cf53-4cfc-bbf0-106382419e2d_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (7, N'sda', N'asd', N'asd', N'asd', N'asd', N'asd', N'asd', NULL)
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (8, N'dsf', N'sd', N'sd', N'sd', N'sd', N'sd', N'sd', N'584e8d10-44ce-452a-8225-808b1e56b0a0_c87a7744.jpg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (9, N'dfs', N'df', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'9b77d106-6c18-478b-a832-f7db684de031_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (10, N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'e44b561d-aee0-4d8c-8569-e466a6a22e6d_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (11, N'zx', N'zxc', N'zxc', N'zx', N'zx', N'zx', N'xcz', N'cd495c19-89eb-4709-97ff-b41490b428bb_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (12, N'sdf', N'sfd', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'37c3f8cd-3662-48e0-97d3-3ea0e4db3469_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (13, N'df', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'sdf', N'1090d92a-9e5e-4647-8dd8-21d86db5f3cb_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (14, N'dsf', N'sdf', N'sdf', N'sdf', N'dfs', N'sdf', N'sdf', N'31b82a22-ab40-4b1f-9770-f9c2bff3ef17_building-1.jpeg')
INSERT [dbo].[ApartmentBuildings] ([BuildingId], [BuildingShortName], [BuildingFullName], [BuildingDescription], [BuildingAddress], [BuildingManager], [BuildingPhone], [OtherBuildingDetails], [ImageName]) VALUES (15, N'dfs', N'dfs', N'sdf', N'sdf', N'dsf', N'sdf', N'sdf', N'9ef70f6d-31f5-4d9e-b4d1-8922799aec6b_building-1.jpeg')
SET IDENTITY_INSERT [dbo].[ApartmentBuildings] OFF
GO
SET IDENTITY_INSERT [dbo].[RefApartmentTypes] ON 

INSERT [dbo].[RefApartmentTypes] ([AptTypeCode], [AptTypeDescription]) VALUES (1, N'Studios')
INSERT [dbo].[RefApartmentTypes] ([AptTypeCode], [AptTypeDescription]) VALUES (2, N'Studio')
SET IDENTITY_INSERT [dbo].[RefApartmentTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Apartments] ON 

INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (2, N'asfd', 2, 1, 1, 1, 1, CAST(10000.00 AS Decimal(16, 2)), CAST(10000.00 AS Decimal(16, 2)), N'ads')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (7, N'ds', 2, 1, 0, 0, 0, CAST(0.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), NULL)
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (8, N'dfs', 2, 1, 231, 2234, 34, CAST(42.00 AS Decimal(16, 2)), CAST(342.00 AS Decimal(16, 2)), N'sfdsd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (9, N'dfs', 2, 1, 23, 32, 234, CAST(32.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'sdfa')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (10, N'dfs', 2, 1, 23, 32, 234, CAST(32.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'sdfa')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (11, N'dsf', 2, 1, 345, 35, 35, CAST(34.00 AS Decimal(16, 2)), CAST(34.00 AS Decimal(16, 2)), N'dfgdg')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (12, N'efds', 2, 1, 23, 32, 23, CAST(32.00 AS Decimal(16, 2)), CAST(23.00 AS Decimal(16, 2)), N'gfgfd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (13, N'12', 2, 1, 12, 12, 12, CAST(12.00 AS Decimal(16, 2)), CAST(12.00 AS Decimal(16, 2)), N'sdfa')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (14, N'sdf', 2, 1, 213, 312, 123, CAST(123.00 AS Decimal(16, 2)), CAST(213.00 AS Decimal(16, 2)), N'213')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (15, N'sdf', 2, 1, 213, 312, 123, CAST(123.00 AS Decimal(16, 2)), CAST(213.00 AS Decimal(16, 2)), N'213')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (16, N'sdf', 2, 1, 234, 342, 243, CAST(3234.00 AS Decimal(16, 2)), CAST(234.00 AS Decimal(16, 2)), N'sdfa')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (17, N'dsf', 2, 1, 123, 123, 123, CAST(123.00 AS Decimal(16, 2)), CAST(12312.00 AS Decimal(16, 2)), N'sdf')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (18, N'df', 2, 1, 3, 342, 32, CAST(342.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'fda')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (19, N'df', 2, 1, 3, 342, 32, CAST(342.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'fda')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (20, N'df', 2, 1, 3, 342, 32, CAST(342.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'fda')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (21, N'df', 2, 1, 3, 342, 32, CAST(342.00 AS Decimal(16, 2)), CAST(324.00 AS Decimal(16, 2)), N'fda')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (22, N'dsf', 2, 1, 32, 342, 23, CAST(342.00 AS Decimal(16, 2)), CAST(24.00 AS Decimal(16, 2)), N'dfs')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (23, N'fds', 2, 1, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(32.00 AS Decimal(16, 2)), N'sdffd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (24, N'fds', 2, 1, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(32.00 AS Decimal(16, 2)), N'sdffd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (25, N'fds', 2, 1, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(32.00 AS Decimal(16, 2)), N'sdffd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (26, N'sdf', 2, 1, 34, 43, 34, CAST(234.00 AS Decimal(16, 2)), CAST(43.00 AS Decimal(16, 2)), N'fdgfd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (27, N'dfs', 2, 1, 34, 3423, 34, CAST(34.00 AS Decimal(16, 2)), CAST(43.00 AS Decimal(16, 2)), N'dfs')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (28, N'sfds', 2, 1, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(32.00 AS Decimal(16, 2)), N'sdf')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (29, N'df', 2, 1, 32, 32, 342, CAST(342.00 AS Decimal(16, 2)), CAST(34.00 AS Decimal(16, 2)), N'sdf')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (30, N'sdf', 2, 1, 34, 34, 34, CAST(34.00 AS Decimal(16, 2)), CAST(34.00 AS Decimal(16, 2)), N'sd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (31, N'xcv', 2, 1, 543, 34, 334, CAST(43.00 AS Decimal(16, 2)), CAST(34.00 AS Decimal(16, 2)), N'fdg sdf dsf')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (32, N'dfs', 5, 2, 23, 23, 32, CAST(32.00 AS Decimal(16, 2)), CAST(32.00 AS Decimal(16, 2)), N'32')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (36, N'sdf', 4, 2, 32, 32, 23, CAST(23.00 AS Decimal(16, 2)), CAST(23.00 AS Decimal(16, 2)), N'asd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (38, N'23', 4, 1, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(23.00 AS Decimal(16, 2)), N'sd')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (39, N'sd', 2, 2, 23, 23, 23, CAST(23.00 AS Decimal(16, 2)), CAST(23.00 AS Decimal(16, 2)), N'zxc')
INSERT [dbo].[Apartments] ([AptId], [ApartmentName], [BuildingId], [AptTypeCode], [BathroomCount], [BedroomCount], [RoomCount], [MonthlyRent], [SecurityDepositAmount], [OtherApartmentDetails]) VALUES (40, N'ew', 4, 1, 34, 34, 34, CAST(34.00 AS Decimal(16, 2)), CAST(34.00 AS Decimal(16, 2)), N'asfzf')
SET IDENTITY_INSERT [dbo].[Apartments] OFF
GO
SET IDENTITY_INSERT [dbo].[RefBookingStatuses] ON 

INSERT [dbo].[RefBookingStatuses] ([BookingStatusCode], [BookingStatusDescription]) VALUES (1, N'Confirmed')
INSERT [dbo].[RefBookingStatuses] ([BookingStatusCode], [BookingStatusDescription]) VALUES (2, N'Provisional')
SET IDENTITY_INSERT [dbo].[RefBookingStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Tenantes] ON 

INSERT [dbo].[Tenantes] ([TenantId], [TenantFirstName], [TenantLastName], [Phone], [Email], [DateOfBirth], [GenderCode], [OtherTenantDetails], [ImageName], [ImageFullPath]) VALUES (1, N'Sohan', N'Hasan', N'01751050039', N's.pairet21@gmail.com', CAST(N'2021-12-02T00:00:00.0000000' AS DateTime2), N'1', N'sdf', N'396b4fa1-240a-40c6-8f1e-27bd8bf16670_building-1.jpeg', N'F:\SOHAN\EidUlAzaha\Final-Project\AngularJs\HouseRentalManagementSystem5\HouseRentalManagementSystem\HouseRentalManagementSystem\wwwroot\images/tenant_images/396b4fa1-240a-40c6-8f1e-27bd8bf16670_building-1.jpeg')
SET IDENTITY_INSERT [dbo].[Tenantes] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [JsonData], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6c137836-50f2-4ff9-81bb-8753325cc087', N'[{''controller'':''Home'',''action'':''index'',''text'':''Dashboard'',''class'':''fa fa-th'',''child'':[]}', N'Admin', N'ADMIN', N'367c9410-6d00-42e2-be15-2056a076c35b')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [ImageName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4e0e622e-9fd1-4340-8370-36436a1dc4d7', N'ADMIN', N'ADMIN', N'ADMIN', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEIk/Q0+DFZMR+J0muLIl/NWwVVRO2BusPuX2dGMIwt6BdglYSB6GPjGGOFSd5SKLiA==', N'NGOF4YNPBWSRG2Q43UBMMRIDQ4XZG543', N'442e6f40-9ffb-4d0e-8762-dc3feea2af0f', N'+8801677672824', 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4e0e622e-9fd1-4340-8370-36436a1dc4d7', N'6c137836-50f2-4ff9-81bb-8753325cc087')
GO
SET IDENTITY_INSERT [dbo].[RefApartmentFacilities] ON 

INSERT [dbo].[RefApartmentFacilities] ([FacilityCode], [FacilityDescription]) VALUES (1, N'24 Hour Water Avliable')
INSERT [dbo].[RefApartmentFacilities] ([FacilityCode], [FacilityDescription]) VALUES (2, N'Provisional')
INSERT [dbo].[RefApartmentFacilities] ([FacilityCode], [FacilityDescription]) VALUES (3, N'24 Hour Gash')
SET IDENTITY_INSERT [dbo].[RefApartmentFacilities] OFF
GO
SET IDENTITY_INSERT [dbo].[RefPaymentTypes] ON 

INSERT [dbo].[RefPaymentTypes] ([PaymentTypeId], [PaymentTypeDetails]) VALUES (1, N'Bkash')
SET IDENTITY_INSERT [dbo].[RefPaymentTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[ApartmentImages] ON 

INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (1, N'4cc4792f-04af-44f2-a6c9-f22dfad27f98_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 28)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (2, N'ff19ea4d-32d3-4907-b617-da54145161b7_building-1.jpeg', 28)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (3, N'f240f277-c1d5-4a9d-9c62-4a064190905f_c87a7744.jpg', 28)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (4, N'fc154a3c-c753-43a8-bf5f-ce5385f800ea_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (5, N'228fc450-64b2-46dc-b9a4-449f64358656_building-1.jpeg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (6, N'3dde4c70-4d7b-4bb4-9fe4-d2ddf1f6c896_c87a7744.jpg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (7, N'bfd149c3-e733-4dd8-83d8-21701e0c5af9_building-1.jpeg', 30)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (8, N'4165cd36-8276-46be-a045-2eede7d03460_c87a7744.jpg', 30)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (9, N'6246c01d-fcc0-42ba-a349-740335dbd0bb_550d19_2a7881ee1a6741c39fd34fa4e285a2d8_mv2.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (10, N'26a87fb5-d1ff-4b6d-88f1-4edf481f2cfb_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (11, N'c7db2fec-73d0-4bb9-9322-adca162f3941_building-1.jpeg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (12, N'4468e19b-2df5-4e1a-85a3-9ef206ff6e2c_c87a7744.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (13, N'a983b384-6415-49b4-b43f-d7ea532f6614_images.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (14, N'937edb28-aec9-4148-bdf4-6f042e56dced_building-1.jpeg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (15, N'eb0db7fc-91fc-4807-943c-cddb533bcada_c87a7744.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (16, N'0be9df72-e97e-4850-b7df-8debc4ccc9b2_550d19_2a7881ee1a6741c39fd34fa4e285a2d8_mv2.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (17, N'7da3bd79-72c4-49f5-9c32-a53422a82d48_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (18, N'f6faf991-75f8-4442-bab8-fe7bccd0be46_building-1.jpeg', 31)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (27, N'83b1b64d-4b5d-4ce7-9b2d-1bac9fafbd55_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (28, N'96e7aa6c-4586-41a3-9b3d-c5713236ecad_building-1.jpeg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (29, N'd8f13223-12cf-44c7-ab4d-da4cfcf870af_c87a7744.jpg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (30, N'f13dad11-a924-4c50-bdf8-5cfbb7d007eb_building-1.jpeg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (31, N'd4a54a5d-a6c8-4010-80e9-973e01d02aed_c87a7744.jpg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (32, N'24c3a7d1-4865-43b2-b8d2-a685c0e1ea2e_building-1.jpeg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (33, N'c4afa152-ada9-4d57-aefe-d7b0a05eb37e_c87a7744.jpg', 32)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (66, N'f0ea5905-5d9b-4b52-bdb0-bf5060ff1e58_building-1.jpeg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (67, N'961e7aaf-dc1b-463e-9cfe-717d639b852c_c87a7744.jpg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (68, N'c70f63f8-8ac2-4403-82bb-ee9bdc61befb_building-1.jpeg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (69, N'0974dcb8-3258-4bd1-a599-2e104ddaec3a_c87a7744.jpg', 29)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (70, N'87d6d531-4926-410b-a4b0-d6502ec54b4b_building-1.jpeg', 28)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (71, N'c2717085-3ef5-437a-a247-49477e433dc1_c87a7744.jpg', 28)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (85, N'c88eb9e5-3a76-44fb-a076-28edeb745297_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 36)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (86, N'ead078d0-bce0-47b9-a4af-2b0d9c7b4172_building-1.jpeg', 36)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (87, N'8f3dc5f9-44e7-4e1d-95ff-2f7c404373cf_c87a7744.jpg', 36)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (91, N'4220d3f0-3e77-4b44-b015-ad8b6227e142_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 38)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (92, N'e4f56a42-1615-4719-b233-262b79f30398_building-1.jpeg', 38)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (93, N'3575a56c-5cc6-4432-8d3f-562b1d7c0045_c87a7744.jpg', 38)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (94, N'c20e4406-8a48-4f29-80f2-f6b904897a82_building-1.jpeg', 39)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (95, N'7c9c90dd-bc95-4ee5-a78f-33dbd9b43c85_c87a7744.jpg', 39)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (96, N'2a4cdb30-ef06-4f04-b0f4-264f3c5909aa_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 40)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (97, N'0e24b330-5e4e-4cc5-ac5f-4d9764efc21d_building-1.jpeg', 40)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (98, N'3344b105-a69c-4f2f-afee-d3672d2856c0_c87a7744.jpg', 40)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (99, N'fd5ccfba-651b-40b0-b234-bc193a6918cf_AKH-ECO-Apparels-at-Dhamrai-Bangladesh_Q320.jpg', 40)
INSERT [dbo].[ApartmentImages] ([ImageId], [ImageName], [AptId]) VALUES (100, N'5f551346-b285-4ed3-aa3c-a22fca2dc053_building-1.jpeg', 40)
SET IDENTITY_INSERT [dbo].[ApartmentImages] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211121030104_init', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211126164619_new', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211126164812_add', N'5.0.11')
GO
