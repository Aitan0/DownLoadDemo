use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_�ͷ���Ϣ')
drop index �ͷ���Ϣ.index_�ͷ���Ϣ
go
use �Ƶ����ϵͳ
create unique index index_�ͷ���Ϣ
on �ͷ���Ϣ(�ͷ����) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go