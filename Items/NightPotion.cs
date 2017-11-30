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
	public class NightPotion : ModItem
	{		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Potion");
			Tooltip.SetDefault("Change time to night.");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.value = 10000;
			item.rare = 4;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
		}
		
		public override bool UseItem(Player player)
		{
			Main.dayTime = false;
			Main.time = 0.0;
			if (Main.netMode == 2)
				NetMessage.SendData(MessageID.WorldData);
			
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddIngredient(ItemID.RainbowBrick);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddIngredient(ItemID.RainbowBrick);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
