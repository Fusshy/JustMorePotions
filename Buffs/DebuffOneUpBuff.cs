using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JMP.Buffs
{
	public class DebuffOneUpBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Can't 1UP");
			Description.SetDefault("You can die"
								+"\nAt least for next 5 minutes.");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
		}	

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<JMPPlayer>(mod).NoONEUP = true;
			player.buffImmune[mod.BuffType("OneUpbuff")] = true;
		}

		// public override void Update(NPC npc, ref int buffIndex)
		// {
			// npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
//			npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
		// }
	}
}
