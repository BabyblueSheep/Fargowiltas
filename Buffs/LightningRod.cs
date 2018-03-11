using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Fargowiltas.Buffs
{
	public class LightningRod : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Lightning Rod");
			Description.SetDefault("You attract thunderbolts");
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

		private void SpawnLightning(Player player)
		{
			//tends to spawn in ceilings if the player goes indoors/underground
			Point tileCoordinates = player.Top.ToTileCoordinates();

			tileCoordinates.X += Main.rand.Next(-25, 25);
			tileCoordinates.Y -= 15 + Main.rand.Next(-5, 5);

			for (int index = 0; index < 10 && !WorldGen.SolidTile((int) tileCoordinates.X, (int) tileCoordinates.Y) && tileCoordinates.Y > 10; ++index)
			{
				tileCoordinates.Y -= 1;
			}

			Projectile.NewProjectile((float) (tileCoordinates.X * 16 + 8), (float) (tileCoordinates.Y * 16 + 17), 0f, 0f, 578, 0, 1f, Main.myPlayer);
		}

		public override void Update(Player player, ref int buffIndex)
        {
			//spawns lightning once per second with a 1/60 chance of spawning another every tick
			if(player.buffTime[buffIndex] % 60 == 0)
				SpawnLightning(player);

			if(Main.rand.Next(60) == 1)
				SpawnLightning(player);
        }
	}
}
