﻿// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using dutchdotnetgroup.nl.Models;

namespace dutchdotnetgroup.nl.Services
{
    public interface ILiveShowDetailsService
    {
        Task<LiveShowDetails> LoadAsync();

        Task SaveAsync(LiveShowDetails liveShowDetails);
    }
}
