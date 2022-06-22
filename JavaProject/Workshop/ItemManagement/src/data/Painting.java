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
public class Painting extends Item{
    private int height;
    private int width;
    private boolean isWatercolour;
    private boolean isFramed;

    public Painting() {
    }

    public Painting(int height, int width, boolean isWatercolour, boolean isFramed) {
        this.height = height;
        this.width = width;
        this.isWatercolour = isWatercolour;
        this.isFramed = isFramed;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public boolean isIsWatercolour() {
        return isWatercolour;
    }

    public void setIsWatercolour(boolean isWatercolour) {
        this.isWatercolour = isWatercolour;
    }

    public boolean isIsFramed() {
        return isFramed;
    }

    public void setIsFramed(boolean isFramed) {
        this.isFramed = isFramed;
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
        System.out.print("Input width: ");
        this.width = sc.nextInt();
        sc.nextLine();
        System.out.print("Is it Water colour?: ");
        this.isWatercolour = sc.nextBoolean();
        sc.nextLine();
        System.out.print("Is it framed?: ");
        this.isFramed = sc.nextBoolean();
        sc.nextLine();
    }
    
    public void output(){
        System.out.printf("   Painting | %-7s | %5d | Height: %d, Width: %d , Water colour: %b, Framed: %b\n", this.creator, this.value, this.height,this.width, this.isWatercolour, this.isFramed);   
    }

    
}
