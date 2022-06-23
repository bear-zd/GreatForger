using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria;
using Microsoft.Xna.Framework;

namespace GreatForger
{
    public class GreatForger : Mod
    {
        internal UserInterface GreatForgerUserInterface;
        public static GreatForger Instance;

        public GreatForger()
        {

        }
        public override void Load()
        {
            Instance = this;    
            GreatForgerUserInterface = new UserInterface();
            base.Load();
        }
        public override void Unload()
        {
            Instance = null;
        }

    }
}