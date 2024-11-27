using System;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public class Recursivos
    {
        // Suma de números de 1 a n
        public int SumaDeNumeros(int n)
        {
            if (n <= 1)
                return n;
            return n + SumaDeNumeros(n - 1);
        }

        // Cálculo de exponente (base^exponente)
        public int CalculoDeExponente(int baseNum, int exponente) {
            
          if (exponente == 0) return 1;
            
           return baseNum * CalculoDeExponente(baseNum, exponente - 1); 
        }

        // Torres de Hanoi
        public void TorresDeHanoi(int discos, char origen, char auxiliar, char destino)  {
            
            if (discos == 1) { Console.WriteLine($"Mover disco de {origen} a {destino}"); return; 
            
            } TorresDeHanoi(discos - 1, origen, destino, auxiliar);
                
          Console.WriteLine($"Mover disco de {origen} a {destino}"); 
            
            TorresDeHanoi(discos - 1, auxiliar, origen, destino); }

        // Búsqueda binaria
        public int BusquedaBinaria(int[] array, int inicio, int fin, int objetivo) {
        if (inicio > fin) return -1;
            
            int medio = (inicio + fin) / 2; 
            
            if (array[medio] == objetivo) return medio;
            
            else if (array[medio] > objetivo) return BusquedaBinaria(array, inicio, medio - 1, objetivo);
            
            else return BusquedaBinaria(array, medio + 1, fin, objetivo); }

        // Fibonacci
        public int Fibonacci(int n) { if (n <= 1) return n; 
            
            return Fibonacci(n - 1) + Fibonacci(n - 2); }




        // Factorial
        public int Factorial(int n) { if (n <= 1) return 1; 
            
            return n * Factorial(n - 1); }
    }

    

}

