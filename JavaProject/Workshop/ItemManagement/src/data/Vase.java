/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

import java.util.Scanner;

/**
 *
 * @author ADMIN
 */
public class Vase extends Item{

    private int height;
    private String material;

    public Vase() {
        
    }

    public Vase(int height, String material, int value, String creator) {
        super(value, creator);
        this.height = height;
        this.material = material;
    }

    
    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public String getMaterial() {
        return material;
    }

    public void setMaterial(String material) {
        this.material = material;
    }

    public int getValue() {
        return value;
    }

    public void setValue(int value) {
        this.value = value;
    }

    public String getCreator() {
        return creator;
    }

    public void setCreator(String creator) {
        this.creator = creator;
    }
    
    
    public void input(Scanner sc){
        super.input(sc);
        System.out.print("Input height: ");
        this.height = sc.nextInt();
        sc.nextLine();
        System.out.print("Input material: ");
        this.material = sc.nextLine();
    }
    
    public void output(){
        System.out.printf("   Vase     | %-7s | %5d | Height: %d, Material: %s\n",this.creator,this.value,this.height,this.material);
    }
    
    
}
