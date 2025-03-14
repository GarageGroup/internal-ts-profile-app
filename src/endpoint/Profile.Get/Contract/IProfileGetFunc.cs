﻿using GarageGroup.Infra;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GarageGroup.Internal.Timesheet;

using static ProfileGetMetadata;

[Endpoint(EndpointMethod.Get, Func.Route, Summary = Func.Summary, Description = Func.Description)]
[EndpointTag(Func.Tag)]
public interface IProfileGetFunc
{
    ValueTask<Result<ProfileGetOut, Failure<ProfileGetFailureCode>>> InvokeAsync(
        ProfileGetIn input, CancellationToken cancellationToken);
}