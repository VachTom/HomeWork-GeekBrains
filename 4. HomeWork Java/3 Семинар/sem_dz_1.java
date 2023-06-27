import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.IntSummaryStatistics;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class sem_dz_1 {
  /*
   * Пусть дан произвольный список целых чисел.
   * 
   * 1) Найти минимальное значение
   * 2) Найти максимальное значение
   * 3) Найти среднее ариф. значение
   * 4) Нужно удалить из него чётные числа
   */
  public static void main(String[] args) {
    System.out.print("Пожалуйста введите кол-во целых чисел в массиве: ");
    Scanner sc = new Scanner(System.in, "cp866");
    int n = sc.nextInt();

    ArrayList<Integer> array = new ArrayList<>();
    for (int i = 0; i < n; i++) {
      var rand = new Random();
      array.add(rand.nextInt(100));

    }
    System.out.println("Массив: " + array); // Массив
    System.out.println();

    System.out.println("1) Min число: " + Collections.min(array));
    System.out.println("2) Max число: " + Collections.max(array));

    double avg = getAverage(array);
    System.out.println("3) Сред. арифм. значение: " + avg);

    for (int i = 0; i < array.size(); i++) { // 1)
      int number = array.get(i) % 2;
      if (number % 2 == 0) {
        array.remove(i);
      }
    }
    System.out.println("4) Массив без четных чисел: " + array);

  }

  public static double getAverage(List<Integer> array) {
    IntSummaryStatistics stats = array.stream()
        .mapToInt(Integer::intValue)
        .summaryStatistics();
    return stats.getAverage();
  }
}