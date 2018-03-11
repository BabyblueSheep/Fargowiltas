using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Fargowiltas.Items.Explosives         
{
    public class Nuke : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Galactic Reformer");
			Tooltip.SetDefault("Destroys a massive area\n" +
								"Use at your own risk");
		}
        public override void SetDefaults()
        {
            item.damage = 50;     
            item.width = 10;    
            item.height = 32;  
            item.maxStack = 99;   
            item.consumable = true;  
            item.useStyle = 1;   
            item.rare = 4;     //
            item.UseSound = SoundID.Item1; //
            item.useAnimation = 20;  
            item.useTime = 20;   
            item.value = Item.buyPrice(0, 0, 3, 0); 
            item.noUseGraphic = true;
            item.noMelee = true;      
            item.shoot = mod.ProjectileType("NukeProj"); 
            item.shootSpeed = 5f; 
        }
        public override void AddRecipes()   //
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Dynamite, 999);   
			
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);   
            recipe.AddRecipe();
        }
    }
}