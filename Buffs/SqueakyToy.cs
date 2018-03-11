using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class SqueakyToy : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Squeaky Toy");
			Description.SetDefault("Your attacks are squeaky toys!");
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
			//all attacks do one damage and make squeaky noises
			player.GetModPlayer<FargoPlayer>(mod).squeakyToy = true;
        }
	}
}
