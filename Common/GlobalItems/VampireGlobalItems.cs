using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;
using System;

namespace GreatForger.Common.GlobalItems
{
    internal class VampireGlobalItems : GlobalItem
    {
		public override bool AppliesToEntity(Item item, bool lateInstatiation)
		{
         //
         return item.damage > -1 && item.prefix == PrefixID.Godly;

			// return item.damage > -1 && item.prefix == ModContent.PrefixType<Infinite>(); 
		}

		public override void SetDefaults(Item item)
		{
			item.StatsModifiedBy.Add(Mod); // Notify the game that we've made a functional change to this item.

			item.damage = 10000; // Change damage to 50!
		}

		public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			// Make it shoot grenades for no reason
			Projectile.NewProjectileDirect(source, player.Center, velocity * 5f, ProjectileID.Grenade, damage, knockback, player.whoAmI);
			// Returning false prevents vanilla's shooting behavior from running.
			// In this case it prevents the shortsword's blade stabbing animation, as the blade itself is a projectile.
			return false;
		}
	}
}
