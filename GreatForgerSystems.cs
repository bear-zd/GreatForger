using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using GreatForger.Content.UI;
using GreatForger;

namespace GreatForger
{
    internal class GreatForgerSystems : ModSystem
    {
		private UserInterface GreatForgerUserInterface;
		public override void OnModLoad()
		{
			GreatForgerUserInterface = GreatForger.Instance.GreatForgerUserInterface;
		}

		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
			int inventoryIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
			if (inventoryIndex != -1)
			{
				layers.Insert(inventoryIndex, new LegacyGameInterfaceLayer(
					"ExampleMod: Example Person UI",
					delegate {
						// If the current UIState of the UserInterface is null, nothing will draw. We don't need to track a separate .visible value.
						GreatForgerUserInterface.Draw(Main.spriteBatch, new GameTime());
						return true;
					},
					InterfaceScaleType.UI)
				);
			}
		}
		public override void UpdateUI(GameTime gameTime)
		{
			GreatForgerUserInterface?.Update(gameTime);
		}
	}
	
}
