/*
 * File: ShoppingCartMain.cs
 * Author: Christian J. Ramos Ortega 841-18-4582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/22/2023
 * Purpose: This is the main program for the ShoppingCartApp.
 */
namespace ShoppingCartApp
{
    internal static class ShoppingCartMain
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ShoppingCartForm());
        }
    }
}