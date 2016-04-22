use 酒店管理系统
if exists(select name from sysindexes
   where name='index_入住单')
drop index 入住单.index_入住单
go
use 酒店管理系统
create unique index index_入住单
on 入住单(入住单号) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go