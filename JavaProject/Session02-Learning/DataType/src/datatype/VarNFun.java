package datatype;

import java.util.Scanner; // Mo kho, muon do choi, muon hang, muon thu vien, do co san
// ~~~ #include <stdio.h> 
/**
 *
 * @author ADMIN
 */
public class VarNFun {

    public static void main(String[] args) {
        int x;
        x = getAPositiveInt();
        printIntegerList(x);
//        playWithBooleans();
//        playWithCharacters();
//        playWithDoubles();
//        playWithInteger();
//        playWithVariables();
    }

    public static int getAPositiveInt(){
        int n;
        System.out.print("Input a positive integer: ");
        Scanner banPhimCuaTui = new Scanner(System.in);
        n = banPhimCuaTui.nextInt();
        
        return n; // chinh la gan gia tri cho ten ham
    }   
    
    
    
    //Viet ham in ra so tu nhien tu 1-n
    //Hien tuong trong 1 class bat ki nao do, ma co nhieu ham trung ten nhau
    //va khac phan tham so/dau vao, nhung khac tren data type 
    //thi duoc goi la: OVERLOADING, qua tai ham
    public static void printIntegerList(int n) {
        System.out.println("The list of n first integers");
        for (int i = 1; i <= n; i++) {
            //System.out.print(i + " ");
            System.out.printf("%d ", i);
        }
    }

    //Viet ham in ra so tu nhien tu 1-100
    public static void printIntegerList() {
        System.out.println("The list of 100 first integers");
        for (int i = 1; i <= 100; i++) {
            //System.out.print(i + " ");
            System.out.printf("%d ", i);
        }
    }

    // Menh de so sanh, bieu thuc so sanh, cau phat bieu se co 2 trang thai dung sai 
    // 5 > 4, dung; 4 > 5, sai
    //C: dung quy uoc la 1, >0, sai quy uoc la 0
    //Java: dung quy uoc la true, sai quy uoc la false -> boolean
    public static void playWithBooleans() {
        boolean marriedStatus = false;
        if (marriedStatus == true) {
            System.out.println("Danh don co dich moi vui");
        } else {
            System.out.println("Vuon hong co loi chua co ai vao");
        }

        System.out.println("Luon co hy vong");
    }

    //char trong java  dung 2 bytes bang Unicode, luu cac loai ki tu tren the gioi
    public static void playWithCharacters() {
        char unit = '$';
        System.out.println("unit: " + unit);

        //luu ca 1 ten , chuoi ki tu - string
        //String moi hoan toan, kieu Object 
        String name = "Nguyen Dinh Nghia";
        System.out.println("My name is " + name);
        System.out.println("1st letter of my name " + name.charAt(0));

        System.out.println("My name as in lowercase: " + name.toLowerCase());

        //~ ham nam trong "." ~ C thu vien string.h 
        //Vdu trong C la strlwr() thi Java la .toLowercase() 
    }

    //Mac dinh Java uu tien double hon float
    //Moi so thuc literal dc xem la double 8 bytes
    public static void playWithDoubles() {
        double pi = 3.14;
        System.out.println("pi = " + pi);
        System.out.printf("pi: %.2f\n", pi); //Java khong ho tro %lf, cam tuyet doi dung %lf, chi dung %f cho ca 2

        float vat = 0.1F;
        System.out.println("vat: " + vat);

    }

    //nhung con so, ky tu, chuoi xuat hien ro rang, san trong code duoc goi la literal value
    //mac dinh Java uu tien choi voi int hon la voi long
    //moi so nguyen xuat hien trong code/literal integer thi mac nhien
    //coi la 4 byte int (khong qua 2^31~ 2 ty 1 may)
    public static void playWithInteger() {
        int yob = 2001;
        long money = 210_000_000_000L; // neu khong co chu L thi se bi loi vi so nguyen duoc de o dang int
        // them dau "_" de chia so to ra cho de nhin
        System.out.println("money: " + money);

        int a = 0xFA; //0x dung truoc so literal goi la he 16
        System.out.println("status = " + a);

        int phone = 070; //0 dung truoc so literal goi la he 8
        System.out.println("phone: " + phone);
    }

    public static void playWithVariables() {
        int yob = 2003;
        int a = 18, b;
        b = 79;
        //bien la 1 vung ram dc dat ten 
        System.out.println("yob = " + yob);
        int age = 2022 - yob;
        System.out.println("age: " + age + " years old");
        System.out.println("age: " + (2022 - yob) + " years old");
        System.out.printf("age: %d years old\n", age);
    }

}
