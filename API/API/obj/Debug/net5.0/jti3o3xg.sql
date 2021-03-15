IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Haandværkere] (
    [HaandvaerkerId] int NOT NULL IDENTITY,
    [HVAnsaettelsedato] datetime2 NOT NULL,
    [HVEfternavn] nvarchar(max) NULL,
    [HVFagomraade] nvarchar(max) NULL,
    [HVFornavn] nvarchar(max) NULL,
    CONSTRAINT [PK_Haandværkere] PRIMARY KEY ([HaandvaerkerId])
);
GO

CREATE TABLE [Vaerktoejskasser] (
    [VTKId] int NOT NULL IDENTITY,
    [VTKAnskaffet] datetime2 NOT NULL,
    [VTKFabrikat] nvarchar(max) NULL,
    [VTKEjesAf] int NULL,
    [VTKModel] nvarchar(max) NULL,
    [VTKSerienummer] nvarchar(max) NULL,
    [VTKFarve] nvarchar(max) NULL,
    [EjesAfNavigationHaandvaerkerId] int NULL,
    CONSTRAINT [PK_Vaerktoejskasser] PRIMARY KEY ([VTKId]),
    CONSTRAINT [FK_Vaerktoejskasser_Haandværkere_EjesAfNavigationHaandvaerkerId] FOREIGN KEY ([EjesAfNavigationHaandvaerkerId]) REFERENCES [Haandværkere] ([HaandvaerkerId]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Vaerktøjer] (
    [VTId] bigint NOT NULL IDENTITY,
    [VTAnskaffet] datetime2 NOT NULL,
    [VTFabrikat] nvarchar(max) NULL,
    [VTModel] nvarchar(max) NULL,
    [VTSerienr] nvarchar(max) NULL,
    [VTType] nvarchar(max) NULL,
    [LiggerIvtk] int NULL,
    [LiggerIvtkNavigationVTKId] int NULL,
    CONSTRAINT [PK_Vaerktøjer] PRIMARY KEY ([VTId]),
    CONSTRAINT [FK_Vaerktøjer_Vaerktoejskasser_LiggerIvtkNavigationVTKId] FOREIGN KEY ([LiggerIvtkNavigationVTKId]) REFERENCES [Vaerktoejskasser] ([VTKId]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Vaerktoejskasser_EjesAfNavigationHaandvaerkerId] ON [Vaerktoejskasser] ([EjesAfNavigationHaandvaerkerId]);
GO

CREATE INDEX [IX_Vaerktøjer_LiggerIvtkNavigationVTKId] ON [Vaerktøjer] ([LiggerIvtkNavigationVTKId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210311143930_InitialCommit', N'5.0.3');
GO

COMMIT;
GO

