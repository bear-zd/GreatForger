using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace GreatForger.Content.Items.Accessories
{
    internal class VampireRuam : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("power of vampire! make all of your attack has the vampire effect.");
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.accessory = true;
            Item.rare = ItemRarityID.Purple;            
        }
        
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 /= 2;
        }

    }
}
