USE �Ƶ����ϵͳ
GO
CREATE TRIGGER Tr_��ס��DELETE ON ��ס��  --ɾ�� 
FOR DELETE 
AS 
begin
delete from ��ס�� where ��ס���� in (select ��ס���� from deleted )
end
GO
CREATE TRIGGER Tr_��ס��UPDATE ON ��ס��  --�޸� 
FOR UPDATE 
AS 
begin
update �ʵ���ϸ set ��ס����=(select ��ס���� from inserted ) where ��ס���� in( select ��ס���� from deleted )
update �ʵ���ϸ set �ͷ����=(select �ͷ���� from inserted ) where �ͷ���� in( select �ͷ���� from deleted )
update �ʵ���ϸ set �ͷ�����=(select �ͷ����� from inserted) where �ͷ����� in( select �ͷ����� from deleted )
update �ʵ���ϸ set �ͷ�λ��=(select �ͷ�λ�� from inserted) where �ͷ�λ�� in( select �ͷ�λ�� from deleted )

update �ʵ���ϸ set �ͷ��۸�=(select �ͷ��۸� from inserted ) where �ͷ��۸� in( select �ͷ��۸� from deleted )
update �ʵ���ϸ set �˿�����=(select Ԥ���� from inserted) where �˿����� in( select Ԥ���� from deleted )
update �ʵ���ϸ set ���֤=(select ���֤ from inserted) where ���֤ in( select ���֤ from deleted )

update �ʵ���ϸ set ��סʱ��=(select �ֵ�ʱ�� from inserted ) where ��סʱ�� in( select �ֵ�ʱ�� from deleted )
update �ʵ���ϸ set �ۿ�=(select �ۿ� from inserted) where �ۿ� in( select �ۿ� from deleted )
update �ʵ���ϸ set ��������=(select ���ʱ�� from inserted) where �������� in( select ���ʱ�� from deleted )
end
GO