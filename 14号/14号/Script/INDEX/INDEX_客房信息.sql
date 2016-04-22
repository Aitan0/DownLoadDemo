use 酒店管理系统
if exists(select name from sysindexes
   where name='index_客房信息')
drop index 客房信息.index_客房信息
go
use 酒店管理系统
create unique index index_客房信息
on 客房信息(客房编号) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go