/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shapes;

/**
 *
 * @author Admin
 */
public class Program {

    public static void main(String[] args) {
        Shape s = new Circle(3);
        System.out.println(s.circumstance());
        System.out.println(s.area());
    }
}

abstract class Shape {
    int x; 

    abstract public double circumstance();

    abstract public double area();
}

//Trong class abstract (thường định nghĩa ra lớp parent), những method nào có thể hiện thực được, thì parent sẽ thực hiện ( công việc general nhất), các method khác (abstract method) thì để con tùy biến 
//class con cũng có thể ghi đè những class đã hiện thực trong class abstract.
class Circle extends Shape { //concrete class: có thể hiện thực hóa thành đối tượng (tạo instance hoặc tạo object)

    double r;

    public Circle(double rr) {
        r = rr;
    }

    public double circumstance() {
        return 2 * Math.PI * r;
    }

    public double area() {
        return Math.PI * r * r;
    }
}

class Rect extends Shape {

    double l, w;

    public Rect(double ll, double ww) {
        this.l = ll;
        this.w = ww;
    }

    public double circumstance() {
        return 2 * (l + w);
    }

    public double area() {
        return l * w;
    }
}