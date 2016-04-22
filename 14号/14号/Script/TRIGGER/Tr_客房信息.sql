USE 酒店管理系统
GO
CREATE TRIGGER Tr_客房信息DELETE ON 客房信息  --删除 
FOR DELETE 
AS 
begin
delete from 入住单 where 客房编号 in (select 客房编号 from deleted )
delete from 入住单历史 where 客房编号 in (select 客房编号 from deleted )
delete from 预订单 where 客房编号 in (select 客房编号 from deleted )
delete from 预订单历史 where 客房编号 in (select 客房编号 from deleted )
end
GO
CREATE TRIGGER Tr_客房信息UPDATE ON 客房信息  --修改 
FOR UPDATE 
AS 
begin
update 入住单 set 客房编号=(select 客房编号 from inserted ) where 客房编号 in( select 客房编号 from deleted )
update 入住单 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
update 入住单 set 客房位置=(select 客房位置 from inserted) where 客房位置 in( select 客房位置 from deleted )

update 入住单历史 set 客房编号=(select 客房编号 from inserted ) where 客房编号 in( select 客房编号 from deleted )
update 入住单历史 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
update 入住单历史 set 客房位置=(select 客房位置 from inserted) where 客房位置 in( select 客房位置 from deleted )

update 预订单 set 客房编号=(select 客房编号 from inserted ) where 客房编号 in( select 客房编号 from deleted )
update 预订单 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
update 预订单 set 客房位置=(select 客房位置 from inserted) where 客房位置 in( select 客房位置 from deleted )

update 预订单历史 set 客房编号=(select 客房编号 from inserted ) where 客房编号 in( select 客房编号 from deleted )
update 预订单历史 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
update 预订单历史 set 客房位置=(select 客房位置 from inserted) where 客房位置 in( select 客房位置 from deleted )
end
GO