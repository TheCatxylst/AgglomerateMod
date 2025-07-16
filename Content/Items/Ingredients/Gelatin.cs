using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Ingredients
{
    internal class Gelatin : ModItem
    {
        //https://tconfig.fandom.com/wiki/Sprite_Making_for_the_Artistically_Challenged
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.maxStack = 9999;
            Item.value = Item.buyPrice(silver: 5);
            Item.rare = ItemRarityID.Gray;

            Item.useStyle = ItemUseStyleID.None;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe()
                .AddIngredient(ItemID.Seashell, 3)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
