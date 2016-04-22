USE 酒店管理系统
GO
CREATE TABLE 入住单(
[入住单号][CHAR](10) NOT NULL PRIMARY KEY,
[预订单号][CHAR](10) NULL,
[会员编号][CHAR](10) NULL,
[客房编号][CHAR](10) NOT NULL,
[客房类型][CHAR](20) NULL,
[客房位置][CHAR](10) NULL,
[抵店时间][SMALLDATETIME] NULL,
[离店时间][SMALLDATETIME] NULL,
[单据状态][CHAR](10) NULL,
[入住人数][INT] NULL,
[客房价格][DECIMAL] NULL,
[入住价格][DECIMAL] NULL,
[折扣][DECIMAL] NULL,
[折扣原因][VARCHAR](40) NULL,
[是否加床][BIT] NULL,
[加床价格][DECIMAL] NULL,
[预收款][DECIMAL] NULL,
[预订人][CHAR](10) NULL,
[身份证][CHAR](20) NULL,
[预订公司][VARCHAR](40) NULL,
[联系电话][CHAR](13) NULL,
[备注][VARCHAR](40) NULL,
[操作员][CHAR](10) NULL,
[业务员][CHAR](10) NULL,
[早餐][BIT] NULL,
[叫醒][BIT] NULL,
[保密][BIT] NULL,
[VIP][BIT] NULL,
[电话等级][CHAR](10) NULL,
[特要说明][VARCHAR](40) NULL,
[应收帐款][DECIMAL] NULL,
[是否结帐][BIT] NULL,
[结帐金额][DECIMAL] NULL,
[结帐日期][SMALLDATETIME] NULL,
[付帐方式][CHAR](10) NULL
)
GO















