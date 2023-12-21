/*
Navicat SQL Server Data Transfer

Source Server         : DATASERVER
Source Server Version : 120000
Source Host           : PC34\DATASERVER:1433
Source Database       : LIBRARY_1202
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2019-02-14 22:47:26
*/


-- ----------------------------
-- Table structure for TBL_ACCOUNT
-- ----------------------------
DROP TABLE [dbo].[TBL_ACCOUNT]
GO
CREATE TABLE [dbo].[TBL_ACCOUNT] (
[USERNAME] varchar(250) NOT NULL ,
[PASSWORD] varchar(250) NOT NULL 
)


GO

-- ----------------------------
-- Records of TBL_ACCOUNT
-- ----------------------------
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'rhyanbano07', N'cmh5YW4=')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'rhyandilla', N'cmh5YW4=')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'r', N'MQ==')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N' rhyan2', N'MTI=')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'rhyan', N'MTIz')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'rhyan123', N'MTIz')
GO
GO
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'rhyan3', N'MTIz')
GO
GO

-- ----------------------------
-- Table structure for TBL_BCODE
-- ----------------------------
DROP TABLE [dbo].[TBL_BCODE]
GO
CREATE TABLE [dbo].[TBL_BCODE] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BCODE
-- ----------------------------
INSERT INTO [dbo].[TBL_BCODE] ([pcode], [prefix]) VALUES (N'0000009', N'BTRANS')
GO
GO

-- ----------------------------
-- Table structure for TBL_BOOKS
-- ----------------------------
DROP TABLE [dbo].[TBL_BOOKS]
GO
CREATE TABLE [dbo].[TBL_BOOKS] (
[BOOKID] varchar(100) NOT NULL ,
[CATEGO] varchar(50) NULL ,
[TITLE] varchar(50) NULL ,
[AUTHOR] varchar(50) NULL ,
[YEARPUB] varchar(20) NULL ,
[DESCRIPTION] varchar(300) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BOOKS
-- ----------------------------
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'123', N'wfdsafsdf', N'qwewqe', N'dasd', N'asdffdsaf', N'123123asdasdsadasd')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'123445', N'science', N'hyup', N'ako a', N'1999', N'dsadasdqweqwewqedfdf')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190004', N'Reference', N'Book', N'Rhyan', N'2015', N'This is a book hehe')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'2019002', N'Reference', N'Ewan ko ba', N'Rhyan', N'1969', N'This is a book')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'2019003', N'Math', N'Math is fun', N'Rhyan', N'2015', N'This is a math book')
GO
GO

