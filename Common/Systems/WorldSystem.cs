using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using GreatForger.Common.Systems.Genpasses;

namespace GreatForger.Common.Systems
{
    internal class WorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(t => t.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new RuamOreGenPasses("Ruam Ore Pass", 320f));
            }
        }
    }
}
