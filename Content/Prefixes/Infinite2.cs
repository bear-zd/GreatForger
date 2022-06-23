using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GreatForger.Content.Prefixes
{
    internal class Infinite2 : ModPrefix
    { //this is the infinite prefix for the gun.
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
            item.autoReuse = true;
            Item Ammo = new Item(item.useAmmo);
            Ammo.consumable = false;            

        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // infinite means no cost of ammo and mana
            shootSpeedMult *= 0.6f;
        }

    }

}
