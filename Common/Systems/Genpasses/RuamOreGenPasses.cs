using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using GreatForger.Content.Tiles;

namespace GreatForger.Common.Systems.Genpasses
{
    internal class RuamOreGenPasses : GenPass
    {
        public RuamOreGenPasses(string name, float weight): base(name, weight) { }
        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning Ruam Ores";

            // RuamOre
            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY* 6E-05);
            for (int i =0;i<maxToSpawn;i++)
            {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurface, Main.maxTilesY - 300);
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<RuamOre>());
            }
            
            
            
        }
    }
}
