using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;
using System;
namespace GreatForger.Common.GlobalItems
{
    internal class PlatformItems : GlobalItem
    {
		public override bool AppliesToEntity(Item item, bool lateInstatiation)
		{
			return item.accessory == true;
		}

		public override void SetDefaults(Item item)
		{
			item.StatsModifiedBy.Add(Mod); // Notify the game that we've made a functional change to this item.
		}
        public override bool WingUpdate(int wings, Player player, bool inUse)
        {
            if (player.wingTime == 0 && player.velocity.Y>=5f && !inUse)
            {
                int x = player.Center.ToTileCoordinates().X;
                x += (int)(5 / player.velocity.Y * player.velocity.X);
                // _ = WorldGen.PlaceTile(i: (int)player.Center.X, j: (int)player.Center.Y, Type: TileID.Platforms); 
                _ = WorldGen.PlaceTile(i:  x, 
                    j: player.Center.ToTileCoordinates().Y + 5, Type: TileID.Platforms, forced: true);                
            }
            /*
            for (int i = 0; i < Player.armor.GetLength(0); i++)
            {
                if (item.prefix == ModContent.PrefixType<Platform>() &&
                    nowPlayer.armor[i].type == item.type)
                {

                    Console.WriteLine("platform detected!");
                    if (nowPlayer.wingTime == 0)
                    {
                        Tile platformTile = new Tile();
                        platformTile.TileType = TileID.Platforms;
                        platformTile.TileFrameX = (short)nowPlayer.position.X;
                        platformTile.TileFrameY = (short)nowPlayer.position.Y;
                        _ = platformTile.HasTile;
                        Console.WriteLine("platform gen!");

                    }
                }            
            */
                return base.WingUpdate(wings, player, inUse);
        

        }
    }
}
