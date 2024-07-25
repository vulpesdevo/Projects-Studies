package BSIT2A;

import java.util.*;

public class galanDSALogicGates {
    public static void main(String[] args) {
        Scanner scGalan = new Scanner(System.in);
        String con1galan, con2galan;
        while (true) {
            print("\n-----------------------\nLOGIC GATES : \nOR\nAND\nNAND\nXOR\nNOT\nNOR\n-----------------------\nEnter Logic Gate : ");
            String askGalan = scGalan.nextLine();
            switch (askGalan) {
                case "AND":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();
                    print("Enter Condition (True | False) : ");
                    con2galan = scGalan.nextLine();
                    if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : True");
                    } else if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("False")) {
                        print("Result : False");
                    } else if (con1galan.equalsIgnoreCase("False") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else {
                        print("Result : False");
                    }
                    break;
                case "OR":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();
                    print("Enter Condition (True | False) : ");
                    con2galan = scGalan.nextLine();
                    if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : True");
                    } else if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("False")) {
                        print("Result : True");
                    } else if (con1galan.equalsIgnoreCase("False") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : True");
                    } else {
                        print("Result : False");
                    }
                    break;
                case "NAND":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();
                    print("Enter Condition (True | False) : ");
                    con2galan = scGalan.nextLine();
                    if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("False")) {
                        print("Result : True");
                    } else if (con1galan.equalsIgnoreCase("False") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : True");
                    } else {
                        print("Result : True");
                    }
                    break;
                case "XOR":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();
                    print("Enter Condition (True | False) : ");
                    con2galan = scGalan.nextLine();
                    if (con1galan.equalsIgnoreCase("True") ^ con2galan.equalsIgnoreCase("True")) {
                        print("Result : True");
                    } else if (con1galan.equalsIgnoreCase("True") ^ con2galan.equalsIgnoreCase("False")) {
                        print("Result : False");
                    } else if (con1galan.equalsIgnoreCase("False") ^ con2galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else {
                        print("Result : True");
                    }
                    break;
                case "NOT":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();

                    if (con1galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else {
                        print("Result : True");
                    }
                    break;
                case "NOR":
                    print("Enter Condition (True | False) : ");
                    con1galan = scGalan.nextLine();
                    print("Enter Condition (True | False) : ");
                    con2galan = scGalan.nextLine();
                    if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else if (con1galan.equalsIgnoreCase("True") && con2galan.equalsIgnoreCase("False")) {
                        print("Result : False");
                    } else if (con1galan.equalsIgnoreCase("False") && con2galan.equalsIgnoreCase("True")) {
                        print("Result : False");
                    } else {
                        print("Result : True");
                    }
                    break;
                default:
                    print(">>> Incorrect Input <<<\n>>> please CAPS ALL LETTER <<<\n");
                    continue;
            }
            Math.round(10.26434426229508);
        }
    }

    // to Shorten the System.out.print()
    static void print(String text) {
        System.out.print(text);
    }
}