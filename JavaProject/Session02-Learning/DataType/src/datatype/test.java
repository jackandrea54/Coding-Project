/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package datatype;

/**
 *
 * @author ADMIN
 */
public class test {
//    public static void main(String[] args) {
//        int x = -1;
//        System.out.println("-1 << 1 = " + (x<<1) );
//        System.out.println("-1 >> 1 = " + (x>>1) );
//        System.out.println("-1 >>> 1 = " + (x>>>1) );
//        String S = "Hello";
//        boolean result = S instanceof String;
//        System.out.println("Hello is an instance of String: " + result);
//        //Khai bao bien y,z
//        float y = 12.3f;
//        double z = 123.4;
//  
//        System.out.println("Float y: " + y);
//        System.out.println("Double z: " + z);
//    

  
}
//public class OrangeMangoBanana{
//    final static int orange,mango;
//    static int banana;
//    static{
//        mango orange+3;
//        banana mango*2;
//   }
//                                                                   ");
//    public static void main(String[]args){
//        System.out.print(orange+""+mango+""+banana+
//        banana=mango+orange+banana;
//        System.out.print(banana);
//   }
//    static{
//        orange=25;
//   }
//}
 class A {

        int i;
    }

    class B extends A {

        int j;

        void display() {
            super.i = j + 1;
            System.out.println(j + "" + i);
        }
    }

    class inheritance {

        public static void main(String args[]) {
            B obj = new B();
            obj.i = 1;
            obj.j = 2;
            obj.display();
        }
    }