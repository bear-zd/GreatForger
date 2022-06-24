using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria;
using Microsoft.Xna.Framework;
using System;


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

        /* randomDebuff
         * 
         * 
         * 
         * 
         */
        public List<float> randomDebuff(List<int> validBuff, List<float> defaultRatio, float totalDecease)
        { 
            Random rand = new Random();
            int debuffNum = rand.Next(1, 3);
            switch(debuffNum)
            {
                case 1:
                    {
                        
                    }
                    
            }
        

            
            return { };
        }


            

    }
}