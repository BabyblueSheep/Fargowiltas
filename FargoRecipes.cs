﻿using Fargowiltas.Items.CaughtNPCs;
using Fargowiltas.Items.Summons;
using Fargowiltas.Items.Summons.Deviantt;
using Fargowiltas.Items.Summons.Abom;
using Fargowiltas.Items.Summons.SwarmSummons;
using Fargowiltas.Items.Summons.Mutant;
using Fargowiltas.Items.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Fargowiltas.Items.Summons.VanillaCopy;

namespace Fargowiltas
{
    internal class FargoRecipes
    {
        public static void AddRecipeGroups()
        {
            // Evil Wood
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Wood", new int[] { ItemID.Ebonwood, ItemID.Shadewood });
            RecipeGroup.RegisterGroup("Fargowiltas:AnyEvilWood", group);

            //iron anvil
            group = new RecipeGroup(() => "Any Iron Anvil", new int[] { ItemID.IronAnvil, ItemID.LeadAnvil});
            RecipeGroup.RegisterGroup("Fargowiltas:AnyAnvil", group);

            //anvil HM
            group = new RecipeGroup(() => "Any Mythril Anvil", ItemID.MythrilAnvil, ItemID.OrichalcumAnvil);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyHMAnvil", group);

            //forge HM
            group = new RecipeGroup(() => "Any Adamantite Forge", ItemID.AdamantiteForge, ItemID.TitaniumForge);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyForge", group);

            //book cases
            group = new RecipeGroup(() => "Any Bookcase", new int[]
            {
                ItemID.Bookcase,
                ItemID.BlueDungeonBookcase,
                ItemID.BoneBookcase,
                ItemID.BorealWoodBookcase,
                ItemID.CactusBookcase,
                ItemID.CrystalBookCase,
                ItemID.DynastyBookcase,
                ItemID.EbonwoodBookcase,
                ItemID.FleshBookcase,
                ItemID.FrozenBookcase,
                ItemID.GlassBookcase,
                ItemID.GoldenBookcase,
                ItemID.GothicBookcase,
                ItemID.GraniteBookcase,
                ItemID.GreenDungeonBookcase,
                ItemID.HoneyBookcase,
                ItemID.LivingWoodBookcase,
                ItemID.MarbleBookcase,
                ItemID.MeteoriteBookcase,
                ItemID.MushroomBookcase,
                ItemID.ObsidianBookcase,
                ItemID.PalmWoodBookcase,
                ItemID.PearlwoodBookcase,
                ItemID.PinkDungeonBookcase,
                ItemID.PumpkinBookcase,
                ItemID.RichMahoganyBookcase,
                ItemID.ShadewoodBookcase,
                ItemID.SkywareBookcase,
                ItemID.SlimeBookcase,
                ItemID.SpookyBookcase,
                ItemID.SteampunkBookcase
            });
            RecipeGroup.RegisterGroup("Fargowiltas:AnyBookcase", group);


            // Bone Banners
            int[] boneBanners = { ItemID.BlueArmoredBonesBanner, ItemID.HellArmoredBonesBanner, ItemID.RustyArmoredBonesBanner };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Armored Bones Banner", boneBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyArmoredBones", group);

            int[] pirateBanners = { ItemID.PirateDeadeyeBanner, ItemID.PirateCorsairBanner, ItemID.PirateCrossbowerBanner, ItemID.PirateBanner };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pirate Banner", pirateBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyPirateBanner", group);

            // Slimes (excluding ones that don't drop gel)
            int[] slimeBanners = {
                ItemID.SlimeBanner,
                ItemID.GreenSlimeBanner,
                ItemID.RedSlimeBanner,
                ItemID.PurpleSlimeBanner,
                ItemID.YellowSlimeBanner,
                ItemID.BlackSlimeBanner,
                ItemID.IceSlimeBanner,
                ItemID.SandSlimeBanner,
                ItemID.JungleSlimeBanner,
                ItemID.SpikedIceSlimeBanner,
                ItemID.SpikedJungleSlimeBanner,
                ItemID.MotherSlimeBanner,
                ItemID.UmbrellaSlimeBanner,
                ItemID.ToxicSludgeBanner,
                ItemID.CorruptSlimeBanner,
                ItemID.SlimerBanner,
                ItemID.CrimslimeBanner,
                ItemID.GastropodBanner,
                ItemID.IlluminantSlimeBanner,
                ItemID.RainbowSlimeBanner
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Slime Banner", slimeBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnySlimes", group);

            // Any Hallow enemy
            int[] hallowBanners = {
                ItemID.PixieBanner,
                ItemID.UnicornBanner,
                ItemID.RainbowSlimeBanner,
                ItemID.GastropodBanner,
                ItemID.LightMummyBanner,
                ItemID.IlluminantBatBanner,
                ItemID.IlluminantSlimeBanner,
                ItemID.ChaosElementalBanner,
                ItemID.EnchantedSwordBanner,
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Hallow Banner", hallowBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyHallows", group);

            // Any Corruption enemy
            int[] corruptionBanners = {
                ItemID.EaterofSoulsBanner,
                ItemID.CorruptorBanner,
                ItemID.CorruptSlimeBanner,
                ItemID.SlimerBanner,
                ItemID.DevourerBanner,
                ItemID.WorldFeederBanner,
                ItemID.DarkMummyBanner,
                ItemID.CursedHammerBanner,
                ItemID.ClingerBanner,
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Corruption Banner", corruptionBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyCorrupts", group);

            // Any Crimson enemy
            int[] crimsonBanners = {
                ItemID.BloodCrawlerBanner,
                ItemID.FaceMonsterBanner,
                ItemID.CrimeraBanner,
                ItemID.HerplingBanner,
                ItemID.CrimslimeBanner,
                ItemID.BloodJellyBanner,
                ItemID.BloodFeederBanner,
                ItemID.DarkMummyBanner,
                ItemID.CrimsonAxeBanner,
                ItemID.IchorStickerBanner,
                ItemID.FloatyGrossBanner,
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Crimson Banner", crimsonBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyCrimsons", group);

            // Any Jungle enemy
            int[] jungleBanners = {
                ItemID.PiranhaBanner,
                ItemID.SnatcherBanner,
                ItemID.JungleBatBanner,
                ItemID.JungleSlimeBanner,
                ItemID.DoctorBonesBanner,
                ItemID.AnglerFishBanner,
                ItemID.ArapaimaBanner,
                ItemID.TortoiseBanner,
                ItemID.AngryTrapperBanner,
                ItemID.DerplingBanner,
                ItemID.GiantFlyingFoxBanner,
                ItemID.HornetBanner,
                ItemID.SpikedJungleSlimeBanner,
                ItemID.JungleCreeperBanner,
                ItemID.MothBanner,
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Jungle Banner", jungleBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyJungles", group);

            // Any Snow enemy
            int[] snowBanners = {
                ItemID.IceSlimeBanner,
                ItemID.ZombieEskimoBanner,
                ItemID.IceElementalBanner,
                ItemID.WolfBanner,
                ItemID.IceGolemBanner,
                ItemID.IceBatBanner,
                ItemID.SnowFlinxBanner,
                ItemID.SpikedIceSlimeBanner,
                ItemID.UndeadVikingBanner,
                ItemID.ArmoredVikingBanner,
                ItemID.IceTortoiseBanner,
                ItemID.IcyMermanBanner,
                ItemID.PigronBanner,
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Snow Banner", snowBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnySnows", group);

            // Any Crimson enemy
            int[] desertBanners = {
                ItemID.FlyingAntlionBanner,
                ItemID.WalkingAntlionBanner,
                ItemID.AntlionBanner,
                ItemID.DesertDjinnBanner,
                ItemID.DesertBasiliskBanner,
                ItemID.DesertLamiaBanner,
                ItemID.DesertGhoulBanner,
                //fill in more
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Desert Banner", desertBanners);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyDeserts", group);

            // Caught NPCs
            int[] caughtNPCs = new int[]
            {
                ModContent.ItemType<Guide>(),
                ModContent.ItemType<Angler>(),
                ModContent.ItemType<ArmsDealer>(),
                ModContent.ItemType<Clothier>(),
                ModContent.ItemType<Cyborg>(),
                ModContent.ItemType<Demolitionist>(),
                ModContent.ItemType<Dryad>(),
                ModContent.ItemType<DyeTrader>(),
                ModContent.ItemType<GoblinTinkerer>(),
                ModContent.ItemType<LumberJack>(),
                ModContent.ItemType<Mechanic>(),
                ModContent.ItemType<Merchant>(),
                ModContent.ItemType<Nurse>(),
                ModContent.ItemType<Painter>(),
                ModContent.ItemType<PartyGirl>(),
                ModContent.ItemType<Pirate>(),
                ModContent.ItemType<SantaClaus>(),
                ModContent.ItemType<SkeletonMerchant>(),
                ModContent.ItemType<Steampunker>(),
                ModContent.ItemType<Stylist>(),
                ModContent.ItemType<Tavernkeep>(),
                ModContent.ItemType<TaxCollector>(),
                ModContent.ItemType<TravellingMerchant>(),
                ModContent.ItemType<WitchDoctor>(),
                ModContent.ItemType<Wizard>(),
            };
            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Caught Town NPC", caughtNPCs);
            RecipeGroup.RegisterGroup("Fargowiltas:AnyCaughtNPC", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Omnistation", ModContent.ItemType<Omnistation>(), ModContent.ItemType<Omnistation2>());
            RecipeGroup.RegisterGroup("Fargowiltas:AnyOmnistation", group);
        }

