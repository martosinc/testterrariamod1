using Terraria.ID;
using Terraria.ModLoader;

namespace PlazmaMode.Items.Bars
{
	public class PlazmaOre : ModItem
	{
        public override void SetDefaults() {
            item.name = "Плазматическая руда";
            item.width = 12;
            item.height = 12;
            item.tooltip = "Из самых жарких мест планеты";
            item.useTime = 20;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
	}
}