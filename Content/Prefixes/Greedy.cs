using System;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace GreatForger.Content.Prefixes
{
    internal class Greedy : ModPrefix
    {
        public override PrefixCategory Category => PrefixCategory.AnyWeapon;


        public override float RollChance(Item item)
        {
            return 2f;
        }
        public override bool CanRoll(Item item)
        {
            return true;
        }
        public override void Apply(Item item)
        {
            base.Apply(item);
        }
    }
}
