using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Agglomerate.Content.Items.Weapons.Summon
{
    public class StaffOfLICC : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;

            Item.useTime = 20;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Summon;
            Item.damage = 20;
            Item.knockBack = 0;
            Item.mana = 0;
            Item.noMelee = true;

            Item.value = Item.buyPrice(gold: 1);

            //Item.shoot
            //Item.buffType
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            position = Main.MouseWorld;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.AddBuff(Item.buffType, 2);

            var projectile = Projectile.NewProjectileDirect(source, position, velocity, type, damage, Main.myPlayer);
            projectile.originalDamage = Item.damage;

            return false;
        }
    }
}
