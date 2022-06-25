using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;
using GreatForger.Common.GlobalItems;
using GreatForger.Content.Items.Accessories;

namespace GreatForger.Common.GlobalProjectiles
{
    internal class VampireProjectiles : GlobalProjectile
    {
        public  static bool vampire = false;
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return entity.damage != -1;
        }
        /*
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            Player nowPlayer = Main.LocalPlayer;
            vampire = false;
            for (int i = 0; i < nowPlayer.armor.GetLength(0); i++)
            { if (nowPlayer.armor[i].type ==ModContent.ItemType<VampireRuam>())
                {
                    vampire = true;
                }
            }
            base.OnSpawn(projectile, source);
        }
        */
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            vampire = false;
            if (source is EntitySource_ItemUse itemUse && itemUse.Item.prefix == ModContent.PrefixType<Vampire>())
            {
                vampire = true;
            }
        }
        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            if (vampire == true)
            { projectile.vampireHeal(projectile.damage, target.position, target); }
            base.OnHitNPC(projectile, target, damage, knockback, crit);
        }
    }
}
