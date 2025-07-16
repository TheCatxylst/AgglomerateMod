using Agglomerate.Content.Items.Ingredients;
using Agglomerate.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Misc
{
    public class EstrogenPill : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.noMelee = true;

            Item.value = Item.buyPrice(gold: 5);
            Item.rare = ItemRarityID.Pink;

            Item.buffType = ModContent.BuffType<EstrogenPillBuff>();
            Item.buffTime = 3600; // 1 minute

            Item.useStyle = ItemUseStyleID.EatFood;
            Item.autoReuse = false;
            Item.consumable = true;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.UseSound = SoundID.Item58;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe()
                .AddIngredient(ItemID.PinkDye, 2)
                .AddIngredient(ItemID.LifeFruit, 1)
                .AddIngredient<Gelatin>(5)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
