using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria;

namespace Macrocosm.Content.Items.Placeables.BlocksAndWalls {
	public class SpaceshipWindowWall : ModItem {
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
			Item.createWall = WallType<Walls.SpaceshipWindowWall>();
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<SpaceshipWindow>()
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}