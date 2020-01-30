using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular android = new Celular();
            android.AgregarMarca("Android").AgregarPais("China").MostrarCelular();

            Celular iphone = new Celular();
            iphone.AgregarMarca("Iphone").AgregarFechaCreacion(new DateTime(2018, 3, 4)).CalcularPrecio().MostrarCelular();
            Console.Read();
        }
    }

    class Celular
    {
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Pais { get; set; }
        public string FechaCreacion { get; set; }

        public Celular ()
        {
            Precio = 1000;
        }

        public Celular AgregarMarca(string marca)
        {
            Marca = marca;
            return this;
        }

        public Celular AgregarPrecio(int precio)
        {
            Precio = precio;
            return this;
        }

        public Celular AgregarPais(string pais)
        {
            Pais = pais;
            return this;
        }

        public Celular AgregarFechaCreacion(DateTime fechaCreacion)
        {
            FechaCreacion = fechaCreacion.ToString("yyyy/MM/dd");
            return this;
        }

        public void MostrarCelular()
        {
            Console.WriteLine(" Es un " + Marca + ", fecha de creacion" + " " + FechaCreacion + ", cuesta " + Precio + " y viene desde " + Pais);
        }

        public Celular CalcularPrecio()
        {
            if (Marca == "Android")
            {
                Precio = Precio - 500;
            } else{
                Precio = Precio + 500;
            }
            return this;
        }
    }
}
