/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ADMIN
 */
public class SpecCala extends Cala {

    private int color;

    public SpecCala() {
    }

    public SpecCala(int color) {
        this.color = color;
    }

    public SpecCala(String owner, int price, int color) {
        super(owner, price);
        this.color = color;
    }

    @Override
    public String toString() {
        return super.toString() + "," + this.color;
    }

    public void setData() {
        this.setOwner(this.getOwner().replaceFirst(".\\w", this.getOwner().charAt(0) + "XX"));
    }

    public int getValue() {
        if (this.color % 2 != 0) {
            return this.getPrice() + 3;
        }
        return this.getPrice() + 7;
    }

}
