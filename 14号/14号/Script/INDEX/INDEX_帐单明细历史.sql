use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_�ʵ���ϸ��ʷ')
drop index �ʵ���ϸ��ʷ.index_�ʵ���ϸ��ʷ
go
use �Ƶ����ϵͳ
create unique index index_�ʵ���ϸ��ʷ
on �ʵ���ϸ��ʷ(�ʵ����) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go