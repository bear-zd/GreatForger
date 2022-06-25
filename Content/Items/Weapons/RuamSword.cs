using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;

namespace GreatForger.Content.Items.Weapons
{
    internal class RuamSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruam Sword");
            Tooltip.SetDefault("A sword made by Ruam. Shining with wonderful heart color light.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }
        public override void SetDefaults()
        {
            // hitbox
            Item.width = 32;
            Item.height = 32;

            // animation type
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            // damage values
            Item.DamageType = DamageClass.Melee;
 
            Item.damage = 20;
            Item.knockBack = 3.5f;
            Item.crit = 5;

            // misc
            Item.value = Item.buyPrice(platinum: 10);
            Item.rare = ItemRarityID.Purple;

            // sound
            Item.UseSound = SoundID.Item1;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 10)
                .AddIngredient(ModContent.ItemType<Placeables.Ruam>(), 8)
                .AddTile(TileID.DemonAltar)
                .Register();

        }
        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            damage = new StatModifier(1f, 2 * player.statLife / player.statLifeMax2);
            base.ModifyWeaponDamage(player, ref damage);
        }
    }
    
}
