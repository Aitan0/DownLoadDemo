use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_Ԥ������ʷ')
drop index Ԥ������ʷ.index_Ԥ������ʷ
go
use �Ƶ����ϵͳ
create unique index index_Ԥ������ʷ
on Ԥ������ʷ(Ԥ������) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go