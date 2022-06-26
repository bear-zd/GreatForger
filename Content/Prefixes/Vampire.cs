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
            return 2f;
        }
        public override bool CanRoll(Item item)
        {
            return true;
        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // infinite means no cost of mana, in contraty, it will not gain the better effect of the magic weapon.
            damageMult *= 0.8f;
            useTimeMult *= 0.8f;
            base.SetStats(ref damageMult, ref knockbackMult, ref useTimeMult, ref scaleMult, ref shootSpeedMult, ref manaMult, ref critBonus);
        }

    }
}
