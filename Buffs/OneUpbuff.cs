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
	public class OneUpbuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("1UP");
			Description.SetDefault("You don't die"
								+"\nAt least one time");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = false;
		}	

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<JMPPlayer>(mod).OneUPACTIVE = true;
		}

		// public override void Update(NPC npc, ref int buffIndex)
		// {
			// npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
//			npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
		// }
	}
}
