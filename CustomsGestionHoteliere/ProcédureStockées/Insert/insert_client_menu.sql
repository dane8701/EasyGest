CREATE PROCEDURE insert_client_menu
    @CLIENTSidClient INT,
    @MENUSidMenu VARCHAR(255)
AS
INSERT INTO [CLIENTS_MENUS]
(
    [CLIENTSidClient],
    [MENUSidMenu]
)
VALUES
(
    @CLIENTSidClient,
    @MENUSidMenu
);