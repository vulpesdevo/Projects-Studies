package switchStatements;

import java.util.Scanner;

public class switch01 {

  public static void main(String[] args) {
    try (Scanner scan = new Scanner(System.in)) {
      String name;
      String grade;

      System.out.print("Enter your name: ");
      name = scan.nextLine();
      System.out.print("Enter Grade: ");
      grade = scan.next();

      switch (grade) {
        case "A":
          System.out.println("Naol" + name);
          break;
        case "B":
          System.out.println("Sakto lang" + name);
          break;
        case "C":
          System.out.println("Bawi nalang next layp " + name);
          break;
        default:
          System.out.println("Failed " + name);
      }
    }
  }
}
