using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace PlazmaMode.Items.Weapons
{
    public class RetroStyle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Retro Style");
            Tooltip.SetDefault("It's not even 1.2");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 24;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5; // Bow Use Style
            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.
            item.value = Item.buyPrice(0, 0, 10, 0); // Another way to handle value of item.
            item.rare = 2;
            item.UseSound = SoundID.Item5; // Sound for Bows
            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon
            item.shoot = 1;
            item.shootSpeed = 5f;
            item.ranged = true; // For Ranged Weapon
            item.damage = 49;
            item.knockBack = 0;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.GetInstance<Items.Bars.PlazmaBar>(), 16);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}