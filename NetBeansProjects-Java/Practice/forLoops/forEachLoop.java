package forLoops;

public class forEachLoop {

  public static void main(String[] args) {
    String[] fruits = { "Apple", "Mango", "Orange", "Guava" };
    int[] num = { 1, 2, 4, 5, 6, 7 };
    int sum = 0;
    // for ( datatype variable : array variable )
    for (String f : fruits) {
      System.out.println(f);
      if (f.equalsIgnoreCase("Apple")) {
        System.out.print("There's a/an " + f + "\n");
      }
    }
    for (int i : num) {
      sum += i;
      System.out.print(sum);
    }
    System.out.println("\nSum is " + sum);
  }
}
