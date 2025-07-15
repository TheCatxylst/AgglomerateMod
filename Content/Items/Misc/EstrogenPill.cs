using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Misc
{
    internal class EstrogenPill : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.noMelee = true;

            Item.value = Item.buyPrice(gold: 5);
            Item.rare = ItemRarityID.Pink;

            Item.useStyle = ItemUseStyleID.EatFood;
            Item.autoReuse = false;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.UseSound = SoundID.Item58;

        }
    }
}
