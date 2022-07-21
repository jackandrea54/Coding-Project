/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package array;

import sun.net.www.content.audio.x_aiff;

/**
 *
 * @author ADMIN
 */
public class BasicArray {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
//        playWithPrimitiveArray();
//        playWithPrimitiveArrayV2();
//        playWithPrimitiveArrayV3();
//        playWithObjectArray();
        sortObjectArray();
    }
    
    public static void sortObjectArray(){
        Student[] arr = new Student[2];
        arr[0] = new Student("HE172000", "Nghia Nguyen", 2003, 9.0);
        arr[1] = new Student("HE172578", "BINH LE", 2000, 5.0);
        System.out.println("Before sorting: ");
        for (Student stu : arr) {
            stu.showProfile();
        }
        
    }
    
    public static void playWithObjectArray(){
        //luu 50 sinh vien
        Student s1, s2, s3;
        Student[] s = new Student[50];
        s[0] = new Student("HE172579", "Nghia Nguyen", 2003, 9.0);
        s[1] = new Student("HE172579", "BINH LE", 2000, 5.0);
        s[2] = new Student("HE172579", "An Nguyen", 2001, 8.2);
        //47 bien con lai la default
        System.out.println("THE LIST OF STUDENTS: ");
        for (int i = 0; i < 3; i++) {
            s[i].showProfile();
        } //con tro null cho cac bien con lai, tuc la tro vao đáy RAM
        // đáy RAM  chỉ 00000000 (byte null) in ra NullPointerException 
        // khi chơi với mảng object, phải nhớ ko for hết mảng
        // vì phần chưa gán biến của mảng sẽ trỏ null, exception
        //chỉ for đến count, tức là chỗ đã gán new
        
//        String stest = "Hello8World";
//        System.out.println(stest + ": " + stest.matches("^.*\\d.*$")); //String Pattern, Regular Expression
    }
    
    public static void playWithPrimitiveArrayV3(){
        int arr3[] = new int[5]; //default het cho tat ca cac bien int thu [i]
        arr3[0] = 1;
        arr3[1] = 3;
        arr3[2] = 100;
        //[3], [4] default, khong phai rac nhu ben C
        //default: số -> 0, boolean -> false
        //vùng new có chứa hàm toString() 
        System.out.println("THe array has: " + arr3); // hash code cua arr3
        for (int x : arr3) {
            System.out.println("Print x: "+x);
        }
    }
    
    public static void playWithPrimitiveArrayV2(){
       // Trong C: double *arr = calloc(365, sizeof(double));
       
       double arr[] = new double[365]; //dung new vi toan bo data cua mang phai nam tren Heap
       //arr la con tro tro vung new chua 365 bien double primitive, gia tri 365 bien nay default la 0
       arr[0] = 6868;
        for (double x : arr) {
            System.out.print(x + " ");
        }
        System.out.println("The array has (Using for i):");
        for (int i = 0; i < arr.length; i++) {
            System.out.print("Arr[" + i + "]: "+arr[i] + ", ");
        }
        
    }
    
    
    
    public static void playWithPrimitiveArray(){
        // double v[100]; //ko cho phep ghi kich thuoc mang, so bien, so pt luc khai bao mang
        // double v[100] = {0, 1, 123, 321}; //Ko cho phep ghi kich thuoc luc khai bao mang
        double v[] = {0, 1, 123, 321, 10, 20, 200}; // co 7 bien double primitive
        System.out.println("The array has: ");
        for (int i = 0; i < 7; i++) { //CAM FOR VUOT BIEN< NEU VUOT SE BI EXCEPTION
            System.out.println("v["+i+"]:"+v[i]);
        }
        
        
    }
    
    
}
