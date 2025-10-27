--------------------------------------------------------
--  ������ ������ - ������-1��-30-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CCTV_INFO
--------------------------------------------------------

  CREATE TABLE "YY_PSH"."CCTV_INFO" 
   (	"CCTV_ID" VARCHAR2(20 BYTE) DEFAULT 'FF', 
	"ON_OFF" VARCHAR2(20 BYTE) DEFAULT 'FF', 
	"NAME" VARCHAR2(128 BYTE) DEFAULT 'FF', 
	"MEMO" VARCHAR2(1024 BYTE) DEFAULT 'FF', 
	"CHANEL" VARCHAR2(512 BYTE) DEFAULT 'FF', 
	"IP" VARCHAR2(64 BYTE) DEFAULT 'FF', 
	"ID" VARCHAR2(64 BYTE) DEFAULT 'FF', 
	"PW" VARCHAR2(64 BYTE) DEFAULT 'FF'
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "YY_PSH_TBS" ;

   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."CCTV_ID" IS 'CCTV ID(���� INDEX ��,��� �� �ڵ�����)';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."ON_OFF" IS '��뿩��(T:��� ,F: �̻��)';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."NAME" IS 'CCTV �̸�';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."MEMO" IS '�߰�����';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."CHANEL" IS 'ä�θ�';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."IP" IS 'IP';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."ID" IS 'ID';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."PW" IS '��й�ȣ';
   COMMENT ON TABLE "YY_PSH"."CCTV_INFO"  IS '(WEB) �� ȭ����� ���� ���� ���̺� (airhub - agent ���̺� ����)
(ID,NAME,TcpIp(rtsp�ּ�,�Ǵ� ���� ��ġ) ���� ���)';
REM INSERTING into YY_PSH.CCTV_INFO
SET DEFINE OFF;
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('1','T','#4 ���͸� �巹�� ���','FF','7','10.145.196.104','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('2','T','�����⵿ 1��','FF','8','10.145.196.50','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('3','T','���� ��������','FF','9','10.145.196.51','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('4','T','1ȣ�� IPB �ͳ�','FF','10','10.145.196.61','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('5','T','2ȣ�� IPB �ͳ�','FF','11','10.145.196.62','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('6','T','3ȣ�� IPB �ͳ�','FF','12','10.145.196.63','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('7','T','4ȣ�� IPB �ͳ�','FF','13','10.145.196.64','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('8','T','Sychro ����(�������)','FF','14','10.145.196.65','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('9','F','���·���� #1(�������)','FF','15','10.145.196.66','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('10','F','���·���� #2(�������)','FF','16','10.145.196.67','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('11','F','1ȣ�� �ǳ�(���ڱ���)','FF','17','10.145.196.68','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('12','F','2ȣ�� �ǳ�(���ڱ���)','FF','18','10.145.196.69','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('13','F','3ȣ�� �ǳ�(���ڱ���)','FF','19','10.145.196.70','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('14','F','4ȣ�� �ǳ�(���ڱ���)','FF','20','10.145.196.71','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('15','F','���ڱ���','FF','21','10.145.196.81','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('16','F','#1���� Inlet Valve','FF','22','10.145.196.82','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('17','F','#2���� Inlet Valve','FF','23','10.145.196.83','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('18','F','#3���� Inlet Valve','FF','24','10.145.196.84','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('19','F','#4���� Inlet Valve','FF','25','10.145.196.85','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('20','F','#1 ���͸� �巹�� ���','FF','26','10.145.196.101','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('21','F','#2 ���͸� �巹�� ���','FF','27','10.145.196.102','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('22','F','#3 ���͸� �巹�� ���','FF','28','10.145.196.103','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('23','F','#1 Penstock Pressure','FF','29','10.145.196.105','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('24','F','#2 Penstock Pressure','FF','30','10.145.196.106','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('25','F','#3 Penstock Pressure','FF','31','10.145.196.107','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('26','F','#4 Penstock Pressure','FF','32','10.145.196.108','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('27','F','#1 �����͸� ���й��','FF','33','10.145.196.121','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('28','F','#2 �����͸� ���й��','FF','34','10.145.196.122','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('29','F','#3 �����͸� ���й��','FF','35','10.145.196.123','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('30','F','#4 �����͸� ���й��','FF','36','10.145.196.124','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('31','F','#1 Lower Servomoter','FF','37','10.145.196.125','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('32','F','#2 Lower Servomoter','FF','38','10.145.196.126','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('33','F','#3 Lower Servomoter','FF','39','10.145.196.127','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('34','F','#4 Lower Servomoter','FF','40','10.145.196.128','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('35','F','�����͸���� ��� 1ȣ��','FF','41','10.145.196.129','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('36','F','�����͸���� ��� 2ȣ��','FF','42','10.145.196.130','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('37','F','�����͸���� ��� 3ȣ��','FF','43','10.145.196.131','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('38','F','�����͸���� ��� 4ȣ��','FF','44','10.145.196.132','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('39','F','����� ���� ��Ʈ�� ����','FF','45','10.145.196.133','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('40','F','������� ��Ʈ(��)','FF','46','10.145.196.134','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('41','F','����� ���� Floor','FF','47','10.145.196.135','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('42','F','#1 ����� ����Ʈ','FF','48','10.145.196.141','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('43','F','#2 ����� ����Ʈ','FF','49','10.145.196.142','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('44','F','#3 ����� ����Ʈ','FF','50','10.145.196.143','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('45','F','#4 ����� ����Ʈ','FF','51','10.145.196.144','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('46','F','D/T Gate','FF','52','10.145.196.145','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('47','F','�ֺ��б⵿','FF','53','10.145.196.146','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('48','F','���̺� ��','FF','54','10.145.196.147','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('49','F','SFC�� 2,3ȣ�� ����','FF','55','10.145.196.148','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('50','F','SFC��','FF','56','10.145.196.149','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('51','F','#1 ���б� ���(��ȭ��)','FF','57','10.145.196.150','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('52','F','#2 ���б� ���(��ȭ��)','FF','58','10.145.196.151','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('53','F','#3 ���б� ���(��ȭ��)','FF','59','10.145.196.152','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('54','F','#4 ���б� ���(��ȭ��)','FF','60','10.145.196.153','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('55','F','#1 ���б� ���(�Ϲ�)','FF','61','10.145.196.154','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('56','F','#2 ���б� ���(�Ϲ�)','FF','62','10.145.196.155','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('57','F','#3 ���б� ���(�Ϲ�)','FF','63','10.145.196.156','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('58','F','#4 ���б� ���(�Ϲ�)','FF','64','10.145.196.157','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('59','F','�����ͳ� ��','FF','65','10.145.196.161','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('60','F','�����ͳ� ��','FF','66','10.145.196.162','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('61','F','�����ͳ� ��','FF','67','10.145.196.163','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('62','F','�����ͳ� ��(��������)','FF','68','10.145.196.164','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('63','F','�����ͳ� ��(������)','FF','69','10.145.196.165','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('64','F','���̺� �ͳ� ��','FF','70','10.145.196.171','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('65','F','���̺� �ͳ� ��','FF','71','10.145.196.172','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('66','F','���̺� �ͳ� ��������','FF','72','10.145.196.173','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('67','F','���̺� �ͳ� ��','FF','73','10.145.196.174','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('68','F','��δ� ����','FF','74','10.145.196.181','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('69','F','��δ� �����','FF','75','10.145.196.182','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('70','F','��δ� ����','FF','76','10.145.196.183','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('71','F','�Ϻδ� �Ϸ�(�� ����)','FF','77','10.145.196.191','admin','1234');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('72','F','�Ϻδ� ����','FF','78','10.145.196.192','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('73','F','�Ϻδ� �����','FF','79','10.145.196.193','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('74','F','�Ϻδ� ����','FF','80','10.145.196.194','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('75','F','�������� 1ȣ��','FF','81','10.145.196.195','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('76','F','�������� 2ȣ��','FF','82','10.145.196.196','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('77','F','�������� 3ȣ��','FF','83','10.145.196.197','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('78','F','�������� 4ȣ��','FF','84','10.145.196.198','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('79','F','�Ϻδ� �','FF','85','10.145.196.199','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('80','F','�Ҽ��� ���� #3 VCB PNL','FF','86','10.145.196.211','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('81','F','�Ҽ��� ���� #3 LBS PNL','FF','87','10.145.196.212','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('82','F','�Ҽ��� �ܰ� �ǳ� ����','FF','88','10.145.196.213','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('83','F','�Ҽ��� ����� ��ü','FF','89','10.145.196.214','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('84','F','#1 MV-1 PNL','FF','90','10.145.196.215','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('85','F','#1 MV-2 PNL','FF','91','10.145.196.216','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('86','F','#1,2 HV-4 PNL','FF','92','10.145.196.217','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('87','F','#1 MAIN CTRL BOARD & RTU','FF','93','10.145.196.218','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('88','F','#2 MAIN CTRL BOARD & RTU','FF','94','10.145.196.219','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('89','F','EXT CTRL BOARD & RTU','FF','95','10.145.196.220','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('90','F','�Ҽ��� ���� ��ü','FF','96','10.145.196.221','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('91','F','#1 TURBIN CTRL PNL','FF','97','10.145.196.222','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('92','F','#2 TURBIN CTRL PNL','FF','98','10.145.196.223','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('93','F','#3 �Ҽ��� ���� ���۹�','FF','99','10.145.196.224','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('94','F','Drainage Pump CTRL PNL','FF','100','10.145.196.225','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('95','F','�߾������','FF','101','10.145.196.231','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('96','F','��Ž�','FF','102','10.145.196.232','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('97','F','EWS �Ա�','FF','103','10.145.196.233','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('98','F','���ڱ��� �Ա�','FF','104','10.145.196.234','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('99','F','�Ҽ��� ����1�� �������� ����ġ','FF','105','10.145.196.241','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('100','F','#1 Penstock �������� ����ġ','FF','106','10.145.196.242','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('101','F','#2 Penstock �������� ����ġ','FF','107','10.145.196.243','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('102','F','#3 Penstock �������� ����ġ','FF','108','10.145.196.244','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('103','F','#4 Penstock �������� ����ġ','FF','109','10.145.196.245','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('104','F','���� B4 1ȣ�� �������� ����ġ','FF','110','10.145.196.246','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('105','F','���� B4 2,3ȣ�� �������� ����ġ','FF','111','10.145.196.247','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('106','F','���� B4 4ȣ�� �������� ����ġ','FF','112','10.145.196.248','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('107','F','�����Ÿ� GW','FF','113','10.145.196.254','FF','FF');
--------------------------------------------------------
--  DDL for Index CCTV_INFO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "YY_PSH"."CCTV_INFO_PK" ON "YY_PSH"."CCTV_INFO" ("CCTV_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "YY_PSH_TBS" ;
--------------------------------------------------------
--  Constraints for Table CCTV_INFO
--------------------------------------------------------

  ALTER TABLE "YY_PSH"."CCTV_INFO" MODIFY ("CCTV_ID" NOT NULL ENABLE);
  ALTER TABLE "YY_PSH"."CCTV_INFO" ADD CONSTRAINT "CCTV_INFO_PK" PRIMARY KEY ("CCTV_ID")
  USING INDEX "YY_PSH"."CCTV_INFO_PK"  ENABLE;
