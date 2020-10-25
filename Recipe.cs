//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }


        // Precondición: step tiene que ser distinto de nulo
        // Postcondición: el step se agrega al arraylist
        // Invariante: el arraylist debe seguir siendo no nulo
        public void AddStep(Step step)
        {
            if(step == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                this.steps.Add(step);
            }
        }

        // Precondición: step tiene que ser distinto de nulo y estar ya en la lista
        // Postcondición: el arraylist no contiene el step 
        // Invariante: el arraylist debe seguir siendo no nulo
        public void RemoveStep(Step step)
        {
            if(step == null)
            {
                throw new NullReferenceException();
            }
            else if(!this.steps.Contains(step))
            {
                throw new NotContainStepException("No se pueden eliminar Steps que no sean parte del Recipe");
            }
            else
            {
                this.steps.Remove(step);
            }
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}