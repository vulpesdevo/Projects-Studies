package forLoops;

import java.util.Scanner;
import org.w3c.dom.Attr;

public class matching {

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    String user;
    String pass;
    String userName[] = { "Marko", "Franz", "Basenji" };
    String userPass[] = { "marko123", "franz123", "basenji" };
    int attempt = 0;
    boolean match = false;
    boolean matchPass = false;
    boolean matchUser = false;

    while (attempt < 5) {
      System.out.print("Enter User Name: ");
      user = scan.nextLine();
      System.out.print("Enter  password: ");
      pass = scan.nextLine();
      for (int i = 0; i < userName.length; i++) {
        if (user.equals(userName[i]) && pass.equals(userPass[i])) {
          match = true;
          break;
        } else if (user.equals(userName[i]) && pass != (userPass[i])) {
          matchUser = true;
          break;
        } else if (user != (userName[i]) && pass.equals(userPass[i])) {
          matchPass = true;
          break;
        }
      }
      if (match) {
        System.out.print(">>> Welcome " + user + " <<<\n");
        break;
      } else if (matchUser) {
        attempt++;
        System.out.print(
          "*** Your password is incorrect ***\n>>> Try again <<<\n"
        );
        continue;
      } else if (matchPass) {
        attempt++;
        System.out.print(
          "*** Your username  is incorrect ***\n>>> Try again <<<\n"
        );
        continue;
      } else {
        System.out.print(
          "*** Your user name and password is incorrect ***\n>>> Try again <<<\n"
        );
        attempt++;
        continue;
      }
    }
    if (attempt >= 5) {
      System.out.print(">>>  You have used all your attempts <<<");
    }
  }
}
