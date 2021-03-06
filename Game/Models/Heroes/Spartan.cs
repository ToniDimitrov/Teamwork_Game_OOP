﻿using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Spartan : Hero
    {
        private const int spartanHealth = 110;
        private const int spartanAttack = 25;
        private const int spartanDefence = 35;
        private const string pathToImage = "Spartan.png";
        private const string pathToImage1 = "Spartan1.png";
        private const string pathToImage2 = "RevertedSpartan.png";
        private const string pathToImage3 = "RevertedSpartan1.png";


        public Spartan(string id, Point location, Size objectSize, IList<IItem> items)
            : base(id, location, objectSize, spartanHealth, spartanAttack, spartanDefence, items, pathToImage, pathToImage1, pathToImage2, pathToImage3)
        {
        }
    }
}