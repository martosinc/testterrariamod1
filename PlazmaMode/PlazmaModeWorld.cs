using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace PlazmaMode {
    public class PlazmaModeWorld : ModWorld {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1) {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Plazma Mode Ores", OreGeneration));            
            }
        }
        private void OreGeneration(GenerationProgress progress) {
            progress.Message = "Generating Modded Ores!";
            for(int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00006); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh-1050, Main.maxTilesY);
                WorldGen.TileRunner(
                    x,
                    y,
                    (double)WorldGen.genRand.Next(5, 15),
                    WorldGen.genRand.Next(6,8),
                    mod.TileType("PlazmaOreTile"),
                    false,
                    0f,
                    0f,
                    false,
                    true
                );
            }
        }
    }
}