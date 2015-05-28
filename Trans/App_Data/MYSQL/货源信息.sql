
------------------------------------------------------------------------------------
-----------------------------��Դ��Ϣ-----------------------------------------------
------------------------------------------------------------------------------------

use trans
GO

--
-- Goods type
--

--�豸
--ú̿
--���
--�ֲ�
--����
--����
--ľ��
--��ʳ
--ʳƷ
--����
--�߲�
--����
--������Ʒ
--���Ʒ

--
-- ��������
--
--����
--������˾
--�������
--�㵣���

--
-- ע������
--
--����
--����
--����
--Σ��Ʒ


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
	[srccountycode] [varchar](6) NOT NULL, -- ������
	[dstcountycode] [varchar](6) NOT NULL, -- Ŀ�ĵ�
	[deadline] datetime NULL, -- Ĭ��ʮ��
	
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