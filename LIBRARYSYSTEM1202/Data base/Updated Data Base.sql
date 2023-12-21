/*
Navicat SQL Server Data Transfer

Source Server         : DATASERVER
Source Server Version : 120000
Source Host           : PC34\DATASERVER:1433
Source Database       : LIBRARY1202
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2019-02-18 19:15:29
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
INSERT INTO [dbo].[TBL_ACCOUNT] ([USERNAME], [PASSWORD]) VALUES (N'e', N'MQ==')
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
INSERT INTO [dbo].[TBL_BCODE] ([pcode], [prefix]) VALUES (N'0000009', N'TRANS')
GO
GO

-- ----------------------------
-- Table structure for TBL_BOOKS
-- ----------------------------
DROP TABLE [dbo].[TBL_BOOKS]
GO
CREATE TABLE [dbo].[TBL_BOOKS] (
[BOOKID] varchar(100) NULL ,
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
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001', N'math', N'njknfnf', N'njfknfgsn', N'ngjsng', N'gnsjgn')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20190001222', N'0000', N'212121', N'121212121', N'1999', N'THIS')
GO
GO
INSERT INTO [dbo].[TBL_BOOKS] ([BOOKID], [CATEGO], [TITLE], [AUTHOR], [YEARPUB], [DESCRIPTION]) VALUES (N'20199555', N'mATH', N'me', N'ME', N'1999', N'THIS')
GO
GO

-- ----------------------------
-- Table structure for TBL_BORROW
-- ----------------------------
DROP TABLE [dbo].[TBL_BORROW]
GO
CREATE TABLE [dbo].[TBL_BORROW] (
[TRANS] varchar(12) NULL ,
[LRN] varchar(12) NULL ,
[STUDENTNAME] varchar(50) NULL ,
[TRACKSTRAND] varchar(50) NULL ,
[SECTION] varchar(12) NULL ,
[BOOKID] varchar(50) NULL ,
[BOOKTITLE] varchar(50) NULL ,
[CATEGORY] varchar(50) NULL ,
[STATUS] varchar(20) NULL ,
[BORROWDATE] datetime2(7) NULL ,
[RETURNDATE] datetime2(7) NULL 
)


GO

-- ----------------------------
-- Records of TBL_BORROW
-- ----------------------------

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
[LRN] varchar(12) NULL ,
[NAME] varchar(50) NULL ,
[ADDRESS] varchar(100) NULL ,
[CONTACTN] varchar(11) NULL ,
[TRACKSTRAND] varchar(20) NULL ,
[SECTION] varchar(10) NULL ,
[PARENTNAME] varchar(50) NULL ,
[PARENTCONTACT] varchar(11) NULL 
)


GO

-- ----------------------------
-- Records of TBL_STUDENT
-- ----------------------------

-- ----------------------------
-- Indexes structure for table TBL_ACCOUNT
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_ACCOUNT
-- ----------------------------
ALTER TABLE [dbo].[TBL_ACCOUNT] ADD PRIMARY KEY ([PASSWORD], [USERNAME])
GO

-- ----------------------------
-- Indexes structure for table TBL_RETURN
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_RETURN
-- ----------------------------
ALTER TABLE [dbo].[TBL_RETURN] ADD PRIMARY KEY ([LRN])
GO
