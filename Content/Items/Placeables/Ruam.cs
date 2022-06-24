using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace GreatForger.Content.Items.Placeables
{
    internal class Ruam : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruam");
            Tooltip.SetDefault("A gem similar to Heart called Ruam.");
            //using in Journey mode when you develop a item and the number needed to sacrifice it.
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 59;
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.buyPrice(gold: 20);
            Item.maxStack = 99;
            Item.consumable = true;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.Ruam>();
            Item.placeStyle = 0;

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<RuamOre>(), 3)
                .AddTile(TileID.Stone)
                .Register();
        }
    }
}
