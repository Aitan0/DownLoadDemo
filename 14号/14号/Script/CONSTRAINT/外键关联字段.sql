USE �Ƶ����ϵͳ
GO
ALTER TABLE [DBO].[�ͷ���Ϣ] ADD
CONSTRAINT [FK_�ͷ���Ϣ_�ͷ���׼��Ϣ_���ͱ��] FOREIGN KEY
(
    [���ͱ��]
)
REFERENCES [DBO].[�ͷ���׼��Ϣ]
(
    [���ͱ��]
)
GO

ALTER TABLE [DBO].[��ס��] ADD
CONSTRAINT [FK_��ס��_�ͷ���Ϣ_�ͷ����] FOREIGN KEY
(
    [�ͷ����]
)
REFERENCES [DBO].[�ͷ���Ϣ]
(
    [�ͷ����]
)
GO

ALTER TABLE [DBO].[��ס����ʷ] ADD
CONSTRAINT [FK_��ס����ʷ_�ͷ���Ϣ_�ͷ����] FOREIGN KEY
(
    [�ͷ����]
)
REFERENCES [DBO].[�ͷ���Ϣ]
(
    [�ͷ����]
)
GO

ALTER TABLE [DBO].[�ʵ���ϸ] ADD
CONSTRAINT [FK_�ʵ���ϸ_��ס��_��ס����] FOREIGN KEY
(
    [��ס����]
)
REFERENCES [DBO].[��ס��]
(
    [��ס����]
)
GO

ALTER TABLE [DBO].[Ԥ����] ADD
CONSTRAINT [FK_Ԥ����_�ͷ���Ϣ_�ͷ����] FOREIGN KEY
(
    [�ͷ����]
)
REFERENCES [DBO].[�ͷ���Ϣ]
(
    [�ͷ����]
)
GO

ALTER TABLE [DBO].[Ԥ������ʷ] ADD
CONSTRAINT [FK_Ԥ������ʷ_�ͷ���Ϣ_�ͷ����] FOREIGN KEY
(
    [�ͷ����]
)
REFERENCES [DBO].[�ͷ���Ϣ]
(
    [�ͷ����]
)
GO