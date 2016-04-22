
use master
go
create proc killspid
(
@dbname varchar(50)
)
as
begin
declare @sql nvarchar(500)

declare @spid int
set @sql='declare getspid cursor for
	select spid from sysprocesses where dbid=db_id('+@dbname+')'
print @sql
exec (@sql)
open getspid
fetch next from getspid into @spid
while @@FETCH_STATUS<>-1
begin
print @spid
exec ('kill '+@spid)
fetch next from getspid into @spid
end
close getspid
deallocate getspid
print 'OK'
end
