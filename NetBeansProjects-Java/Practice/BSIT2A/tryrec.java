package BSIT2A;

import javax.swing.*;

public class tryrec {

  public static void main(String[] args) {

    int n = 9, fact = 1;
    for (int i = 1; i <= n; i++) {
      fact = fact * i;
      System.out.println(fact);
    }
    System.out.print(fact);
  }
}
