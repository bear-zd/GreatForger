using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using static Terraria.ModLoader.ModContent;

namespace GreatForger.Content.Prefixes
{
    internal class Vampire : ModPrefix
    {
        public override PrefixCategory Category => PrefixCategory.AnyWeapon;
        public override float RollChance(Item item)
        {
            return 5f;
        }
        public override void Apply(Item item)
        { 
            base.Apply(item);
        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            shootSpeedMult *= 0.6f;
        }
    }
}
