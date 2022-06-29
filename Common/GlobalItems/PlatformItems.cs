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
    {/*
        public static bool genPlatform = false;
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
            if (player.wingTime == player.wingTimeMax);
            genPlatform = true;
            if (player.wingTime == 0 && player.velocity.Y>=5f && !inUse && genPlatform)
            {
                for (int i=0 ; i < player.inventory.GetLength(0); i++)
                {
                    if (player.inventory[i].createTile > 0 && TileID.Sets.Platforms[player.inventory[i].createTile] && player.inventory[i].favorited) 
                    {
                            int x = player.Center.ToTileCoordinates().X;
                            int y = player.Center.ToTileCoordinates().Y;
                        float vy = player.velocity.Y;
                        float vx = player.velocity.X;
                        int tile = player.inventory[i].createTile;
                            x += (int)(5 / vy * vx);
                            player.inventory[i].stack -= 3;
                            // _ = WorldGen.PlaceTile(i: (int)player.Center.X, j: (int)player.Center.Y, Type: TileID.Platforms); 
                            _ = WorldGen.PlaceTile(i: x,
                                j: y + 5, Type: tile, forced: true);
                            _ = WorldGen.PlaceTile(i: x - 1,
                                j: y + 5, Type: tile, forced: true);
                            _ = WorldGen.PlaceTile(i: x + 1,
                                j: y + 5, Type: tile, forced: true);
                        genPlatform = false;
                        break;

                    }
                }                
            }
                return base.WingUpdate(wings, player, inUse);
        

        }*/
    }
}
