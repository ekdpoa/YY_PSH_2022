--------------------------------------------------------
--  파일이 생성됨 - 월요일-1월-30-2023   
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

   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."CCTV_ID" IS 'CCTV ID(고유 INDEX 값,등록 시 자동증가)';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."ON_OFF" IS '사용여부(T:사용 ,F: 미사용)';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."NAME" IS 'CCTV 이름';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."MEMO" IS '추가설명';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."CHANEL" IS '채널명';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."IP" IS 'IP';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."ID" IS 'ID';
   COMMENT ON COLUMN "YY_PSH"."CCTV_INFO"."PW" IS '비밀번호';
   COMMENT ON TABLE "YY_PSH"."CCTV_INFO"  IS '(WEB) 각 화면들의 정보 관련 테이블 (airhub - agent 테이블 참조)
(ID,NAME,TcpIp(rtsp주소,또는 파일 위치) 등을 명시)';
REM INSERTING into YY_PSH.CCTV_INFO
SET DEFINE OFF;
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('1','T','#4 워터링 드레인 밸브','FF','7','10.145.196.104','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('2','T','발전기동 1층','FF','8','10.145.196.50','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('3','T','현장 운전원실','FF','9','10.145.196.51','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('4','T','1호기 IPB 터널','FF','10','10.145.196.61','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('5','T','2호기 IPB 터널','FF','11','10.145.196.62','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('6','T','3호기 IPB 터널','FF','12','10.145.196.63','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('7','T','4호기 IPB 터널','FF','13','10.145.196.64','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('8','T','Sychro 감시(전기기기실)','FF','14','10.145.196.65','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('9','F','전력량계용 #1(전기기기실)','FF','15','10.145.196.66','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('10','F','전력량계용 #2(전기기기실)','FF','16','10.145.196.67','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('11','F','1호기 판넬(전자기기실)','FF','17','10.145.196.68','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('12','F','2호기 판넬(전자기기실)','FF','18','10.145.196.69','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('13','F','3호기 판넬(전자기기실)','FF','19','10.145.196.70','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('14','F','4호기 판넬(전자기기실)','FF','20','10.145.196.71','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('15','F','전자기기실','FF','21','10.145.196.81','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('16','F','#1수차 Inlet Valve','FF','22','10.145.196.82','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('17','F','#2수차 Inlet Valve','FF','23','10.145.196.83','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('18','F','#3수차 Inlet Valve','FF','24','10.145.196.84','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('19','F','#4수차 Inlet Valve','FF','25','10.145.196.85','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('20','F','#1 워터링 드레인 밸브','FF','26','10.145.196.101','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('21','F','#2 워터링 드레인 밸브','FF','27','10.145.196.102','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('22','F','#3 워터링 드레인 밸브','FF','28','10.145.196.103','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('23','F','#1 Penstock Pressure','FF','29','10.145.196.105','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('24','F','#2 Penstock Pressure','FF','30','10.145.196.106','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('25','F','#3 Penstock Pressure','FF','31','10.145.196.107','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('26','F','#4 Penstock Pressure','FF','32','10.145.196.108','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('27','F','#1 리워터링 유압밸브','FF','33','10.145.196.121','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('28','F','#2 리워터링 유압밸브','FF','34','10.145.196.122','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('29','F','#3 리워터링 유압밸브','FF','35','10.145.196.123','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('30','F','#4 리워터링 유압밸브','FF','36','10.145.196.124','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('31','F','#1 Lower Servomoter','FF','37','10.145.196.125','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('32','F','#2 Lower Servomoter','FF','38','10.145.196.126','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('33','F','#3 Lower Servomoter','FF','39','10.145.196.127','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('34','F','#4 Lower Servomoter','FF','40','10.145.196.128','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('35','F','리워터링밸브 상단 1호기','FF','41','10.145.196.129','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('36','F','리워터링밸브 상단 2호기','FF','42','10.145.196.130','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('37','F','리워터링밸브 상단 3호기','FF','43','10.145.196.131','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('38','F','리워터링밸브 상단 4호기','FF','44','10.145.196.132','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('39','F','비상배수 펌프 컨트롤 보드','FF','45','10.145.196.133','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('40','F','배수펌프 피트(내)','FF','46','10.145.196.134','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('41','F','비상배수 펌프 Floor','FF','47','10.145.196.135','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('42','F','#1 흡출관 게이트','FF','48','10.145.196.141','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('43','F','#2 흡출관 게이트','FF','49','10.145.196.142','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('44','F','#3 흡출관 게이트','FF','50','10.145.196.143','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('45','F','#4 흡출관 게이트','FF','51','10.145.196.144','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('46','F','D/T Gate','FF','52','10.145.196.145','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('47','F','주변압기동','FF','53','10.145.196.146','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('48','F','케이블 룸','FF','54','10.145.196.147','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('49','F','SFC룸 2,3호기 사이','FF','55','10.145.196.148','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('50','F','SFC룸','FF','56','10.145.196.149','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('51','F','#1 변압기 상단(열화상)','FF','57','10.145.196.150','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('52','F','#2 변압기 상단(열화상)','FF','58','10.145.196.151','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('53','F','#3 변압기 상단(열화상)','FF','59','10.145.196.152','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('54','F','#4 변압기 상단(열화상)','FF','60','10.145.196.153','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('55','F','#1 변압기 상단(일반)','FF','61','10.145.196.154','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('56','F','#2 변압기 상단(일반)','FF','62','10.145.196.155','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('57','F','#3 변압기 상단(일반)','FF','63','10.145.196.156','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('58','F','#4 변압기 상단(일반)','FF','64','10.145.196.157','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('59','F','진입터널 상','FF','65','10.145.196.161','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('60','F','진입터널 중','FF','66','10.145.196.162','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('61','F','진입터널 하','FF','67','10.145.196.163','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('62','F','진입터널 하(진입차도)','FF','68','10.145.196.164','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('63','F','진입터널 하(주차장)','FF','69','10.145.196.165','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('64','F','케이블 터널 상','FF','70','10.145.196.171','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('65','F','케이블 터널 중','FF','71','10.145.196.172','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('66','F','케이블 터널 펌프설비','FF','72','10.145.196.173','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('67','F','케이블 터널 하','FF','73','10.145.196.174','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('68','F','상부댐 옥상','FF','74','10.145.196.181','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('69','F','상부댐 제어소','FF','75','10.145.196.182','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('70','F','상부댐 수위','FF','76','10.145.196.183','admin','YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('71','F','하부댐 하류(댐 감시)','FF','77','10.145.196.191','admin','1234');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('72','F','하부댐 도로','FF','78','10.145.196.192','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('73','F','하부댐 전기실','FF','79','10.145.196.193','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('74','F','하부댐 수위','FF','80','10.145.196.194','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('75','F','수문조작 1호기','FF','81','10.145.196.195','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('76','F','수문조작 2호기','FF','82','10.145.196.196','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('77','F','수문조작 3호기','FF','83','10.145.196.197','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('78','F','수문조작 4호기','FF','84','10.145.196.198','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('79','F','하부댐 어도','FF','85','10.145.196.199','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('80','F','소수력 옥외 #3 VCB PNL','FF','86','10.145.196.211','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('81','F','소수력 옥외 #3 LBS PNL','FF','87','10.145.196.212','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('82','F','소수력 외각 판넬 감시','FF','88','10.145.196.213','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('83','F','소수력 제어실 전체','FF','89','10.145.196.214','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('84','F','#1 MV-1 PNL','FF','90','10.145.196.215','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('85','F','#1 MV-2 PNL','FF','91','10.145.196.216','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('86','F','#1,2 HV-4 PNL','FF','92','10.145.196.217','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('87','F','#1 MAIN CTRL BOARD & RTU','FF','93','10.145.196.218','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('88','F','#2 MAIN CTRL BOARD & RTU','FF','94','10.145.196.219','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('89','F','EXT CTRL BOARD & RTU','FF','95','10.145.196.220','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('90','F','소수력 지하 전체','FF','96','10.145.196.221','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('91','F','#1 TURBIN CTRL PNL','FF','97','10.145.196.222','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('92','F','#2 TURBIN CTRL PNL','FF','98','10.145.196.223','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('93','F','#3 소수력 현장 조작반','FF','99','10.145.196.224','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('94','F','Drainage Pump CTRL PNL','FF','100','10.145.196.225','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('95','F','중앙제어실','FF','101','10.145.196.231','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('96','F','통신실','FF','102','10.145.196.232','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('97','F','EWS 입구','FF','103','10.145.196.233','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('98','F','전자기기실 입구','FF','104','10.145.196.234','admin','@YangYang1');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('99','F','소수력 지하1층 누수센서 스위치','FF','105','10.145.196.241','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('100','F','#1 Penstock 누수센서 스위치','FF','106','10.145.196.242','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('101','F','#2 Penstock 누수센서 스위치','FF','107','10.145.196.243','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('102','F','#3 Penstock 누수센서 스위치','FF','108','10.145.196.244','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('103','F','#4 Penstock 누수센서 스위치','FF','109','10.145.196.245','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('104','F','지하 B4 1호기 누수센서 스위치','FF','110','10.145.196.246','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('105','F','지하 B4 2,3호기 누수센서 스위치','FF','111','10.145.196.247','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('106','F','지하 B4 4호기 누수센서 스위치','FF','112','10.145.196.248','FF','FF');
Insert into YY_PSH.CCTV_INFO (CCTV_ID,ON_OFF,NAME,MEMO,CHANEL,IP,ID,PW) values ('107','F','비상통신망 GW','FF','113','10.145.196.254','FF','FF');
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
