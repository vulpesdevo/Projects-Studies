package userInput;

import java.util.Scanner;

public class ScanLine {

  public static void main(String[] args) {
    try (Scanner sc = new Scanner(System.in)) {
      String userName;
      int userAge;
      String names2[] = new String[20];

      System.out.print("Please enter the user name: ");
      userName = sc.nextLine();
      System.out.print("Please Enter Name: ");
      System.out.print("Please enter the user age: ");
      userAge = sc.nextInt();
      names2[0] = sc.nextLine();
      System.out.print(
        "\nYour username is " + userName + " and  your age is " + userAge
      );
      System.out.print("\nName " + names2[0]);
    }
  }
}
