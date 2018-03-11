using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Lethargic : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Lethargic");
			Description.SetDefault("Your weapons are feeling sluggish.");
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
           //all item speed reduced to 50%
		   player.GetModPlayer<FargoPlayer>(mod).lethargic = true;
        }
	}
}
