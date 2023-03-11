using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticaTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Zapato> CatalogoTienda1 = new List<Zapato>();
            CatalogoTienda1.Add(new Zapato("Sneakers", "Adidas", 9, "$50.00", "5%"));
            CatalogoTienda1.Add(new Zapato("Zapatilla", "Pierre Cardin", 10, "$40.00", "No tiene descuento"));
            CatalogoTienda1.Add(new Zapato("Botas", "CAT", 9/5, "$80.00", "10%"));
            CatalogoTienda1.Add(new Zapato("Running", "Nike", 5, "$40.00", "20%"));

            List<Zapato> CatalogoTienda2 = new List<Zapato>();
            CatalogoTienda2.Add(new Zapato("Tacones", "Zara", 8/5, "$60.00", "10%"));
            CatalogoTienda2.Add(new Zapato("Sandalias", "Gucci", 7/5, "$50.00", "25%"));
            CatalogoTienda2.Add(new Zapato("Sneaker", "All Star", 9, "$45.00" , "No tiene descuento"));
            CatalogoTienda2.Add(new Zapato("Zapato de vestir", "Clarks", 7, "%25.00", "7%"));

            Tienda Tienda1 = new Tienda("Burlington", CatalogoTienda1);
            Tienda Tienda2 = new Tienda("Scholes", CatalogoTienda2);

            Console.WriteLine("Bienvenido/a!");
            Console.WriteLine("Por favor seleccione una de las siguientes tiendas para comparar:");
            Console.WriteLine($"1. {Tienda1.Nombre}");
            Console.WriteLine($"2. {Tienda2.Nombre}");
            Console.Write("Opción: ");

            int opcionTienda = int.Parse(Console.ReadLine());

            if (opcionTienda == 1)
            {
                Tienda1.MostrarCatalogo();
            }
            else if (opcionTienda == 2)
            {
                Tienda2.MostrarCatalogo();
            }
            else
            {
                Console.WriteLine("Opción no válida");
            }
        }

    }
}

class Zapato
{
    public string Estilo { get; set; }
    public string Marca { get; set; }
    public int Talla { get; set; }
    public string Precio { get; set; }
    public string Descuento { get; set; }

    public Zapato(string estilo, string marca, int talla, string precio, string descuento)
    {
        Estilo = estilo;
        Marca = marca;
        Talla = talla;
        Precio = precio;
        Descuento = descuento;
    }

    public override string ToString()
    {
        return $"Estilo: {Estilo}\nMarca: {Marca}\nTalla: {Talla}\nPrecio: {Precio}\nDescuento: {Descuento}\n";
    }
}

class Tienda
{
    public string Nombre { get; set; }
    public List<Zapato> Catalogo { get; set; }

    public Tienda(string nombre, List<Zapato> catalogo)
    {
        Nombre = nombre;
        Catalogo = catalogo;
    }

    public void MostrarCatalogo()
    {
        Console.WriteLine($"Catalogo de {Nombre}:");
        foreach (Zapato zapato in Catalogo)
        {
            Console.WriteLine(zapato);
        }
    }
}

