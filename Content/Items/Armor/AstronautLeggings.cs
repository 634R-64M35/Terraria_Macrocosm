// using Macrocosm.Tiles; What (what) ¿
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Macrocosm.Content.Items.Armor {
	[AutoloadEquip(EquipType.Legs)]
	public class AstronautLeggings : ModItem {
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.defense = 22;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}