CREATE PROCEDURE search_table
    @idTable INT
AS
SELECT * from TABLES
where idTable =  @idTable