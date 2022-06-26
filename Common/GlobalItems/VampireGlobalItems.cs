using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;
using GreatForger.Content.Items.Weapons;

namespace GreatForger.Common.GlobalItems
{
    internal class VampireGlobalItems : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return entity.damage != -1;
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (item.prefix == ModContent.PrefixType<Vampire>())
            {
                Projectile vampireProjectile = new Projectile();
                vampireProjectile.vampireHeal(damage/4, target.position, target);
            }
            base.OnHitNPC(item, player, target, damage, knockBack, crit);

        }


    }
}
