use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_��ס����ʷ')
drop index ��ס����ʷ.index_��ס����ʷ
go
use �Ƶ����ϵͳ
create unique index index_��ס����ʷ
on ��ס����ʷ(��ס����) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go