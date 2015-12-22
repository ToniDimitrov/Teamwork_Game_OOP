using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Exceptions
{
    public class InvalidHeroImagePathException : Exception
    {
        public InvalidHeroImagePathException(string message) : base(message)
        {
        }
    }
}
