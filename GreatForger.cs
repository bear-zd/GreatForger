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

        /* randomDebuff: 
         * validBuff: list of the buff take effect.-1 means can't keep it defaultRatio
         * 0 means no means to change. 1 means should change.
         * defaultRatio: list of the debuff ratio has been set at the prefix setstat method.
         * totalDerease: the sum of the debuffRatio's multiple will equal to this number.
         * 
         */
        public List<float> randomDebuff(List<int> validBuff, List<float> defaultRatio, float totalDecease)
        { 
            Random rand = new Random();
            int debuffNum = rand.Next(1, 4);
            for(int i=0;i<7;i++)
            {
                break;
            }
            switch(debuffNum)
            {
                case 1:
                    {
                        break;
                    }
                    
            }



            return defaultRatio;
        }
        


            

    }
}