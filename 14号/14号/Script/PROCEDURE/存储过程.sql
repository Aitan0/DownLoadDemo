USE �Ƶ����ϵͳ
GO
CREATE PROC SF_������ס�� @��ס���� CHAR(10)
AS
BEGIN TRAN
--�޸Ŀͷ���Ϣ
UPDATE �ͷ���Ϣ SET ״̬='ס��' FROM �ͷ���Ϣ AS A , ��ס�� AS B
WHERE A.�ͷ����=B.�ͷ���� AND B.��ס����=@��ס����
--�޸�Ԥ����״̬
UPDATE Ԥ���� SET ����״̬ = '��ס' FROM Ԥ���� AS A , ��ס�� AS B
WHERE A.Ԥ������ = B.Ԥ������ AND B.��ס���� = @��ס����
--������ס�� Ԥ����������ʷ
INSERT INTO Ԥ������ʷ SELECT * FROM Ԥ���� WHERE ����״̬= '��ס'
--�������סԤ����
DELETE FROM Ԥ���� WHERE ����״̬ = '��ס'
COMMIT
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC SF_�����˷� @��ס���� CHAR(10) , @���ʷ�ʽ CHAR(20)
AS
BEGIN TRAN 
UPDATE ��ס�� SET ���ʱ��=GETDATE(),����״̬= '���',
���ʷ�ʽ= @���ʷ�ʽ , �Ƿ����=1,
�������� = GETDATE()
WHERE ��ס���� = @��ס����
--���÷�״
UPDATE �ͷ���Ϣ SET ״̬='�շ�' FROM �ͷ���Ϣ AS A , ��ס�� AS B
WHERE A.�ͷ���� = B.�ͷ���� AND B.��ס���� = @��ס����
--������ʷ
INSERT INTO ��ס����ʷ SELECT * FROM ��ס��
WHERE ��ס���� = @��ס����
INSERT INTO �ʵ���ϸ��ʷ SELECT * FROM �ʵ���ϸ
WHERE ��ס���� = @��ס����
DELETE FROM �ʵ���ϸ
WHERE ��ס���� = @��ס����
--�����ס��
DELETE FROM ��ס��
WHERE ��ס����=@��ס����
COMMIT
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC SF_����Ӧ���ʿ� @��ס���� CHAR(10)
AS
BEGIN TRAN
DECLARE @TOTAL DECIMAL
DECLARE @DATECOUNT INT 
--�������ʱ��
UPDATE ��ס�� SET ���ʱ�� = GETDATE() WHERE ��ס���� = @��ס����
--ס������
SELECT @DATECOUNT = DATEDIFF(DD , �ֵ�ʱ��,GETDATE())
FROM ��ס�� WHERE ��ס���� = @��ס����
--ס����
SELECT @TOTAL = 0
SELECT @TOTAL = @TOTAL*(ISNULL(��ס�۸�,0)+ISNULL(�Ӵ��۸�,0))
FROM ��ס�� WHERE ��ס���� = @��ס����
--���ѽ��
SELECT @TOTAL = @TOTAL+ISNULL(B.���ѽ��,0) FROM
(SELECT SUM(���ѽ��) AS ���ѽ�� FROM �ʵ���ϸ
WHERE ��ס���� = @��ס����) AS B
--����Ӧ���ʿ�ͽ�����
UPDATE ��ס�� SET Ӧ���ʿ� = @TOTAL,
���ʽ�� = @TOTAL - ISNULL(Ԥ�տ�,0)
WHERE ��ס���� = @��ס����
COMMIT
GO