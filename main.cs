using System;

class MainClass {
  public static void Main (string[] args) {
    double dividendo, divisor, quociente, restante_quociente;
    
    Console.Write ("Digite o dividendo: ");
    dividendo = double.Parse (Console.ReadLine ());
    
    Console.Write ("Digite o divisor: ");
    divisor = double.Parse (Console.ReadLine());
    
    quociente = dividendo/divisor;
    restante_quociente = dividendo%divisor;
    
    Console.Write ("O restante do quociente é: "+restante_quociente +"\n"+"E o quociente é: "+quociente);
    
    Console.ReadKey ();
  }
}