        public static void AddRecipes()
        {
            AddSummonConversions();
            AddEvilConversions();
            AddMetalConversions();

            if (ModContent.GetInstance<FargoConfig>().BannerRecipes)
            {
                AddBannerToItemRecipes();
            }

            AddStatueRecipes();
            AddContainerLootRecipes();
            AddNPCRecipes();
            AddTreasureBagRecipes();
            AddFurnitureRecipes();
            AddMiscRecipes();
        }

        private static void AddSummonConversions()
        {
            ModRecipe recipe;
            void AddSummonConversion(int ingredient, int result)
            {
                recipe = GetNewRecipe();
                recipe.AddIngredient(ingredient);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(result);
                recipe.AddRecipe();
            }

            AddSummonConversion(ModContent.ItemType<FleshyDoll>(), ItemID.GuideVoodooDoll);
            AddSummonConversion(ModContent.ItemType<LihzahrdPowerCell2>(), ItemID.LihzahrdPowerCell);
            AddSummonConversion(ModContent.ItemType<TruffleWorm2>(), ItemID.TruffleWorm);
            AddSummonConversion(ModContent.ItemType<CelestialSigil2>(), ItemID.CelestialSigil);
            AddSummonConversion(ModContent.ItemType<MechEye>(), ItemID.MechanicalEye);
            AddSummonConversion(ModContent.ItemType<MechWorm>(), ItemID.MechanicalWorm);
            AddSummonConversion(ModContent.ItemType<MechSkull>(), ItemID.MechanicalSkull);
            AddSummonConversion(ModContent.ItemType<GoreySpine>(), ItemID.BloodySpine);
            AddSummonConversion(ModContent.ItemType<SlimyCrown>(), ItemID.SlimeCrown);
            AddSummonConversion(ModContent.ItemType<Abeemination2>(), ItemID.Abeemination);
            AddSummonConversion(ModContent.ItemType<WormyFood>(), ItemID.WormFood);
            AddSummonConversion(ModContent.ItemType<SuspiciousEye>(), ItemID.SuspiciousLookingEye);
        }

        private static void AddEvilConversions()
        {
            AddConvertRecipe(ItemID.Vertebrae, ItemID.RottenChunk);
            AddConvertRecipe(ItemID.ShadowScale, ItemID.TissueSample);
            AddConvertRecipe(ItemID.PurpleSolution, ItemID.RedSolution);
            AddConvertRecipe(ItemID.Ichor, ItemID.CursedFlame);
            AddConvertRecipe(ItemID.FleshKnuckles, ItemID.PutridScent);
            AddConvertRecipe(ItemID.DartPistol, ItemID.DartRifle);
            AddConvertRecipe(ItemID.WormHook, ItemID.TendonHook);
            AddConvertRecipe(ItemID.ChainGuillotines, ItemID.FetidBaghnakhs);
            AddConvertRecipe(ItemID.ClingerStaff, ItemID.SoulDrain);
            AddConvertRecipe(ItemID.ShadowOrb, ItemID.CrimsonHeart);
            AddConvertRecipe(ItemID.Musket, ItemID.TheUndertaker);
            AddConvertRecipe(ItemID.PanicNecklace, ItemID.BandofStarpower);
            AddConvertRecipe(ItemID.BallOHurt, ItemID.TheRottedFork);
            AddConvertRecipe(ItemID.CrimsonRod, ItemID.Vilethorn);
            AddConvertRecipe(ItemID.CrimstoneBlock, ItemID.EbonstoneBlock);
            AddConvertRecipe(ItemID.Shadewood, ItemID.Ebonwood);
            AddConvertRecipe(ItemID.VileMushroom, ItemID.ViciousMushroom);
            AddConvertRecipe(ItemID.Bladetongue, ItemID.Toxikarp);
            AddConvertRecipe(ItemID.VampireKnives, ItemID.ScourgeoftheCorruptor);
            AddConvertRecipe(ItemID.Ebonkoi, ItemID.CrimsonTigerfish);
            AddConvertRecipe(ItemID.Hemopiranha, ItemID.Ebonkoi);
            AddConvertRecipe(ItemID.BoneRattle, ItemID.EatersBone);
            AddConvertRecipe(ItemID.CrimsonSeeds, ItemID.CorruptSeeds);
            AddConvertRecipe(ItemID.DeadlandComesAlive, ItemID.LightlessChasms);
        }

        private static void AddMetalConversions()
        {
            AddConvertRecipe(ItemID.CopperOre, ItemID.TinOre);
            AddConvertRecipe(ItemID.CopperBar, ItemID.TinBar);
            AddConvertRecipe(ItemID.IronOre, ItemID.LeadOre);
            AddConvertRecipe(ItemID.IronBar, ItemID.LeadBar);
            AddConvertRecipe(ItemID.SilverOre, ItemID.TungstenOre);
            AddConvertRecipe(ItemID.SilverBar, ItemID.TungstenBar);
            AddConvertRecipe(ItemID.GoldOre, ItemID.PlatinumOre);
            AddConvertRecipe(ItemID.GoldBar, ItemID.PlatinumBar);
            AddConvertRecipe(ItemID.CobaltOre, ItemID.PalladiumOre);
            AddConvertRecipe(ItemID.CobaltBar, ItemID.PalladiumBar);
            AddConvertRecipe(ItemID.MythrilOre, ItemID.OrichalcumOre);
            AddConvertRecipe(ItemID.MythrilBar, ItemID.OrichalcumBar);
            AddConvertRecipe(ItemID.AdamantiteOre, ItemID.TitaniumOre);
            AddConvertRecipe(ItemID.AdamantiteBar, ItemID.TitaniumBar);
            AddConvertRecipe(ItemID.DemoniteOre, ItemID.CrimtaneOre);
            AddConvertRecipe(ItemID.DemoniteBar, ItemID.CrimtaneBar);
        }

