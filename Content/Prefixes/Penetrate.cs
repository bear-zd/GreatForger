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
            return false;
        }
        public override void Apply(Item item)
        {
            base.Apply(item);
        }


    }

}
