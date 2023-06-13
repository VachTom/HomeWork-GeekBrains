/* Задание
1) Вычислить n-ое треугольного число (сумма чисел от 1 до n), 
   n! (произведение чисел от 1 до n)
2) Вывести все простые числа от 1 до 1000. делится на себя и на 1
3) Реализовать простой калькулятор (+-/*)

4) (дополнительное задание) Задано уравнение вида 
   q + w = e, q, w, e >= 0. Некоторые цифры могут быть заменены знаком вопроса, например, 2? + ?5 = 69. Требуется восстановить выражение до верного равенства. Предложить хотя бы одно решение или сообщить, что его нет.
Под знаком вопроса - всегда одинаковая ЦИФРА.
Введите уравнение: ?? + ?? = 44
Решение: 22 + 22 = 44 */

import java.util.Scanner;

public class sem_dz_1_Sum {
   public static void main(String[] args) {
      Scanner sc = new Scanner(System.in, "cp866");
      System.out.print("Введите число: ");
      Integer n = sc.nextInt();
      System.out.print("Результат: ");
      
    System.out.println(Factorial(n));
   }

   public static int Factorial(int n) {
      if (n <= 1)
         return 1;
      else
         return n + Factorial(n - 1);
   }
//    int[] ar = new int[n];for(
//    int j = 0;j<args.length;j++)
//    {

//    }

}