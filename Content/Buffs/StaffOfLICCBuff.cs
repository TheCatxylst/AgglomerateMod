using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Buffs
{
    public class StaffOfLICCBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            /*
            if (player.ownedProjectileCounts[ModContent.ProjectileType<>] > 0)
            {
                player.buffTime[buffIndex] = 999999;
                return;
            }
            */
            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}
