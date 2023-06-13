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

public class sem_dz_3_Calculator {
   public static void main(String[] args) {
      Scanner sc = new Scanner(System.in, "cp866");
      System.out.print("Введите Первое число: ");
      int n1 = sc.nextInt();

      System.out.print("Введите Второе число: ");
      int n2 = sc.nextInt();

      System.out.print("Введите знак +-/*: ");
      char znak = sc.next().charAt(0);

      int result = 0;

      switch (znak) {
         case '+':
            result = n1 + n2;
            break;
         case '-':
            result = n1 - n2;
            break;
         case '*':
            result = n1 * n2;
            break;
         case '/':
            result = n1 / n2;
            break;

         default:
            System.out.print("Ошибка! Пожалуйста, введите корректныйй знак.");
            break;
      }
      System.out.printf("Релуьтат: %s", result);




      // Способ с методом
      // System.out.print(Calculator(n1, n2, znak));

      // public static int Calculator(int n1, int n2, String znak) {
      // if (znak == "+") {

      // }
      // if (znak == "-") {
      // result = n1 - n2;
      // }
      // if (znak == "/") {
      // result = n1 / n2;
      // }
      // if (znak == "*") {
      // result = n1 * n2;
      // }
      // return result;
   }
}