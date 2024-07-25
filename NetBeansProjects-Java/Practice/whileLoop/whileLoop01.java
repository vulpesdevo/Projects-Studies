package whileLoop;

import java.util.ArrayList;
import java.util.*;

public class whileLoop01 {

  public static void main(String[] args) {
    //Scanner to make user input
    Scanner scan = new Scanner(System.in);

    //ArrayList to make a List of objects
    ArrayList<String> list = new ArrayList<String>();
    list.add("Mark");
    list.add("Francis");
    list.add("Galan");
    String user[] = { "Mark", "Galan", "Francis" };
    int i = 0;
    int e = 0;
    int points = 0;
    String nameGuess;

    // While loop to execute the game loop and get the points
    while (i <= user.length) {
      i++;
      System.out.print("\nGuess the name: ");
      nameGuess = scan.nextLine();
      while (e < user.length) {
        if (user[e].equalsIgnoreCase(nameGuess)) {
          points++;
          System.out.print("\nCongratiolations!!\n");
          System.out.print("\n>>>  You've got " + points + " point/s  <<<\n");
        } else {
          if (i <= 4) {
            System.out.print("Oops wrong name !!\n Try Again!!\n");
            System.out.print("\n>>>  You've got " + points + " point/s  <<<\n");
            break;
          } else {
            System.out.print("Oops wrong name !!\n");
            System.out.print("\n>>>  You've got " + points + " point/s  <<<\n");
          }
        }
        break;
      }
      e++;
      if (i <= 4) {
        String play;
        System.out.print("\nYou Want to play again?\n  Y or N?: ");
        play = scan.nextLine();
        if (play.equalsIgnoreCase("y")) {
          continue;
        } else {
          break;
        }
      } else {
        break;
      }
    }
  }
}
