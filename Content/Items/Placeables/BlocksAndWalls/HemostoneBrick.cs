using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Macrocosm.Content.Items.Placeables.BlocksAndWalls {
    public class HemostoneBrick : ModItem {
        public override void SetStaticDefaults() {
            
        }

        public override void SetDefaults() {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 750;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = TileType<Tiles.HemostoneBrick>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient<Hemostone>(2)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}