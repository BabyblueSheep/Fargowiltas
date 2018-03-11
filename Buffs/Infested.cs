using Terraria;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class Infested : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Infested");
			Description.SetDefault("This can only get worse.");
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
            FargoPlayer p = player.GetModPlayer<FargoPlayer>(mod);

            //weak DOT that grows exponentially stronger
            if (p.firstInfection)
            {
                p.maxInfestTime = player.buffTime[buffIndex];
                p.firstInfection = false;
            }
            
            p.infested = true;
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            return true;
        }
    }
}
