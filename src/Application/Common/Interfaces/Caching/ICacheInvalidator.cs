// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CleanArchitecture.Blazor.Application.Common.Interfaces.Caching;

public interface ICacheInvalidator
{
    string CacheKey { get; }
    CancellationTokenSource ResetCacheToken { get; }
}
