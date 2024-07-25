package BSIT2A;

import java.util.*;

public class IT201galan {
  public static void main(String[] Galan) {
    Scanner scGalan = new Scanner(System.in);
    String appleGalan, bananaGalan, IDgalan, nameGalan, cashGalan;
    int aGalan, bGalan, BILLgalan, myCashGalan;
    double changeGalan, withIDgalan;
    boolean notcashGalan = true;

    System.out.print("Ener you name : ");
    nameGalan = scGalan.nextLine();
    System.out.print("Enter how many apple : ");
    appleGalan = scGalan.nextLine();
    System.out.print("Enter how many banana : ");
    bananaGalan = scGalan.nextLine();
    aGalan = Integer.parseInt(appleGalan);
    bGalan = Integer.parseInt(bananaGalan);
    aGalan *= 20;
    bGalan *= 12;
    BILLgalan = aGalan + bGalan;
    System.out.print("Total Bill : " + BILLgalan);
    while (notcashGalan) {
      System.out.print("\nEnter you cash : ");
      cashGalan = scGalan.nextLine();
      myCashGalan = Integer.parseInt(cashGalan);
      if (myCashGalan >= BILLgalan) {
        System.out.print("\nI received " + myCashGalan);
        System.out.print("\nDo you have a Senior ID Mr./Ms. " + nameGalan + "\nY or N >> ");
        IDgalan = scGalan.nextLine();
        if (IDgalan.equalsIgnoreCase("y")) {
          withIDgalan = BILLgalan * .20;
          BILLgalan -= withIDgalan;
          changeGalan = myCashGalan - BILLgalan;
          System.out.print("\nYour Change is " + changeGalan);
          System.out.print("\nThank you !");
          break;
        } else {
          changeGalan = myCashGalan - BILLgalan;
          System.out.print("\nYour Change is " + changeGalan);
          System.out.print("\nThank you !");
        }
        notcashGalan = false;
        break;
      } else {
        System.out.print("Cash is invalid ");
      }
    }
  }
}
