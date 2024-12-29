﻿//-----------------------------------------------------------------------
// <copiright file="DistributionPart.cs">
//      Copyright (c) 2024 Damache Kamil, Ziani Racim, Chaput Denis. All rights reserved.
// </copyright>
// <author> Damache Kamil, Ziani Racim, Chaput Denis </author>
//-----------------------------------------------------------------------

namespace AppLidra.Shared.Models
{
    public class DistributionPart(string name, double share)
    {
        public string Name { get; set; } = name;
        public double Share { get; set; } = share;
    }
}