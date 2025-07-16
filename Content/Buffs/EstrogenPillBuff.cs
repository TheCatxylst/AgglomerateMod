using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Misc
{
    internal class EstrogenPillBuff : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }
        

        public void Update(Player player, ref int buffIndex)
        {
            player.immune = true; // Makes the player immune to damage while under the effect of this buff
        }
    }
}
