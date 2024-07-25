package forLoops;

import java.util.*;

public class hey {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String veg, nonveg;
        System.out.println("\t===VEGE MENU===\n");
        String vegs[] = { "CARROT", "KANGKONG",
                "PATOLA", "TALONG", "SITAW", "BATAW",
                "PATANI", "KUNDOL", "CUCUMBER", "UPO" };
        for (int i = 0; i <= 9; i++) {
            System.out.println("\t[" + (i + 1) + "] >>>>>>>>> " + vegs[i]);
        }
        System.out.print("\tHi Maam Yolly Choose Your Vegetable: ");
        veg = sc.nextLine();
        switch (veg.toUpperCase()) {// to make the input into CAPITAL LETTER
            case "CARROT":
                System.out.println("\tYour order is c1");
                break;
            case "KANGKONG":
                System.out.println("\tYour order is k1");
                break;
            case "PATOLA":
                System.out.println("\tYour order is p1");
                break;
            case "TALONG":
                System.out.println("\tYour order is t1");
                break;
            case "SITAW":
                System.out.println("\tYour order is s1");
                break;
            case "BATAW":
                System.out.println("\tYour order is b1");
                break;
            case "PATANI":
                System.out.println("\tYour order is p1");
                break;
            case "KUNDOL":
                System.out.println("\tYour order is k1");
                break;
            case "CUCUMBER":
                System.out.println("\tYour order is c2");
                break;
            case "UPO":
                System.out.println("\tYour order is U1");
                break;
            default:
                System.out.println("\tInvalid");
        }
        System.out.println("\n\t===NON-VEGE MENU===\n");
        String nonvegs[] = { "HIPON", "ALIMANGO",
                "PORK", "CHICKEN", "ISAW", "HOTDOG",
                "TALABA", "BANGUS", "HITO", "TILAPIA" };
        for (int i = 0; i <= 9; i++) {
            System.out.println("\t[" + (i + 1) + "] >>>>>>>>> " + nonvegs[i]);
        }

        System.out.print("\tHi Maam Yolly Choose Your NON-Vegetable: ");
        nonveg = sc.nextLine();
        switch (nonveg.toUpperCase()) {// to make the input into CAPITAL LETTER
            case "HIPON":
                System.out.println("\tYour order is hpA");
                break;
            case "ALIMANGO":
                System.out.println("\tYour order is alA");
                break;
            case "PORK":
                System.out.println("\tYour order is pkA");
                break;
            case "CHICKEN":
                System.out.println("\tYour order is ccA");
                break;
            case "ISAW":
                System.out.println("\tYour order is iwA");
                break;
            case "HOTDOG":
                System.out.println("\tYour order is hdA");
                break;
            case "TALABA":
                System.out.println("\tYour order is tbA");
                break;
            case "BANGUS":
                System.out.println("\tYour order is k1");
                break;
            case "HITO":
                System.out.println("\tYour order is htA");
                break;
            case "TILAPIA":
                System.out.println("\tYour order is tpA");
                break;
            default:
                System.out.println("\tInvalid");
        }
    }
}
