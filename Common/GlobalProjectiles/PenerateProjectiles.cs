using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;


namespace GreatForger.Common.GlobalProjectiles
{
    internal class PenerateProjectiles : GlobalProjectile
    {
        public static bool penertrateState = false;
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return entity.damage != -1;
        }
        
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            if (source is EntitySource_ItemUse itemUse && itemUse.Item.prefix == ModContent.PrefixType<Penetrate>())
            {
                projectile.tileCollide = false;
                if (projectile.timeLeft >=20*60*60)
                { projectile.timeLeft = 60 * 60; }
            }
        }
        
    }
}
