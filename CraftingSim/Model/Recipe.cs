using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftingSim.Model
{
    public class Recipe
    {
        private IReadOnlyDictionary<IMaterial, int> RequiredMaterial;
        private double SuccessRates;
        private string Names;

        public Recipe(double SuccessRate, string name,IReadOnlyDictionary<IMaterial, int> RequiredMaterial)
        {
            this.SuccessRates = SuccessRate;
            this.Names = name;
            this.RequiredMaterial = RequiredMaterial;
        }
        public IReadOnlyDictionary<IMaterial, int> RequiredMaterials => RequiredMaterial;
        public double SuccessRate => this.SuccessRates;
        public string Name => this.Names;


    }
}