using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftingSim.Model
{
    public class Material : IMaterial
    {
        private int Ids;
        private string Names;

        public Material(int id, string name)
        {
            this.Ids = id;
            this.Names = name;
        }

        public int Id => this.Ids;
        public string Name => this.Names;

        
        
        public bool Equals(IMaterial obj)
        {
            if (obj is IMaterial other)
            {
                return this.Ids == other.Id && this.Names == other.Name;
            }
            return false;
        }


    }
}