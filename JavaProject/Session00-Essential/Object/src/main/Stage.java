/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import data.Student;

/**
 *
 * @author ADMIN
 */
public class Stage {

    public static void main(String[] args) {

        checkObjectV6();
        Student x = checkObjectV7(); //x = tọa độ new đã được return qua tên hàm
        x.showProfile();
        
        checkObjectV7().showProfile();
    }
    
    //HÀM TRẢ VỀ OBJECT, KHÔNG TRẢ VỀ PRIMITIVE
    //Hàm này trả về tọa độ của 1 object đã new đâu đó
    public static Student checkObjectV7() { //tên hàm này cũng là 1 biến Object, giá trị của hàm này là tọa độ new nào đó
        Student s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);
        
        return s1;
        //
    }
    
    //KHAI BÁO BIẾN RỒI GÁN SAU
    public static void checkObjectV6() {
        Student s1;
        s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);
    }
    
    public static void checkObjectV5() {
        
    }

    //HAI CHÀNG TRỎ MỘT NÀNG
    public static void checkObjectV4() {
        Student s1 = new Student("SE172579", "An Nguye", 1998, 8.0);
        Student s2 = s1; //2 thằng cùng trỏ 1 địa chỉ
        s1.setName("DIT ME CUOC DOI");
        s2.showProfile();
        s1.showProfile();
    }

    //BACKUP OBJECT, LƯU LẠI TỌA ĐỘ
    public static void checkObjectV3() {
        Student s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);

        Student x = s1; //Copy dia chi cua con tro s1 cho x
        s1.setName("Dit me cuoc doi");
        s1 = new Student("HE172579", "Binh Le", 2003, 8.9);
        s1.showProfile();
        x.showProfile();;
    }

    public static void checkObjectV2() {
        Student s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);
        s1 = new Student("HE172579", "Binh Le", 2003, 8.9);
        s1.showProfile();

    }

    //Kiem tra xem viec new trung thong tin bi lam sao
    public static void checkObjectV1() {
        Student s1 = new Student("HE172579", "An Nguyen", 2003, 8.9);
        Student s2 = new Student("HE172579", "An Nguyen", 2003, 8.9);
        s1.showProfile();
        s2.showProfile();
    }

    public static void checkObject() {
        Student an = new Student("HE172579", "An Nguyen", 2003, 8.9);
        an.showProfile();

    }
}
