using Agglomerate.Content.Buffs;
using rail;
using System.Net.Http.Headers;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Projectiles.Minions
{
    public class StaffOfLICCMinion : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 1;
            ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.MinionSacrificable[Projectile.type] = true;
            ProjectileID.Sets.CultistIsResistantTo[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.width = 24;
            Projectile.height = 24;

            Projectile.friendly = true;
            Projectile.minion = true;
            Projectile.DamageType = DamageClass.Summon;
            Projectile.minionSlots = 1f;
            Projectile.penetrate = -1;
        }

        public override bool? CanCutTiles()
        {
            return true;
        }

        public override bool MinionContactDamage()
        {
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            if (player.dead || !player.active)
            {
                player.ClearBuff(ModContent.BuffType<StaffOfLICCBuff>());
                return;
            }

            if(owner.HasBuff(ModContent.BuffType<StaffOfLICCBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
