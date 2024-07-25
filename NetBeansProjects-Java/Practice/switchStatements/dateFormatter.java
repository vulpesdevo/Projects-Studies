package switchStatements;

import java.util.Scanner;

public class dateFormatter {

  public static void main(String[] args) {
    Scanner scanNum = new Scanner(System.in);

    String name;
    int month;
    int date;
    int year;

    System.out.print("Enter your name: ");
    name = scanNum.nextLine();
    System.out.print("Enter month in num: ");
    month = scanNum.nextInt();
    System.out.print("Enter date: ");
    date = scanNum.nextInt();
    System.out.print("Enter year: ");
    year = scanNum.nextInt();

    switch (month) {
      case 1:
        System.out.println(
          "Hey " + name + " your Schedule is on January " + date + " " + year
        );
        break;
      case 2:
        System.out.println(
          "Hey " + name + " your Schedule is on February " + date + " " + year
        );
        break;
      case 3:
        System.out.println(
          "Hey " + name + " your Schedule is on March " + date + " " + year
        );
        break;
      case 4:
        System.out.println(
          "Hey " + name + " your Schedule is on April " + date + " " + year
        );
        break;
      case 5:
        System.out.println(
          "Hey " + name + " your Schedule is on May " + date + " " + year
        );
        break;
      case 6:
        System.out.println(
          "Hey " + name + " your Schedule is on June " + date + " " + year
        );
        break;
      case 7:
        System.out.println(
          "Hey " + name + " your Schedule is on July " + date + " " + year
        );
        break;
      case 8:
        System.out.println(
          "Hey " + name + " your Schedule is on August " + date + " " + year
        );
        break;
      case 9:
        System.out.println(
          "Hey " + name + " your Schedule is on September " + date + " " + year
        );
        break;
      case 10:
        System.out.println(
          "Hey " + name + " your Schedule is on October " + date + " " + year
        );
        break;
      case 11:
        System.out.println(
          "Hey " + name + " your Schedule is on November " + date + " " + year
        );
        break;
      case 12:
        System.out.println(
          "Hey " + name + " your Schedule is on December " + date + " " + year
        );
        break;
    }
  }
}
