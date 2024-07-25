package galangrading;

import java.util.*;

public class markfrancisGalan {

    public static void main(String[] args) {
        Scanner scGalan = new Scanner(System.in);

        String fnGalan, lnGalan, miGalan, addGalan, contactGalan, preGalan, midGalan, finGalan; // String
        double subgrdGalan; // Double
        boolean notNumGalan = true;

        // Getting the Students informations
        System.out.print("Enter Student's Firstname : "); // First Name
        fnGalan = scGalan.nextLine();
        System.out.print("Enter Student's Lastname : "); // Last Name
        lnGalan = scGalan.nextLine();
        System.out.print("Enter Student's M.I. : "); // MI
        miGalan = scGalan.nextLine();
        System.out.print("Enter Address : ");
        addGalan = scGalan.nextLine();
        System.out.print("Enter contact : ");
        contactGalan = scGalan.nextLine();
        while (notNumGalan) {
            // Getting the Students Grades
            System.out.print("\n*** Enter your grades below ***");
            System.out.print("\n\nEnter prelim grade : ");
            preGalan = scGalan.nextLine();
            System.out.print("Enter midterm grade : ");
            midGalan = scGalan.nextLine();
            System.out.print("Enter finals grade : ");
            finGalan = scGalan.nextLine();
            /**
             * *** Converter ****
             */
            double pGalan = Double.parseDouble(preGalan);
            double mGalan = Double.parseDouble(midGalan);
            double fGalan = Double.parseDouble(finGalan);

            if (pGalan <= 100 && mGalan <= 100 && fGalan <= 100) {
                // Showing the output of inputed informations ang grades
                System.out.print("\n\n>>> About Student <<<");
                System.out.print("\nStudent's name : " + fnGalan + " " + lnGalan + " " + miGalan + "\nAddress : " + addGalan
                        + "\nContact : " + contactGalan + "\n");

                // Showing the results
                System.out.print("\n\n>>> Grades of the Student <<<");
                pGalan = pGalan * .33;
                System.out.print("\nPrelim : " + pGalan);
                mGalan = mGalan * .33;
                System.out.print("\nMidterm : " + mGalan);
                fGalan = fGalan * .34;
                System.out.print("\nFinals : " + fGalan);
                subgrdGalan = pGalan + mGalan + fGalan; // formula to get the sum of pre, mid ,finals
                System.out.print(
                        "\n---------------------------------------\nSubject Grade\t\t|\tRemark\n---------------------------------------\n"
                        + subgrdGalan);

                // getting the remark
                int digGalan = 0;
                String strGalan = Double.toString(subgrdGalan);
                char chGalan[] = strGalan.toCharArray();
                if (subgrdGalan >= 75) {
                    for (int i = 0; i < chGalan.length; i++) {
                        Character.isDigit(chGalan[i]);
                        digGalan++;
                    }
                    if (digGalan >= 15) {
                        System.out.print("\t|\tPassed");
                    } else {
                        System.out.print("\t\t\t|\tPassed");
                    }
                } else {
                    for (int i = 0; i < chGalan.length; i++) {
                        Character.isDigit(chGalan[i]);
                        digGalan++;
                    }
                    if (digGalan >= 15) {
                        System.out.print("\t|\tFailed");
                    } else {
                        System.out.print("\t\t\t|\tFailed");
                    }
                }
                System.out.print("\n---------------------------------------");
                notNumGalan = false;
                break;
            } else {
                System.out.print("\n>>> Invalid Input !!\n");
                notNumGalan = true;
                continue;
            }
        }
    }
}
