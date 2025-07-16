using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Buffs //Don't copy paste like a dumbass
{
    public class EstrogenPillBuff : ModBuff //
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }
        

        public override void Update(Player player, ref int buffIndex)
        {
            player.immune = true; // Makes the player immune to damage while under the effect of this buff
        }
    }
}
