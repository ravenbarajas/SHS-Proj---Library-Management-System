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

Date: 2019-02-11 19:23:13
*/


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
-- Indexes structure for table TBL_RETURN
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TBL_RETURN
-- ----------------------------
ALTER TABLE [dbo].[TBL_RETURN] ADD PRIMARY KEY ([LRN])
GO
