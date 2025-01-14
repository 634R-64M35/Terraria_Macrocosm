using Macrocosm.Content.Items.Materials.Chunks;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Macrocosm.Content.Items.Materials
{
    public class LuminiteCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 100;
            Item.rare = ItemRarityID.Blue;
            // Set other Item.X values here
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.LunarBar, 5)
                .AddIngredient<SidusChunk>(10)
                .AddIngredient<NubisChunk>(10)
                .AddIngredient<CinisChunk>(10)
                .AddIngredient<TurbenChunk>(10)
                .AddIngredient<CosmicEssence>(3)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}