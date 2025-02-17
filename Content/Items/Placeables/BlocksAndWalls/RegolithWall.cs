using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;

namespace Macrocosm.Content.Items.Placeables.BlocksAndWalls {
	public class RegolithWall : ModItem {
		public override void SetStaticDefaults() {
			
		}

		public override void SetDefaults() {
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 7;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createWall = WallType<Walls.RegolithWall>();
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Regolith>()
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}