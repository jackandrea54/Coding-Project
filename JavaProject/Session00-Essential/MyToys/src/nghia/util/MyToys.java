
package nghia.util;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */

//Trong thiết kế Class thì:
//    Có Class có cả static và non-static: String
//    Có Class hầu hết static: Math
//    Có CLass thì không có static: Scanner
public class MyToys {
    public static final double PI = 3.1415; //Dùng nhiều lần trong tính S,P hình tròn
    public static final double VAT = 0.1;
    public static final int MAX_ELEMENTS = 500;
    private static Scanner sc = new Scanner(System.in); //Scanner dung chung cho nhieu ham
    
    public static int getAnInteger() {
        int n;
        do {            
            try {
                System.out.print("Input an integer: ");
                n = Integer.parseInt(sc.nextLine());
                return n;
            } catch (Exception e) {
                System.out.println("Do you know hwo to input an integer?");
            }
        } while (true);
        
    }
    
    public static int getAnInteger(String msg) {
        int n;       
        do {            
            try {
                System.out.print(msg);
                n = Integer.parseInt(sc.nextLine());
                
                return n;
            } catch (Exception e) {
                System.out.println("Do you know hwo to input an integer?");
            }
        } while (true);
        
    }
    
    
}
