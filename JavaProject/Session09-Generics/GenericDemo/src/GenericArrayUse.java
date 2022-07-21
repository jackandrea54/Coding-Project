
import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author ADMIN
 */
public class GenericArrayUse {

    public static <E> void printArray(E[] elements) { //GENERIC METHOD
        for(E element: elements) {
            System.out.print(element + ", ");    
        }
        System.out.println();
    }
    
    
    
    
    
    public static void main(String[] args) {
//        //Test Generic with ArrayList
//        int n = 5;
//        ArrayList<Student> list = new ArrayList();
//        for (int i = 0; i < n; i++) {
//            Student s = new Student("HE172", "Nghia", 2003, 8.9);
//            list.add(s);
//        }
////        list.add(n); không add được n dạng int vào ArrayList giới hạn object Student
//        for (int i = 0; i < n; i++) {
////            list.get(i);
////            System.out.println(list.get(i));
////            Student s = (Student) list.get(i); // list.get(i) trả về dạng Object do arraylist lưu ở dạng object
//            // nên phải ép kiểu về Student
//            //Sửa lại, dùng Generics, giới hạn list chỉ chứa đối tượng Student
//            Student s = list.get(i);
//            s.showProfile();
//        }
//        //----------------------------------------------------------------------
//        //Test Generic Class
//        MyGeneric<Integer> mg = new MyGeneric<>();
//        mg.add(9);
//        System.out.println("mg: " + mg.get());
//        MyGeneric<String> mg2 = new MyGeneric<>();
//        mg2.add("Hello");
//        System.out.println("mg2: " + mg2.get());

        //----------------------------------------------------------------------
        //Test Generic method: Method that introduce their own type parameters.
        //The type parameter's scope is limited to the method where it is declared
        //The syntax appears before the method's return type: public static <T> double out()
        Integer[] int_arr = {10,20,40,80};
        Double[] doub_arr = {3.4, 5.5, 1.2, 12.1};
        System.out.println("In mang so nguyen:");
        printArray(int_arr);
        
        String[] str_arr = {"hello", "every", "guys"};
        System.out.println("In mang string:");
        printArray(str_arr);
        
        //Check Generic static method with static <T>
        GenericArray<Integer> obj1 = new GenericArray<>();
        obj1.output(doub_arr); //Van dung vi T cua static khong dung chung voi object ma nhan lay cai gi thi dung cai day
        obj1.sort(doub_arr);
        System.out.println("After sort: ");
        GenericArray.output(doub_arr);
    }
}
