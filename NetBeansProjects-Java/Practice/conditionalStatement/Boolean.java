package conditionalStatement;

import java.util.Scanner;

public class Boolean {
    public static void main(String[] args) {
      try (Scanner sc = new Scanner(System.in)) {

        /****** VARIABLES ******/
        String userNames[] = { "Markus01", "Franz02", "John03"};
        String passWord[] = { "makmak123", "franz", "johney"};
        int Num[] = {0, 1, 2,};
        String sites[] = {"fb", "ig", "yt"};

  
        System.out.print("Enter what site: ");
        String site = sc.nextLine();
        if(site == sites[0]) {
          int numOfSite = Num[0];
          System.out.print("Username: " + userNames[numOfSite]);
          System.out.print("\nPassWord: " + passWord[numOfSite]);
        }
        else if(site == sites[1]) {
          int numOfSite = Num[1];
          System.out.print("Username: " + userNames[numOfSite]);
          System.out.print("\nPassWord: " + passWord[numOfSite]);
        }
        else if ( site == sites[2]) {
          int numOfSite = Num[2];
          System.out.print("Username: " + userNames[numOfSite]);
          System.out.print("\nPassWord: " + passWord[numOfSite]);
        }
        
        /********  BOOLEAN ********/
        else if (notFound(site) == false){
          System.out.print("Site is not registered");
          
        }
      }
    }

    private static boolean notFound(String site) {
      return false;
    }
  
}
