using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlazmaMode.Tiles
{
    public class PlazmaOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = true; // ???
            Main.tileBlockLight[Type] = true; // Emits Light
            Main.tileSpelunker[Type] = true;
            
            drop = mod.ItemType("PlazmaOre"); // What item drops after destorying the tile
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Plazma Ore");
            AddMapEntry(new Color(95, 84, 115), name); // Colour of Tile on Map
            minPick = 100; // What power pick minimum is needed to mine this block.
        }

        // public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        // {
        //     r = 0.75f;
        //     g = 0.25f;
        //     b = 0.5f;
        // }
    }
}