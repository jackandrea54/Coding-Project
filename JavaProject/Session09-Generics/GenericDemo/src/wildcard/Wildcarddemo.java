/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package wildcard;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ADMIN
 */
abstract class Shape{
    abstract void draw();
}

class Rectangle extends Shape{

    @Override
    public void draw() {
        System.out.println("Draw rectangle");
    }
}

class Circle extends Shape{
    @Override
    public void draw() {
        System.out.println("Draw circle");
    }
}

//USED TO BOUND TYPE PARAMETERS
public class Wildcarddemo {
    public static void drawShape(List<? extends Shape> lists){
        for(Shape s:lists) {
            s.draw();
        }
    }
    
    public static void main(String[] args) {
        List<Rectangle> list1 = new ArrayList<>();
        list1.add(new Rectangle());
        list1.add(new Rectangle());
        
        List<Circle> list2 = new ArrayList<>();
        list2.add(new Circle());
        
        drawShape(list1);
        drawShape(list2);
    }
}

