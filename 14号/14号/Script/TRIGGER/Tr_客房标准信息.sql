USE �Ƶ����ϵͳ
GO
CREATE TRIGGER Tr_�ͷ���׼��ϢDELETE ON �ͷ���׼��Ϣ  --ɾ�� 
FOR DELETE 
AS 
begin
delete from �ͷ���Ϣ where ���ͱ�� in (select ���ͱ�� from deleted )
end
GO
CREATE TRIGGER Tr_�ͷ���׼��ϢUPDATE ON �ͷ���׼��Ϣ  --�޸� 
FOR UPDATE 
AS 
begin
update �ͷ���Ϣ set ���ͱ��=(select ���ͱ�� from inserted ) where ���ͱ�� in( select ���ͱ�� from deleted )
update �ͷ���Ϣ set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
end
GO