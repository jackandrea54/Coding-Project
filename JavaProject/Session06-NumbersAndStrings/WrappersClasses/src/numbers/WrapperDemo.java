/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numbers;

/**
 *
 * @author ADMIN
 */
public class WrapperDemo {

    public static void main(String[] args) {
        int n = 7;
//        Integer intObj = new Integer(5);
        Integer intObj = 5; //new ngầm, vẫn new nhưng mà không cần viết ra
                            //BOXING, đóng hộp thằng PRIMITIVE/LITERAL
        int a = intObj; //1 thằng là primitive, 1 thằng là con trỏ.
                        //UNBOXING: MỞ vùng RAM bự ra, lôi đúng value int ra xài.
        
        
        System.out.println(intObj);
        System.out.println(intObj.toString());
        intObj = n; // boxing
        System.out.println(intObj);
        int y = intObj * 2; // unboxing
        int z = intObj.intValue();
        System.out.println("y = " + y + ", z = " + z);
        n = Integer.parseInt("1234");
        System.out.println("n = " + n);
        n = Integer.parseInt("1A", 16);
        System.out.println("n = " + n);
        
    }
}
