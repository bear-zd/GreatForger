using System;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace GreatForger.Content.Prefixes
{
    internal class Infinite : ModPrefix
    { //this is the infinite prefix for the Magic.
        public override PrefixCategory Category => PrefixCategory.Magic;


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
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // infinite means no cost of mana, in contraty, it will not gain the better effect of the magic weapon.
            manaMult *= 0f;
            // knockbackMult *= 0.9f;
            damageMult *= 0.9f;
            // useTimeMult *= 0.95f;
            base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
        }

    }

}
