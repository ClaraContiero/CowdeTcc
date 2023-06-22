using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cowde.Models
{
    public class Avatares
    {
        private string avatar;

        public Avatares(string avatar)
        {
            this.avatar = avatar;
        }

        public string Avatar { get => avatar; set => avatar = value; }



    }
}
