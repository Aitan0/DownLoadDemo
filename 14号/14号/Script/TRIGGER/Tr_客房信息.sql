USE �Ƶ����ϵͳ
GO
CREATE TRIGGER Tr_�ͷ���ϢDELETE ON �ͷ���Ϣ  --ɾ�� 
FOR DELETE 
AS 
begin
delete from ��ס�� where �ͷ���� in (select �ͷ���� from deleted )
delete from ��ס����ʷ where �ͷ���� in (select �ͷ���� from deleted )
delete from Ԥ���� where �ͷ���� in (select �ͷ���� from deleted )
delete from Ԥ������ʷ where �ͷ���� in (select �ͷ���� from deleted )
end
GO
CREATE TRIGGER Tr_�ͷ���ϢUPDATE ON �ͷ���Ϣ  --�޸� 
FOR UPDATE 
AS 
begin
update ��ס�� set �ͷ����=(select �ͷ���� from inserted ) where �ͷ���� in( select �ͷ���� from deleted )
update ��ס�� set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
update ��ס�� set �ͷ�λ��=(select �ͷ�λ�� from inserted) where �ͷ�λ�� in( select �ͷ�λ�� from deleted )

update ��ס����ʷ set �ͷ����=(select �ͷ���� from inserted ) where �ͷ���� in( select �ͷ���� from deleted )
update ��ס����ʷ set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
update ��ס����ʷ set �ͷ�λ��=(select �ͷ�λ�� from inserted) where �ͷ�λ�� in( select �ͷ�λ�� from deleted )

update Ԥ���� set �ͷ����=(select �ͷ���� from inserted ) where �ͷ���� in( select �ͷ���� from deleted )
update Ԥ���� set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
update Ԥ���� set �ͷ�λ��=(select �ͷ�λ�� from inserted) where �ͷ�λ�� in( select �ͷ�λ�� from deleted )

update Ԥ������ʷ set �ͷ����=(select �ͷ���� from inserted ) where �ͷ���� in( select �ͷ���� from deleted )
update Ԥ������ʷ set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
update Ԥ������ʷ set �ͷ�λ��=(select �ͷ�λ�� from inserted) where �ͷ�λ�� in( select �ͷ�λ�� from deleted )
end
GO