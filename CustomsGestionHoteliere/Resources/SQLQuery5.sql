CREATE TABLE [dbo].[FACTURES] (
    [idFacture]       INT  NOT NULL,
    [dataFacturation] DATE NULL,
    [montantTotal]    INT  NULL,
    [nomPlat]         varchar(20)  NULL,
    [quantiter]       INT  DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([idFacture] ASC)
);