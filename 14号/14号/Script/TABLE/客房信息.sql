USE 酒店管理系统
GO
CREATE TABLE 客房信息(
[客房编号][CHAR](10) NOT NULL PRIMARY KEY,
[类型编号][CHAR](10) NOT NULL,
[客房类型][CHAR](20) NULL,
[客房位置][CHAR](10) NULL,
[额定人数][INT] NULL,
[床数][INT] NULL,
[客房描述][VARCHAR](40) NULL,
[状态][CHAR](10) NULL,
[是否可拼房][BIT] NULL
)
GO 