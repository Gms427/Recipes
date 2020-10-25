//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        private double unitCost;
        public double UnitCost 
        { 
            get
            {
                return this.unitCost;
            } 
            set
            {
                
                if(value > 0) // Chequeo de la precondición, el valor a asignar debe ser positivo
                {
                    this.unitCost = value;
                }
                else // Si el valor es 0 o negativo, se lanza una excepción
                {
                    throw new NegativeValueException("El valor unitario no puede ser negativo");
                }
            } 
        }
    }
}