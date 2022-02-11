using System;
using System.Threading;

namespace Expendedoras_G2_2022_II
{//no se puede llmara igual el namespace y el class
    internal class LaExpendedora
    {
        #region atributos
        string marca;
        byte temperatura;
        float precio;
        ushort cantProductos;
        #endregion

        #region metodos
        void Saludar()
        {
            Console.WriteLine("***Bienbenido a tu expendedora*** \n");
        }

        void LimpiarPantalla()
        {
            Thread.Sleep(2000); //sirve para ralentizar por 2000 milisegundos (2 seg)
            Console.Clear();
        }
        string MostrarCodigoProducto()
        {
            Console.WriteLine(" 1A) Crujitos \n 2B) Totis");
            Console.WriteLine("Introduce el codigo del producto: ");
            string codigo = Console.ReadLine();
            return codigo;

        }
        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "1A":
                    precio = 13;
                    break;

                case "2B":
                    precio= 10;
                    break;
            }
            Console.WriteLine("eL PRECIO ES {0}",precio);
        }
            #endregion

            #region Constructor
            public LaExpendedora()
        {
            marca = "AMD";
            temperatura = 18;
            Saludar();              //limpiar pantalla se agrega System.Threading;
            Thread.Sleep(2000); //sirve para ralentizar por 2000 milisegundos (2 seg)
            Console.Clear(); //limpia la pantalla
            Console.WriteLine("Marca : {0}",marca);
            Console.WriteLine("Temperatura : {0}",temperatura);
            LimpiarPantalla(); //ya es la funcion declarada en métodos
           

            MostrarPrecio(MostrarCodigoProducto());
        }
        #endregion
    }
}
