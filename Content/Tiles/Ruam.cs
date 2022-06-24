using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.Localization;

namespace GreatForger.Content.Tiles
{
    internal class Ruam : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileShine[Type] = 1100;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(173, 47, 69), Language.GetText("Ruma"));
        }
        public override bool RightClick(int i, int j)
        {
            return this.Drop(i, j);
        }
        public override bool Drop(int x, int y)
        {
            
            Tile t = Main.tile[x, y];
            int style = t.TileFrameX / 10;
            int numItem = 0;
            /*
             * Player nowPlayer = Main.LocalPlayer;
            
            int lenInventory = nowPlayer.inventory.GetLength(0);
            for (int i=0;i<lenInventory;i++)
            {
                if (nowPlayer.inventory[i].type == ModContent.ItemType<Items.Placeables.Ruam>())
                {
                    numItem = nowPlayer.inventory[i].stack;
                }
            }
            */
            switch(style)
            {
                case 0: Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 16, ModContent.ItemType<Items.Placeables.Ruam>(),numItem*2);break;
                case 1:
                    break;
                case 2:
                    break;
            }
            return base.Drop(x, y);
 
        }
    }
}

