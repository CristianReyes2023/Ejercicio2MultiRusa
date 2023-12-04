using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el multiplicador");
        var multiplicador = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el multiplicando");
        var multiplicando = Convert.ToUInt32(Console.ReadLine());
        ArrayList suma = new ArrayList();
        bool AddBreak = true;
        while (AddBreak)
        {
            var multiInterador = multiplicador % 2;
            if (multiInterador == 1)
            {
                suma.Add(multiplicando);
                multiplicador = (multiplicador - 1) / 2;
            }
            if(multiInterador == 0)
            {
            multiplicador = (multiplicador) / 2;
            }
            multiplicando = multiplicando*2;
            if (multiplicador == 1)
            {
                AddBreak = false;
                suma.Add(multiplicando);
                var sumaTotal = 0;
                for(int i=0;i<suma.Count;i++)
                {
                    sumaTotal = sumaTotal + Convert.ToInt32(suma[i]);
                }
                Console.WriteLine($"El valor de la suma total es: {sumaTotal}");
            }

        }
    }
}