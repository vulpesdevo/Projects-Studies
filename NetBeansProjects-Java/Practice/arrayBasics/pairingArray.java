package arrayBasics;

import java.util.Scanner;

public class pairingArray {

  public static void main(String[] args) {
    try (Scanner sc = new Scanner(System.in)) {
      String userNames[] = { "Markus01", "Franz02", "John03" };
      String passWord[] = { "makmak123", "franz", "johney" };
      int Num[] = { 0, 1, 2 };
      String sites[] = { "fb", "ig", "yt" };

      System.out.print("Enter what site: ");
      String site = sc.nextLine();
      if (site == sites[0]) {
        int numOfSite = Num[0];
        System.out.print("Username: " + userNames[numOfSite]);
        System.out.print("\nPassWord: " + passWord[numOfSite]);
      } else if (site == sites[1]) {
        int numOfSite = Num[1];
        System.out.print("Username: " + userNames[numOfSite]);
        System.out.print("\nPassWord: " + passWord[numOfSite]);
      } else {
        int numOfSite = Num[2];
        System.out.print("Username: " + userNames[numOfSite]);
        System.out.print("\nPassWord: " + passWord[numOfSite]);
      }
    }
  }
}
