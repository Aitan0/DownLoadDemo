USE 酒店管理系统
GO
ALTER TABLE [DBO].[客房信息] ADD
CONSTRAINT [FK_客房信息_客房标准信息_类型编号] FOREIGN KEY
(
    [类型编号]
)
REFERENCES [DBO].[客房标准信息]
(
    [类型编号]
)
GO

ALTER TABLE [DBO].[入住单] ADD
CONSTRAINT [FK_入住单_客房信息_客房编号] FOREIGN KEY
(
    [客房编号]
)
REFERENCES [DBO].[客房信息]
(
    [客房编号]
)
GO

ALTER TABLE [DBO].[入住单历史] ADD
CONSTRAINT [FK_入住单历史_客房信息_客房编号] FOREIGN KEY
(
    [客房编号]
)
REFERENCES [DBO].[客房信息]
(
    [客房编号]
)
GO

ALTER TABLE [DBO].[帐单明细] ADD
CONSTRAINT [FK_帐单明细_入住单_入住单号] FOREIGN KEY
(
    [入住单号]
)
REFERENCES [DBO].[入住单]
(
    [入住单号]
)
GO

ALTER TABLE [DBO].[预订单] ADD
CONSTRAINT [FK_预订单_客房信息_客房编号] FOREIGN KEY
(
    [客房编号]
)
REFERENCES [DBO].[客房信息]
(
    [客房编号]
)
GO

ALTER TABLE [DBO].[预订单历史] ADD
CONSTRAINT [FK_预订单历史_客房信息_客房编号] FOREIGN KEY
(
    [客房编号]
)
REFERENCES [DBO].[客房信息]
(
    [客房编号]
)
GO