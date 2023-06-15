/* Задание 
2) Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.
1 3 4 2
1 3 2 4
1 2 3 4
*/

import java.io.FileWriter;
import java.util.Arrays;

public class sem_dz_2 {
  public static void main(String[] args) {

    try {
      FileWriter writer = new FileWriter("Pz.txt", false);
      int[] arr = { 4, 2, 153, 3, 1, 88, 6, 5, 55, 23 };
      int count = 0;
      int counter = 1;
      boolean isSorted = false;
      while (!isSorted) {
        isSorted = true;
        for (int i = 0; i < arr.length - 1; i++) {
          if (arr[i] > arr[i + 1]) {
            isSorted = false;
            count = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = count;
          }
          writer.write(counter + ". " + Arrays.toString(arr) + "\n");
          counter++;
        }
      }
      writer.close();
      System.out.println(Arrays.toString(arr));

    } catch (Exception e) {
      System.out.println("Не получилось");
    }
  }
}