/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package wrapper;

/**
 *
 * @author ADMIN
 */
public class WrapperClass {
    public static void main(String[] args) {
//        playWithIntegers();
//        playWithPointers();
          playWithPools();
    }
    
    //Hồ bơi: nhiều chàng trỏ 1 nàng, share chung vùng new Wrapper
    public static void playWithPools() {
        Integer n1 = new Integer("2003");
        
        Integer n2 = new Integer(2003);
        Integer n3 = new Integer(2003);
        
        Integer n4 = 2003;
        Integer n5 = 2003;
        
        System.out.println("n1 vs n2: " +(n1 == n2));
        System.out.println("n2 compare to n3: " + n2.compareTo(n3));
        System.out.println("n1 vs n3: " +(n1 == n3));
        System.out.println("n2 vs n3: " +(n2 == n3));
        System.out.println("n3 vs n4: " +(n3 == n4));
        System.out.println("n4 vs n5: " +(n4 == n5));
        System.out.println("n2 vs n4: " +(n2 == n4));
        
        Integer n6 = -128;
        Integer n7 = -128;
        System.out.println("n6 vs n7: " +(n6==n7));
        
        //Nếu chơi trực tiếp NEW NGẦM trong đoạn [-128,..127]
        //thì các biến Object trỏ cùng 1 vùng new dù có lệnh gán = value;
        //n7 = -128; nó không new mà tìm xem thằng nào new -128 trực tiếp chưa, tìm thấy thì 
        //xin vùng new đó, trò cùng vào.
        //[-128,..127] -> hồ bơi integer, INTEGER POOL
        
        //STRING CŨNG Y CHANG, CÓ HỒ BƠI 
        String s1 = "Hello";
        String s2 = "Hello"; //2 đứa tắm chung
        
        String s3 = new String("Hello");
        String s4 = "HELLO"; //hồ tắm khác
        //String pool phân biệt hoa thường
        String s5 = "Hello";
        
        System.out.println("s1 = s2? "+(s1==s2));
        System.out.println("s2 = s3? "+(s2==s3));
        System.out.println("s3 = s4? "+(s3==s4));
        System.out.println("s3 = s5? "+(s3==s5));
        System.out.println("s1 = s5? "+(s1==s5));
        //CHUỖI NEW NGẦM LÀ POOL
        
        //CHỐT HẠ: KO CARE VIỆC SO SÁNH 2 BIẾN OBJECT DÙNG ==
        //VÌ KẾT QUẢ ĐÚNG SAI KHÔNG CHÍNH XÁC, LIÊN QUAN ĐẾN POOL VÀ KHÔNG POOL
        //ĐÚNG CHUẨN LÀ PHẢI CHẤM VÀO BÊN TRONG ĐỂ LẤY VALUE RA XÀI VÀ SO SÁNH
        //MỖI OBJECT NÊN LÀM LUÔN SẴN HÀM SO SÁNH VỚI CÙNG ĐỒNG LOẠI
        //SO XEM MÌNH CÓ EQUALS(NGƯỜI KIA KHÔNG)
        //SO XEM MÌNH TƯƠNG QUAN THẾ NÀO COMPARETO(NGƯỜI KIA)
        
        
        
        
        
        
    }
    
    public static void playWithPointers(){
        Integer num0 = 2000;
        Integer num1 = 2001;
        
        //SO SÁNH LÕI
        System.out.println("Compare in core num0 and num1: " + num0.equals(num1));
    }
    
    
    //Collection, List/Set/Map chỉ chơi với Object
    public static void playWithIntegers(){
        
        int num0 = 2003; //4 bytes
        
        Integer num1 = new Integer("2003");
        Integer num2 = new Integer(2003); //trò này đừng nên chơi ở JDK 10 trở lên
        Integer num3 = 2003; //new ngầm, nhìn tự nhiên
        
        System.out.println("num0: "+num0);  //xài luôn vùng RAM
        System.out.println("num1 "+num1);   //biến con trỏ
        System.out.println("num2 "+num2.toString());   
        System.out.println("num3 "+num3.intValue());
        //vào bên trong lấy value lõi ra mà xài, lõi chính là int 4 bytes
        //BOXING là hiện tượng: Primite -> Object
        //Gán primitive vào biến Object-> New trước rồi nhét value vào trong hạt nhân
        
        int num4 = num3; //địa chỉ gán vào primite????
                         //vào vùng num3, lôi ra cái core/lõi chính là int value = 2003 thay sang num4.
                         //UNBOXING: gán từ Wrapper Object sang Primitive
        System.out.println("num4: "+num4);  
        
        //Integer num3 = 2003;
        System.out.println("Check num3: " + num3);
        num3 = 2001;    //1 vùng new Integer mới (2001 đổ vào)
                        //vùng Integer cũ (2003) bị dọn
        //WRAPPER CLASS không có hàm set()
        //CLASS này Object này kiểu READ-ONLY
        //IMMUTABLE CLASS: Class không cho phép hiệu chỉnh info, muốn hiệu chỉnh phải New mới, là Class không có hàm Set()
                      
    }
    // WRAPPER CLASS LÀ NHỮNG CLASS SINH RA ĐỂ BAO CÁC PRIMITIVE LẠI THÀNH 1 OBJECT
    //LÕI CỦA OBJECT NÀY CHÍNH LÀ CHỈ CÓ 1 BIẾN PRIMITIVE
    //CẢ THẾ GIỚI LÚC NÀY LÀ OBJECT, DO ĐÓ TÚI COLLECTION/LIST/SET/MAP SẴN SÀNG
    //CHỨA CÁC CON SỐ,1 MÌNH CON SỐ, THEO KIỂU TRỎ VÀO VÙNG NEW WRAPPER CLASS
    //LÕI CHÍNH LÀ SỐ CẦN LƯU
    //KHÁC MẢNG []: 2 LOẠI MẢNG PRIMITIVE VÀ MẢNG OBJECT
    
    //WRAPPER CLASS: Byte   Short   Integer     Long    Float   Double  Character   Boolean
    //Lõi            byte   short   int         long    float   double  char        boolean
}
