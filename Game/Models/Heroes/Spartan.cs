﻿using System.Collections.Generic;
using ConsoleApplication5.Models;

namespace Game.Models.Heroes
{
    public class Spartan : Hero
    {
        private const int spartanHealth = 110;
        private const int spartanAttack = 25;
        private const int spartanDefence = 35;

        protected Spartan(string id, Point location, Size objectSize, List<Item> items) :
            base(id, location, objectSize, spartanHealth, spartanAttack, spartanDefence, items)
        {
        }
    }
}