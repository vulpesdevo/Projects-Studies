package unitconvgalan2;

import java.util.*;

public class UnitConvGalan2 {

    public static void main(String[] Galan) {

        Scanner scGalan = new Scanner(System.in);
        int converterGalan;
        float input1Galan;
        double meterGalan, kWhGalan, cmInchGalan, mmInchGalan, inchYardGalan;
        int galan = 0;
        while (galan <= 4) {
            System.out.print("\n\n1. Squaremeter - meter \n2. Horsepower - kWh \n3. Cm - Inches \n4. Mm - Inches \n5. Inches - Yards ");
            System.out.print("\nWhat unit do you want to convert : ");
            converterGalan = scGalan.nextInt();
            switch (converterGalan) {
                case 1:
                    System.out.print("Enter Squaremeter : ");
                    input1Galan = scGalan.nextFloat();
                    meterGalan = Math.sqrt(input1Galan);
                    System.out.print("===================================\nmeter is " + meterGalan
                            + "\n===================================");
                    galan++;
                    break;
                case 2:
                    System.out.print("Enter Horsepower : ");
                    input1Galan = scGalan.nextFloat();
                    kWhGalan = input1Galan / 1.341;
                    System.out.print("===================================\nKwh is " + kWhGalan
                            + "\n===================================");
                    galan++;
                    break;
                case 3:
                    System.out.print("Enter CM : ");
                    input1Galan = scGalan.nextFloat();
                    cmInchGalan = input1Galan / 2.54;
                    System.out.print("===================================\nCM to Inch/es is " + cmInchGalan
                            + "\n===================================");
                    galan++;
                    break;
                case 4:
                    System.out.print("Enter MM : ");
                    input1Galan = scGalan.nextFloat();
                    mmInchGalan = input1Galan / 25.4;
                    System.out.print("===================================\nMM to Inch/es is " + mmInchGalan
                            + "\n===================================");
                    galan++;
                    break;
                case 5:
                    System.out.print("Enter Inche/es : ");
                    input1Galan = scGalan.nextFloat();
                    inchYardGalan = input1Galan / 36;
                    System.out.print("===================================\nYard/s is " + inchYardGalan
                            + "\n===================================");
                    galan++;
                    break;
                default:
                    System.out.print("\n>>> Invalid input <<<");
                    break;
            }
        }
    }
}
