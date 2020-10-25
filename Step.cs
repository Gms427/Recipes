//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        /*
            Precondiciones: 
                - Producto no nulo
                - Cantidad mayor a 0
                - Equipamiento no nulo
                - Tiempo mayor a 0
        

            Postcondición:
                - Se crea la instancia del Step
        */
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        private Product input;

        public Product Input
        { 
            get
            {
                return this.input;
            } 
            set
            {
                if(value == null) // Chequeo de la precondición, la instancia de la clase
                // Product a asignar no debe ser nula
                {
                    throw new NullReferenceException();
                }
                else // Si la instancia no es nula, se le asigna el valor a la clase Step
                {
                    this.input = value;
                }
            } 
        }
        private double quantity;
        public double Quantity 
        { 
            get
            {
                return this.quantity;
            } 
            set
            {
                
                if(value > 0) // Chequeo de la precondición, el valor a asignar debe ser positivo
                {
                    this.quantity = value;
                }
                else // Si el valor es 0 o negativo, se lanza una excepción
                {
                    throw new NegativeValueException("La cantidad no puede ser negativa");
                }
            } 
        }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}