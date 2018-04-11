using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Fargowiltas.NPCs
{
    public class TophatSquirrel : ModNPC
    {
		
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Top Hat Squirrel");
            Main.npcFrameCount[npc.type] = 6;
        }
		
        public override void SetDefaults()
        {
            npc.width = 50;
            npc.height = 34;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 100;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("TophatSquirrel");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			//banner = npc.type;
			//bannerItem = mod.ItemType("Banner");
			
			animationType = NPCID.Squirrel;
			npc.aiStyle = 7;
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneJungle ? 0.05f : 0f;
        }
		
		// lazy gore
		public override void HitEffect(int hitDirection, double damage)
        {
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 5, hitDirection, -1f, 0, default(Color), 1f);
				}
			}
        }
    }
}
