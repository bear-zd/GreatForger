using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using GreatForger.Content.Projectiles.Weapons;

namespace GreatForger.Content.Items.Weapons
{
    internal class RuamShortSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 3.5f;

            Item.rare = ItemRarityID.Purple;
            Item.value = Item.buyPrice(platinum: 1);

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<RuamShortSwordProjectile>();

        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 10)
                .AddIngredient(ModContent.ItemType<Placeables.Ruam>(), 5)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}
