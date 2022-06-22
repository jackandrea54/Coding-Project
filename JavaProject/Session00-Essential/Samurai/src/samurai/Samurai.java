/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package samurai;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Samurai {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
//        inputProfile();
        inputProfileXinXo();
    }

    public static void inputProfileXinXo() {
        String name, address;
        int yob;
        Scanner sc = new Scanner(System.in);

        System.out.print("Input name: ");
        name = sc.nextLine().toUpperCase();
        
        do {            
            try {
                System.out.print("Input yob: ");
                yob = Integer.parseInt(sc.nextLine()); //Nếu có lỗi thì bỏ qua lệnh ở dưới và
                                                       //sẽ nhảy thẳng sang catch luôn, nếu không thi
                System.out.println("Hehe stupid");
                break; //Thoát khỏi vòng lặp nếu không có lỗi
            } catch (Exception e) {
                System.out.println("Invalid input, please input yob again");
            }
        } while (true);
        

        System.out.print("Input address: ");
        address = sc.nextLine().toUpperCase();

        System.out.println("Here is your profile: ");
        System.out.println("Name: " + name);
        System.out.println("Yob: " + yob);
        System.out.println("Address: " + address);
    }

    public static void inputProfile() {
        String name, address;
        int yob;
        Scanner sc = new Scanner(System.in);

        System.out.print("Input name: ");
        name = sc.nextLine().toUpperCase();

        try {
            //Câu lệnh nguy hiểm thì nhốt nó lại          
            System.out.print("Input yob: ");
            yob = Integer.parseInt(sc.nextLine());
        } catch (Exception e) {
            //Khi có exception xảy ra, CPU bay vào đây, không giết app nữa, nghĩ rằng mình đã tự chủ động xử lý rồi
            //thường dùng để nhập lại, báo cáo lỗi
            //e chính là object msg màu đỏ mà JVM theo lẽ thường sẽ thông báo và giết app
            //nay chỉ gửi mình báo rằng có exception, m làm tiếp đi
            //Exception e = new Exceroption(dòng chữ màu đỏ);
            //e.printStackTrace(); //xem thử điều gì xảy ra
            yob = 2003;
        }

        System.out.print("Input address: ");
        address = sc.nextLine().toUpperCase();

        System.out.println("Here is your profile: ");
        System.out.println("Name: " + name);
        System.out.println("Yob: " + yob);
        System.out.println("Address: " + address);
    }

}
