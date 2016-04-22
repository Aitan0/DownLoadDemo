USE 酒店管理系统
GO
CREATE TRIGGER Tr_客房标准信息DELETE ON 客房标准信息  --删除 
FOR DELETE 
AS 
begin
delete from 客房信息 where 类型编号 in (select 类型编号 from deleted )
end
GO
CREATE TRIGGER Tr_客房标准信息UPDATE ON 客房标准信息  --修改 
FOR UPDATE 
AS 
begin
update 客房信息 set 类型编号=(select 类型编号 from inserted ) where 类型编号 in( select 类型编号 from deleted )
update 客房信息 set 客房类型=(select 客房类型 from inserted) where 客房类型 in( select 客房类型 from deleted )
end
GO