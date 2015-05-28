USE transinfo;
--
-- ר����Ϣ
--

INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode) 
VALUES('�ɶ�','PS','18030762400','028-85303053','659004');
INSERT INTO placeinfo(address,contactpersonname,contactcellphone,contactphone,countycode) 
VALUES('���','Jerry','18230762400','028-85313053','654324');

INSERT INTO speciallineinfo(userid,title,sourceplaceinfoid,destinationplaceinfoid,weightprice,volumeprice,departuretypeid,speciallinetypeid,description)
VALUES(1,'�������ݣ���ɾ��',1,2,20,23,1,1,'note');

call uspInsertSpecialineData(' <speciallinedata>
	<userid>1</userid>
	<title>�洢���̲���</title>
	<srcaddress>��ʼ��ַ</srcaddress>
	<srccontactperson>����ʼ</srccontactperson>
	<srccontactcellphone>18030762400</srccontactcellphone>
	<srccontactphone>87303051</srccontactphone>
	<srccountycode>120111</srccountycode>
	<dstaddress>Ŀ�ĵ�ַ</dstaddress>
	<dstcontactperson>������</dstcontactperson>
	<dstcontactcellphone>18224010531</dstcontactcellphone>
	<dstcontactphone>87654321</dstcontactphone>
	<dstcountycode>140802</dstcountycode>
	<weightprice>20</weightprice>
	<volumeprice>21</volumeprice>
	<departuretypeid>1</departuretypeid>
	<speciallinetypeid>2</speciallinetypeid>
	<description>���Դ洢���̲�������</description>
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
	<location>�ɶ�����ص�</location>
	<vantypeid>1</vantypeid>
	<brand>����</brand>
	<trunktypeid>1</trunktypeid>
	<contactpersonname>�Űٴ�</contactpersonname>
	<contactphone>18030762400</contactphone>
	<trunkidentifynumber>RSL132487648235687214528</trunkidentifynumber>
	<vanimageuri>url:null</vanimageuri>
	<licenseuri>url:null</licenseuri>
</trunkmetadata>
'
);

