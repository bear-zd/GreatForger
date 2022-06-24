using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using GreatForger.Content.Prefixes;
using GreatForger.Common.GlobalItems;

namespace GreatForger.Common.GlobalProjectiles
{
    internal class PenerateProjectiles : GlobalProjectile
    {
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return false;
        }
        
    }
}
