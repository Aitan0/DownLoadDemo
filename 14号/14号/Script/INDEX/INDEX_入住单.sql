use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_��ס��')
drop index ��ס��.index_��ס��
go
use �Ƶ����ϵͳ
create unique index index_��ס��
on ��ס��(��ס����) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go