﻿/*  
 *  This Source Code Form is subject to the terms of the Mozilla Public
 *  License, v. 2.0. If a copy of the MPL was not distributed with this
 *  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *  
 *  Copyright (C) 2021 Jaiden "398utubzyt" Garcia
*/

using Rhein.Gamemodes;

namespace Rhein.Mods
{
    /// <summary>A 1.5x speed <see cref="Mod"/>.</summary>
    public class X150Mod : X000Mod
    {
        internal override void ApplyDefaults()
        {
            Type = 19;
            Speed = 1.5f;
        }
    }
}
