using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Agglomerate.Content.Items.Misc
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class ClockOfTime : ModItem
	{
        private const int NoonCutoff = 27000;
        private const int MidnightCutoff = 16200;
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.HoldUp;
			
			Item.value = Item.buyPrice(gold: 3);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item29;
			Item.autoReuse = false;
		}
        public override bool? UseItem(Player player)
        {
            //Only SinglePlayer or DedServ should change time to prevent unwanted race condition
            if (Main.netMode == NetmodeID.MultiplayerClient)
                return true;

            // Early Morning -> Noon
            if (Main.dayTime && Main.time < NoonCutoff)
                Main.SkipToTime(NoonCutoff, true);

            // Afternoon -> Dusk
            else if (Main.dayTime)
                Main.SkipToTime(0, false);

            // Early Night -> Midnight
            else if (!Main.dayTime && Main.time < MidnightCutoff)
                Main.SkipToTime(MidnightCutoff, false);

            // Late Night -> Dawn
            else if (!Main.dayTime)
                Main.SkipToTime(0, true);

            return true;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe()
				.AddIngredient(RecipeGroupID.IronBar, 10)
				.AddIngredient(ItemID.GoldBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
;		}
	}
}
