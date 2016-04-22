USE 酒店管理系统
GO
CREATE TABLE 客房标准信息(
[类型编号][CHAR](10) NOT NULL PRIMARY KEY,
[客房类型][CHAR](20) NULL,
[房间面积][DECIMAL] NULL,
[床位数量][INT] NULL,
[客房价格][DECIMAL] NULL,
[空调][BIT] NULL,
[电视机][BIT] NULL,
[电话][BIT] NULL,
[单独卫生间][BIT] NULL
)
GO