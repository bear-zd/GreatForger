using Terraria;
using Terraria.ModLoader;

namespace GreatForger.Content.Prefixes
{
    internal class Penetrate : ModPrefix
    {
        public override PrefixCategory Category => PrefixCategory.Ranged;


        public override float RollChance(Item item)
        {
            return 5f;
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
            // infinite means no cost of ammo and mana
            manaMult *= 0;
            damageMult *= 0.6f;
        }

    }

}
