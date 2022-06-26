using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using static Terraria.ModLoader.ModContent;

namespace GreatForger.Content.Prefixes
{
    internal class Infinite2 : ModPrefix
    { //this is the infinite prefix for the gun.
        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override bool CanRoll(Item item)
        {
            return true;
        }
        public override float RollChance(Item item)
        {
            return 5f;
        }
        public override void Apply(Item item)
        {
            item.autoReuse = true;
            base.Apply(item);
        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // infinite means no cost of ammo as it will not decrease a lot as it always not important while fighe 
            knockbackMult *= 1.1f;
            damageMult *= 1.15f;
            shootSpeedMult *= 1.05f;
            base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
        }

    }

}
