package ui;


import java.util.ArrayList;
import java.util.Scanner;
/**
 *
 * @author thangnv
 */
public class Menu {
    ArrayList<String> menu;

    public Menu() {
        menu=new ArrayList<>();
    }
    
    public void add(String s){
        menu.add(s);
    }
    public void display(){
        if (menu.isEmpty()){
            System.out.println("Empty Menu");
            return;
        }
        for (int i=0;i<menu.size();i++)
            System.out.println(menu.get(i));
    }
    public int select(){
        if (menu.isEmpty()){
            return -1;
        }
        Scanner scan = new Scanner(System.in);
        display();
        System.out.print("Enter a number: ");
        int num = scan.nextInt();
        scan.nextLine();
        if (num<menu.size()) return num;
        else return -1;
    }
}
