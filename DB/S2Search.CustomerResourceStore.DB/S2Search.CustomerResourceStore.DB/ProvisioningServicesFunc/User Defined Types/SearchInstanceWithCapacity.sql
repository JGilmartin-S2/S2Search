﻿CREATE TYPE [ProvisioningServicesFunc].[SearchInstanceWithCapacity] AS TABLE (
    [SearchInstanceId] UNIQUEIDENTIFIER NOT NULL,
    [ServiceName]      VARCHAR (255)    NOT NULL,
    [SubscriptionId]   UNIQUEIDENTIFIER NOT NULL,
    [ResourceGroup]    VARCHAR (255)    NOT NULL,
    [Location]         VARCHAR (50)     NOT NULL,
    [PricingTier]      VARCHAR (50)     NOT NULL,
    [Replicas]         INT              NULL,
    [Partitions]       INT              NULL,
    [IsShared]         BIT              NOT NULL,
    [StorageQuotaMB]   DECIMAL (18, 2)  NOT NULL,
    [StorageUsedMB]    DECIMAL (18, 2)  NOT NULL,
    [IndexesQuota]     INT              NOT NULL,
    [IndexesUsed]      INT              NOT NULL,
    [IndexesAvailable] INT              NOT NULL,
    [IndexesReserved]  INT              NOT NULL,
    [DocumentsQuota]   INT              NOT NULL,
    [DocumentsUsed]    INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([SearchInstanceId] ASC));

