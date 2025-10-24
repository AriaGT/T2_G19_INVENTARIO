using System;
using System.Windows.Forms;

namespace T2
{
    internal class Listado
    {
        private Inventario[] inventarios;
        private int contador;

        public Listado(int capacidad)
        {
           inventarios=new Inventario[capacidad];
            contador=0;
        }
        public void Registrarinventario(Inventario inventario)
        {
            if (contador < inventarios.Length)
            {
                inventarios[contador] = inventario;
                contador++;
            }
            else
            {
                MessageBox.Show("Se lleno...");
            }
        }
        public Inventario[] ObtenerInventirio() 
        {
            Inventario[] resultado = new Inventario[contador];
            for (int i=0; i<contador;i++) 
            {
                resultado[i] = inventarios[i];
            }
            int n =resultado.Length;
            for (int i=0;i<n-1;i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (resultado[j].precio > resultado[j + 1].precio)
                    {
                        Inventario valor = resultado[j];
                        resultado[j] = resultado[j + 1];
                        resultado[j + 1] = valor;
                    }
                }
            }
            return resultado;
        }

        public Inventario[] ObtenerInventirioDescendente()
        {
            Inventario[] resultado = new Inventario[contador];
            for (int i = 0; i < contador; i++)
            {
                resultado[i] = inventarios[i];
            }

            int n = resultado.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (resultado[j].precio < resultado[j + 1].precio)
                    {
                        Inventario temp = resultado[j];
                        resultado[j] = resultado[j + 1];
                        resultado[j + 1] = temp;
                    }
                }
            }
            return resultado;
        }

        public Inventario BuscarPorNombre(string nombre)
        {
            for (int i = 0; i < contador; i++)
            {
                if (inventarios[i] != null &&
                    inventarios[i].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return inventarios[i];
                }
            }
            return null;
        }

        public int CalcularStockPorCategoria(string categoria, int indice = 0)
        {
            if (indice >= contador) return 0;
            int cantidadActual = 0;
            if (inventarios[indice] != null &&
                inventarios[indice].categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
            {
                cantidadActual = inventarios[indice].cantidad;
            }

            return cantidadActual + CalcularStockPorCategoria(categoria, indice + 1);
        }
    }
}
