package Enum_sample;

public class sampleEnum {

    enum myEnum {
        CAR("toyota"), BRAND("nestle");

        private String value;

        myEnum(String value) {
            this.value = value;
        }

        public String getValue() {
            return value;
        }
    }

    public static void main(String[] args) {
        myEnum e = myEnum.BRAND;
        print("Enums values : " + e.name());

        for (myEnum i : myEnum.values()) {
            print("\nAll values : " + i + " = " + i.getValue());

        }
    }

    static void print(String word) {
        System.out.print(word);
    }
}
