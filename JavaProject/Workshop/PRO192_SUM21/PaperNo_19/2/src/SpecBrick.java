/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class SpecBrick extends Brick{
    private int color;

    public SpecBrick() {
    }

    public SpecBrick( String place, int price, int color) {
        super(place, price);
        this.color = color;
    }

    @Override
    public String toString() {
        return super.toString() + "," + color;
    }
    
    public void setData(){
        System.out.println(this.getPlace().substring(0, 2) + "BCA" + this.getPlace().substring(2,this.getPlace().length()));
            
    }
    
    public int getValue(){
        int inc;
        if(this.color > 7) inc = 9;
        else inc = 6;
        return this.getPrice() + inc;
    }
}
