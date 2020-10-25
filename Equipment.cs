//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }
        private double hourlyCost;
        

        // Precondición: El valor debe ser mayor a 0
        // Postcondición: El valor hora es igual al valor recibido 
        // Invariante: La descripción sigue siendo la misma
        public double HourlyCost 
        { 
            get
            {
                return this.hourlyCost;
            } 
            set
            {
                
                if(value > 0) // Chequeo de la precondición, el valor a asignar debe ser positivo
                {
                    this.hourlyCost = value;
                }
                else // Si el valor es 0 o negativo, se lanza una excepción
                {
                    throw new NegativeValueException("El valor/hora no puede ser negativo");
                }
            } 
        }
    }
}