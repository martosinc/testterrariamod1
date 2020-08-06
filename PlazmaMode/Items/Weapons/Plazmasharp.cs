using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace PlazmaMode.Items.Weapons
{
    public class Plazmasharp : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plazmasharp");
            Tooltip.SetDefault("How the hell did you make a sword made out of hotdogs with items that aren't even hotdogs?");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.knockBack = 6f;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.melee = true;
            item.autoReuse = true;
            item.value = 5000;
            item.rare = 2;
            item.shootSpeed = 10f;
            item.shoot = ModContent.ProjectileType<Projectiles.PlazmaBeam>();
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.GetInstance<Items.Bars.PlazmaBar>(), 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}