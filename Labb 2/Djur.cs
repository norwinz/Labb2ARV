using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    class Djur
    {
        private int _Eyes, _Legs;
        private string _Color, _Sound;
        bool _LiveInWater;
        

        public Djur(int Eyes, int Legs, string Color, string Sound, bool LiveInWater)
            {
            _Eyes = Eyes;
            _Legs = Legs;
            _Color = Color;
            _Sound = Sound;
            _LiveInWater = LiveInWater;
            }

    }
}