        private static void AddBannerToItemRecipes()
        {
            ModRecipe recipe;
            void AddBannerToItemRecipe(int banner, int result, int bannerAmount = 1, int resultAmount = 1)
            {
                recipe = GetNewRecipe();
                recipe.AddIngredient(banner, bannerAmount);
                recipe.AddTile(TileID.Solidifier);
                recipe.SetResult(result, resultAmount);
                recipe.AddRecipe();
            }

            void AddBannerToItemsRecipe(int banner, int[] results, int bannerAmount = 1)
            {
                foreach (int result in results)
                {
                    recipe = GetNewRecipe();
                    recipe.AddIngredient(banner, bannerAmount);
                    recipe.AddTile(TileID.Solidifier);
                    recipe.SetResult(result);
                    recipe.AddRecipe();
                }
            }

            void AddGroupToItemRecipe(string group, int result, int station = TileID.Solidifier, int resultAmount = 1, int groupAmount = 1)
            {
                recipe = GetNewRecipe();
                recipe.AddRecipeGroup(group, groupAmount);
                recipe.AddTile(station);
                recipe.SetResult(result, resultAmount);
                recipe.AddRecipe();
            }

            AddBannerToItemRecipe(ItemID.AnglerFishBanner, ItemID.AdhesiveBandage);
            AddBannerToItemRecipe(ItemID.WerewolfBanner, ItemID.AdhesiveBandage);
            AddBannerToItemRecipe(ItemID.AngryBonesBanner, ItemID.TallyCounter);
            AddBannerToItemRecipe(ItemID.AngryNimbusBanner, ItemID.NimbusRod);
            AddBannerToItemRecipe(ItemID.AngryTrapperBanner, ItemID.Uzi);
            AddBannerToItemRecipe(ItemID.ArmoredVikingBanner, ItemID.IceSickle);
            AddBannerToItemRecipe(ItemID.BatBanner, ItemID.ChainKnife);
            AddBannerToItemRecipe(ItemID.BlackRecluseBanner, ItemID.PoisonStaff);
            AddBannerToItemRecipe(ItemID.BloodZombieBanner, ItemID.SharkToothNecklace);
            AddBannerToItemRecipe(ItemID.BunnyBanner, ItemID.BunnyHood);
            AddBannerToItemRecipe(ItemID.ButcherBanner, ItemID.ButchersChainsaw);
            AddBannerToItemRecipe(ItemID.CorruptorBanner, ItemID.Vitamins);
            AddBannerToItemRecipe(ItemID.CorruptSlimeBanner, ItemID.Blindfold);
            AddBannerToItemRecipe(ItemID.CrawdadBanner, ItemID.Rally);
            AddBannerToItemRecipe(ItemID.CreatureFromTheDeepBanner, ItemID.NeptunesShell);
            AddBannerToItemRecipe(ItemID.CursedSkullBanner, ItemID.Nazar);
            AddBannerToItemRecipe(ItemID.DarkMummyBanner, ItemID.Blindfold);
            AddBannerToItemRecipe(ItemID.DeadlySphereBanner, ItemID.DeadlySphereStaff);
            AddBannerToItemRecipe(ItemID.DemonBanner, ItemID.DemonScythe);
            AddBannerToItemRecipe(ItemID.DemonEyeBanner, ItemID.BlackLens);
            AddBannerToItemRecipe(ItemID.DesertBasiliskBanner, ItemID.AncientHorn);
            AddBannerToItemRecipe(ItemID.DiablolistBanner, ItemID.InfernoFork);
            AddBannerToItemRecipe(ItemID.DripplerBanner, ItemID.MoneyTrough);
            AddBannerToItemRecipe(ItemID.DrManFlyBanner, ItemID.ToxicFlask);
            AddBannerToItemRecipe(ItemID.EyezorBanner, ItemID.EyeSpring);
            AddBannerToItemRecipe(ItemID.FireImpBanner, ItemID.ObsidianRose);
            AddBannerToItemRecipe(ItemID.GastropodBanner, ItemID.BlessedApple);
            AddBannerToItemRecipe(ItemID.GiantBatBanner, ItemID.TrifoldMap);
            AddBannerToItemRecipe(ItemID.GiantShellyBanner, ItemID.Rally);
            AddBannerToItemRecipe(ItemID.GoblinArcherBanner, ItemID.Harpoon);
            AddBannerToItemRecipe(ItemID.GraniteFlyerBanner, ItemID.NightVisionHelmet);
            AddBannerToItemRecipe(ItemID.HarpyBanner, ItemID.GiantHarpyFeather);
            AddBannerToItemRecipe(ItemID.HellbatBanner, ItemID.MagmaStone);
            AddBannerToItemRecipe(ItemID.HornetBanner, ItemID.TatteredBeeWing);
            AddBannerToItemRecipe(ItemID.IceBatBanner, ItemID.DepthMeter);
            AddBannerToItemRecipe(ItemID.IceTortoiseBanner, ItemID.FrozenTurtleShell);
            AddBannerToItemRecipe(ItemID.IcyMermanBanner, ItemID.FrostStaff);
            AddBannerToItemRecipe(ItemID.JungleBatBanner, ItemID.DepthMeter);
            AddBannerToItemRecipe(ItemID.JungleCreeperBanner, ItemID.Yelets);
            AddBannerToItemRecipe(ItemID.LavaBatBanner, ItemID.HelFire);
            AddBannerToItemRecipe(ItemID.LavaSlimeBanner, ItemID.Cascade);
            AddBannerToItemRecipe(ItemID.LihzahrdBanner, ItemID.LizardEgg);
            AddBannerToItemRecipe(ItemID.MartianScutlixGunnerBanner, ItemID.BrainScrambler);
            AddBannerToItemRecipe(ItemID.MothronBanner, ItemID.MothronWings);
            AddBannerToItemRecipe(ItemID.NailheadBanner, ItemID.NailGun);
            AddBannerToItemRecipe(ItemID.NecromancerBanner, ItemID.ShadowbeamStaff);
            AddBannerToItemRecipe(ItemID.PinkJellyfishBanner, ItemID.JellyfishNecklace);
            AddBannerToItemRecipe(ItemID.PiranhaBanner, ItemID.RobotHat);
            AddBannerToItemRecipe(ItemID.PixieBanner, ItemID.Megaphone);
            AddBannerToItemRecipe(ItemID.PsychoBanner, ItemID.PsychoKnife);
            AddBannerToItemRecipe(ItemID.RaggedCasterBanner, ItemID.SpectreStaff);
            AddBannerToItemRecipe(ItemID.RaincoatZombieBanner, ItemID.RainHat);
            AddBannerToItemRecipe(ItemID.RaincoatZombieBanner, ItemID.RainCoat);
            AddBannerToItemRecipe(ItemID.ReaperBanner, ItemID.DeathSickle);
            AddBannerToItemRecipe(ItemID.SalamanderBanner, ItemID.Rally);
            AddBannerToItemRecipe(ItemID.SharkBanner, ItemID.DivingHelmet);
            AddBannerToItemRecipe(ItemID.SkeletonBanner, ItemID.BoneSword);
            AddBannerToItemRecipe(ItemID.SkeletonCommandoBanner, ItemID.RocketLauncher);
            AddBannerToItemRecipe(ItemID.SkeletonMageBanner, ItemID.BoneWand);
            AddBannerToItemRecipe(ItemID.SnowFlinxBanner, ItemID.SnowballLauncher);
            AddBannerToItemRecipe(ItemID.TortoiseBanner, ItemID.TurtleShell);
            AddBannerToItemRecipe(ItemID.HornetBanner, ItemID.Bezoar);
            AddBannerToItemRecipe(ItemID.ToxicSludgeBanner, ItemID.Bezoar);
            AddBannerToItemRecipe(ItemID.UmbrellaSlimeBanner, ItemID.UmbrellaHat);
            AddBannerToItemRecipe(ItemID.UndeadMinerBanner, ItemID.BonePickaxe);
            AddBannerToItemRecipe(ItemID.UndeadVikingBanner, ItemID.VikingHelmet);
            AddBannerToItemRecipe(ItemID.UnicornBanner, ItemID.UnicornonaStick);
            AddBannerToItemRecipe(ItemID.WalkingAntlionBanner, ItemID.AntlionClaw);
            AddBannerToItemRecipe(ItemID.WerewolfBanner, ItemID.MoonCharm);
            AddBannerToItemRecipe(ItemID.WolfBanner, ItemID.Amarok);
            AddBannerToItemRecipe(ItemID.WormBanner, ItemID.WhoopieCushion);
            AddBannerToItemRecipe(ItemID.WraithBanner, ItemID.FastClock);
            AddBannerToItemRecipe(ItemID.PirateCaptainBanner, ItemID.CoinGun);
            AddBannerToItemRecipe(ItemID.ChaosElementalBanner, ItemID.RodofDiscord, 5);
            AddBannerToItemRecipe(ItemID.SalamanderBanner, ItemID.Compass);
            AddBannerToItemRecipe(ItemID.CrawdadBanner, ItemID.Compass);
            AddBannerToItemRecipe(ItemID.GiantShellyBanner, ItemID.Compass);

            AddBannerToItemsRecipe(ItemID.MimicBanner, new int[] { ItemID.DualHook, ItemID.MagicDagger, ItemID.TitanGlove, ItemID.PhilosophersStone, ItemID.CrossNecklace, ItemID.StarCloak, ItemID.Frostbrand, ItemID.IceBow, ItemID.FlowerofFrost, ItemID.ToySled });
            AddBannerToItemsRecipe(ItemID.ArmoredSkeletonBanner, new int[] { ItemID.ArmorPolish, ItemID.BeamSword });
            AddBannerToItemsRecipe(ItemID.BoneLeeBanner, new int[] { ItemID.BlackBelt, ItemID.Tabi });
            AddBannerToItemsRecipe(ItemID.DesertDjinnBanner, new int[] { ItemID.DjinnLamp, ItemID.DjinnsCurse });
            AddBannerToItemsRecipe(ItemID.DesertLamiaBanner, new int[] { ItemID.LamiaHat, ItemID.LamiaShirt, ItemID.LamiaPants, ItemID.MoonMask, ItemID.SunMask });
            AddBannerToItemsRecipe(ItemID.FloatyGrossBanner, new int[] { ItemID.Vitamins, ItemID.MeatGrinder });
            AddBannerToItemsRecipe(ItemID.MedusaBanner, new int[] { ItemID.MedusaHead, ItemID.PocketMirror });
            AddBannerToItemsRecipe(ItemID.MummyBanner, new int[] { ItemID.MummyMask, ItemID.MummyShirt, ItemID.MummyPants });
            AddBannerToItemsRecipe(ItemID.PaladinBanner, new int[] { ItemID.PaladinsHammer, ItemID.PaladinsShield });
            AddBannerToItemsRecipe(ItemID.PenguinBanner, new int[] { ItemID.PedguinHat, ItemID.PedguinShirt, ItemID.PedguinPants });
            AddBannerToItemsRecipe(ItemID.PirateBanner, new int[] { ItemID.SailorHat, ItemID.SailorShirt, ItemID.SailorPants });
            AddBannerToItemsRecipe(ItemID.RedDevilBanner, new int[] { ItemID.UnholyTrident, ItemID.FireFeather });
			AddBannerToItemsRecipe(ItemID.SkeletonArcherBanner, new int[] { ItemID.MagicQuiver, ItemID.Marrow});
            AddBannerToItemsRecipe(ItemID.SkeletonSniperBanner, new int[] { ItemID.RifleScope, ItemID.SniperRifle });
            AddBannerToItemsRecipe(ItemID.TacticalSkeletonBanner, new int[] { ItemID.TacticalShotgun, ItemID.SWATHelmet });
            AddBannerToItemsRecipe(ItemID.VampireBanner, new int[] { ItemID.BrokenBatWing, ItemID.MoonStone });
            AddBannerToItemsRecipe(ItemID.ZombieBanner, new int[] { ItemID.ZombieArm, ItemID.Shackle });
            AddBannerToItemsRecipe(ItemID.ZombieElfBanner, new int[] { ItemID.ElfHat, ItemID.ElfShirt, ItemID.ElfPants });
            AddBannerToItemsRecipe(ItemID.ZombieEskimoBanner, new int[] { ItemID.EskimoHood, ItemID.EskimoCoat, ItemID.EskimoPants });
            //ancient armors
            AddBannerToItemsRecipe(ItemID.EaterofSoulsBanner, new int[] { ItemID.AncientShadowHelmet, ItemID.AncientShadowScalemail, ItemID.AncientShadowGreaves }, 2);
            AddBannerToItemsRecipe(ItemID.HornetBanner, new int[] { ItemID.AncientCobaltHelmet, ItemID.AncientCobaltBreastplate, ItemID.AncientCobaltLeggings }, 2);
            AddBannerToItemsRecipe(ItemID.SkeletonBanner, new int[] { ItemID.AncientIronHelmet, ItemID.AncientGoldHelmet }, 2);
            AddBannerToItemRecipe(ItemID.AngryBonesBanner, ItemID.AncientNecroHelmet, 2);
            //gladiator
            AddBannerToItemsRecipe(ItemID.GreekSkeletonBanner, new int[] { ItemID.GladiatorHelmet, ItemID.GladiatorBreastplate, ItemID.GladiatorLeggings });
            
            //boss trophy recipes
            AddBannerToItemRecipe(ItemID.KingSlimeTrophy, ItemID.SlimeStaff);
            AddBannerToItemRecipe(ItemID.EyeofCthulhuTrophy, ItemID.Binoculars);
            AddBannerToItemRecipe(ItemID.EaterofWorldsTrophy, ItemID.EatersBone);
            AddBannerToItemRecipe(ItemID.BrainofCthulhuTrophy, ItemID.BoneRattle);
            AddBannerToItemRecipe(ItemID.QueenBeeTrophy, ItemID.HoneyedGoggles);
            AddBannerToItemRecipe(ItemID.SkeletronTrophy, ItemID.BookofSkulls);
            AddBannerToItemRecipe(ItemID.PlanteraTrophy, ItemID.TheAxe);
            AddBannerToItemRecipe(ItemID.DukeFishronTrophy, ItemID.FishronWings);
            //empress of light trophy = stellar tune or empress wings
            //dutchamn trophy = the dutchman cart

            //pirates
            AddGroupToItemRecipe("Fargowiltas:AnyPirateBanner", ItemID.Cutlass);
            AddGroupToItemRecipe("Fargowiltas:AnyPirateBanner", ItemID.GoldRing);
            AddGroupToItemRecipe("Fargowiltas:AnyPirateBanner", ItemID.PirateStaff);
            AddGroupToItemRecipe("Fargowiltas:AnyPirateBanner", ItemID.DiscountCard);
            AddGroupToItemRecipe("Fargowiltas:AnyPirateBanner", ItemID.LuckyCoin);

            AddGroupToItemRecipe("Fargowiltas:AnyArmoredBones", ItemID.Keybrand);
            AddGroupToItemRecipe("Fargowiltas:AnyArmoredBones", ItemID.Kraken);
            AddGroupToItemRecipe("Fargowiltas:AnyArmoredBones", ItemID.MagnetSphere);
            AddGroupToItemRecipe("Fargowiltas:AnyArmoredBones", ItemID.WispinaBottle);
            AddGroupToItemRecipe("Fargowiltas:AnyArmoredBones", ItemID.BoneFeather);
            //morning star recipe here

            AddGroupToItemRecipe("Fargowiltas:AnySlimes", ItemID.Gel, resultAmount: 200);

            AddGroupToItemRecipe("Fargowiltas:AnyHallows", ItemID.HallowedKey, TileID.MythrilAnvil, 1, 10);
            AddGroupToItemRecipe("Fargowiltas:AnyCorrupts", ItemID.CorruptionKey, TileID.MythrilAnvil, 1, 10);
            AddGroupToItemRecipe("Fargowiltas:AnyCrimsons", ItemID.CrimsonKey, TileID.MythrilAnvil, 1, 10);
            AddGroupToItemRecipe("Fargowiltas:AnyJungles", ItemID.JungleKey, TileID.MythrilAnvil, 1, 10);
            AddGroupToItemRecipe("Fargowiltas:AnySnows", ItemID.FrozenKey, TileID.MythrilAnvil, 1, 10);
            //desert key

            //FOOD
            //chaos ele, illum slime, illum bat = apple pie
            //antlion, antlion swarmer, antlion charger = banana split
            //skeleton commando, skeleton sniper, tactical skeleton = ribs give 2
            //eater of souls and crimera = burger
            //harpies = chicken nugget
            //gastropod = chocolate chip cookie
            //cursed skull and giant cursed skull = cream soda
            //wall creeper, black recluse, sand poacher = fried egg
            //flying fish = fries
            //giant flying fox and derpling = grapes
            //pigron = 2 bacon
            //icy merman, ice tortoise = milkshake
            //medusa and hoplites = pizza
            //granite golem and elemental = spaghetti
            //undead miner = 5 steaks
            //the possessed = 1 steak
            //bone lee = 5 coffee
            //man eater, snatcher, angry trapper = 1 coffee
            //bone serpent and red devil = hotdog
            //ice slime, ice bat, spiked ice slime = ice cream
            //sand sharks and angry tumblers = nachos
            //sharks and crabs = shrimp po boy
            //salamanders, crawdad, giant shelly = potato chip
            //skeletons = carton of milk

            //dreadnaut banner = blood moon monolith
            //flying fish = rain song
            //super star shooter crafted from star cannon?
            //zombie merman/wandering eye = vampire frog staff, chum caster, blood rain bow
            //hoplite = gladius
            //enchanted sword banner = blade staff
            //rock golem = rock golem head
            //spore bat = shroomerang
            //giant cursed skull = shadow jousting lance
            //pigron = pigron minecart, pigron kite
            //corrupt bunny = corrupt bunny kite
            //crimson bunny = crimson bunny kite
            //man eater = man eater kite
            //blu jelly = blue jelly kite
            //pink jelly = pink jelly kite
            //shark = shark kite
            //bone serpent = bone serpent kite
            //wandering eye = wandering eye kite
            //unicorn = unicorn kite
            //world feeder = world feeder kite
            //sand shark bannr = sand shark kite
            //wyvern = wyvern kite
            //angry trapper = angry trapper kite
            //bunny banner = bunny kite
            //gold fish = goldfish kite
            //red slime = red kite
            //blue slime = blue kite
            //yellow slime = yellow kite
            //they craft together to make the others

            // Thorium
            if (Fargowiltas.ModLoaded["ThoriumMod"])
            {
                Mod thorium = ModLoader.GetMod("ThoriumMod");

                AddBannerToItemRecipe(thorium.ItemType("AncientChargerBanner"), thorium.ItemType("OlympicTorch"));
                AddBannerToItemRecipe(thorium.ItemType("AncientPhalanxBanner"), thorium.ItemType("AncientAegis"));
                AddBannerToItemRecipe(thorium.ItemType("ArmyAntBanner"), thorium.ItemType("HiveMind"));
                AddBannerToItemRecipe(thorium.ItemType("AstroBeetleBanner"), thorium.ItemType("AstroBeetleHusk"));
                AddBannerToItemRecipe(thorium.ItemType("BlisterPodBanner"), thorium.ItemType("BlisterSack"));
                AddBannerToItemRecipe(thorium.ItemType("BlizzardBatBanner"), thorium.ItemType("IceFairyStaff"));
                AddBannerToItemRecipe(thorium.ItemType("BoneFlayerBanner"), thorium.ItemType("BoneFlayerTail"));
                AddBannerToItemRecipe(thorium.ItemType("ChilledSpitterBanner"), thorium.ItemType("FrostPlagueStaff"));
                AddBannerToItemRecipe(thorium.ItemType("CoinBagBanner"), thorium.ItemType("AncientDrachma"));
                AddBannerToItemRecipe(thorium.ItemType("ColdlingBanner"), thorium.ItemType("SpineBuster"));
                AddBannerToItemRecipe(thorium.ItemType("CoolmeraBanner"), thorium.ItemType("MeatBallStaff"));
                AddBannerToItemRecipe(thorium.ItemType("CrownBanner"), thorium.ItemType("SpinyShell"));
                AddBannerToItemRecipe(thorium.ItemType("FlamekinCasterBanner"), thorium.ItemType("MoltenScale"));
                AddBannerToItemRecipe(thorium.ItemType("FrostBurntBanner"), thorium.ItemType("BlizzardsEdge"));
                AddBannerToItemRecipe(thorium.ItemType("GigaClamBanner"), thorium.ItemType("NanoClamCane"));
                AddBannerToItemRecipe(thorium.ItemType("GnomesBanner"), thorium.ItemType("GnomePick"));
                AddBannerToItemRecipe(thorium.ItemType("HammerHeadBanner"), thorium.ItemType("CartlidgedCatcher"));
                AddBannerToItemRecipe(thorium.ItemType("InfernalHoundBanner"), thorium.ItemType("MoltenCollar"));
                AddBannerToItemRecipe(thorium.ItemType("KrakenBanner"), thorium.ItemType("Leviathan"));
                AddBannerToItemRecipe(thorium.ItemType("LycanBanner"), thorium.ItemType("MoonlightStaff"));
                AddBannerToItemRecipe(thorium.ItemType("MoltenMortarBanner"), thorium.ItemType("MortarStaff"));
                AddBannerToItemRecipe(thorium.ItemType("NecroPotBanner"), thorium.ItemType("GhostlyGrapple"));
                AddBannerToItemRecipe(thorium.ItemType("ScissorStalkerBanner"), thorium.ItemType("StalkersSnippers"));
                AddBannerToItemRecipe(thorium.ItemType("ShamblerBanner"), thorium.ItemType("BallnChain"));
                AddBannerToItemRecipe(thorium.ItemType("SharptoothBanner"), thorium.ItemType("GoldenScale"), 4);
                AddBannerToItemRecipe(thorium.ItemType("SnowSingaBanner"), thorium.ItemType("EskimoBanjo"));
                AddBannerToItemRecipe(thorium.ItemType("SnowyOwlBanner"), thorium.ItemType("LostMail"));
                AddBannerToItemRecipe(thorium.ItemType("SpectrumiteBanner"), thorium.ItemType("PrismiteStaff"));
                AddBannerToItemRecipe(thorium.ItemType("StarvedBanner"), thorium.ItemType("DesecratedHeart"));
                AddBannerToItemRecipe(thorium.ItemType("TarantulaBanner"), thorium.ItemType("Arthropod"));
                AddBannerToItemRecipe(thorium.ItemType("UFOBanner"), thorium.ItemType("DetachedUFOBlaster"));
                AddBannerToItemRecipe(thorium.ItemType("UnderworldPotBanner"), thorium.ItemType("HotPot"));
                AddBannerToItemRecipe(thorium.ItemType("VampireSquidBanner"), thorium.ItemType("VampireGland"));
                AddBannerToItemRecipe(thorium.ItemType("VileSpitterBanner"), thorium.ItemType("VileSpitter"));
                AddBannerToItemRecipe(thorium.ItemType("VoltBanner"), thorium.ItemType("VoltHatchet"));
                AddBannerToItemRecipe(thorium.ItemType("WindElementalBanner"), thorium.ItemType("Zapper"));

                AddBannerToItemRecipe(ItemID.AngryBonesBanner, thorium.ItemType("GraveGoods"));
                AddBannerToItemRecipe(ItemID.BoneLeeBanner, thorium.ItemType("TechniqueShadowClone"));
                AddBannerToItemRecipe(ItemID.BoneSerpentBanner, thorium.ItemType("SpineBreaker"));
                AddBannerToItemRecipe(ItemID.FlyingSnakeBanner, thorium.ItemType("Spearmint"));
                AddBannerToItemRecipe(ItemID.FrankensteinBanner, thorium.ItemType("TeslaDefibrillator"));
                AddBannerToItemRecipe(ItemID.MartianOfficerBanner, thorium.ItemType("ShieldDroneBeacon"));
                AddBannerToItemRecipe(ItemID.MisterStabbyBanner, thorium.ItemType("BackStabber"));
                AddBannerToItemRecipe(ItemID.PirateDeadeyeBanner, thorium.ItemType("DeadEyePatch"));
                AddBannerToItemRecipe(ItemID.RaggedCasterBanner, thorium.ItemType("GatewayGlass"));
                AddBannerToItemRecipe(ItemID.RavagerScorpionBanner, thorium.ItemType("EbonyTail"));
                AddBannerToItemRecipe(ItemID.RedDevilBanner, thorium.ItemType("DemonTongue"));
                AddBannerToItemRecipe(ItemID.SkeletonCommandoBanner, thorium.ItemType("LaunchJumper"));
                AddBannerToItemRecipe(ItemID.SnowBallaBanner, thorium.ItemType("HailBomber"));
                AddBannerToItemRecipe(ItemID.SnowmanGangstaBanner, thorium.ItemType("TommyGun"));
                AddBannerToItemRecipe(ItemID.SquirrelGold, thorium.ItemType("SinisterAcorn"), 10);
                AddBannerToItemRecipe(ItemID.SwampThingBanner, thorium.ItemType("SwampSpike"));
                AddBannerToItemRecipe(ItemID.WyvernBanner, thorium.ItemType("CloudyChewToy"));

                AddBannerToItemsRecipe(thorium.ItemType("DarksteelKnightBanner"), new int[] { thorium.ItemType("BrokenDarksteelHelmet"), thorium.ItemType("GrayDPaintingItem") });
                AddBannerToItemsRecipe(thorium.ItemType("InvaderBanner"), new int[] { thorium.ItemType("VegaPhaser"), thorium.ItemType("BioPod") });
                AddBannerToItemsRecipe(thorium.ItemType("NecroticImbuerBanner"), new int[] { thorium.ItemType("NecroticStaff"), thorium.ItemType("TechniqueBloodLotus") });
                AddBannerToItemsRecipe(thorium.ItemType("WargBanner"), new int[] { thorium.ItemType("BattleHorn"), thorium.ItemType("BlackCatEars"), thorium.ItemType("Bagpipe"), thorium.ItemType("BloodCellStaff") });
                AddBannerToItemsRecipe(ItemID.MimicBanner, new int[] { thorium.ItemType("LargeCoin"), thorium.ItemType("ProofAvarice") });
            }

            // Calamity
            if (Fargowiltas.ModLoaded["CalamityMod"])
            {
                Mod calamity = ModLoader.GetMod("CalamityMod");

                AddBannerToItemRecipe(calamity.ItemType("AngryDogBanner"), calamity.ItemType("Cryophobia"), 2);
                AddBannerToItemRecipe(calamity.ItemType("ArmoredDiggerBanner"), calamity.ItemType("LeadWizard"));
                AddBannerToItemRecipe(calamity.ItemType("CnidrionBanner"), calamity.ItemType("TheTransformer"), 2);
                AddBannerToItemRecipe(calamity.ItemType("CrystalCrawlerBanner"), calamity.ItemType("CrystalBlade"));
                AddBannerToItemRecipe(calamity.ItemType("CuttlefishBanner"), calamity.ItemType("InkBomb"));
                AddBannerToItemRecipe(calamity.ItemType("EidolonWyrmJuvenileBanner"), calamity.ItemType("HalibutCannon"), 200);
                AddBannerToItemRecipe(calamity.ItemType("IceClasperBanner"), calamity.ItemType("FrostBarrier"));
                AddBannerToItemRecipe(calamity.ItemType("ImpiousImmolatorBanner"), calamity.ItemType("EnergyStaff"));
                AddBannerToItemRecipe(calamity.ItemType("IrradiatedSlimeBanner"), calamity.ItemType("LeadCore"));
                AddBannerToItemRecipe(calamity.ItemType("TrasherBanner"), calamity.ItemType("TrashmanTrashcan"));

                AddBannerToItemRecipe(ItemID.BoneSerpentBanner, calamity.ItemType("OldLordOathsword"));
                AddBannerToItemRecipe(ItemID.ClingerBanner, calamity.ItemType("CursedDagger"));
                AddBannerToItemRecipe(ItemID.DemonBanner, calamity.ItemType("BladecrestOathsword"));
                AddBannerToItemRecipe(ItemID.DesertBasiliskBanner, calamity.ItemType("EvilSmasher"), 4);
                AddBannerToItemRecipe(ItemID.DungeonSpiritBanner, calamity.ItemType("PearlGod"), 4);
                AddBannerToItemRecipe(ItemID.FlyingAntlionBanner, calamity.ItemType("MandibleBow"));
                AddBannerToItemRecipe(ItemID.GoblinSorcererBanner, calamity.ItemType("PlasmaRod"));
                AddBannerToItemRecipe(ItemID.GoblinWarriorBanner, calamity.ItemType("Warblade"));
                AddBannerToItemRecipe(ItemID.HarpyBanner, calamity.ItemType("SkyGlaze"), 2);
                AddBannerToItemRecipe(ItemID.IchorStickerBanner, calamity.ItemType("IchorSpear"));
                AddBannerToItemRecipe(ItemID.IchorStickerBanner, calamity.ItemType("SpearofDestiny"), 4);
                AddBannerToItemRecipe(ItemID.MimicBanner, calamity.ItemType("TheBee"), 2);
                AddBannerToItemRecipe(ItemID.NecromancerBanner, calamity.ItemType("WrathoftheAncients"));
                AddBannerToItemRecipe(ItemID.PirateCrossbowerBanner, calamity.ItemType("Arbalest"), 4);
                AddBannerToItemRecipe(ItemID.PirateCrossbowerBanner, calamity.ItemType("RaidersGlory"));
                AddBannerToItemRecipe(ItemID.PirateDeadeyeBanner, calamity.ItemType("ProporsePistol"));
                AddBannerToItemRecipe(ItemID.PossessedArmorBanner, calamity.ItemType("PsychoticAmulet"), 4);
                AddBannerToItemRecipe(ItemID.RuneWizardBanner, calamity.ItemType("EyeofMagnus"));
                AddBannerToItemRecipe(ItemID.SandElementalBanner, calamity.ItemType("WifeinaBottlewithBoobs"));
                AddBannerToItemRecipe(ItemID.SharkBanner, calamity.ItemType("DepthBlade"));
                AddBannerToItemRecipe(ItemID.SkeletonBanner, calamity.ItemType("Waraxe"));
                AddBannerToItemRecipe(ItemID.SkeletonMageBanner, calamity.ItemType("AncientShiv"));
                AddBannerToItemRecipe(ItemID.TacticalSkeletonBanner, calamity.ItemType("TrueConferenceCall"), 4);
                AddBannerToItemRecipe(ItemID.TombCrawlerBanner, calamity.ItemType("BurntSienna"));
                AddBannerToItemRecipe(ItemID.TortoiseBanner, calamity.ItemType("FabledTortoiseShell"), 4);
                AddBannerToItemRecipe(ItemID.WalkingAntlionBanner, calamity.ItemType("MandibleClaws"));
            }
        }

