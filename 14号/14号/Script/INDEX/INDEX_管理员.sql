use �Ƶ����ϵͳ
if exists(select name from sysindexes
   where name='index_����Ա')
drop index ����Ա.index_����Ա
go
use �Ƶ����ϵͳ
create unique index index_����Ա
on ����Ա(���) 
with
PAD_INDEX,
FILLFACTOR=20,
IGNORE_DUP_KEY,
STATISTICS_NORECOMPUTE 
on[primary]
go