﻿using GarageGroup.Infra;
using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Internal.Timesheet;

internal sealed record class OpportunityJson : IProjectJson, IProjectDataverseInputBuilder
{
    private const string EntityPluralName = "opportunities";

    private const string FieldProjectName = "name";

    public static DataverseEntityGetIn BuildDataverseEntityGetIn(Guid opportunityId)
        =>
        new(
            entityPluralName: EntityPluralName,
            entityKey: new DataversePrimaryKey(opportunityId),
            selectFields: [FieldProjectName]);

    public string? GetName()
        =>
        ProjectName;

    public string GetLookupValue()
        =>
        $"/{EntityPluralName}({Id:D})";

    [JsonPropertyName($"opportunityid")]
    public Guid Id { get; init; }

    [JsonPropertyName(FieldProjectName)]
    public string? ProjectName { get; init; }
}
