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
        // Precondición: el tiempo tiene que ser mayor a 0
        // Postcondición: el tiempo sea igual al recibido
        // Invariante: La cantidad sigue siendo la misma        
        private int time;
        public int Time
        { 
            get
            {
                return this.time;   
            } 
            set
            {
                if(value > 0) // Chequeo de la precondición, el tiempo debe ser mayor a 0
                {
                    this.time = value;
                }
                else // Si el valor es 0 o negativo, se lanza una excepción
                {
                    throw new NegativeValueException("El tiempo no puede ser menor a 0");
                }
            }
        }

        // Precondición: equipment no puede ser nulo
        // Postcondición: equipment debe ser igual al recibido
        // Invariante: El tiempo sigue siendo el mismo
        private Equipment equipment;
        public Equipment Equipment
        { 
            get
            {
                return this.equipment;
            } 
            set
            {
                
                if(value != null) // Chequeo de la precondición,  no debe ser nulo
                {
                    this.equipment = value;
                }
                else // Si el equipment a asignar es nulo, se lanza una excepción
                {
                    throw new NullReferenceException("Equipment no puede ser nulo");
                }
            }
        }
    }
}