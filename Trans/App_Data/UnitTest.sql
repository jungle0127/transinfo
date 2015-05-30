USE transinfo;
--
-- 专线信息
--

INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode) 
VALUES('成都','PS','18030762400','028-85303053','659004');
INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode) 
VALUES('天津','Jerry','18230762400','028-85313053','654324');

INSERT INTO speciallineinfo(userid,title,sourceplaceinfoid,destinationplaceinfoid,weightprice,volumeprice,departuretypeid,speciallinetypeid,description)
VALUES(1,'测试数据，请删除',1,2,20,23,1,1,'note');

INSERT INTO trunknumber(prefixid,number,userid) VALUES(1,'A 23456',1);
INSERT INTO trunknumber(prefixid,number,userid) VALUES(1,'A 23457',1);
INSERT INTO trunknumber(prefixid,number,userid) VALUES(1,'A 23458',1);
INSERt INTO trunkmetadata(numberid,length,weightcapacity,volume,countycode,location,vantypeid,brand,trunktypeid,contactpersonname,conatactphone,trunkidentifynumber)
VALUES (1,'12','23','21','110105','Location of trunk',1,'Dongfeng','1','联系人','18030762500','SAL234232');
INSERt INTO trunkmetadata(numberid,length,weightcapacity,volume,countycode,location,vantypeid,brand,trunktypeid,contactpersonname,conatactphone,trunkidentifynumber)
VALUES (1,'12','23','21','110104','Location of trunk',1,'Dongfeng','1','联系人1','18030762500','SAL234235');
INSERt INTO trunkmetadata(numberid,length,weightcapacity,volume,countycode,location,vantypeid,brand,trunktypeid,contactpersonname,conatactphone,trunkidentifynumber)
VALUES (1,'12','23','21','110103','Location of trunk',1,'Dongfeng','1','联系人2','18030762500','SAL234236');


insert into trunkinformation(trunkid,routetypeid,srccountycode,dstcountycode,timetypeid,returntypeid,userid,title,releasedate)
values (1,2,'110101','110102',2,1,1,'dasdasda','2015-05-27');


insert into goodssourceinformation(userid,srccountycode,dstcountycode,title,goodsname,transporttypeid,cautiontypeid,goodstypeid,price)
values (1,'110105','110103','dfasfadfsdfsdfs','HUOWU',1,1,1,'110');
insert into goodssourceinformation(userid,srccountycode,dstcountycode,title,goodsname,transporttypeid,cautiontypeid,goodstypeid,price)
values (1,'110105','110102','dfasfadfsdfsdfs','HUOWU',1,1,1,'110');
insert into goodssourceinformation(userid,srccountycode,dstcountycode,title,goodsname,transporttypeid,cautiontypeid,goodstypeid,price)
values (1,'110105','110107','dfasfadfsdfsdfs','HUOWU',1,1,1,'110');
insert into goodssourceinformation(userid,srccountycode,dstcountycode,title,goodsname,transporttypeid,cautiontypeid,goodstypeid,price)
values (1,'110101','110103','dfasfadfsdfsdfs','HUOWU',1,1,1,'110');
insert into goodssourceinformation(userid,srccountycode,dstcountycode,title,goodsname,transporttypeid,cautiontypeid,goodstypeid,price)
values (1,'110102','110103','dfasfadfsdfsdfs','HUOWU',1,1,1,'110');

INSERT INTO depotinformation
(
	`userid`,
	`title`,
	`countycode`,
	`address`,
	`bizscopetype`,
	`depottype`,
	`area`,
	`useablearea`,
	`price`,
	`contactperson`,
	`cellphone`,
	`validtime`,
	`description`
)
VALUES
(
1,
'仓储信息测试',
'110102',
'仓库地址',
1,
1,
23,
22,
32,
'联系人',
'13888888888',
'2015-05-29',
'描述信息：这是测试数据，请删除'
);


call uspInsertSpecialineData(' <speciallinedata>
	<userid>1</userid>
	<title>存储过程测试</title>
	<srcaddress>起始地址</srcaddress>
	<srccontactperson>张肇始</srccontactperson>
	<srccontactcellphone>18030762400</srccontactcellphone>
	<srccontactphone>87303051</srccontactphone>
	<srccountycode>120111</srccountycode>
	<dstaddress>目的地址</dstaddress>
	<dstcontactperson>王结束</dstcontactperson>
	<dstcontactcellphone>18224010531</dstcontactcellphone>
	<dstcontactphone>87654321</dstcontactphone>
	<dstcountycode>140802</dstcountycode>
	<weightprice>20</weightprice>
	<volumeprice>21</volumeprice>
	<departuretypeid>1</departuretypeid>
	<speciallinetypeid>2</speciallinetypeid>
	<description>测试存储过程插入数据</description>
 </speciallinedata>');
 
 call uspUpdateRoleHasRights('
 <rights>
<roleid>1</roleid>
<rightid>1</rightid>
<rightid>2</rightid>
<rightid>3</rightid>
<rightid>4</rightid>
<rightid>5</rightid>
<rightid>6</rightid>
<rightid>7</rightid>
<rightid>8</rightid>
<rightid>9</rightid>
<rightid>10</rightid>
<rightid>11</rightid>
<rightid>12</rightid>
<rightid>13</rightid>
<rightid>14</rightid>
<rightid>15</rightid>
<rightid>16</rightid>
<rightid>17</rightid>
<rightid>18</rightid>
<rightid>19</rightid>
<rightid>20</rightid>
<rightid>21</rightid>
<rightid>22</rightid>
<rightid>23</rightid>
</rights>
 ');
 
 call uspInsertTrunkMetadata(
 '
<trunkmetadata>
	<userid>1</userid>
	<numberprefixid>1</numberprefixid>
	<trunknumber>A PP944</trunknumber>
	<length>5</length>
	<weightcapacity>23</weightcapacity>
	<volume>32</volume>
	<countycode>110105</countycode>
	<location>成都虚拟地点</location>
	<vantypeid>1</vantypeid>
	<brand>东风</brand>
	<trunktypeid>1</trunktypeid>
	<contactpersonname>张百川</contactpersonname>
	<contactphone>18030762400</contactphone>
	<trunkidentifynumber>RSL132487648235687214528</trunkidentifynumber>
	<vanimageuri>url:null</vanimageuri>
	<licenseuri>url:null</licenseuri>
</trunkmetadata>
'
);

--
-- article 测试
--

INSERT INTO article (userid,typeid,title,content,releaseip,ispass,hittimes,releasedate)
VALUES(1,1,'新闻测试','测试数据请删除','10.200.96.102',1,12,'2015-06-01');
INSERT INTO article (userid,typeid,title,content,releaseip,ispass,hittimes,releasedate)
VALUES(1,2,'公告测试','测试数据请删除','10.200.96.102',1,12,'2015-06-01');
INSERT INTO article (userid,typeid,title,content,releaseip,ispass,hittimes,releasedate)
VALUES(1,2,'公告测试','测试数据请删除','10.200.96.102',1,12,'2015-06-01');
INSERT INTO article (userid,typeid,title,content,releaseip,ispass,hittimes,releasedate)
VALUES(1,1,'新闻测试','测试数据请删除','10.200.96.102',1,12,'2015-06-01');
INSERT INTO article (userid,typeid,title,content,releaseip,ispass,hittimes,releasedate)
VALUES(1,1,'新闻测试','测试数据请删除','10.200.96.102',1,12,'2015-06-01');
