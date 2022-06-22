/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import data.Item;
import data.Painting;
import data.Statue;
import data.Vase;
import java.io.IOException;
import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class AntiqueShop {

    public static void main(String[] args) throws InterruptedException, IOException {
        Scanner sc = new Scanner(System.in);
        ItemList antiqueList = new ItemList();
        int index;
        String creator, type;
        Item tmp;
        int choice = 0;
        do {
            System.out.println("---------------------------");
            System.out.println("1. Add a new vase");
            System.out.println("2. Add a new statue");
            System.out.println("3. Add a new painting");
            System.out.println("4. Display all items");
            System.out.println("5. Find the items by the creator");
            System.out.println("6. Update the item by its index");
            System.out.println("7. Remove the item by its index");
            System.out.println("8. Display the list of vase items");
            System.out.println("9. Sorts items in ascending order based on their values");
            System.out.println("10. Exit");
            System.out.print("Input your choice: ");
            choice = sc.nextInt();
            System.out.println("");
            sc.nextLine();
            switch (choice) {
                case 1:
                    tmp = new Vase();
                    tmp.input(sc);
                    if (antiqueList.addItem(tmp)) {
                        System.out.println("Added!\n");
                    }
                    break;
                case 2:
                    tmp = new Statue();
                    tmp.input(sc);
                    if (antiqueList.addItem(tmp)) {
                        System.out.println("Added!\n");
                    }
                    break;
                case 3:
                    tmp = new Painting();
                    tmp.input(sc);
                    if (antiqueList.addItem(tmp)) {
                        System.out.println("Added!\n");
                    }
                    break;
                case 4:
                    antiqueList.displayAll();
                    break;
                case 5:
                    System.out.print("Which creator do you want to search?:");
                    creator = sc.nextLine();
                    tmp = antiqueList.findItem(creator);
                    if (tmp == null) {
                        System.out.println("There are no such creator.");
                    } else {
                        tmp.output();
                    }
                    break;
                case 6:
                    System.out.print("Which index item do you want to update?: ");
                    index = sc.nextInt();
                    sc.nextLine();
                    antiqueList.updateItem(index, sc);
                    break;
                case 7:
                    System.out.print("Which index item do you want to remove?: ");
                    index = sc.nextInt();
                    sc.nextLine();
                    antiqueList.removeItem(index);
                    break;
                case 8:
                    System.out.println("Input your desire Item type to searth");
                    type = sc.nextLine();
                    antiqueList.displayItemsByType(type);
                    break;
                case 9:
                    antiqueList.sortItems();
                    System.out.println("Finished sorting!\n");
                    break;
            }
            System.out.print("Press any key to continue . . . ");
            sc.nextLine();
            System.out.print("\f"); //Chua clear duoc console
        } while (choice <= 9);
    }
}
