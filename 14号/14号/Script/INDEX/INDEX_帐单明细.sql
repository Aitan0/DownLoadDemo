use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_�ʵ���ϸ')
drop index �ʵ���ϸ.index_�ʵ���ϸ
go
use �Ƶ����ϵͳ
create unique index index_�ʵ���ϸ
on �ʵ���ϸ(�ʵ����) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go