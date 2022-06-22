/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package studentmanagement;

import data.Student;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class StudentManagement {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        saveAStudent();
    }

    
    public static void inputAStudent() {
        String id,name;
        int yob;
        double gpa; //local variable, STACK
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Input id: ");
        id = sc.nextLine();
        
        System.out.print("Input name: ");
        name = sc.nextLine();
        
        System.out.print("Input Year of birth: "); // Java cx bị lạc trôi lệnh y chang như C khi cho nhập chuỗi sau số
        yob = sc.nextInt();
        
        System.out.print("Input GPA: ");
        gpa = sc.nextDouble();
        Student x = new Student(id, name, yob, gpa);
        x.showProfile();
        
    }

    //hard-code fix luôn tên sinh viên
    public static void saveAStudent() {
        Student s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);      
        s1.showProfile();
        Student s2 = new Student("HE123456", "BINH LE", 2001, 8.5); // chốt deal biến static, ghi đè lên biến static chung cho mọi object cùng class
        s1.showProfile();
        s2.showProfile();// Cac instance static se giong nhau
        
        //Khi dac tinh public ta co the lay instance thoai mai
        System.out.println("s2 name: " +s2.name);
        System.out.println("s2 name: " + s2.getName());
        
        System.out.println("After renaming");
        s2.name = "Hoc bai di cu";
        
        //Khi dùng static và public thì ko nên TƯ HỮU
        //PHẢI LÀ CỦA CHUNG, SỜ STATIC THÌ NÊN SỜ QUA CLASS NAME
        //Student.name mới đúng chuẩn vì name là của chung mọi Object clone từ Student
        Student.name = "Chơi game thôi";
        Student.sayHi();
        s1.showProfile();
        s2.showProfile();
        
        //CHơi static làm chấm trực tiếp: Tên Class chấm hàm/biến        
        //Ví dụ Math.PI, System.in, 
    }
}
