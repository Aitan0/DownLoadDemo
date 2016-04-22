use 酒店管理系统
if exists(select name from sysindexes
   where name='index_预订单历史')
drop index 预订单历史.index_预订单历史
go
use 酒店管理系统
create unique index index_预订单历史
on 预订单历史(预订单号) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go