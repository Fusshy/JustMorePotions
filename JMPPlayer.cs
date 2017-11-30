using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace JMP
{
	public class JMPPlayer : ModPlayer
	{
		public bool RandomBuffActive = false;
		public bool OneUPACTIVE = false;
		public bool NoONEUP = false;
		
		public override void ResetEffects()
		{
			RandomBuffActive = false;
			OneUPACTIVE = false;
			NoONEUP = false;
		}
		
		public override bool PreHurt (bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
		{
			if (OneUPACTIVE)
			{
				if (damage > player.statLife)
				{
					int	heal = player.statLifeMax2 - player.statLife;
					player.statLife += heal;
					if (player.statLife > player.statLifeMax2)
					{
						player.statLife = player.statLifeMax2;
					}
					
					int	mana = player.statManaMax2 - player.statMana;
					player.statMana += mana;
					if (player.statMana > player.statManaMax2)
					{
						player.statMana = player.statManaMax2;
					}
					
					player.AddBuff(mod.BuffType("DebuffOneUpBuff"), 18000, true);
					Main.PlaySound(SoundID.Item20, player.position);
					int dust = Dust.NewDust(new Vector2(player.position.X * player.direction, player.position.Y - 14f), 0, 0, mod.DustType("OneUpDust"), 0f, 0f, 100, default(Color), 2f);
					Main.dust[dust].noGravity = false;
					Main.dust[dust].velocity.Y = 0f;
					Main.dust[dust].velocity.X = 0f;
					return false;
				}
			}
			return true;
		}
		public void RandomBuff()
		{
			if (this.RandomBuffActive)
			{
				int randomBuff = 0;
				switch (Main.rand.Next(81)) //return 5 values including case 0 and default.
				{
					case 0:
						randomBuff = 112;
						break;
					case 1:
						randomBuff = 16;
						break;
					case 2:
						randomBuff = 13;
						break;
					case 3:
						randomBuff = 107;
						break;
					case 4:
						randomBuff = 106;
						break;
					case 5:
						randomBuff = 123;
						break;
					case 6:
						randomBuff = 111;
						break;
					case 7:
						randomBuff = 114;
						break;
					case 8:
						randomBuff = 8;
						break;
					case 9:
						randomBuff = 121;
						break;
					case 10:
						randomBuff = 109;
						break;
					case 11:
						randomBuff = 4;
						break;
					case 12:
						randomBuff = 18;
						break;
					case 13:
						randomBuff = 105;
						break;
					case 14:
						randomBuff = 17;
						break;
					case 15:
						randomBuff = 116;
						break;
					case 16:
						randomBuff = 10;
						break;
					case 17:
						randomBuff = 5;
						break;
					case 18:
						randomBuff = 113;
						break;
					case 19:
						randomBuff = 7;
						break;
					case 20:
						randomBuff = 6;
						break;
					case 21:
						randomBuff = 104;
						break;
					case 22:
						randomBuff = 12;
						break;
					case 23:
						randomBuff = 1;
						break;
					case 24:
						randomBuff = 115;
						break;
					case 25:
						randomBuff = 2;
						break;
					case 26:
						randomBuff = 11;
						break;
					case 27:
						randomBuff = 122;
						break;
					case 28:
						randomBuff = 9;
						break;
					case 29:
						randomBuff = 110;
						break;
					case 30:
						randomBuff = 3;
						break;
					case 31:
						randomBuff = 14;
						break;
					case 32:
						randomBuff = 108;
						break;
					case 33:
						randomBuff = 124;
						break;
					case 34:
						randomBuff = 15;
						break;
					case 35:
						randomBuff = 117;
						break;
					case 36:
						randomBuff = 26;
						break;
					case 37:
						randomBuff = 73;
						break;
					case 38:
						randomBuff = 74;
						break;
					case 39:
						randomBuff = 75;
						break;
					case 40:
						randomBuff = 76;
						break;
					case 41:
						randomBuff = 77;
						break;
					case 42:
						randomBuff = 79;
						break;
					case 43:
						randomBuff = 71;
						break;
					case 44:
						randomBuff = 95;
						break;
					case 45:
						randomBuff = 96;
						break;
					case 46:
						randomBuff = 97;
						break;
					case 47:
						randomBuff = 98;
						break;
					case 48:
						randomBuff = 99;
						break;
					case 49:
						randomBuff = 100;
						break;
					case 50:
						randomBuff = 173;
						break;
					case 51:
						randomBuff = 174;
						break;
					case 52:
						randomBuff = 175;
						break;
					case 53:
						randomBuff = 176;
						break;
					case 54:
						randomBuff = 177;
						break;
					case 55:
						randomBuff = 178;
						break;
					case 56:
						randomBuff = 179;
						break;
					case 57:
						randomBuff = 180;
						break;
					case 58:
						randomBuff = 181;
						break;
					case 59:
						randomBuff = 62;
						break;
					case 60:
						randomBuff = 151;
						break;
					case 61:
						randomBuff = 34;
						break;
					case 62:
						randomBuff = 63;
						break;
					case 63:
						randomBuff = 58;
						break;
					case 64:
						randomBuff = 187;
						break;
					case 65:
						randomBuff = 28;
						break;
					case 66:
						randomBuff = 150;
						break;
					case 67:
						randomBuff = 29;
						break;
					case 68:
						randomBuff = 159;
						break;
					case 69:
						randomBuff = 87;
						break;
					case 70:
						randomBuff = 150;
						break;
					case 71:
						randomBuff = 165;
						break;
					case 72:
						randomBuff = 146;
						break;
					case 73:
						randomBuff = 89;
						break;
					case 74:
						randomBuff = 48;
						break;
					case 75:
						randomBuff = 157;
						break;
					case 76:
						randomBuff = 158;
						break;
					case 77:
						randomBuff = 157;
						break;
					case 78:
						randomBuff = 157;
						break;
					case 79:
						randomBuff = 157;
						break;
					default:
						randomBuff = 157;
						break;
				}
				player.AddBuff((int)randomBuff, 108000, true);
			}
		}
	}
}
