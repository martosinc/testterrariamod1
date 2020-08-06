using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PlazmaMode.Items.Instruments
{
    public class PickaxeOfHope : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Pick Of Hope");
            Tooltip.SetDefault("Very hot on the touch and doesn't seem to be solid");
        }
        public override void SetDefaults()
        {
            //item properties
            item.damage = 27;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 14;
            item.useAnimation = 30;
            item.pick = 110;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 100000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.GetInstance<Items.Bars.PlazmaBar>(), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}