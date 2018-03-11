<<<<<<< HEAD
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Fargowiltas.Projectiles
{
	public class FargoGlobalProjectile : GlobalProjectile
	{
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}
		
		public int timePass = 0;
		public int numSplits = 1;
		public int numSpeedups = 3;
		public bool ninjaTele = false;
        public bool isRecolor = false;
		
		public override void SetDefaults (Projectile projectile)
		{
			//timePass = 0;
			/*if(projectile.type == 1)
			{
				projectile.penetrate = -1;
			}*/
			
			if(projectile.type == ProjectileID.BoneJavelin || projectile.type == ProjectileID.JavelinFriendly)
			{
				projectile.thrown = true;
			}

		}		
		
		public override bool PreAI(Projectile projectile)
		{
			FargoPlayer modPlayer = Main.LocalPlayer.GetModPlayer<FargoPlayer>();

            if(modPlayer.jammed && projectile.ranged && projectile.type != ProjectileID.ConfettiGun)
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity, ProjectileID.ConfettiGun, 0, 0f);
                projectile.damage = 0;
                projectile.position = new Vector2(Main.maxTilesX);
                projectile.Kill();
            }

            if(modPlayer.atrophied && projectile.thrown)
            {
                projectile.damage = 0;
                projectile.position = new Vector2(Main.maxTilesX);
                projectile.Kill();
            }

			if (projectile.thrown && projectile.owner == Main.myPlayer)
			{
				timePass++;
				
				if(modPlayer.gladEnchant && numSpeedups > 0 && timePass % 10 == 0 )
				{
					numSpeedups--;
					projectile.velocity = Vector2.Multiply(projectile.velocity, 2);
				}
				
				if (modPlayer.throwSoul && numSplits > 0 && timePass == 20 * (1 + projectile.extraUpdates))
				{
					numSplits--;
					Projectile split = Projectile.NewProjectileDirect(projectile.Center, projectile.velocity.RotatedBy(0.3), projectile.type, projectile.damage, projectile.knockBack, projectile.owner, projectile.ai[0], projectile.ai[1]);
					split.GetGlobalProjectile<FargoGlobalProjectile>().numSplits = numSplits;
					split = Projectile.NewProjectileDirect(projectile.Center, projectile.velocity.RotatedBy(-0.3), projectile.type, projectile.damage, projectile.knockBack, projectile.owner, projectile.ai[0], projectile.ai[1]);
					split.GetGlobalProjectile<FargoGlobalProjectile>().numSplits = numSplits;
					///projectile.active = false;
					return false;
				}
			}
					
			return true;
		}
		
		public override void AI (Projectile projectile)
		{			
			Player player = Main.player[projectile.owner];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			if(projectile.type == 623)
			{
				if (!modPlayer.stardustEnchant && (player.FindBuffIndex(187) == -1))
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == mod.ProjectileType("HallowProj"))
			{
				if (!modPlayer.hallowEnchant)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == mod.ProjectileType("Chlorofuck"))
			{
				if (!modPlayer.chloroEnchant)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.DD2PetDragon && (player.FindBuffIndex(202) == -1))
			{
				if (!modPlayer.dragPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyDino && (player.FindBuffIndex(61) == -1))
			{
				if (!modPlayer.dinoPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Penguin && (player.FindBuffIndex(41) == -1))
			{
				if (!modPlayer.penguinPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabySkeletronHead && (player.FindBuffIndex(50) == -1))
			{
				if (!modPlayer.skullPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			/*if(projectile.type == ProjectileID.DD2PetGato && (player.FindBuffIndex(200) == -1))
			{
				if (!modPlayer.mythrilPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Parrot && (player.FindBuffIndex(54) == -1))
			{
				if (!modPlayer.oriPet)
				{
					projectile.Kill();
					return;
				}
			}*/
			
			if(projectile.type == ProjectileID.Puppy && (player.FindBuffIndex(91) == -1))
			{
				if (!modPlayer.dogPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyFaceMonster && (player.FindBuffIndex(154) == -1))
			{
				if (!modPlayer.crimsonPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.PetLizard && (player.FindBuffIndex(53) == -1))
			{
				if (!modPlayer.lizPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BlackCat && (player.FindBuffIndex(84) == -1))
			{
				if (!modPlayer.catPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.MiniMinotaur && (player.FindBuffIndex(136) == -1))
			{
				if (!modPlayer.minotaurPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.CursedSapling && (player.FindBuffIndex(85) == -1))
			{
				if (!modPlayer.saplingPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Squashling && (player.FindBuffIndex(82) == -1))
			{
				if (!modPlayer.pumpkinPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyEater && (player.FindBuffIndex(45) == -1))
			{
				if (!modPlayer.shadowPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Wisp && (player.FindBuffIndex(57) == -1))
			{
				if (!modPlayer.spectrePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Turtle && (player.FindBuffIndex(42) == -1))
			{
				if (!modPlayer.turtlePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabySnowman && (player.FindBuffIndex(66) == -1))
			{
				if (!modPlayer.snowmanPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.ZephyrFish && (player.FindBuffIndex(127) == -1))
			{
				if (!modPlayer.fishPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.CompanionCube && (player.FindBuffIndex(191) == -1))
			{
				if (!modPlayer.cubePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyGrinch && (player.FindBuffIndex(92) == -1))
			{
				if (!modPlayer.grinchPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.SuspiciousTentacle && (player.FindBuffIndex(190) == -1))
			{
				if (!modPlayer.suspiciousEyePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Spider && (player.FindBuffIndex(81) == -1))
			{
				if (!modPlayer.spiderPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			
			if(projectile.type == ProjectileID.BabyHornet && (player.FindBuffIndex(51) == -1))
			{
				if (!modPlayer.beePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.MagicLantern && (player.FindBuffIndex(152) == -1))
			{
				if (!modPlayer.lanternPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.ShadowOrb && (player.FindBuffIndex(19) == -1))
			{
				if (!modPlayer.shadowPet2)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.CrimsonHeart && (player.FindBuffIndex(155) == -1))
			{
				if (!modPlayer.crimsonPet2)
				{
					projectile.Kill();
					return;
				}
			}
			
		}

        public override Color? GetAlpha(Projectile projectile, Color lightColor)
        {
            if(isRecolor)
            {
                if (projectile.type == ProjectileID.HarpyFeather)
                {
                    return Color.Brown;
                }

                if(projectile.type == ProjectileID.SpikyBall)
                {
                    return Color.LimeGreen;
                }
            }
            

            return null;
        }

        public override bool CanHitPlayer(Projectile projectile, Player target)
		{
			FargoPlayer modPlayer = Main.player[projectile.owner].GetModPlayer<FargoPlayer>();
			
			//when standing still
			if (modPlayer.turtleEnchant && (double)Math.Abs(target.velocity.X) < 0.05 && (double)Math.Abs(target.velocity.Y) < 0.05 && target.itemAnimation == 0 && Main.rand.Next(3) == 0)
			{
				return false;
			}
			return true;
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
			
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);

            if(modPlayer.squeakyToy)
            {
                return;
            }

			//spawn proj on hit
			if (modPlayer.shroomEnchant && modPlayer.isStandingStill && (projectile.magic || projectile.thrown || projectile.melee || projectile.minion || projectile.ranged) && Main.rand.Next(5) == 0)
			{
				int shrooms = Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f, 0f, 590, 32/*dmg*/, 0f, projectile.owner, 0f, 0f);
				Main.projectile[shrooms].melee = false;
			}
			
			if(modPlayer.oriEnchant && projectile.magic && Main.rand.Next(6) == 0)
			{
				int[] ball = {15, 95, 253};
				int fireball = Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, ball[Main.rand.Next(3)], 32/*dmg*/, 0f, projectile.owner, 0f, 0f);
				Main.projectile[fireball].melee = false;
			}
			
			if(modPlayer.beeEnchant && Main.rand.Next(10) == 0)
			{
				Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, 181, projectile.damage / 3, 0f, projectile.owner, 0f, 0f);
			}
			
			if (projectile.minion && modPlayer.universeEffect)
			{
				target.AddBuff(BuffID.Ichor, 240, true);
				target.AddBuff(BuffID.CursedInferno, 240, true);
				target.AddBuff(BuffID.Confused, 120, true);
				target.AddBuff(BuffID.Venom, 240, true);
				target.AddBuff(BuffID.ShadowFlame, 240, true);
				target.AddBuff(BuffID.OnFire, 240, true);
				target.AddBuff(BuffID.Frostburn, 240, true);
				target.AddBuff(BuffID.Daybreak, 240, true);	
			}
			
			//coin portals
			if(modPlayer.voidSoul && target.type != NPCID.TargetDummy && Main.rand.Next(100) == 0)
			{
				Projectile.NewProjectile(target.Center.X, target.Center.Y, 0f - 10, 0f, 518, 0, 0f, projectile.owner, 0f, 0f);
			}
		}
		
		public override bool OnTileCollide (Projectile projectile, Vector2 oldVelocity)
		{
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			if(modPlayer.ninjaEnchant && projectile.type == ProjectileID.SmokeBomb && !ninjaTele)
			{
				ninjaTele = true;
				
				var teleportPos = new Vector2();
				
				teleportPos.X = projectile.position.X;
				teleportPos.Y = projectile.position.Y;
				
				//spiral out to find a save spot
				int count = 0;
				int increase = 10;
				while(Collision.SolidCollision(teleportPos, player.width, player.height))
				{
					switch(count)
					{
						case 0:
							teleportPos.X -= increase;
							break;
						case 1:
							teleportPos.X += increase * 2;
							break;
						case 2:
							teleportPos.Y += increase;
							break;
						default:
							teleportPos.Y -= increase * 2;
							increase+= 10;
							break;
					}
					count++;
					
					if(count >= 4)
					{
						count = 0;
					}
					
				}
				

				if(teleportPos.X > 50 && teleportPos.X < (double) (Main.maxTilesX * 16 - 50) && teleportPos.Y > 50 && teleportPos.Y < (double) (Main.maxTilesY * 16 - 50))
				{
					player.Teleport(teleportPos, 1);
					NetMessage.SendData(65, -1, -1, null, 0, (float) player.whoAmI, teleportPos.X, teleportPos.Y, 1);
				}
			}
			
			
			return true;
		}
		
		public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
		{
			/*Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			//reflect proj
			if (modPlayer.hallowEnchant && projectile.active && !projectile.friendly && projectile.hostile && damage > 0/* && Main.rand.Next(8) == 0)
			{
				projectile.hostile = false;
				target.statLife += damage;
				
    			//target.HealEffect(damage);
				Projectile.NewProjectile(player.Center.X, player.Center.Y, -projectile.velocity.X, -projectile.velocity.Y, 156, damage, 2f, Main.myPlayer, 0f, 0f);
				
				
			}*/
		}
		
		/*public override bool Colliding (Rectangle projHitbox, Rectangle targetHitbox)
		{
			if(projectile.projHitbox == mod.ProjectileType("DualSaberProj").projHitbox)
			{
				stuff
			}
		}*/
		
		public override void ModifyHitPlayer (Projectile projectile, Player target, ref int damage, ref bool crit)
		{
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);

            //Main.NewText(projectile.type.ToString(), 206, 12, 15);

            if (FargoWorld.masochistMode)
            {
                if (projectile.type == ProjectileID.JavelinHostile)
                {
                    target.AddBuff(mod.BuffType("Defenseless"), 600);
                    target.AddBuff(mod.BuffType("Stunned"), 90);
                }

                if (projectile.type == ProjectileID.DemonSickle)
                {
                    target.AddBuff(BuffID.Darkness, 1800);
                }

                if (projectile.type == ProjectileID.HarpyFeather && Main.rand.Next(2) == 0)
                {
                    target.AddBuff(mod.BuffType("ClippedWings"), 480);
                }

                //so only antlion sand and not falling sand 
                if (projectile.type == ProjectileID.SandBallFalling && projectile.velocity.X != 0)
                {
                    target.AddBuff(mod.BuffType("Stunned"), 120);
                }

                if(projectile.type == ProjectileID.Stinger && NPC.AnyNPCs(NPCID.QueenBee))
                {
                    target.AddBuff(BuffID.Venom, 900);
                    target.AddBuff(BuffID.BrokenArmor, 1200);
                }

                if(projectile.type == ProjectileID.Skull && Main.rand.Next(10) == 0)
                {
                    target.AddBuff(BuffID.Cursed, 360);
                }

                if (projectile.type == ProjectileID.EyeLaser && NPC.AnyNPCs(NPCID.WallofFlesh))
                {
                    target.AddBuff(BuffID.OnFire, 600);
                }
            }

			int chance = 0;
			if (modPlayer.hallowEnchant)
			{
				chance = 8;
			}
			else if(modPlayer.terrariaSoul)
			{
				chance = 2;
			}
			
			//reflect proj
			if (chance != 0 && projectile.active && !projectile.friendly && projectile.hostile && damage > 0 && Main.rand.Next(chance) == 0)
			{
				target.statLife += damage;
				
				//Projectile.NewProjectile(player.Center.X, player.Center.Y, -projectile.velocity.X, -projectile.velocity.Y, mod.ProjectileType("HallowSword"), damage, 2f, Main.myPlayer, 0f, 0f);
				
				// Set ownership
				projectile.hostile = false;
				projectile.friendly = true;
				projectile.owner = player.whoAmI;
	
				// Turn around
				projectile.velocity *= -1f;
				projectile.penetrate = 1;
	
				// Flip sprite
				if (projectile.Center.X > player.Center.X * 0.5f)
				{
					projectile.direction = 1;
					projectile.spriteDirection = 1;
				}
				else
				{
					projectile.direction = -1;
					projectile.spriteDirection = -1;
				}
	
				// Don't know if this will help but here it is
				projectile.netUpdate = true;
				
			}
		}

        public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            Player player = Main.player[Main.myPlayer];
            FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);

            if (modPlayer.squeakyToy)
            {
                return;
            }
        }
    }
=======
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Fargowiltas.Projectiles
{
	public class FargoGlobalProjectile : GlobalProjectile
	{
		public override void SetDefaults (Projectile projectile)
		{
			
					/*if(projectile.type == 1)
					{
						projectile.penetrate = -1;
					}*/

		}
		
		public override void AI (Projectile projectile)
		{
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			if(projectile.type == 623)
			{
				if (!modPlayer.stardustEnchant && (player.FindBuffIndex(187) == -1))
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == mod.ProjectileType("HallowProj"))
			{
				if (!modPlayer.hallowEnchant)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == mod.ProjectileType("Chlorofuck"))
			{
				if (!modPlayer.chloroEnchant)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.DD2PetDragon && (player.FindBuffIndex(202) == -1))
			{
				if (!modPlayer.dragPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			/*if(projectile.type == ProjectileID.DD2PetGato && (player.FindBuffIndex(200) == -1))
			{
				if (!modPlayer.mythrilPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Parrot && (player.FindBuffIndex(54) == -1))
			{
				if (!modPlayer.oriPet)
				{
					projectile.Kill();
					return;
				}
			}*/
			
			if(projectile.type == ProjectileID.Puppy && (player.FindBuffIndex(91) == -1))
			{
				if (!modPlayer.dogPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyFaceMonster && (player.FindBuffIndex(154) == -1))
			{
				if (!modPlayer.crimsonPet)
				{
					projectile.Kill();
					return;
				}
			}
			/*
			if(projectile.type == ProjectileID.BabyHornet && (player.FindBuffIndex(51) == -1))
			{
				if (!modPlayer.beePet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.TikiSpirit && (player.FindBuffIndex(52) == -1))
			{
				if (!modPlayer.turtPet)
				{
					projectile.Kill();
					return;
				}
			}*/
			
			if(projectile.type == ProjectileID.PetLizard && (player.FindBuffIndex(53) == -1))
			{
				if (!modPlayer.lizPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BlackCat && (player.FindBuffIndex(84) == -1))
			{
				if (!modPlayer.catPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.MiniMinotaur && (player.FindBuffIndex(136) == -1))
			{
				if (!modPlayer.minotaurPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.CursedSapling && (player.FindBuffIndex(85) == -1))
			{
				if (!modPlayer.saplingPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Squashling && (player.FindBuffIndex(82) == -1))
			{
				if (!modPlayer.pumpkinPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.BabyEater && (player.FindBuffIndex(45) == -1))
			{
				if (!modPlayer.shadowPet)
				{
					projectile.Kill();
					return;
				}
			}
			
			if(projectile.type == ProjectileID.Wisp && (player.FindBuffIndex(57) == -1))
			{
				if (!modPlayer.spectrePet)
				{
					projectile.Kill();
					return;
				}
			}
			
		}
		
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			//spawn proj on hit
			if (modPlayer.shroomEnchant && (projectile.magic || projectile.thrown || projectile.melee || projectile.minion || projectile.ranged) && Main.rand.Next(5) == 0)
			{
				int shrooms = Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f, 0f, 590, 32/*dmg*/, 0f, projectile.owner, 0f, 0f);
				Main.projectile[shrooms].melee = false;
			}
			
			if(modPlayer.oriEnchant && projectile.magic && Main.rand.Next(6) == 0)
			{
				int[] ball = {15, 95, 253};
				int fireball = Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, ball[Main.rand.Next(3)], 32/*dmg*/, 0f, projectile.owner, 0f, 0f);
				Main.projectile[fireball].melee = false;
			}
			
			if(modPlayer.beeEnchant && projectile.minion && Main.rand.Next(5) == 0)
			{
				Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, 181, projectile.damage / 3, 0f, projectile.owner, 0f, 0f);
			}
			
			if(modPlayer.spiderEnchant && projectile.minion && Main.rand.Next(5) == 0)
			{
				Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, 379, projectile.damage / 2, 0f, projectile.owner, 0f, 0f);
			}
			
			if(modPlayer.terrariaSoul && Main.rand.Next(4) == 0)
			{
				Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, 181, projectile.damage / 3, 0f, projectile.owner, 0f, 0f);
				
				Projectile.NewProjectile(projectile.Center.X + Main.rand.Next(-40, 40), projectile.Center.Y + Main.rand.Next(-40, 40), 0f + Main.rand.Next(-5, 5), -5f, 379, projectile.damage / 2, 0f, projectile.owner, 0f, 0f);
			}
			
			if (projectile.minion && modPlayer.universeEffect)
			{
				target.AddBuff(BuffID.Ichor, 240, true);
				target.AddBuff(BuffID.CursedInferno, 240, true);
				target.AddBuff(BuffID.Confused, 120, true);
				target.AddBuff(BuffID.Venom, 240, true);
				target.AddBuff(BuffID.ShadowFlame, 240, true);
				target.AddBuff(BuffID.OnFire, 240, true);
				target.AddBuff(BuffID.Frostburn, 240, true);
				target.AddBuff(BuffID.Daybreak, 240, true);	
			}
		}
		
		public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
		{
			/*Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			//reflect proj
			if (modPlayer.hallowEnchant && projectile.active && !projectile.friendly && projectile.hostile && damage > 0/* && Main.rand.Next(8) == 0)
			{
				projectile.hostile = false;
				target.statLife += damage;
				
    			//target.HealEffect(damage);
				Projectile.NewProjectile(player.Center.X, player.Center.Y, -projectile.velocity.X, -projectile.velocity.Y, 156, damage, 2f, Main.myPlayer, 0f, 0f);
				
				
			}*/
		}
		
		/*public override bool Colliding (Rectangle projHitbox, Rectangle targetHitbox)
		{
			if(projectile.projHitbox == mod.ProjectileType("DualSaberProj").projHitbox)
			{
				stuff
			}
		}*/
		
		public override void ModifyHitPlayer (Projectile projectile, Player target, ref int damage, ref bool crit)
		{
			Player player = Main.player[Main.myPlayer];
			FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>(mod);
			
			int chance = 0;
			if (modPlayer.hallowEnchant)
			{
				chance = 8;
			}
			else if(modPlayer.terrariaSoul)
			{
				chance = 2;
			}
			
			//reflect proj
			if (chance != 0 && projectile.active && !projectile.friendly && projectile.hostile && damage > 0 && Main.rand.Next(chance) == 0)
			{
				target.statLife += damage;
				
				//Projectile.NewProjectile(player.Center.X, player.Center.Y, -projectile.velocity.X, -projectile.velocity.Y, mod.ProjectileType("HallowSword"), damage, 2f, Main.myPlayer, 0f, 0f);
				
				// Set ownership
				projectile.hostile = false;
				projectile.friendly = true;
				projectile.owner = player.whoAmI;
	
				// Turn around
				projectile.velocity *= -1f;
				projectile.penetrate = 1;
	
				// Flip sprite
				if (projectile.Center.X > player.Center.X * 0.5f)
				{
					projectile.direction = 1;
					projectile.spriteDirection = 1;
				}
				else
				{
					projectile.direction = -1;
					projectile.spriteDirection = -1;
				}
	
				// Don't know if this will help but here it is
				projectile.netUpdate = true;
				
			}
		}
	}
>>>>>>> 66ed39caf4938fca8e7009752b635e42f8a8a58f
}