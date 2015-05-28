
------------------------------------------------------------------------------------
-----------------------------货源信息-----------------------------------------------
------------------------------------------------------------------------------------

use trans
GO

--
-- Goods type
--

--设备
--煤炭
--矿产
--钢材
--饲料
--建材
--木材
--粮食
--食品
--饮料
--蔬菜
--电器
--化工产品
--畜产品

--
-- 运输类型
--
--不限
--物流公司
--整车配货
--零担配货

--
-- 注意事项
--
--向上
--防潮
--易碎
--危险品


--
-- Goods source information table
-- http://www.chinawutong.com/fabu_huoyuan.html
--
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[goodssourceinformation]')
	AND type IN (N'U'))
BEGIN
	DROP TABLE [dbo].[goodssourceinformation]
END
GO
CREATE TABLE [dbo].[goodssourceinformation](
	[id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[userid] [bigint] NOT NULL,
	[srccountycode] [varchar](6) NOT NULL, -- 出发地
	[dstcountycode] [varchar](6) NOT NULL, -- 目的地
	[deadline] datetime NULL, -- 默认十天
	
	[title] [varchar] (500) NOT NULL,
	[titlecolor] [varchar] (10),
	[goodsname] [varchar] (50) NOT NULL,
	[goodstype] [varchar] (50) NOT NULL,
	[goodsproperty] [varchar] (50) NOT NULL,
	[price] [money] NOT NULL,
	[content] [text],
	[active] [tinyint] DEFAULT(1) NOT NULL
)
GO
ALTER TABLE [dbo].[goodssourceinformation] WITH NOCHECK ADD CONSTRAINT FK_goodssrcinfo_user
FOREIGN KEY ([userid]) REFERENCES [dbo].[users](id);
GO
CREATE INDEX IX_goodssrcinfo_userid ON [dbo].[goodssourceinformation] ([userid]);
CREATE INDEX IX_goodssrcinfo_title ON [dbo].[goodssourceinformation]([title]);
CREATE INDEX IX_goodssrcinfo_goodsname ON [dbo].[goodssourceinformation]([goodsname]);
CREATE INDEX IX_goodssrcinfo_goodstype ON [dbo].[goodssourceinformation]([goodstype]);
GO