//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
    /*
    Para asignar la responsabilidad, usamos el principio de Polymorphism, dado que
    la operación de "PrintRecipe" debe variar según el tipo de Print que se necesite.
    */
}