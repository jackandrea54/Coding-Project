/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package main;

import com.sun.org.apache.bcel.internal.generic.INSTANCEOF;
import data.Item;
import data.Painting;
import data.Statue;
/**
 *
 * @author ADMIN
 */
import data.Item;
import data.Vase;
import static java.rmi.server.RMIClassLoader.loadClass;
import java.util.ArrayList;
import java.util.Scanner;


public class ItemList {

    ArrayList<Item> list = new ArrayList<>();
    final int MAX = 100; //is the size of the array
    Scanner sc;

    

    public boolean addItem(Item item) {
        if (item == null) {
            return false;
        }
        list.add(item);
   
        return true;
    }

    //PRINT OUT INFORMATION OF ALL ITEMS
    public void displayAll() {
        if (list.isEmpty()) {
            System.out.println("The list is empty");
        } else {
            System.out.println("The list of item:\n--------------------------\n"
                    + " Types of Item | Creator | Value | Other information|\n");
            for (int i = 0; i < list.size(); i++) {
                System.out.printf("%2d.",i+1);
                list.get(i).output();
            }
        }
    }

    //Find the items by its creator and return the first item that found
    public Item findItem(String creator) {
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i).getCreator().equals(creator)) {
                return list.get(i);
            }
        }

        return null;
    }
    
    //Find the items by its creator and return the index of the first item that found
    public int findItemIndex(String creator) {
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i).getCreator().equals(creator)) {
                return i;
            }
        }

        return -1;
    }
    
    //Update the item
    public boolean updateItem(int index, Scanner sc) {
        if (index >= 0 && index < list.size()) {
            list.get(index).input(sc);
            return true;
        }
        return false;
    }
    
    //Remove an item
    public boolean removeItem(int index){
        if (index >= 0 && index < list.size()) {
            list.remove(index);
            return true;
        }
        return false;
    }
    
    //Print out all items that belongs to the given type in the list
    public void displayItemsByType(String type){
        System.out.println("The list of item:\n--------------------------\n"
                    + " Types of Item | Creator | Value | Other information|\n");
        if(type.equals("Vase")){
            for (int i = 0; i < list.size(); i++) {
                if(list.get(i) instanceof Vase){
                    list.get(i).output();
                }
            }
        }
        else if(type.equals("Painting")){
            for (int i = 0; i < list.size(); i++) {
                if(list.get(i) instanceof Painting){
                    list.get(i).output();
                }
            }
        } else if (type.equals("Statue")) {
            for (int i = 0; i < list.size(); i++) {
                if(list.get(i) instanceof Statue){
                    list.get(i).output();
                }
            }
        }       
    }
    
    //Sort item list
    public void sortItems(){
        Item tmp;
        for (int i = 0; i < list.size()-1; i++) {
            for (int j = 0; j < list.size(); j++) {
                if (list.get(i).getValue() > list.get(j).getValue()) {
                    tmp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, tmp);
                }
            }
        }
    }
}
