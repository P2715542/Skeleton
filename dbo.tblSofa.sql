CREATE TABLE [dbo].[tblSofa] (
    [SofaId]          INT          NOT NULL,
    [SofaDescription] TEXT         NULL,
    [SofaColour]      TEXT         NOT NULL,
    [SupplierId]      INT          NOT NULL,
    [Price]           DECIMAL (18) NOT NULL,
    [Available]       BIT          NOT NULL,
    [DateAdded]       DATE         NULL,
    PRIMARY KEY CLUSTERED ([SofaId] ASC)
);

