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

namespace JMP.Items
{
	public class OneUPPotion : ModItem
	{		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("1Up Potion");
			Tooltip.SetDefault("If you lose die in next 5 minutes, ressurect you with full life."
							+"\nAfter it happen, you can't ressurect for next 5 minutes.");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.value = 50000;
			item.rare = 4;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
            item.buffType = mod.BuffType("OneUpbuff");
            item.buffTime = 18000;
		}
		
		public override bool UseItem(Player player)
		{
			if (!player.GetModPlayer<JMPPlayer>(mod).NoONEUP)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
