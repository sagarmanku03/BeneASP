SET IDENTITY_INSERT [dbo].[Plan] ON
INSERT INTO [dbo].[Plan] ([PlanCode], [PlanDescription], [EndDate]) VALUES (1, N'Bridge work should be finished before  next year', N'2022-12-31 00:00:00')
INSERT INTO [dbo].[Plan] ([PlanCode], [PlanDescription], [EndDate]) VALUES (2, N'Construction contract will finish after six months', N'2021-07-06 00:00:00')
SET IDENTITY_INSERT [dbo].[Plan] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON
INSERT INTO [dbo].[Staff] ([StaffCode], [Name], [Birth]) VALUES (1, N'george', N'1991-11-27 00:00:00')
INSERT INTO [dbo].[Staff] ([StaffCode], [Name], [Birth]) VALUES (2, N'jhon abbot', N'1999-12-28 00:00:00')
INSERT INTO [dbo].[Staff] ([StaffCode], [Name], [Birth]) VALUES (3, N'sion abel', N'1994-06-15 00:00:00')
INSERT INTO [dbo].[Staff] ([StaffCode], [Name], [Birth]) VALUES (4, N'nanak singh', N'1990-11-15 00:00:00')
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[Job] ON
INSERT INTO [dbo].[Job] ([JobCode], [Description], [isAvailable], [StaffCode]) VALUES (1, N'Need for Ceo in Nyriad', 1, 2)
INSERT INTO [dbo].[Job] ([JobCode], [Description], [isAvailable], [StaffCode]) VALUES (2, N'Need for contractor for Construction', 1, 1)
SET IDENTITY_INSERT [dbo].[Job] OFF
SET IDENTITY_INSERT [dbo].[Benefit] ON
INSERT INTO [dbo].[Benefit] ([Id], [PlanCode], [StaffCode]) VALUES (1, 1, 2)
INSERT INTO [dbo].[Benefit] ([Id], [PlanCode], [StaffCode]) VALUES (2, 2, 3)
INSERT INTO [dbo].[Benefit] ([Id], [PlanCode], [StaffCode]) VALUES (3, 1, 3)
SET IDENTITY_INSERT [dbo].[Benefit] OFF
