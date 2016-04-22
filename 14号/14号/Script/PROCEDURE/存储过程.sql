USE 酒店管理系统
GO
CREATE PROC SF_保存入住单 @入住单号 CHAR(10)
AS
BEGIN TRAN
--修改客房信息
UPDATE 客房信息 SET 状态='住房' FROM 客房信息 AS A , 入住单 AS B
WHERE A.客房编号=B.客房编号 AND B.入住单号=@入住单号
--修改预订单状态
UPDATE 预订单 SET 单据状态 = '入住' FROM 预订单 AS A , 入住单 AS B
WHERE A.预订单号 = B.预订单号 AND B.入住单号 = @入住单号
--将已入住的 预订单放入历史
INSERT INTO 预订单历史 SELECT * FROM 预订单 WHERE 单据状态= '入住'
--清除已入住预订单
DELETE FROM 预订单 WHERE 单据状态 = '入住'
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
CREATE PROC SF_收银退房 @入住单号 CHAR(10) , @付帐方式 CHAR(20)
AS
BEGIN TRAN 
UPDATE 入住单 SET 离店时间=GETDATE(),单据状态= '离店',
付帐方式= @付帐方式 , 是否结帐=1,
结帐日期 = GETDATE()
WHERE 入住单号 = @入住单号
--设置放状
UPDATE 客房信息 SET 状态='空房' FROM 客房信息 AS A , 入住单 AS B
WHERE A.客房编号 = B.客房编号 AND B.入住单号 = @入住单号
--导入历史
INSERT INTO 入住单历史 SELECT * FROM 入住单
WHERE 入住单号 = @入住单号
INSERT INTO 帐单明细历史 SELECT * FROM 帐单明细
WHERE 入住单号 = @入住单号
DELETE FROM 帐单明细
WHERE 入住单号 = @入住单号
--清除入住单
DELETE FROM 入住单
WHERE 入住单号=@入住单号
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
CREATE PROC SF_计算应收帐款 @入住单号 CHAR(10)
AS
BEGIN TRAN
DECLARE @TOTAL DECIMAL
DECLARE @DATECOUNT INT 
--设置离店时间
UPDATE 入住单 SET 离店时间 = GETDATE() WHERE 入住单号 = @入住单号
--住店天数
SELECT @DATECOUNT = DATEDIFF(DD , 抵店时间,GETDATE())
FROM 入住单 WHERE 入住单号 = @入住单号
--住店金额
SELECT @TOTAL = 0
SELECT @TOTAL = @TOTAL*(ISNULL(入住价格,0)+ISNULL(加床价格,0))
FROM 入住单 WHERE 入住单号 = @入住单号
--消费金额
SELECT @TOTAL = @TOTAL+ISNULL(B.消费金额,0) FROM
(SELECT SUM(消费金额) AS 消费金额 FROM 帐单明细
WHERE 入住单号 = @入住单号) AS B
--设置应收帐款和结算金额
UPDATE 入住单 SET 应收帐款 = @TOTAL,
结帐金额 = @TOTAL - ISNULL(预收款,0)
WHERE 入住单号 = @入住单号
COMMIT
GO