/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package dogmanagement;

import data.Dog;

/**
 *
 * @author ADMIN
 */
public class DogManagement {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Dog ngaoda = new Dog("NGAO DA", 1998, 60);
        System.out.println("ND: " + ngaoda.toString());

        //toString() rat dac biet, 
        System.out.println("Check the toString() method: ");
        System.out.println("ND: " + ngaoda); //ngaoda la bien con tro, ben C in ngaoda se cho ra dia chi o nho
                                             //Java: ko in toa do, nó hiểu là vào vùng ram của object show hết info
                                             // gọi ngầm hàm toString() khi in biến Object
        // nếu ko có toString() rõ ràng trong class mà lại đòi in ra chi tiết của biến Object đang trỏ đến Object
        //thì JVM tự động in ra 1 con số Hexa, gọi là hash-number (mã băm) của vùng RAM
        //toàn bộ data được đổ vào của object được băm theo một thuật toán, convert theo 1 thuật toán để ra được 1 con số đặc trưng
    }

}
