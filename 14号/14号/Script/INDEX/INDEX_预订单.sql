use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_Ԥ����')
drop index Ԥ����.index_Ԥ����
go
use �Ƶ����ϵͳ
create unique index index_Ԥ����
on Ԥ����(Ԥ������) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go