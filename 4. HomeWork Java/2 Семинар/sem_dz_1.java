/* Задание
1) Дана строка sql-запроса "select * from students WHERE ". Сформируйте часть WHERE этого запроса, используя StringBuilder. 
Данные для фильтрации приведены ниже в виде json-строки.
Если значение null, то параметр не должен попадать в запрос.
Пример данной строки {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
Вывод: select * from students WHERE name=Ivanov AND country=Russia AND city=Moscow */

/* Основная логика в том что если человек не указал имя значит в выводе он будет отсутсвовать, в то время когда возраст есть он должен быть в выводе
 * 
 */

import java.util.Scanner;

/**
 * sem_dz_1
 */
public class sem_dz_1 {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in, "cp866");
  System.out.print("Введите имя студента: ");
  String name = sc.nextLine();

  System.out.print("Введите страну: ");
  String country = sc.nextLine();

  System.out.print("Введите город: ");
  String city = sc.nextLine();

  System.out.print("Введите возвраст: ");
  String age = sc.nextLine();
  

  StringBuilder stroka = new StringBuilder("{" + "name" + ": " + name + ", " + "country" + ": " + country + ", " + "city" + ": " + city + ", " + "age" + ": " + age + "}");
  System.out.println(stroka);


  System.out.print("Результат: select * from students WHERE name=" + name + " AND country=" + country + " АND city=" + city);

 
 }
}