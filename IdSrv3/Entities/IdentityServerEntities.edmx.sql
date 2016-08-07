
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/14/2016 16:51:55
-- Generated from EDMX file: C:\TFS\IdentityServer3\IdentityServer3\IdSrv3\Entities\IdentityServerEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_ClientClaims_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientClaims] DROP CONSTRAINT [FK_dbo_ClientClaims_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientCorsOrigins_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientCorsOrigins] DROP CONSTRAINT [FK_dbo_ClientCorsOrigins_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientCustomGrantTypes_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientCustomGrantTypes] DROP CONSTRAINT [FK_dbo_ClientCustomGrantTypes_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientIdPRestrictions_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientIdPRestrictions] DROP CONSTRAINT [FK_dbo_ClientIdPRestrictions_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientPostLogoutRedirectUris_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientPostLogoutRedirectUris] DROP CONSTRAINT [FK_dbo_ClientPostLogoutRedirectUris_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientRedirectUris_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientRedirectUris] DROP CONSTRAINT [FK_dbo_ClientRedirectUris_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientScopes_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientScopes] DROP CONSTRAINT [FK_dbo_ClientScopes_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ClientSecrets_dbo_Clients_Client_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientSecrets] DROP CONSTRAINT [FK_dbo_ClientSecrets_dbo_Clients_Client_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_GroupChilds_dbo_Groups_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupChilds] DROP CONSTRAINT [FK_dbo_GroupChilds_dbo_Groups_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_LinkedAccountClaims_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LinkedAccountClaims] DROP CONSTRAINT [FK_dbo_LinkedAccountClaims_dbo_UserAccounts_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_LinkedAccounts_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LinkedAccounts] DROP CONSTRAINT [FK_dbo_LinkedAccounts_dbo_UserAccounts_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_PasswordResetSecrets_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PasswordResetSecrets] DROP CONSTRAINT [FK_dbo_PasswordResetSecrets_dbo_UserAccounts_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ScopeClaims_dbo_Scopes_Scope_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScopeClaims] DROP CONSTRAINT [FK_dbo_ScopeClaims_dbo_Scopes_Scope_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ScopeSecrets_dbo_Scopes_Scope_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScopeSecrets] DROP CONSTRAINT [FK_dbo_ScopeSecrets_dbo_Scopes_Scope_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_TwoFactorAuthTokens_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TwoFactorAuthTokens] DROP CONSTRAINT [FK_dbo_TwoFactorAuthTokens_dbo_UserAccounts_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UserCertificates_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCertificates] DROP CONSTRAINT [FK_dbo_UserCertificates_dbo_UserAccounts_ParentKey];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_UserClaims_dbo_UserAccounts_ParentKey]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserClaims] DROP CONSTRAINT [FK_dbo_UserClaims_dbo_UserAccounts_ParentKey];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[ClientClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientClaims];
GO
IF OBJECT_ID(N'[dbo].[ClientCorsOrigins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientCorsOrigins];
GO
IF OBJECT_ID(N'[dbo].[ClientCustomGrantTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientCustomGrantTypes];
GO
IF OBJECT_ID(N'[dbo].[ClientIdPRestrictions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientIdPRestrictions];
GO
IF OBJECT_ID(N'[dbo].[ClientPostLogoutRedirectUris]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientPostLogoutRedirectUris];
GO
IF OBJECT_ID(N'[dbo].[ClientRedirectUris]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientRedirectUris];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[ClientScopes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientScopes];
GO
IF OBJECT_ID(N'[dbo].[ClientSecrets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientSecrets];
GO
IF OBJECT_ID(N'[dbo].[Consents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consents];
GO
IF OBJECT_ID(N'[dbo].[GroupChilds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupChilds];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[LinkedAccountClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LinkedAccountClaims];
GO
IF OBJECT_ID(N'[dbo].[LinkedAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LinkedAccounts];
GO
IF OBJECT_ID(N'[dbo].[PasswordResetSecrets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PasswordResetSecrets];
GO
IF OBJECT_ID(N'[dbo].[ScopeClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScopeClaims];
GO
IF OBJECT_ID(N'[dbo].[Scopes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Scopes];
GO
IF OBJECT_ID(N'[dbo].[ScopeSecrets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScopeSecrets];
GO
IF OBJECT_ID(N'[dbo].[Tokens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tokens];
GO
IF OBJECT_ID(N'[dbo].[TwoFactorAuthTokens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TwoFactorAuthTokens];
GO
IF OBJECT_ID(N'[dbo].[UserAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserAccounts];
GO
IF OBJECT_ID(N'[dbo].[UserCertificates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCertificates];
GO
IF OBJECT_ID(N'[dbo].[UserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserClaims];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'ClientClaims'
CREATE TABLE [dbo].[ClientClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(250)  NOT NULL,
    [Value] nvarchar(250)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientCorsOrigins'
CREATE TABLE [dbo].[ClientCorsOrigins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Origin] nvarchar(150)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientCustomGrantTypes'
CREATE TABLE [dbo].[ClientCustomGrantTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GrantType] nvarchar(250)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientIdPRestrictions'
CREATE TABLE [dbo].[ClientIdPRestrictions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Provider] nvarchar(200)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientPostLogoutRedirectUris'
CREATE TABLE [dbo].[ClientPostLogoutRedirectUris] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Uri] nvarchar(2000)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientRedirectUris'
CREATE TABLE [dbo].[ClientRedirectUris] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Uri] nvarchar(2000)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Enabled] bit  NOT NULL,
    [ClientId] nvarchar(200)  NOT NULL,
    [ClientName] nvarchar(200)  NOT NULL,
    [ClientUri] nvarchar(2000)  NULL,
    [LogoUri] nvarchar(max)  NULL,
    [RequireConsent] bit  NOT NULL,
    [AllowRememberConsent] bit  NOT NULL,
    [AllowAccessTokensViaBrowser] bit  NOT NULL,
    [Flow] int  NOT NULL,
    [AllowClientCredentialsOnly] bit  NOT NULL,
    [LogoutUri] nvarchar(max)  NULL,
    [LogoutSessionRequired] bit  NOT NULL,
    [RequireSignOutPrompt] bit  NOT NULL,
    [AllowAccessToAllScopes] bit  NOT NULL,
    [IdentityTokenLifetime] int  NOT NULL,
    [AccessTokenLifetime] int  NOT NULL,
    [AuthorizationCodeLifetime] int  NOT NULL,
    [AbsoluteRefreshTokenLifetime] int  NOT NULL,
    [SlidingRefreshTokenLifetime] int  NOT NULL,
    [RefreshTokenUsage] int  NOT NULL,
    [UpdateAccessTokenOnRefresh] bit  NOT NULL,
    [RefreshTokenExpiration] int  NOT NULL,
    [AccessTokenType] int  NOT NULL,
    [EnableLocalLogin] bit  NOT NULL,
    [IncludeJwtId] bit  NOT NULL,
    [AlwaysSendClientClaims] bit  NOT NULL,
    [PrefixClientClaims] bit  NOT NULL,
    [AllowAccessToAllGrantTypes] bit  NOT NULL
);
GO

-- Creating table 'ClientScopes'
CREATE TABLE [dbo].[ClientScopes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Scope] nvarchar(200)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientSecrets'
CREATE TABLE [dbo].[ClientSecrets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(250)  NOT NULL,
    [Type] nvarchar(250)  NULL,
    [Description] nvarchar(2000)  NULL,
    [Expiration] datetimeoffset  NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'Consents'
CREATE TABLE [dbo].[Consents] (
    [Subject] nvarchar(200)  NOT NULL,
    [ClientId] nvarchar(200)  NOT NULL,
    [Scopes] nvarchar(2000)  NOT NULL
);
GO

-- Creating table 'GroupChilds'
CREATE TABLE [dbo].[GroupChilds] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [ChildGroupID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL,
    [ID] uniqueidentifier  NOT NULL,
    [Tenant] nvarchar(50)  NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Created] datetime  NOT NULL,
    [LastUpdated] datetime  NOT NULL
);
GO

-- Creating table 'LinkedAccountClaims'
CREATE TABLE [dbo].[LinkedAccountClaims] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [ProviderName] nvarchar(30)  NOT NULL,
    [ProviderAccountID] nvarchar(100)  NOT NULL,
    [Type] nvarchar(150)  NOT NULL,
    [Value] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'LinkedAccounts'
CREATE TABLE [dbo].[LinkedAccounts] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [ProviderName] nvarchar(30)  NOT NULL,
    [ProviderAccountID] nvarchar(100)  NOT NULL,
    [LastLogin] datetime  NOT NULL
);
GO

-- Creating table 'PasswordResetSecrets'
CREATE TABLE [dbo].[PasswordResetSecrets] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [PasswordResetSecretID] uniqueidentifier  NOT NULL,
    [Question] nvarchar(150)  NOT NULL,
    [Answer] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'ScopeClaims'
CREATE TABLE [dbo].[ScopeClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Description] nvarchar(1000)  NULL,
    [AlwaysIncludeInIdToken] bit  NOT NULL,
    [Scope_Id] int  NOT NULL
);
GO

-- Creating table 'Scopes'
CREATE TABLE [dbo].[Scopes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Enabled] bit  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [DisplayName] nvarchar(200)  NULL,
    [Description] nvarchar(1000)  NULL,
    [Required] bit  NOT NULL,
    [Emphasize] bit  NOT NULL,
    [Type] int  NOT NULL,
    [IncludeAllClaimsForUser] bit  NOT NULL,
    [ClaimsRule] nvarchar(200)  NULL,
    [ShowInDiscoveryDocument] bit  NOT NULL,
    [AllowUnrestrictedIntrospection] bit  NOT NULL
);
GO

-- Creating table 'ScopeSecrets'
CREATE TABLE [dbo].[ScopeSecrets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(1000)  NULL,
    [Expiration] datetimeoffset  NULL,
    [Type] nvarchar(250)  NULL,
    [Value] nvarchar(250)  NOT NULL,
    [Scope_Id] int  NOT NULL
);
GO

-- Creating table 'Tokens'
CREATE TABLE [dbo].[Tokens] (
    [Key] nvarchar(128)  NOT NULL,
    [TokenType] smallint  NOT NULL,
    [SubjectId] nvarchar(200)  NULL,
    [ClientId] nvarchar(200)  NOT NULL,
    [JsonCode] nvarchar(max)  NOT NULL,
    [Expiry] datetimeoffset  NOT NULL
);
GO

-- Creating table 'TwoFactorAuthTokens'
CREATE TABLE [dbo].[TwoFactorAuthTokens] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [Token] nvarchar(100)  NOT NULL,
    [Issued] datetime  NOT NULL
);
GO

-- Creating table 'UserAccounts'
CREATE TABLE [dbo].[UserAccounts] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Age] int  NULL,
    [ID] uniqueidentifier  NOT NULL,
    [Tenant] nvarchar(50)  NOT NULL,
    [Username] nvarchar(254)  NOT NULL,
    [Created] datetime  NOT NULL,
    [LastUpdated] datetime  NOT NULL,
    [IsAccountClosed] bit  NOT NULL,
    [AccountClosed] datetime  NULL,
    [IsLoginAllowed] bit  NOT NULL,
    [LastLogin] datetime  NULL,
    [LastFailedLogin] datetime  NULL,
    [FailedLoginCount] int  NOT NULL,
    [PasswordChanged] datetime  NULL,
    [RequiresPasswordReset] bit  NOT NULL,
    [Email] nvarchar(254)  NULL,
    [IsAccountVerified] bit  NOT NULL,
    [LastFailedPasswordReset] datetime  NULL,
    [FailedPasswordResetCount] int  NOT NULL,
    [MobileCode] nvarchar(100)  NULL,
    [MobileCodeSent] datetime  NULL,
    [MobilePhoneNumber] nvarchar(20)  NULL,
    [MobilePhoneNumberChanged] datetime  NULL,
    [AccountTwoFactorAuthMode] int  NOT NULL,
    [CurrentTwoFactorAuthStatus] int  NOT NULL,
    [VerificationKey] nvarchar(100)  NULL,
    [VerificationPurpose] int  NULL,
    [VerificationKeySent] datetime  NULL,
    [VerificationStorage] nvarchar(100)  NULL,
    [HashedPassword] nvarchar(200)  NULL
);
GO

-- Creating table 'UserCertificates'
CREATE TABLE [dbo].[UserCertificates] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [Thumbprint] nvarchar(150)  NOT NULL,
    [Subject] nvarchar(250)  NULL
);
GO

-- Creating table 'UserClaims'
CREATE TABLE [dbo].[UserClaims] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [ParentKey] int  NOT NULL,
    [Type] nvarchar(150)  NOT NULL,
    [Value] nvarchar(150)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'ClientClaims'
ALTER TABLE [dbo].[ClientClaims]
ADD CONSTRAINT [PK_ClientClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientCorsOrigins'
ALTER TABLE [dbo].[ClientCorsOrigins]
ADD CONSTRAINT [PK_ClientCorsOrigins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientCustomGrantTypes'
ALTER TABLE [dbo].[ClientCustomGrantTypes]
ADD CONSTRAINT [PK_ClientCustomGrantTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientIdPRestrictions'
ALTER TABLE [dbo].[ClientIdPRestrictions]
ADD CONSTRAINT [PK_ClientIdPRestrictions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientPostLogoutRedirectUris'
ALTER TABLE [dbo].[ClientPostLogoutRedirectUris]
ADD CONSTRAINT [PK_ClientPostLogoutRedirectUris]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientRedirectUris'
ALTER TABLE [dbo].[ClientRedirectUris]
ADD CONSTRAINT [PK_ClientRedirectUris]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientScopes'
ALTER TABLE [dbo].[ClientScopes]
ADD CONSTRAINT [PK_ClientScopes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientSecrets'
ALTER TABLE [dbo].[ClientSecrets]
ADD CONSTRAINT [PK_ClientSecrets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Subject], [ClientId] in table 'Consents'
ALTER TABLE [dbo].[Consents]
ADD CONSTRAINT [PK_Consents]
    PRIMARY KEY CLUSTERED ([Subject], [ClientId] ASC);
GO

-- Creating primary key on [Key] in table 'GroupChilds'
ALTER TABLE [dbo].[GroupChilds]
ADD CONSTRAINT [PK_GroupChilds]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'LinkedAccountClaims'
ALTER TABLE [dbo].[LinkedAccountClaims]
ADD CONSTRAINT [PK_LinkedAccountClaims]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'LinkedAccounts'
ALTER TABLE [dbo].[LinkedAccounts]
ADD CONSTRAINT [PK_LinkedAccounts]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'PasswordResetSecrets'
ALTER TABLE [dbo].[PasswordResetSecrets]
ADD CONSTRAINT [PK_PasswordResetSecrets]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Id] in table 'ScopeClaims'
ALTER TABLE [dbo].[ScopeClaims]
ADD CONSTRAINT [PK_ScopeClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Scopes'
ALTER TABLE [dbo].[Scopes]
ADD CONSTRAINT [PK_Scopes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScopeSecrets'
ALTER TABLE [dbo].[ScopeSecrets]
ADD CONSTRAINT [PK_ScopeSecrets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Key], [TokenType] in table 'Tokens'
ALTER TABLE [dbo].[Tokens]
ADD CONSTRAINT [PK_Tokens]
    PRIMARY KEY CLUSTERED ([Key], [TokenType] ASC);
GO

-- Creating primary key on [Key] in table 'TwoFactorAuthTokens'
ALTER TABLE [dbo].[TwoFactorAuthTokens]
ADD CONSTRAINT [PK_TwoFactorAuthTokens]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'UserAccounts'
ALTER TABLE [dbo].[UserAccounts]
ADD CONSTRAINT [PK_UserAccounts]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'UserCertificates'
ALTER TABLE [dbo].[UserCertificates]
ADD CONSTRAINT [PK_UserCertificates]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [Key] in table 'UserClaims'
ALTER TABLE [dbo].[UserClaims]
ADD CONSTRAINT [PK_UserClaims]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_Id] in table 'ClientClaims'
ALTER TABLE [dbo].[ClientClaims]
ADD CONSTRAINT [FK_dbo_ClientClaims_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientClaims_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientClaims_dbo_Clients_Client_Id]
ON [dbo].[ClientClaims]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientCorsOrigins'
ALTER TABLE [dbo].[ClientCorsOrigins]
ADD CONSTRAINT [FK_dbo_ClientCorsOrigins_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientCorsOrigins_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientCorsOrigins_dbo_Clients_Client_Id]
ON [dbo].[ClientCorsOrigins]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientCustomGrantTypes'
ALTER TABLE [dbo].[ClientCustomGrantTypes]
ADD CONSTRAINT [FK_dbo_ClientCustomGrantTypes_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientCustomGrantTypes_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientCustomGrantTypes_dbo_Clients_Client_Id]
ON [dbo].[ClientCustomGrantTypes]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientIdPRestrictions'
ALTER TABLE [dbo].[ClientIdPRestrictions]
ADD CONSTRAINT [FK_dbo_ClientIdPRestrictions_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientIdPRestrictions_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientIdPRestrictions_dbo_Clients_Client_Id]
ON [dbo].[ClientIdPRestrictions]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientPostLogoutRedirectUris'
ALTER TABLE [dbo].[ClientPostLogoutRedirectUris]
ADD CONSTRAINT [FK_dbo_ClientPostLogoutRedirectUris_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientPostLogoutRedirectUris_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientPostLogoutRedirectUris_dbo_Clients_Client_Id]
ON [dbo].[ClientPostLogoutRedirectUris]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientRedirectUris'
ALTER TABLE [dbo].[ClientRedirectUris]
ADD CONSTRAINT [FK_dbo_ClientRedirectUris_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientRedirectUris_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientRedirectUris_dbo_Clients_Client_Id]
ON [dbo].[ClientRedirectUris]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientScopes'
ALTER TABLE [dbo].[ClientScopes]
ADD CONSTRAINT [FK_dbo_ClientScopes_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientScopes_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientScopes_dbo_Clients_Client_Id]
ON [dbo].[ClientScopes]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientSecrets'
ALTER TABLE [dbo].[ClientSecrets]
ADD CONSTRAINT [FK_dbo_ClientSecrets_dbo_Clients_Client_Id]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ClientSecrets_dbo_Clients_Client_Id'
CREATE INDEX [IX_FK_dbo_ClientSecrets_dbo_Clients_Client_Id]
ON [dbo].[ClientSecrets]
    ([Client_Id]);
GO

-- Creating foreign key on [ParentKey] in table 'GroupChilds'
ALTER TABLE [dbo].[GroupChilds]
ADD CONSTRAINT [FK_dbo_GroupChilds_dbo_Groups_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[Groups]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_GroupChilds_dbo_Groups_ParentKey'
CREATE INDEX [IX_FK_dbo_GroupChilds_dbo_Groups_ParentKey]
ON [dbo].[GroupChilds]
    ([ParentKey]);
GO

-- Creating foreign key on [ParentKey] in table 'LinkedAccountClaims'
ALTER TABLE [dbo].[LinkedAccountClaims]
ADD CONSTRAINT [FK_dbo_LinkedAccountClaims_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_LinkedAccountClaims_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_LinkedAccountClaims_dbo_UserAccounts_ParentKey]
ON [dbo].[LinkedAccountClaims]
    ([ParentKey]);
GO

-- Creating foreign key on [ParentKey] in table 'LinkedAccounts'
ALTER TABLE [dbo].[LinkedAccounts]
ADD CONSTRAINT [FK_dbo_LinkedAccounts_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_LinkedAccounts_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_LinkedAccounts_dbo_UserAccounts_ParentKey]
ON [dbo].[LinkedAccounts]
    ([ParentKey]);
GO

-- Creating foreign key on [ParentKey] in table 'PasswordResetSecrets'
ALTER TABLE [dbo].[PasswordResetSecrets]
ADD CONSTRAINT [FK_dbo_PasswordResetSecrets_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_PasswordResetSecrets_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_PasswordResetSecrets_dbo_UserAccounts_ParentKey]
ON [dbo].[PasswordResetSecrets]
    ([ParentKey]);
GO

-- Creating foreign key on [Scope_Id] in table 'ScopeClaims'
ALTER TABLE [dbo].[ScopeClaims]
ADD CONSTRAINT [FK_dbo_ScopeClaims_dbo_Scopes_Scope_Id]
    FOREIGN KEY ([Scope_Id])
    REFERENCES [dbo].[Scopes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ScopeClaims_dbo_Scopes_Scope_Id'
CREATE INDEX [IX_FK_dbo_ScopeClaims_dbo_Scopes_Scope_Id]
ON [dbo].[ScopeClaims]
    ([Scope_Id]);
GO

-- Creating foreign key on [Scope_Id] in table 'ScopeSecrets'
ALTER TABLE [dbo].[ScopeSecrets]
ADD CONSTRAINT [FK_dbo_ScopeSecrets_dbo_Scopes_Scope_Id]
    FOREIGN KEY ([Scope_Id])
    REFERENCES [dbo].[Scopes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ScopeSecrets_dbo_Scopes_Scope_Id'
CREATE INDEX [IX_FK_dbo_ScopeSecrets_dbo_Scopes_Scope_Id]
ON [dbo].[ScopeSecrets]
    ([Scope_Id]);
GO

-- Creating foreign key on [ParentKey] in table 'TwoFactorAuthTokens'
ALTER TABLE [dbo].[TwoFactorAuthTokens]
ADD CONSTRAINT [FK_dbo_TwoFactorAuthTokens_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TwoFactorAuthTokens_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_TwoFactorAuthTokens_dbo_UserAccounts_ParentKey]
ON [dbo].[TwoFactorAuthTokens]
    ([ParentKey]);
GO

-- Creating foreign key on [ParentKey] in table 'UserCertificates'
ALTER TABLE [dbo].[UserCertificates]
ADD CONSTRAINT [FK_dbo_UserCertificates_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UserCertificates_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_UserCertificates_dbo_UserAccounts_ParentKey]
ON [dbo].[UserCertificates]
    ([ParentKey]);
GO

-- Creating foreign key on [ParentKey] in table 'UserClaims'
ALTER TABLE [dbo].[UserClaims]
ADD CONSTRAINT [FK_dbo_UserClaims_dbo_UserAccounts_ParentKey]
    FOREIGN KEY ([ParentKey])
    REFERENCES [dbo].[UserAccounts]
        ([Key])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_UserClaims_dbo_UserAccounts_ParentKey'
CREATE INDEX [IX_FK_dbo_UserClaims_dbo_UserAccounts_ParentKey]
ON [dbo].[UserClaims]
    ([ParentKey]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------