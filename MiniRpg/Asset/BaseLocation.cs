using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiniRpg.Asset
{
    internal abstract class BaseLocation
    {
        [Required]
        private string name;
        private string[] description;


        public string Name { get { return name; } set { name = value; } }
        public string[] Description { get { return description; } set { description = value; } }

        public BaseLocation(string name, string[] description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
