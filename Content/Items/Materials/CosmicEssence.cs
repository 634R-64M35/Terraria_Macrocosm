using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Macrocosm.Content.Items.Materials
{
    public class CosmicEssence : ModItem
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
            Item.rare = 1;
            // Set other Item.X values here
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.FragmentSolar, 5)
                .AddIngredient(ItemID.FragmentVortex, 5)
                .AddIngredient(ItemID.FragmentNebula, 5)
                .AddIngredient(ItemID.FragmentStardust, 5)
                .AddIngredient<CosmicDust>(25)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}