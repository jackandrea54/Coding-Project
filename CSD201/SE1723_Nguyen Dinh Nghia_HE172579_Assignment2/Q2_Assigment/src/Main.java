// ======= DO NOT EDIT THIS FILE ============
import java.io.*;
import java.util.*;
class Main {
   public static void main(String args[]) throws Exception {
    BSTree t = new BSTree();
    BSTree_fix t_fix = new BSTree_fix();
    int choice;
    Scanner sca = new Scanner(System.in);
    System.out.println("Nguyen Dinh Nghia- HE172579");
    System.out.println(" 1. Test f1 (1 mark)");
    System.out.println(" 2. Test f2 (1 mark)");
    System.out.println(" 3. Test f3 (1 mark)");
    System.out.println(" 4. Test f4 (1 mark)");
    System.out.print("    Your selection (1 -> 4): ");
    choice = sca.nextInt();
    sca.nextLine();
    switch(choice) {
       case 1: t.f1();
               System.out.println("Your output:");
               Lib.viewFile("f1.txt");
               t_fix.f1();
               System.out.println("Fixed output:");
               Lib.viewFile("f1.txt");
               break;
       case 2: t.f2();
               System.out.println("Your output:");
               Lib.viewFile("f2.txt");
               t_fix.f2();
               System.out.println("Fixed output:");
               Lib.viewFile("f2.txt");
               break;
       case 3: t.f3();
               System.out.println("Your output:");
               Lib.viewFile("f3.txt");
               t_fix.f3();
               System.out.println("Fixed output:");
               Lib.viewFile("f3.txt");
               break;
       case 4: t.f4();
               System.out.println("Your output:");
               Lib.viewFile("f4.txt");
//               System.out.println("Phan lam cua Duc:");
//               t_fix.f4();
//               System.out.println("Fixed output:");
//               Lib.viewFile("f4.txt");
               break;
       default: System.out.println("Wrong selection");
      }
     System.out.println();
   }      
 }