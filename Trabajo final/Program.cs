using System;

namespace trabajofinal
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
           int N = 1, cp = 0, maxpar = 0, cimp = 0,minPrimos = 0 ;
            
            Console.WriteLine("ingrese un numero:");
            N = int.Parse(Console.ReadLine());
           
            while (N!=0){  
            
            if ((N % 2 == 0) & (cp == 0)){
            maxpar = N;
            cp++;
            }
            else if ((N % 2 == 0 ) &(N > maxpar)){
            cp++;
            maxpar = N;
            } 
            else{
                cimp ++;
            
            }

        if (primo(N)){
        if (minPrimos == 0){
            
            minPrimos = N;
        }
        else{
            
            if (N < minPrimos)
                
                minPrimos = N;
                        }
        }  
        
    
            Console.WriteLine("ingrese otro numero: ");
            N = int.Parse(Console.ReadLine());  
}
        Console.WriteLine("El maximo par es: " + maxpar);
        
        Console.WriteLine("la cantidad de impares son: "+ cimp);
        
        Console.WriteLine("el menor de los  primos es: " +minPrimos); 
        
        }
        static bool primo(int a)
        {

            int con = 0 ;

           for (int x = 1; x <= a; x++){
                if (a % x == 0){
                
                con++;
                
                }
            }
            if (con == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
