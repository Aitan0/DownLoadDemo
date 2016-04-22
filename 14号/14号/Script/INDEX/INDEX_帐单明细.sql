use 酒店管理系统
if exists(select name from sysindexes
   where name='index_帐单明细')
drop index 帐单明细.index_帐单明细
go
use 酒店管理系统
create unique index index_帐单明细
on 帐单明细(帐单编号) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go