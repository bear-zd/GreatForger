﻿using System;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace GreatForger.Content.Prefixes
{
    internal class Platform : ModPrefix
    {
        public override PrefixCategory Category => PrefixCategory.Accessory;
        public override float RollChance(Item item)
        {
            return 5f;
        }
        public override bool CanRoll(Item item)
        {
            return false;
        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // infinite means no cost of ammo as it will not decrease a lot as it always not important while fighe 
            knockbackMult *= 1.1f;
            damageMult *= 1.15f;
            shootSpeedMult *= 1.05f;
        }   
    }
}
