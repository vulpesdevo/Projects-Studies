package BSIT2A;

import java.util.Scanner;

public class exchange {

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    float billAmount, amountTendered;
    int attempt = 0;
    int total;
    float oneK, fiveH, twoH, oneH, fifty, twenty, ten, five, piso;
    double for50Cent, for20Cent, for10Cent, for5Cent, for1Cent;

    while (attempt < 5) {
      System.out.print("Enter bill amount: ");
      billAmount = scan.nextFloat();
      System.out.print("Enter amount tendered: ");
      amountTendered = scan.nextFloat();
      if (amountTendered < 0) {
        System.out.print(
            "*** Amount entered not allowed!  ***\n***  Please enter amount again  ***\n");
        attempt++;
        continue;
      } else if (amountTendered < billAmount) {
        System.out.print(
            "***  Tendered amount is less than bill amount!  ***\n***  please enter new amount  ***\n");
        attempt++;
        continue;
      } else {
        total = (int) (amountTendered - billAmount);
        System.out.print("\n>>> The change is: " + total + " <<<\n");
        System.out.print("\nQTY\tDenomination\n---\t--------------");
        oneK = total / 1000;
        if (oneK >= 1) {
          System.out.print("\n" + (int) (oneK) + "\t1000 peso note/s");
          total = total % 1000;
        }
        fiveH = total / 500;
        if (fiveH >= 1) {
          System.out.print("\n" + (int) (fiveH) + "\t500 peso note/s");
          total = total % 500;
        }
        twoH = total / 200;
        if (twoH >= 1) {
          System.out.print("\n" + (int) (twoH) + "\t200 peso note/s");
          total = total % 200;
        }
        oneH = total / 100;
        if (oneH >= 1) {
          System.out.print("\n" + (int) (oneH) + "\t100 peso note/s");
          total = total % 100;
        }
        fifty = total / 50;
        if (fifty >= 1) {
          System.out.print("\n" + (int) (fifty) + "\t50 peso note/s");
          total = total % 50;
        }
        twenty = total / 20;
        if (twenty >= 1) {
          System.out.print("\n" + (int) (twenty) + "\t20 peso note/s");
          total = total % 20;
        }
        ten = total / 10;
        if (ten >= 1) {
          System.out.print("\n" + (int) (ten) + "\t10 peso note/s");
          total = total % 10;
        }
        five = total / 5;
        if (five >= 1) {
          System.out.print("\n" + (int) (five) + "\t5 peso note/s");
          total = total % 5;
        }
        piso = total / 1;
        if (piso >= 1) {
          System.out.print("\n" + (int) (piso) + "\t1 peso note/s");
          total = total % 1;
        }
        for50Cent = total / 0.50;
        if (for50Cent >= 1) {
          System.out.print("\n" + (int) (for50Cent) + "\t50 cent/s");
          total = (int) (total % 0.50);
        }
        for20Cent = total / 0.20;
        if (for20Cent >= 1) {
          System.out.print("\n" + (int) (for20Cent) + "\t20 cent/s");
          total = (int) (total % 0.20);
        }
        for10Cent = total / 0.10;
        if (for10Cent >= 1) {
          System.out.print("\n" + (int) (for10Cent) + "\t10 cent/s");
          total = (int) (total % 0.10);
        }
        for5Cent = total / 0.05;
        if (for5Cent >= 1) {
          System.out.print("\n" + (int) (for5Cent) + "\t5 cent/s");
          total = (int) (total % 0.05);
        }
        for1Cent = total / 0.01;
        if (for1Cent >= 1) {
          System.out.print("\n" + (int) (for1Cent) + "\t1 cent/s");
        }
        break;
      }
    }
    if (attempt >= 5) {
      System.out.print("\nYou have Exceed the maximum Attempt\n");
    }
  }
}
