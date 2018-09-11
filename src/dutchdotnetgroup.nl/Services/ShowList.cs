// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using dutchdotnetgroup.nl.Models;

namespace dutchdotnetgroup.nl.Services
{
    public class ShowList
    {
        public IList<Show> PreviousShows { get; set; }

        public string MoreShowsUrl { get; set; }
    }
}
