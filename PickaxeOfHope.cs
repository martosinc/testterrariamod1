using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
    public class PickaxeOfHope : ModItem
    {
        public override void SetDefaults()
        {
            //item properties
            item.name = "Pick Of Hope";
            item.damage = 35;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.toolTip = "Very hot on the touch and doesn't seem to be solid";
            item.useTime = 50;
            item.useAnimation = 10;
            item.pick = 110;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = 100000;
            item.rare = 4;
            item.useSound = 1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod)
            recipe.AddIngredient(ModContent.GetInstance<Items.Bars.PlazmaBar>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}