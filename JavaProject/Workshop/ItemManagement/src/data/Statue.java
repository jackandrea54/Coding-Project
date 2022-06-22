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
public class Statue extends Item{
    private int weight;
    private String colour;

    public Statue() {
        
    }
    
    public Statue(int weight, String colour, int value, String creator) {
        super(value, creator);
        this.weight = weight;
        this.colour = colour;
    }

   
    public int getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public String getColour() {
        return colour;
    }

    public void setColour(String colour) {
        this.colour = colour;
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
        System.out.print("Input weight: ");
        this.weight = sc.nextInt();
        sc.nextLine();
        System.out.print("Input colour: ");
        this.colour = sc.nextLine();
    }
    
    public void output(){
        System.out.printf("   Statue   | %-7s | %5d | Weight: %d, Colour: %s\n",this.creator,this.value,this.weight,this.colour);
    }
}
