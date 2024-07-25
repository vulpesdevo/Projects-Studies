package BSIT2A;

import java.util.*;

public class galanArithmetic {
  public static void main(String[] args) {
    Scanner scGalan = new Scanner(System.in);   
    int num1Galan,num2Galan;
    System.out.print("Enter number: ");
    num1Galan = scGalan.nextInt();
    System.out.print("Enter number: ");
    num2Galan = scGalan.nextInt();

    totals(num1Galan,num2Galan);
  }
  static void totals(int num1, int num2){
    System.out.print("Sum : "+ (num1 + num2));
    System.out.print("\nDifference : "+ (num1 - num2));
    System.out.print("\nProduct : "+(num1 * num2));
    System.out.print("\nQuotient : "+(num1 / num2));
  }
}

