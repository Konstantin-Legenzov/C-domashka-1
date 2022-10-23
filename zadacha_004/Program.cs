/* Написать программу, которая на вход принимает число (N), 
на выходе показывает все чётные числа от 1 до N.*/


using System;
 
class Program {
 public static int Main() {
  for(int i=0; i<=20; i++) {
   if(i%2 == 0) {
    Console.Write("{0} ", i);
   }
  }
  Console.ReadKey();
  return 0;
 }
}