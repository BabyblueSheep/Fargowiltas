using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Summons
{
    public class MechWorm : BaseSummon
    {
        public override string Texture => "Terraria/Item_556";

        public override int Type => NPCID.TheDestroyer;

        public override string NPCName => "The Destroyer";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Some Kind of Metallic Worm");
            Tooltip.SetDefault("Summons the Destroyer");
        }

        public override bool CanUseItem(Player player)
        {
            return Main.dayTime != true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MechanicalWorm);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}