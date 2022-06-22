package ws2;

import java.util.Scanner;


public class Q2 {

    public static void main(String[] args) {
        String id, name;
        Scanner sc = new Scanner(System.in);
        Utility2 u = new Utility2();
        id = u.GetStringID(sc, "Enter student id (HE123456): ");
        name = u.GetStringName(sc, "Enter name (NOT EMPTY): ");
        System.out.println("OUTPUT");
        System.out.println(id);
        System.out.println(name);
    }

}

class Utility2 {

    public String GetStringID(Scanner sc, String msg) {
        String outString = "";
        boolean flag;
        do {
            flag = false;
            System.out.print(msg);
            outString = sc.nextLine();
            if (outString.length() == 0) {
                flag = true;
                continue;
            }

            for (int i = 0; i < outString.length(); i++) {                
                if (outString.charAt(0) != 'H' || outString.charAt(1) != 'E') {
                    flag = true;
                    break;
                }
                if (outString.charAt(0) == 'H' && outString.charAt(1) == 'E') {
                    if(outString.length() < 8) {
                        flag = true;
                        break;
                    }
                    
                    if (i >= 2 && i <= 5) {
                        if (((int)outString.charAt(i) ) > 57 || ((int) outString.charAt(i)) < 48) {
                            flag = true;
                            
                            System.out.println((int)outString.charAt(i));
                            break;
                        }
                    }
                    
                }

            }
        } while (flag);

        return outString;
    }
    public String GetStringName(Scanner sc, String msg) {
        String outString = "";
        boolean flag;
        do {
            flag = false;
            System.out.print(msg);
            outString = sc.nextLine();
            if (outString.length() == 0) {
                flag = true;
            }           
        } while (flag);

        return outString;
    }
}
