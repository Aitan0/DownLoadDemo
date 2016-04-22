use 酒店管理系统
if exists(select name from sysindexes
   where name='index_管理员')
drop index 管理员.index_管理员
go
use 酒店管理系统
create unique index index_管理员
on 管理员(编号) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go