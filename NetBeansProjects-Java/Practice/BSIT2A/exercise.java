package BSIT2A;

import java.util.Scanner;

public class exercise {

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    String[] section = { "A", "B", "C" };
    String[] studentsA = { "Mark", "Bob", "John", "Bea", "Lee" };
    String[] studentsB = { "Leo", "Rance", "Clint", "Angel", "Chou" };
    String[] studentsC = { "Harley", "King", "Lance", "Frank", "Bryan" };
    float mark = 0, bob = 0, john = 0, bea = 0, lee = 0, Leo = 0, Rance = 0, Clint = 0, Angel = 0, Chou = 0, Harley = 0,
        King = 0, Lance = 0, Frank = 0, Bryan = 0;
    String stud;
    String sec;
    int gr01;
    int gr02;
    int gr03;
    float ave;
    int i = 0;
    int e = 0;
    int a = 0;
    int b = 0;
    int c = 0;

    while (i <= section.length) {
      System.out.print("What section: ");
      sec = scan.nextLine();
      if (sec.equalsIgnoreCase("A")) {
        while (a <= studentsA.length) {
          System.out.print("\nEnter students name: ");
          stud = scan.nextLine();
          if (stud.equalsIgnoreCase("mark")) {
            System.out.print("\nEnter grade in quiz 1: ");
            gr01 = scan.nextInt();
            System.out.print("Enter grade in quiz 2: ");
            gr02 = scan.nextInt();
            System.out.print("Enter grade in quiz 3: ");
            gr03 = scan.nextInt();
            int[] grades = { gr01, gr02, gr03 };
            while (e < grades.length) {
              if (grades[e] <= 100) {
                for (int g : grades) {
                  mark += g;
                }
                ave = mark / 3;
                System.out.print("\nMark's Average: " + ave + "\n");
                break;
              }
            }
            a++;
            continue;
          }
          if (stud.equalsIgnoreCase("bob")) {
            System.out.print("\nEnter grade in quiz 1: ");
            gr01 = scan.nextInt();
            System.out.print("Enter grade in quiz 2: ");
            gr02 = scan.nextInt();
            System.out.print("Enter grade in quiz 3: ");
            gr03 = scan.nextInt();
            int[] grades = { gr01, gr02, gr03 };
            while (e < grades.length) {
              if (grades[e] <= 100) {
                for (int g : grades) {
                  bob += g;
                }
                ave = bob / 3;
                System.out.print("\nBob's Average: " + ave + "\n");
                break;
              }
            }
            a++;
            continue;
          }
          if (stud.equalsIgnoreCase("john")) {
            System.out.print("\nEnter grade in quiz 1: ");
            gr01 = scan.nextInt();
            System.out.print("Enter grade in quiz 2: ");
            gr02 = scan.nextInt();
            System.out.print("Enter grade in quiz 3: ");
            gr03 = scan.nextInt();
            int[] grades = { gr01, gr02, gr03 };
            while (e < grades.length) {
              if (grades[e] <= 100) {
                for (int g : grades) {
                  john += g;
                }
                ave = john / 3;
                System.out.print("\nJohn's Average: " + ave + "\n");
                break;
              }
            }
            a++;
            continue;
          }
          if (stud.equalsIgnoreCase("bea")) {
            System.out.print("\nEnter grade in quiz 1: ");
            gr01 = scan.nextInt();
            System.out.print("Enter grade in quiz 2: ");
            gr02 = scan.nextInt();
            System.out.print("Enter grade in quiz 3: ");
            gr03 = scan.nextInt();
            int[] grades = { gr01, gr02, gr03 };
            while (e < grades.length) {
              if (grades[e] <= 100) {
                for (int g : grades) {
                  bea += g;
                }
                ave = bea / 3;
                System.out.print("\nBea's Average: " + ave + "\n");
                break;
              }
            }
            a++;
            continue;
          }
          if (stud.equalsIgnoreCase("lee")) {
            System.out.print("\nEnter grade in quiz 1: ");
            gr01 = scan.nextInt();
            System.out.print("Enter grade in quiz 2: ");
            gr02 = scan.nextInt();
            System.out.print("Enter grade in quiz 3: ");
            gr03 = scan.nextInt();
            int[] grades = { gr01, gr02, gr03 };
            while (e < grades.length) {
              if (grades[e] <= 100) {
                for (int g : grades) {
                  lee += g;
                }
                ave = lee / 3;
                System.out.print("\nLee'sAverage: " + ave + "\n");
                break;
              }
            }
            a++;
            continue;
          }
        }
      }
    }
  }
}
