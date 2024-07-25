package conditionalStatement;
import java.util.Scanner;

public class IfElse02 {
  public static void main(String[] args) {
    try (Scanner scan = new Scanner(System.in)) {
      String name ;
      int age;

      System.out.print("Enter your name: ");
      name = scan.nextLine();
      System.out.print("Enter your age: ");
      age = scan.nextInt();

      if( age >= 18 ){
        System.out.print("Hey" + name + " You're allowed to vote!");
      }
      else if (age <= 18 && age >=12) {
        System.out.print("Hey " + name + " You're not allowed to vote!");
      }
      else {
        System.out.print( "Access Denied!");

      }
    }

  }
}