        private static void AddStatueRecipes()
        {
            ModRecipe recipe;
            void AddStatueRecipe(int statue, int ingredient, int ingredientAmount = 1)
            {
                recipe = GetNewRecipe();

                if (ingredient != -1)
                {
                    recipe.AddIngredient(ingredient, ingredientAmount);
                }
                
                recipe.AddIngredient(ItemID.StoneBlock, 50);
                recipe.AddTile(TileID.HeavyWorkBench);
                recipe.SetResult(statue);
                recipe.AddRecipe();
            }

            //functional
            AddStatueRecipe(ItemID.BatStatue, ItemID.BatBanner);
            AddStatueRecipe(ItemID.ChestStatue, ItemID.MimicBanner);
            AddStatueRecipe(ItemID.CrabStatue, ItemID.CrabBanner);
            AddStatueRecipe(ItemID.JellyfishStatue, ItemID.JellyfishBanner);
            AddStatueRecipe(ItemID.PiranhaStatue, ItemID.PiranhaBanner);
            AddStatueRecipe(ItemID.SharkStatue, ItemID.SharkBanner);
            AddStatueRecipe(ItemID.SkeletonStatue, ItemID.SkeletonBanner);
            AddStatueRecipe(ItemID.BoneSkeletonStatue, ItemID.SkeletonBanner);
            AddStatueRecipe(ItemID.SlimeStatue, ItemID.SlimeBanner);
            AddStatueRecipe(ItemID.WallCreeperStatue, ItemID.SpiderBanner);
            AddStatueRecipe(ItemID.UnicornStatue, ItemID.UnicornBanner);
            AddStatueRecipe(ItemID.DripplerStatue, ItemID.DripplerBanner);
            AddStatueRecipe(ItemID.WraithStatue, ItemID.WraithBanner);
            AddStatueRecipe(ItemID.UndeadVikingStatue, ItemID.UndeadVikingBanner);
            AddStatueRecipe(ItemID.MedusaStatue, ItemID.MedusaBanner);
            AddStatueRecipe(ItemID.HarpyStatue, ItemID.HarpyBanner);
            AddStatueRecipe(ItemID.PigronStatue, ItemID.PigronBanner);
            AddStatueRecipe(ItemID.HopliteStatue, ItemID.GreekSkeletonBanner);
            AddStatueRecipe(ItemID.GraniteGolemStatue, ItemID.GraniteGolemBanner);
            AddStatueRecipe(ItemID.BloodZombieStatue, ItemID.BloodZombieBanner);
            AddStatueRecipe(ItemID.BombStatue, ItemID.Bomb, 99);
            AddStatueRecipe(ItemID.HeartStatue, ItemID.LifeCrystal, 6);
            AddStatueRecipe(ItemID.StarStatue, ItemID.ManaCrystal, 6);
            AddStatueRecipe(ItemID.ZombieArmStatue, ItemID.ZombieBanner);
            AddStatueRecipe(ItemID.CorruptStatue, ItemID.EaterofSoulsBanner);
            AddStatueRecipe(ItemID.EyeballStatue, ItemID.DemonEyeBanner);
            AddStatueRecipe(ItemID.GoblinStatue, ItemID.GoblinPeonBanner);
            AddStatueRecipe(ItemID.HornetStatue, ItemID.HornetBanner);
            AddStatueRecipe(ItemID.ImpStatue, ItemID.FireImpBanner);

            //non functional
            AddStatueRecipe(ItemID.ShieldStatue, -1);
            AddStatueRecipe(ItemID.AnvilStatue,-1);
            AddStatueRecipe(ItemID.AxeStatue, -1);
            AddStatueRecipe(ItemID.BoomerangStatue, -1);
            AddStatueRecipe(ItemID.BootStatue, -1);
            AddStatueRecipe(ItemID.BowStatue, -1);
            AddStatueRecipe(ItemID.HammerStatue, -1);
            AddStatueRecipe(ItemID.PickaxeStatue, -1);
            AddStatueRecipe(ItemID.SpearStatue, -1);
            AddStatueRecipe(ItemID.SunflowerStatue, -1);
            AddStatueRecipe(ItemID.SwordStatue, -1);
            AddStatueRecipe(ItemID.PotionStatue, -1);
            AddStatueRecipe(ItemID.AngelStatue, -1);
            AddStatueRecipe(ItemID.CrossStatue, -1);
            AddStatueRecipe(ItemID.GargoyleStatue, -1);
            AddStatueRecipe(ItemID.GloomStatue, -1);
            AddStatueRecipe(ItemID.PillarStatue, -1);
            AddStatueRecipe(ItemID.PotStatue, -1);
            AddStatueRecipe(ItemID.ReaperStatue, -1);
            AddStatueRecipe(ItemID.WomanStatue, -1);
            AddStatueRecipe(ItemID.TreeStatue, -1);

            //lihzahrd
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.LihzahrdBanner);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemID.LihzahrdGuardianStatue);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.LihzahrdBanner);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemID.LihzahrdStatue);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.LihzahrdBanner);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemID.LihzahrdWatcherStatue);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Throne);
            recipe.AddIngredient(ItemID.TeleportationPotion);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemID.KingStatue);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Throne);
            recipe.AddIngredient(ItemID.TeleportationPotion);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemID.QueenStatue);
            recipe.AddRecipe();
        }

        private static void AddContainerLootRecipes()
        {
            ModRecipe recipe;
            void KeyToItemRecipe(int key, int result)
            {
                recipe = GetNewRecipe();
                recipe.AddIngredient(key);
                recipe.AddIngredient(ItemID.Ectoplasm, 10);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(result);
                recipe.AddRecipe();
            }

            KeyToItemRecipe(ItemID.CrimsonKey, ItemID.VampireKnives);
            KeyToItemRecipe(ItemID.CorruptionKey, ItemID.ScourgeoftheCorruptor);
            KeyToItemRecipe(ItemID.JungleKey, ItemID.PiranhaGun);
            KeyToItemRecipe(ItemID.FrozenKey, ItemID.StaffoftheFrostHydra);
            KeyToItemRecipe(ItemID.HallowedKey, ItemID.RainbowGun);
            //Desert key

            if (Fargowiltas.ModLoaded["ThoriumMod"])
            {
                Mod thorium = ModLoader.GetMod("ThoriumMod");

                KeyToItemRecipe(thorium.ItemType("DesertBiomeKey"), thorium.ItemType("PharaohsSlab"));
                KeyToItemRecipe(thorium.ItemType("UnderworldBiomeKey"), thorium.ItemType("PheonixStaff"));
                KeyToItemRecipe(thorium.ItemType("AquaticDepthsBiomeKey"), thorium.ItemType("Fishbone"));
            }

            // Goodie Bag / Present recipes
            void AddGrabBagItemRecipe(int result, int grabBag = ItemID.Present, int grabBagAmount = 50)
            {
                recipe = GetNewRecipe();
                recipe.AddIngredient(grabBag, grabBagAmount);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(result);
                recipe.AddRecipe();
            }

            AddGrabBagItemRecipe(ItemID.DogWhistle);
            AddGrabBagItemRecipe(ItemID.Toolbox);
            AddGrabBagItemRecipe(ItemID.HandWarmer);
            AddGrabBagItemRecipe(ItemID.RedRyder);
            AddGrabBagItemRecipe(ItemID.CandyCaneSword);
            AddGrabBagItemRecipe(ItemID.CandyCaneHook);
            AddGrabBagItemRecipe(ItemID.FruitcakeChakram);
            AddGrabBagItemRecipe(ItemID.CnadyCanePickaxe);
            AddGrabBagItemRecipe(ItemID.UnluckyYarn, ItemID.GoodieBag);
            AddGrabBagItemRecipe(ItemID.BatHook, ItemID.GoodieBag, 100);

            //wooden
            AddGrabBagItemRecipe(ItemID.SailfishBoots, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.TsunamiInABottle, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Extractinator, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Aglet, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.CordageGuide, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Umbrella, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.ClimbingClaws, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Radar, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.WoodenBoomerang, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.WandofSparking, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Spear, ItemID.WoodenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Blowpipe, ItemID.WoodenCrate, 5);
            //step stool and finch staff here, ladybug and sunflower cart, finch staff
            //pearlwood /////////////////////////////////////////////////
            AddGrabBagItemRecipe(ItemID.Anchor, ItemID.WoodenCrate, 5);
            //all else is the same except no extractinator? recipe group
            
            //iron
            AddGrabBagItemRecipe(ItemID.FalconBlade, ItemID.IronCrate, 5);
            AddGrabBagItemRecipe(ItemID.TartarSauce, ItemID.IronCrate, 5);
            AddGrabBagItemRecipe(ItemID.GingerBeard, ItemID.IronCrate, 5);
            //mythril
            //same stuff recipe group


            //gold
            AddGrabBagItemRecipe(ItemID.HardySaddle, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.Sundial, ItemID.GoldenCrate, 10);
            AddGrabBagItemRecipe(ItemID.EnchantedSword, ItemID.GoldenCrate, 10);
            AddGrabBagItemRecipe(ItemID.BandofRegeneration, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.MagicMirror, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.FlareGun, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.HermesBoots, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.ShoeSpikes, ItemID.GoldenCrate, 5);
            AddGrabBagItemRecipe(ItemID.CloudinaBottle, ItemID.GoldenCrate, 5);
            //add mace here
            
            //titanium
            //same shit recipe group

            //jungle
            AddGrabBagItemRecipe(ItemID.AnkletoftheWind, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.StaffofRegrowth, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Boomstick, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.FeralClaws, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.FiberglassFishingPole, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.HoneyDispenser, ItemID.JungleFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.FlowerBoots, ItemID.JungleFishingCrate, 5);
            AddGrabBagItemRecipe(ItemID.Seaweed, ItemID.JungleFishingCrate, 10);
            //bee minecart
            //bramble
            //same shit

            //sky
            AddGrabBagItemRecipe(ItemID.ShinyRedBalloon, ItemID.FloatingIslandFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Starfury, ItemID.FloatingIslandFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.LuckyHorseshoe, ItemID.FloatingIslandFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.SkyMill, ItemID.FloatingIslandFishingCrate, 3);
            //azure
            //same shit

            //corrupt
            AddGrabBagItemRecipe(ItemID.BallOHurt, ItemID.CorruptFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.BandofStarpower, ItemID.CorruptFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.ShadowOrb, ItemID.CorruptFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Musket, ItemID.CorruptFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Vilethorn, ItemID.CorruptFishingCrate, 3);
            //defiled
            //same shit recipe group

            //crimson
            AddGrabBagItemRecipe(ItemID.TheUndertaker, ItemID.CrimsonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.TheRottedFork, ItemID.CrimsonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.CrimsonRod, ItemID.CrimsonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.PanicNecklace, ItemID.CrimsonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.CrimsonHeart, ItemID.CrimsonFishingCrate, 3);
            //hematic same ree

            //dungeon
            AddGrabBagItemRecipe(ItemID.WaterBolt, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Muramasa, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.CobaltShield, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.MagicMissile, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.AquaScepter, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Valor, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.Handgun, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.ShadowKey, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.BlueMoon, ItemID.DungeonFishingCrate, 3);
            AddGrabBagItemRecipe(ItemID.BoneWelder, ItemID.DungeonFishingCrate, 3);
            //stockade
            //same but change recipe to 1 lockbox and 1 key

            //frozen crate
            /*AddGrabBagItemRecipe(ItemID.SnowballCannon, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.BlizzardinaBottle, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.IceBlade, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.IceSkates, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.IceMirror, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.FlurryBoots, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.IceBoomerang, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.IceMachine, ModContent.ItemType<IceCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.Fish, ModContent.ItemType<IceCrate>(), 10);*/
            //boreal crate (same stuff)

            //oasis crate
            //dunerider boots, storm spear, ancient chisel, thunder zapper, snake charmers flute, magic conch, bast statue, scarab fishing pole, encumbering stone, desert minecart
            AddGrabBagItemRecipe(ItemID.FlyingCarpet, ItemID.GoldenCrate, 5); //make these from here instead
            AddGrabBagItemRecipe(ItemID.SandstorminaBottle, ItemID.GoldenCrate, 5);
            //mirage crate (same)




            //obsidian
            //10 for slice of hell cake and ornate shadow key
            //5 for lava charm
            //1 for lavaproof fishing hook, superheated blood, flame waker boots, demonic hellcart
            /*AddGrabBagItemRecipe(ItemID.DarkLance, ModContent.ItemType<ShadowCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.HellwingBow, ModContent.ItemType<ShadowCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.Flamelash, ModContent.ItemType<ShadowCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.FlowerofFire, ModContent.ItemType<ShadowCrate>(), 1);
            AddGrabBagItemRecipe(ItemID.Sunfury, ModContent.ItemType<ShadowCrate>(), 1);*/
            //treasure magnet
            //hellstone (same)

            // ocean crate
            //breathing reed, flipper, trident, inner tube for 1
            //shark bait and water walking boots for 5?
            //seaside crate (same)
        }

        private static void AddNPCRecipes()
        {
            ModRecipe recipe = GetNewRecipe();
            recipe.AddRecipeGroup("Fargowiltas:AnyCaughtNPC");
            recipe.AddTile(TileID.MeatGrinder);
            recipe.SetResult(ItemID.FleshBlock, 25);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("Fargowiltas:AnyCaughtNPC");
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(ItemID.DeepRedPaint, 20);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ModContent.ItemType<Truffle>());
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(ItemID.BluePaint, 20);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("Fargowiltas:AnyCaughtNPC");
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(ItemID.GrimDye, 2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("Fargowiltas:AnyCaughtNPC");
            recipe.AddTile(TileID.BoneWelder);
            recipe.SetResult(ItemID.Bone, 25);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Dryad");
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.LeafWand);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Dryad");
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.LivingWoodWand);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Truffle");
            recipe.AddIngredient(ItemID.EnchantedNightcrawler);
            recipe.AddTile(TileID.Autohammer);
            recipe.SetResult(ItemID.TruffleWorm);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "DyeTrader");
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.DyeTradersScimitar);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Tavernkeep");
            recipe.AddIngredient(ItemID.Ale, 5);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.AleThrowingGlove);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Stylist");
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.StylistKilLaKillScissorsIWish);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Painter");
            recipe.AddIngredient(ItemID.WoodenBow);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.PainterPaintballGun);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "TaxCollector");
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.TaxCollectorsStickOfDoom);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Angler");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.FishermansGuide);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Angler");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.WeatherRadio);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "Angler");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.Sextant);
            recipe.AddRecipe();

            //travelling merch recipes (add many more)
            recipe = GetNewRecipe();
            recipe.AddIngredient(null, "TravellingMerchant", 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.AngelHalo);
            recipe.AddRecipe();


            //engineers combat rench recipe
            //engineer plus wrench 
        }

        private static void AddTreasureBagRecipes()
        {
            ModRecipe recipe = GetNewRecipe();
            //QB
            recipe.AddIngredient(ItemID.QueenBeeBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BeesKnees);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.QueenBeeBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BeeGun);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.QueenBeeBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BeeKeeper);
            recipe.AddRecipe();

            //WOF
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.RangerEmblem);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.SorcererEmblem);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.SummonerEmblem);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.WarriorEmblem);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.ClockworkAssaultRifle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BreakerBlade);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WallOfFleshBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.LaserRifle);
            recipe.AddRecipe();

            //add firecracker here

            //plantera
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.GrenadeLauncher);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.VenusMagnum);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.NettleBurst);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.LeafBlower);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Seedler);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.FlowerPow);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PlanteraBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.WaspGun);
            recipe.AddRecipe();

            //golem
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Stynger);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.PossessedHatchet);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.SunStone);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.EyeoftheGolem);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Picksaw);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.HeatRay);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.StaffofEarth);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GolemBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.GolemFist);
            recipe.AddRecipe();

            //duke
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Flairon);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Tsunami);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.RazorbladeTyphoon);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.TempestStaff);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishronBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.BubbleGun);
            recipe.AddRecipe();

            //empress
            //starlight, kalediscope, eventide, nightglow

            //moon lord
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Meowmere);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.Terrarian);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.StarWrath);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.SDMG);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.FireworksLauncher); //CHANGE TO CELEB MK 2
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.LastPrism);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.LunarFlareBook);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.RainbowCrystalStaff);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.MoonLordBossBag);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.MoonlordTurretStaff);
            recipe.AddRecipe();

            //meowmere minecart here

            //besty
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BossBagBetsy);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.DD2BetsyBow);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BossBagBetsy);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.DD2SquireBetsySword);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BossBagBetsy);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.ApprenticeStaffT3);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BossBagBetsy);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(ItemID.MonkStaffT3);
            recipe.AddRecipe();


        }

        private static void AddMiscRecipes()
        {
            ModRecipe recipe = GetNewRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.IceBlade);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.EnchantedSword);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.EnchantedSword, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.Arkhalis); //terragrim
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Pumpkin, 500);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.MagicalPumpkinSeed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.FishingSeaweed, 5);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.Seaweed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.HermesBoots);
            recipe.AddIngredient(ItemID.Daybloom);
            recipe.AddIngredient(ItemID.Blinkroot);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.Moonglow);
            recipe.AddIngredient(ItemID.Waterleaf);
            recipe.AddIngredient(ItemID.Deathweed);
            recipe.AddIngredient(ItemID.Fireblossom);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.FlowerBoots);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Loom);
            recipe.AddIngredient(ItemID.Vine, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.LivingLoom);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.NaturesGift);
            recipe.AddIngredient(ItemID.RedHusk);
            recipe.AddTile(TileID.LivingLoom);
            recipe.SetResult(ItemID.JungleRose);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Amber, 15);
            recipe.AddIngredient(ItemID.Firefly);
            recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(ItemID.AmberMosquito);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Moonglow, 15);
            recipe.AddIngredient(ItemID.ManaCrystal);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(ItemID.NaturesGift);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.SandBlock, 50);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(ItemID.SandstorminaBottle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ChlorophyteBar);
            recipe.AddIngredient(ItemID.DarkBlueSolution);
            recipe.AddTile(TileID.Autohammer);
            recipe.SetResult(ItemID.ShroomiteBar);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GrapplingHook);
            recipe.AddIngredient(ItemID.WebRopeCoil, 8);
            recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(ItemID.WebSlinger);
            recipe.AddRecipe();

        }

        private static void AddFurnitureRecipes()
        {
            //Dungeon furniture pain
            ModRecipe recipe = GetNewRecipe();
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueBrickPlatform, 2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonBathtub);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 15);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonBed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 20);
            recipe.AddIngredient(ItemID.Book, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonBookcase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 5);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonCandelabra);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 4);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonCandle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonChair);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 4);
            recipe.AddIngredient(ItemID.Torch, 4);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonChandelier);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar");
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemID.BlueBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DungeonClockBlue);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonDoor);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonDresser);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddIngredient(ItemID.BlueBrick, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonLamp);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Bone, 4);
            recipe.AddIngredient(ItemID.BlueBrick, 15);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonPiano);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 5);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonSofa);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonTable);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonVase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueDungeonWorkBench);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueBrickWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueSlabWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.BlueBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlueTiledWall, 4);
            recipe.AddRecipe();

            //green
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenBrickPlatform, 2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonBathtub);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 15);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonBed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 20);
            recipe.AddIngredient(ItemID.Book, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonBookcase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 5);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonCandelabra);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 4);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonCandle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonChair);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 4);
            recipe.AddIngredient(ItemID.Torch, 4);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonChandelier);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar");
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemID.GreenBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DungeonClockGreen);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonDoor);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonDresser);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddIngredient(ItemID.GreenBrick, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonLamp);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Bone, 4);
            recipe.AddIngredient(ItemID.GreenBrick, 15);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonPiano);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 5);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonSofa);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonTable);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonVase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenDungeonWorkBench);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenBrickWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenSlabWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.GreenBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GreenTiledWall, 4);
            recipe.AddRecipe();

            //pink
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkBrickPlatform, 2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonBathtub);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 15);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonBed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 20);
            recipe.AddIngredient(ItemID.Book, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonBookcase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 5);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonCandelabra);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 4);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonCandle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonChair);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 4);
            recipe.AddIngredient(ItemID.Torch, 4);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonChandelier);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar");
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemID.PinkBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DungeonClockPink);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonDoor);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonDresser);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddIngredient(ItemID.PinkBrick, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonLamp);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Bone, 4);
            recipe.AddIngredient(ItemID.PinkBrick, 15);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonPiano);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 5);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonSofa);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonTable);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonVase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkDungeonWorkBench);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkBrickWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkSlabWall, 4);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.PinkBrick);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PinkTiledWall, 4);
            recipe.AddRecipe();

            //obsidian
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianBathtub);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 15);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianBed);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 20);
            recipe.AddIngredient(ItemID.Book, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianBookcase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 5);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianCandelabra);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 4);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianCandle);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianChair);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 4);
            recipe.AddIngredient(ItemID.Torch, 4);
            recipe.AddIngredient(ItemID.Chain, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianChandelier);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar");
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemID.ObsidianBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianClock);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianDoor);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianDresser);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddIngredient(ItemID.ObsidianBrick, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianLamp);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Bone, 4);
            recipe.AddIngredient(ItemID.ObsidianBrick, 15);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianPiano);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 5);
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianSofa);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianTable);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianVase);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.ObsidianBrick, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianWorkBench);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.LihzahrdBrick, 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.LihzahrdFurnace);
            recipe.AddRecipe();

            //lanterns
            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ChainLantern);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BrassLantern);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CagedLantern);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CarriageLantern);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AlchemyLantern);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DiablostLamp);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bone, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.OilRagSconse);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Obsidian, 6);
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ObsidianLantern);
            recipe.AddRecipe();

            //platforms
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WoodPlatform, 5);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DungeonShelf, 5);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WoodPlatform, 5);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WoodShelf, 5);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WoodPlatform, 5);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MetalShelf, 5);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.WoodPlatform, 5);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BrassShelf, 5);
            recipe.AddRecipe();

            //banners
            //dungeon
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.MarchingBonesBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.NecromanticSign);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.RustedCompanyStandard);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.RaggedBrotherhoodSigil);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.MoltenLegionFlag);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.DiabolicSigil);
            recipe.AddRecipe();

            //sky island
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SunplateBlock, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.WorldBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SunplateBlock, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.SunBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SunplateBlock, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.GravityBanner);
            recipe.AddRecipe();

            //underworld
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.HellboundBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.HellHammerBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.HelltowerBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.LostHopesofManBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.ObsidianWatcherBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.LavaEruptsBanner);
            recipe.AddRecipe();

            //pyramid
            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SandstoneBrick, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.AnkhBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SandstoneBrick, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.SnakeBanner);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddIngredient(ItemID.SandstoneBrick, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.OmegaBanner);
            recipe.AddRecipe();

        }

        private static void AddConvertRecipe(int item, int item2)
        {
            ModRecipe recipe = GetNewRecipe();
            recipe.AddIngredient(item);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(item2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(item2);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(item);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(item);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(item2);
            recipe.AddRecipe();

            recipe = GetNewRecipe();
            recipe.AddIngredient(item2);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(item);
            recipe.AddRecipe();
        }

        private static ModRecipe GetNewRecipe()
        {
            return new ModRecipe(ModContent.GetInstance<Fargowiltas>());
        }
    }
}
