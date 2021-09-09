using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_de_reposición
{
    class Program
    {
        static void Main(string[] args)
        {
			const int oportunidades = 3;
			int respuesta, inicio;
			byte i, adivinado;
			string linea;
			respuesta = 8;
			i = 1; adivinado = 0;
			do
			{
				Console.WriteLine("******************************");
				Console.WriteLine("BIENVENIDO A ADIVINA EL NUMERO");
				Console.WriteLine("Solo tienes 3 intentos");
				Console.WriteLine("*******************************");
				Console.Write("Selecciona cualquier numero del 1 al 10: ");
				linea = Console.ReadLine();
				inicio  = int.Parse(linea);
				if ((inicio == respuesta))
				{
					Console.WriteLine("¡FELICIDADES ADIVINASTE EL NUMERO!");
					adivinado = 1;
				}
				else
				{
					if ((inicio > respuesta))
					{
						Console.WriteLine("El numero que ingresaste es incorrecto intenta nuevamente");
					}
					else
					{
						Console.WriteLine("El numero que ingresaste es incorrecto intenta nuevamente");
					}
				}
				i++;
			} while (((i <= oportunidades) & (adivinado == 0)));
			if ((adivinado == 0)) ;
			

		}
    }
}
