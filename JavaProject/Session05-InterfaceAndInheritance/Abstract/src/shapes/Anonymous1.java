/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shapes;

/**
 *
 * @author Admin
 */
interface AnonymousInterface {

    void M1();

    void M2();
}

abstract class MyAdapter{
    public void M1(){
        System.out.println("M1");
    }
    public void M2(){
        System.out.println("M2");
    }
}


public class Anonymous1 {

    public static void main(String[] args) {
        //thay thế cho việc tạo 1 class implement AnonymousInterface và tạo 1 object từ class đó    
        AnonymousInterface an_in = new AnonymousInterface() { 
            public void M1() {
                System.out.println("M1");
            }

            public void M2() {
                System.out.println("M2");
            }
        };
        an_in.M1();
        an_in.M2();
        
        MyAdapter obj = new MyAdapter() {
            public void M1(){ // Abstract class can be used only when at least one of its methods is overriden
                System.out.println("Overriden M1");
            }
        };
        obj.M1();
        
    }

}