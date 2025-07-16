using Terraria;
using Terraria.ModLoader;

namespace Agglomerate.Content.Projectiles.Minions
{
    public class StaffOfLICCMinion : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 1;
        }
    }
}