-- ----------------------------
-- Table structure for TBL_BORROW
-- ----------------------------
DROP TABLE [dbo].[TBL_BORROW]
GO
CREATE TABLE [dbo].[TBL_BORROW] (
[LRN] varchar(12) NOT NULL ,
[STUDENTNAME] varchar(50) NULL ,
[TRACKSTRAND] varchar(50) NULL ,
[SECTION] varchar(50) NOT NULL ,
[BOOKID] varchar(12) NULL ,
[BOOKTITLE] varchar(50) NULL ,
[CATEGORY] varchar(50) NULL ,
[STATUS] varchar(50) NULL ,
[BORROWDATE] datetime2(7) NULL ,
[RETURNDATE] datetime2(7) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BORROW
-- ----------------------------
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'', N'', N'', N'', N'', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-14 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'111111', N'', N'', N'', N'2221212', N'', N'', N'Available', N'2019-02-11 00:00:00.0000000', N'2019-02-20 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'13659989898', N'', N'', N'', N'20195656565', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-22 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136656565', N'', N'', N'', N'15151515151', N'', N'', N'Available', N'2019-02-11 00:00:00.0000000', N'2019-02-16 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136900012121', N'', N'', N'', N'201921154184', N'', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-14 00:00:00.0000000')
GO
GO
INSERT INTO [dbo].[TBL_BORROW] ([LRN], [STUDENTNAME], [TRACKSTRAND], [SECTION], [BOOKID], [BOOKTITLE], [CATEGORY], [STATUS], [BORROWDATE], [RETURNDATE]) VALUES (N'136900060020', N'', N'', N'', N'', N'201912', N'', N'', N'2019-02-11 00:00:00.0000000', N'2019-02-22 00:00:00.0000000')
GO
GO

-- ----------------------------
-- Table structure for Tbl_Code
-- ----------------------------
DROP TABLE [dbo].[Tbl_Code]
GO
CREATE TABLE [dbo].[Tbl_Code] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_Code
-- ----------------------------
INSERT INTO [dbo].[Tbl_Code] ([pcode], [prefix]) VALUES (N'0000009', N'PTNO')
GO
GO

-- ----------------------------
-- Table structure for Tbl_DCode
-- ----------------------------
DROP TABLE [dbo].[Tbl_DCode]
GO
CREATE TABLE [dbo].[Tbl_DCode] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_DCode
-- ----------------------------
INSERT INTO [dbo].[Tbl_DCode] ([pcode], [prefix]) VALUES (N'0000006', N'DTNO')
GO
GO

-- ----------------------------
-- Table structure for Tbl_Doctors
-- ----------------------------
DROP TABLE [dbo].[Tbl_Doctors]
GO
CREATE TABLE [dbo].[Tbl_Doctors] (
[Dcode] varchar(255) NOT NULL ,
[DName] varchar(255) NULL ,
[DAddress] varchar(255) NULL ,
[DContactnumber] varchar(255) NULL ,
[DSpecialization] varchar(255) NULL ,
[DConsultationfee] varchar(255) NULL ,
[DStatus] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_Doctors
-- ----------------------------
INSERT INTO [dbo].[Tbl_Doctors] ([Dcode], [DName], [DAddress], [DContactnumber], [DSpecialization], [DConsultationfee], [DStatus]) VALUES (N'DTNO00005', N'Yasmainaaaaaa', N'Imus Caviteaaaaaa', N'03751106660aaaaaaa', N'ENT', N'500', N'Active')
GO
GO
INSERT INTO [dbo].[Tbl_Doctors] ([Dcode], [DName], [DAddress], [DContactnumber], [DSpecialization], [DConsultationfee], [DStatus]) VALUES (N'DTNO00006', N'Pika222', N'Cavite311', N'11166321', N'ENT', N'200', N'Active')
GO
GO

-- ----------------------------
-- Table structure for tbl_Patients
-- ----------------------------
DROP TABLE [dbo].[tbl_Patients]
GO
CREATE TABLE [dbo].[tbl_Patients] (
[pcode] varchar(255) NULL ,
[pname] varchar(255) NULL ,
[paddress] varchar(255) NULL ,
[pbday] varchar(255) NULL ,
[pdatereg] varchar(200) NULL ,
[pgender] varchar(25) NULL ,
[page] varchar(10) NULL 
)


GO

-- ----------------------------
-- Records of tbl_Patients
-- ----------------------------
INSERT INTO [dbo].[tbl_Patients] ([pcode], [pname], [paddress], [pbday], [pdatereg], [pgender], [page]) VALUES (N'PTNO00004', N'clech ww wewaaaaaaaaaa', N'cavite', N'30/09/2018 12:00:00 AM', N'18/10/2018', N'Male', N'201')
GO
GO
INSERT INTO [dbo].[tbl_Patients] ([pcode], [pname], [paddress], [pbday], [pdatereg], [pgender], [page]) VALUES (N'PTNO00008', N'poiqwejpqwje', N'lfmcklmlkxvm', N'18/10/2018 4:23:13 PM', N'18/10/2018', N'Male', N'32')
GO
GO
INSERT INTO [dbo].[tbl_Patients] ([pcode], [pname], [paddress], [pbday], [pdatereg], [pgender], [page]) VALUES (N'PTNO00009', N'Vermillon', N'Cavite', N'18/10/2018 4:23:13 PM', N'18/10/2018', N'Male', N'18')
GO
GO

-- ----------------------------
-- Table structure for Tbl_Pcode
-- ----------------------------
DROP TABLE [dbo].[Tbl_Pcode]
GO
CREATE TABLE [dbo].[Tbl_Pcode] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_Pcode
-- ----------------------------
INSERT INTO [dbo].[Tbl_Pcode] ([pcode], [prefix]) VALUES (N'0000007', N'PONO')
GO
GO

-- ----------------------------
-- Table structure for Tbl_Pharmacy
-- ----------------------------
DROP TABLE [dbo].[Tbl_Pharmacy]
GO
CREATE TABLE [dbo].[Tbl_Pharmacy] (
[Itemcode] varchar(255) NULL ,
[Brandname] varchar(255) NULL ,
[Genericname] varchar(255) NULL ,
[Price] int NULL ,
[QuantityAvailable] varchar(255) NULL ,
[Status] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_Pharmacy
-- ----------------------------
INSERT INTO [dbo].[Tbl_Pharmacy] ([Itemcode], [Brandname], [Genericname], [Price], [QuantityAvailable], [Status]) VALUES (N'PONO00006', N'biogesik', N'antibiotic', N'26', N'2000', N'Active')
GO
GO
INSERT INTO [dbo].[Tbl_Pharmacy] ([Itemcode], [Brandname], [Genericname], [Price], [QuantityAvailable], [Status]) VALUES (N'PONO00007', N'Diatabs', N'atapulguy', N'100', N'200', N'Active')
GO
GO

-- ----------------------------
-- Table structure for TBL_RCODE
-- ----------------------------
DROP TABLE [dbo].[TBL_RCODE]
GO
CREATE TABLE [dbo].[TBL_RCODE] (
[pcode] varchar(20) NULL ,
[prefix] varchar(20) NULL 
)


GO

-- ----------------------------
-- Records of TBL_RCODE
-- ----------------------------
INSERT INTO [dbo].[TBL_RCODE] ([pcode], [prefix]) VALUES (N'0000009', N'RTRANS')
GO
GO

-- ----------------------------
-- Table structure for TBL_RETURN
-- ----------------------------
DROP TABLE [dbo].[TBL_RETURN]
GO
CREATE TABLE [dbo].[TBL_RETURN] (
[LRN] varchar(12) NOT NULL ,
[NAME] varchar(50) NULL ,
[BOOKID] varchar(50) NULL ,
[BOOKTITLE] varchar(50) NULL ,
[BORROWDATE] datetime2(7) NULL ,
[RETURNDATE] datetime2(7) NULL ,
[STATUS] varchar(50) NULL 
)


GO

-- ----------------------------
-- Records of TBL_RETURN
-- ----------------------------

-- ----------------------------
-- Table structure for TBL_STUDENT
-- ----------------------------
DROP TABLE [dbo].[TBL_STUDENT]
GO
CREATE TABLE [dbo].[TBL_STUDENT] (
[LRN] varchar(12) NOT NULL ,
[NAME] varchar(50) NULL ,
[ADDRESS] varchar(100) NULL ,
[CONTACTN] varchar(11) NULL ,
[DEPT] varchar(30) NULL ,
[TRACKSTRAND] varchar(20) NULL ,
[SECTION] varchar(10) NULL ,
[PARENTNAME] varchar(51) NULL ,
[PARENTCONTACT] varchar(11) NULL 
)


GO

-- ----------------------------
-- Records of TBL_STUDENT
-- ----------------------------
INSERT INTO [dbo].[TBL_STUDENT] ([LRN], [NAME], [ADDRESS], [CONTACTN], [DEPT], [TRACKSTRAND], [SECTION], [PARENTNAME], [PARENTCONTACT]) VALUES (N'132465555', N'rAVEN', N'mUNTI', N'12346', N'SDSD', N'SDSD', N'DSD', N'SDSDS', N'SDS')
GO
GO

-- ----------------------------
-- Table structure for Tbl_Users
-- ----------------------------
DROP TABLE [dbo].[Tbl_Users]
GO
CREATE TABLE [dbo].[Tbl_Users] (
[UserN] varchar(255) NULL ,
[PassW] varchar(255) NULL 
)


GO

-- ----------------------------
-- Records of Tbl_Users
-- ----------------------------
INSERT INTO [dbo].[Tbl_Users] ([UserN], [PassW]) VALUES (N'admin', N'cG9naQ==')
GO
GO
INSERT INTO [dbo].[Tbl_Users] ([UserN], [PassW]) VALUES (N'admin', N'MTIz')
GO
GO

-- ----------------------------
-- Indexes structure for table TBL_ACCOUNT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_ACCOUNT
-- ----------------------------
ALTER TABLE [dbo].[TBL_ACCOUNT] ADD PRIMARY KEY ([PASSWORD], [USERNAME])
GO

-- ----------------------------
-- Indexes structure for table TBL_BOOKS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_BOOKS
-- ----------------------------
ALTER TABLE [dbo].[TBL_BOOKS] ADD PRIMARY KEY ([BOOKID])
GO

-- ----------------------------
-- Indexes structure for table TBL_BORROW
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_BORROW
-- ----------------------------
ALTER TABLE [dbo].[TBL_BORROW] ADD PRIMARY KEY ([LRN], [SECTION])
GO

-- ----------------------------
-- Indexes structure for table Tbl_Doctors
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Tbl_Doctors
-- ----------------------------
ALTER TABLE [dbo].[Tbl_Doctors] ADD PRIMARY KEY ([Dcode])
GO

-- ----------------------------
-- Indexes structure for table TBL_RETURN
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_RETURN
-- ----------------------------
ALTER TABLE [dbo].[TBL_RETURN] ADD PRIMARY KEY ([LRN])
GO

-- ----------------------------
-- Indexes structure for table TBL_STUDENT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_STUDENT
-- ----------------------------
ALTER TABLE [dbo].[TBL_STUDENT] ADD PRIMARY KEY ([LRN])
GO
