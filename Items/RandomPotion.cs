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
	public class RandomPotion : ModItem
	{		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Random Potion");
			Tooltip.SetDefault("You will get a random buff for 30 minute."
							+"\nBuff are random."
							+"\nDon't have buffs from mods.");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 36;
			item.maxStack = 30;
			item.value = 100000;
			item.rare = 4;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
            item.buffType = mod.BuffType("RandomBuff");
            item.buffTime = 1;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Deathweed, 5);
			recipe.AddIngredient(ItemID.Fireblossom, 5);
			recipe.AddIngredient(ItemID.Moonglow, 5);
			recipe.AddIngredient(ItemID.Shiverthorn, 5);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Mushroom, 25);
			recipe.AddIngredient(ItemID.GlowingMushroom, 25);
			recipe.AddIngredient(ItemID.VileMushroom, 25);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Deathweed, 5);
			recipe.AddIngredient(ItemID.Fireblossom, 5);
			recipe.AddIngredient(ItemID.Moonglow, 5);
			recipe.AddIngredient(ItemID.Shiverthorn, 5);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Mushroom, 25);
			recipe.AddIngredient(ItemID.GlowingMushroom, 25);
			recipe.AddIngredient(ItemID.VileMushroom, 25);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Deathweed, 5);
			recipe.AddIngredient(ItemID.Fireblossom, 5);
			recipe.AddIngredient(ItemID.Moonglow, 5);
			recipe.AddIngredient(ItemID.Shiverthorn, 5);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Mushroom, 25);
			recipe.AddIngredient(ItemID.GlowingMushroom, 25);
			recipe.AddIngredient(ItemID.ViciousMushroom, 25);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(ItemID.Deathweed, 5);
			recipe.AddIngredient(ItemID.Fireblossom, 5);
			recipe.AddIngredient(ItemID.Moonglow, 5);
			recipe.AddIngredient(ItemID.Shiverthorn, 5);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Mushroom, 25);
			recipe.AddIngredient(ItemID.GlowingMushroom, 25);
			recipe.AddIngredient(ItemID.ViciousMushroom, 25);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();			
		}
	}
}
