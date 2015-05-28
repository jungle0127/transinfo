USE TransInfo;

-- -------------------------------------------------------------------------------------
-- ------------------------------------trunk metadata information-----------------------
-- -------------------------------------------------------------------------------------

DROP TABLE IF EXISTS `trunknumberprefix`;

CREATE TABLE `trunknumberprefix`(
	`id` bigint(20) auto_increment,
	`prefixname` varchar(2) NOT NULL,
	PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('ԥ');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('³');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');
INSERT INTO trunknumberprefix (prefixname) VALUES ('��');

--
-- trunknumber table
-- 
DROP TABLE IF EXISTS `trunknumber`;
CREATE TABLE `trunknumber`(
	`id` bigint(20) auto_increment,
	`prefixid` bigint NOT NULL,
	`number` varchar(20) NOT NULL,
	`userid` bigint NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(prefixid) REFERENCES trunknumberprefix(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_trunknumber_prefix ON trunknumber(prefixid);



--
-- create table vantype
--
DROP TABLE IF EXISTS `vantype`;
CREATE TABLE `vantype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO vantype (typename ) VALUES ('����');
INSERT INTO vantype (typename ) VALUES ('��ж��');
INSERT INTO vantype (typename ) VALUES ('��س�');
INSERT INTO vantype (typename ) VALUES ('���³�');
INSERT INTO vantype (typename ) VALUES ('�͹޳�');
INSERT INTO vantype (typename ) VALUES ('���س�');
INSERT INTO vantype (typename ) VALUES ('���͹޳�');
INSERT INTO vantype (typename ) VALUES ('���׳�');
INSERT INTO vantype (typename ) VALUES ('�������ұ���');
INSERT INTO vantype (typename ) VALUES ('����ִ�۹޳�');

--
-- create table trunktype 
--
DROP TABLE IF EXISTS `trunktype`;
CREATE TABLE `trunktype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(20) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


INSERT INTO trunktype (typename ) VALUES ('��ʽ');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('����');
INSERT INTO trunktype (typename ) VALUES ('ƽ��');
INSERT INTO trunktype (typename ) VALUES ('���');
INSERT INTO trunktype (typename ) VALUES ('ȫ��');
INSERT INTO trunktype (typename ) VALUES ('�ӳ���');
INSERT INTO trunktype (typename ) VALUES ('�����');
INSERT INTO trunktype (typename ) VALUES ('ǰ�ĺ��');
INSERT INTO trunktype (typename ) VALUES ('����');    

--
-- create table trunkmetadata
--
DROP TABLE IF EXISTS `trunkmetadata`;
CREATE TABLE `trunkmetadata`(
	`id` bigint(20) auto_increment,
	`numberid` bigint NOT NULL, -- �����ƺţ�
	`length` varchar(10) NOT NULL, -- �������ף�
	`weightcapacity` varchar(10) NOT NULL, -- ���أ��֣�
	`volume` varchar(10) NULL, -- �ݻ�
	`countycode` varchar(6) NOT NULL, -- ����פ��
	`location` varchar(200) NULL, -- ������ͣ��λ�ã��磺XX����԰����	
	`vantypeid` bigint NOT NULL, -- ��������
	`brand` varchar(45) NULL, -- Ʒ���ͺ�
	`trunktypeid` bigint NOT NULL, -- ��������
	`contactpersonname` varchar(45) NOT NULL, -- �泵��ϵ��
	`conatactphone` varchar(15) NOT NULL, -- �泵�绰
	`trunkidentifynumber` varchar(100) NULL, -- ����ʶ����ţ�����
	`vanimageuri` varchar(200) NOT NULL, -- ����ͼƬ
	`licenseuri` varchar(200) NOT NULL, -- �г�֤ͼƬ
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (numberid) REFERENCES trunknumber(id),
	FOREIGN KEY(vantypeid) REFERENCES vantype(id),
	FOREIGN KEY(trunktypeid) REFERENCES trunktype(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_trunkmetadata_number ON trunkmetadata(numberid);
CREATE INDEX IX_trunkmetadata_length ON trunkmetadata(length);
CREATE INDEX IX_trunkmetadata_weight ON trunkmetadata(weightcapacity);
CREATE INDEX IX_trunkmetadata_countycode ON trunkmetadata(countycode);
CREATE INDEX IX_trunkmetadata_vantype ON trunkmetadata(vantypeid);
CREATE INDEX IX_trunkmetadata_trunktype ON trunkmetadata(trunktypeid);
-- --------------------------------------------------------------------------------------------
-- ------------------------------VIEW----------------------------------------------------------
-- --------------------------------------------------------------------------------------------
--
-- vehicle number view
--
DROP VIEW IF EXISTS `V_vehicle_number`;
CREATE VIEW `V_vehicle_number`
AS
SELECT trunknumber.id,trunknumberprefix.prefixname,trunknumber.number FROM trunknumber
JOIN trunknumberprefix ON trunknumber.prefixid = trunknumberprefix.id
WHERE trunknumber.active = 1;
--
-- trunk metadata view
--
DROP VIEW IF EXISTS `V_trunkmetadata`;
CREATE VIEW `V_trunkmetadata`
AS
SELECT trunkmetadata.id,
trunknumberprefix.prefixname,
trunknumber.number,
trunkmetadata.length,
trunkmetadata.weightcapacity,
trunkmetadata.volume,
county.name, -- uncomplete
location,
vantype.typename as vantypename,
brand,
trunktype.typename as trunktypename,
contactpersonname,
conatactphone,
trunkidentifynumber,
vanimageuri,
licenseuri
FROM trunkmetadata
JOIN trunknumber ON trunknumber.id = trunkmetadata.numberid
JOIN trunknumberprefix ON trunknumberprefix.id = trunknumber.prefixid
JOIN vantype ON vantype.id = trunkmetadata.vantypeid
JOIN trunktype ON trunktype.id = trunkmetadata.trunktypeid
JOIN county ON county.code = trunkmetadata.countycode
WHERE trunkmetadata.active = 1;

-- --------------------------------------------------------------------------------------------
-- ------------------------------Trunk publish information---------------------------------------------
-- --------------------------------------------------------------------------------------------


--
-- Trunk information ��Դ��Ϣ
--
DROP TABLE IF EXISTS `trunkinformation`;
CREATE TABLE `trunkinformation`(
	`id` bigint(20) auto_increment,
	`trunkid` bigint NOT NULL, -- ��ػ���
	`routetype` tinyint NOT NULL, -- 0:  ���س���1:���̳�
	`srccountycode` varchar(6) NOT NULL, -- ������
	`dstcountycode` varchar(6) NOT NULL, -- Ŀ�ĵ�
	`router` varchar(200) , -- ;������
	`takeofftime` datetime  , -- ����ʱ��
	`marketprice` varchar(40) DEFAULT '����' NULL, -- �г��˼�
	`negotiateprice` varchar(40) NULL, -- Э���˼�
	`timetype` tinyint NOT NULL, -- 0: ��ʱ��Դ 1�� ���ڳ�Դ
	`description` varchar(2000) DEFAULT '���Դ', -- ��Ϣ˵��
	`returntype` tinyint NOT NULL, -- 0:���� 1�� ����
	`userid` bigint NOT NULL, -- ������Ϣ�û�
	`title` varchar (350) NOT NULL, -- ��Ϣ����	
	`releasedate` datetime DEFAULT NOW() NOT NULL, -- ����ʱ��
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(userid) REFERENCES users(id),
	FOREIGN KEY(trunkid) REFERENCES trunkmetadata(id),
	FOREIGN KEY(srccountycode) REFERENCES county(code),
	FOREIGN KEY(dstcountycode) REFERENCES county(code)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;


CREATE INDEX IX_trunkinfo_userid ON trunkinformation (userid);
CREATE INDEX IX_trunkinfo_title ON trunkinformation (title);
CREATE INDEX IX_trunkinfo_routetype ON trunkinformation (routetype);
CREATE INDEX IX_trunkinfo_src ON trunkinformation (srccountycode);
CREATE INDEX IX_trunkinfo_dst ON trunkinformation (dstcountycode);
CREATE INDEX IX_trunkinfo_timetype ON trunkinformation (timetype);
CREATE INDEX IX_trunkinfo_returntype ON trunkinformation (returntype);

GO

-- ----------------------------------------------------------------------------------
-- ---------------------------��Դ��Ϣ-----------------------------------------------
-- ----------------------------------------------------------------------------------
--
-- Goods type
--
DROP TABLE IF EXISTS `goodstype`;
CREATE TABLE `goodstype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO goodstype(typename) VALUES ('�豸');
INSERT INTO goodstype(typename) VALUES ('ú̿');
INSERT INTO goodstype(typename) VALUES ('���'),
('�ֲ�'),
('����'),
('����'),
('ľ��'),
('��ʳ'),
('ʳƷ'),
('����'),
('�߲�'),
('����'),
('������Ʒ'),
('���Ʒ');

--
-- ��������
--
DROP TABLE IF EXISTS `transporttype`;
CREATE TABLE `transporttype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

INSERT INTO transporttype(typename) VALUES('����'),
('������˾'),
('�������'),
('�㵣���');

--
-- ע������
--
DROP TABLE IF EXISTS `cautiontype`;
CREATE TABLE `cautiontype`(
	`id` bigint(20) auto_increment,
	`typename` varchar(8) NOT NULL,
	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;
INSERT INTO cautiontype (typename) VALUES('����'),('����'),('����'),('Σ��Ʒ'),('��');

--
-- ��Դ��Ϣ
--
DROP TABLE IF EXISTS `goodssourceinformation`;
CREATE TABLE `goodssourceinformation`(
	`id` bigint(20) auto_increment,
	`userid` bigint NOT NULL,
	`srccountycode` varchar(6) NOT NULL, -- ���˵�
	`dstcountycode` varchar(6) NOT NULL, -- Ŀ�ĵ�
	`deadline` datetime NULL, -- Ĭ��ʮ��
	`title` varchar(350) NOT NULL,
	`titlecolor` varchar(10),
	`goodsname` varchar(50) NOT NULL,
	`transporttypeid` bigint NOT NULL,
	`cautiontypeid` bigint NOT NULL,
	`goodstypeid` bigint NOT NULL,
	`price` varchar(40) NOT NULL, 
	`content` text,
	`releasedate` datetime DEFAULT NOW() NOT NULL,
	`active` tinyint DEFAULT 1 NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(srccountycode) REFERENCES county(code),
	FOREIGN KEY(dstcountycode) REFERENCES county(code),
	FOREIGN KEY(goodstypeid) REFERENCES goodstype(id),
	FOREIGN KEY(transporttypeid) REFERENCES transporttype(id),
	FOREIGN KEY(cautiontypeid) REFERENCES cautiontype(id)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

CREATE INDEX IX_goodssrcinfo_userid ON goodssourceinformation (userid);
CREATE INDEX IX_goodssrcinfo_title ON goodssourceinformation(title);
CREATE INDEX IX_goodssrcinfo_goodsname ON goodssourceinformation(goodsname);
CREATE INDEX IX_goodssrcinfo_goodstype ON goodssourceinformation(goodstypeid);
CREATE INDEX IX_goodssrcinfo_cautiontype ON goodssourceinformation(cautiontypeid);
CREATE INDEX IX_goodssrcinfo_transporttype ON goodssourceinformation(transporttypeid);
CREATE INDEX IX_goodssrcinfo_deadline ON goodssourceinformation(deadline);
CREATE INDEX IX_goodssrcinfo_price ON goodssourceinformation(price);
CREATE INDEX IX_goodssrcinfo_releasedate ON goodssourceinformation(releasedate);
 