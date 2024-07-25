package methods;

public class method01 {

  // Global Variables - in the class
  static int num = 20;
  static String name = "Mark";

  public static void main(String[] args) {
    // Local Variables - in a certain method
    int num = 20;
    String name = "Mark";
    print(name + " " + num);
    print("\nprint\n");

    average(98, 97, 96);
    helloWorld();
  }

  // METHODS
  static void print(String run) { // ARgument
    System.out.print(run);
  }

  static void average(int num1, int num2, int num3) {
    float numbers = num1 + num2 + num3;
    System.out.println(numbers / 3);
  }

  static void helloWorld() {
    System.out.print("Hello World");
  }
}
