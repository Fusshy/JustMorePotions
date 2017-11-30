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
	public class RandomBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Random Buff");
			Description.SetDefault("You get random buffs :D");
			Main.buffNoTimeDisplay[Type] = true;
			Main.debuff[Type] = false;
		}	

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<JMPPlayer>(mod).RandomBuffActive = true;
			player.GetModPlayer<JMPPlayer>(mod).RandomBuff();
			
		}

		// public override void Update(NPC npc, ref int buffIndex)
		// {
			// npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
//			npc.GetModInfo<UpdatedPlayer>(mod).AnkhPaladinBuff = true;
		// }
	}
}
