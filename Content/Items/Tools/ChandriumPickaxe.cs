using Macrocosm.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Macrocosm.Content.Items.Tools {
	public class ChandriumPickaxe : ModItem {
		public override void SetStaticDefaults() {
			
		}

		public override void SetDefaults() {
			Item.damage = 90;
			Item.DamageType = DamageClass.Melee;
			Item.width = 44;
			Item.height = 44;
			Item.useTime = 5;
			Item.useAnimation = 12;
			Item.pick = 250;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.tileBoost = 5;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<LuminiteCrystal>()
				.AddIngredient<ChandriumBar>(12)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}