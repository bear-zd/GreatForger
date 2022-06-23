using System;
using Terraria;
using Terraria.ModLoader;

namespace GreatForger.Content.Prefixes
{
    internal class Infinite : ModPrefix
    { //this is the infinite prefix for the Magic.
        public override PrefixCategory Category => PrefixCategory.Magic;


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
            Random ran = new Random();
            // will generate more high quality debuff
            int numDebuff = ran.Next(1, 3);

            
            // infinite means no cost of ammo and mana
            manaMult *= 0;
            shootSpeedMult *= 0.4f;
        }

    }

}
