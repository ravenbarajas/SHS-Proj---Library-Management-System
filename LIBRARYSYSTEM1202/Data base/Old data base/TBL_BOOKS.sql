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

Date: 2019-02-11 19:23:02
*/


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

-- ----------------------------
-- Indexes structure for table TBL_BOOKS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_BOOKS
-- ----------------------------
ALTER TABLE [dbo].[TBL_BOOKS] ADD PRIMARY KEY ([BOOKID])
GO
