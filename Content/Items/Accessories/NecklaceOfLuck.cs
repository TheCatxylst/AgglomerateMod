using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Accessories
{
    internal class NecklaceOfLuck : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetCritChance(DamageClass.Generic) += 50F; //Increases crit chance by 50%
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe()
                .AddIngredient(ItemID.SharkToothNecklace, 1)
                .AddIngredient(ItemID.LuckPotionGreater, 1)
                .AddIngredient(RecipeGroupID.IronBar, 3)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
