USE 酒店管理系统
GO
CREATE TRIGGER Tr_入住单DELETE ON 入住单  --删除 
FOR DELETE 
AS 
begin
delete from 入住单 where 入住单号 in (select 入住单号 from deleted )
end
GO
CREATE TRIGGER Tr_入住单UPDATE ON 入住单  --修改 
FOR UPDATE 
AS 
begin
update 帐单明细 set 入住单号=(select 入住单号 from inserted ) where 入住单号 in( select 入住单号 from deleted )
update 帐单明细 set 客房编号=(select 客房编号 from inserted ) where 客房编号 in( select 客房编号 from deleted )
update 帐单明细 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
update 帐单明细 set 客房位置=(select 客房位置 from inserted) where 客房位置 in( select 客房位置 from deleted )

update 帐单明细 set 客房价格=(select 客房价格 from inserted ) where 客房价格 in( select 客房价格 from deleted )
update 帐单明细 set 顾客姓名=(select 预订人 from inserted) where 顾客姓名 in( select 预订人 from deleted )
update 帐单明细 set 身份证=(select 身份证 from inserted) where 身份证 in( select 身份证 from deleted )

update 帐单明细 set 入住时间=(select 抵店时间 from inserted ) where 入住时间 in( select 抵店时间 from deleted )
update 帐单明细 set 折扣=(select 折扣 from inserted) where 折扣 in( select 折扣 from deleted )
update 帐单明细 set 结算日期=(select 离店时间 from inserted) where 结算日期 in( select 离店时间 from deleted )
end
GO