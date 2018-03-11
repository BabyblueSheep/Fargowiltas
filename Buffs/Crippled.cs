using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Crippled : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Crippled");
			Description.SetDefault("You cannot run.");
			Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = true;
		}
		
		public override bool Autoload(ref string name, ref string texture)
        {
            texture = "Fargowiltas/Buffs/PlaceholderDebuff";

            return true;
        }

		public override void Update(Player player, ref int buffIndex)
        {
           //disables running :v
		   player.GetModPlayer<FargoPlayer>(mod).kneecapped = true;
        }
	}
}
