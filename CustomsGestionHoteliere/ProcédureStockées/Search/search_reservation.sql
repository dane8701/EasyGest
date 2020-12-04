CREATE PROCEDURE search_reservation
    @CLIENTSidClient INT
AS
SELECT * from RESERVATIONS
where CLIENTSidClient =  @CLIENTSidClient