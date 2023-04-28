USE [test]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_IntReal2Real]    Script Date: 25.4.2018 10:43:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 CREATE FUNCTION [dbo].[fn_IntReal2Real]
 (
     @intFloat int
 )    RETURNS REAL 
 AS
 
 BEGIN    
 
     DECLARE  @Mantissa REAL, 
     @Exponent SMALLINT, 
     @IntValue INT, 
     @Real2 REAL        
     
     SELECT 
         @Real2 = CAST(2.0 AS REAL), 
         @IntValue = CAST(@intFloat AS INT),            
         @Exponent = (@IntValue & 0x7f800000) / 0x00800000,            
         @Mantissa = 1.0 + (@IntValue &  0x007FFFFF) * POWER(@Real2, -23)    
         
     RETURN  SIGN(@IntValue) * @Mantissa * POWER(@Real2, @Exponent - 127)
     
 END
GO


