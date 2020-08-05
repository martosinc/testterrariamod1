using Terraria.ID;
using Terraria.ModLoader;

namespace PlazmaMode.Items.Bars
{
	public class PlazmaBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Плазматический слиток"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Вылит из недр земли");
		}

		public override void SetDefaults() 
		{
			item.width = 400;
			item.height = 400;
			item.value = 10000;
			item.rare = 2;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.GetInstance<Items.Placeable.PlazmaOre>(), 3);
			recipe.AddTile(77);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}