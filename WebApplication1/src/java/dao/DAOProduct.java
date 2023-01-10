/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

import entity.Product;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

/**
 *
 * @author ADMIN
 */
public class DAOProduct extends DBConnect {

    public int AddProduct(Product product) {
        int n = 0;
        String sql = "USE [SE1704]\n"
                + "\n"
                + "INSERT INTO [Product]\n"
                + "           ([pid]\n"
                + "           ,[pname]\n"
                + "           ,[quantity]\n"
                + "           ,[price]\n"
                + "           ,[image]\n"
                + "           ,[description]\n"
                + "           ,[status]\n"
                + "           ,[cateID])\n"
                + "     VALUES\n"
                + "           ('"+product.getPid()+"'\n"
                + "           ,'"+product.getPname()+"'\n"
                + "           ,'"+product.getQuantity()+"'\n"
                + "           ,'"+product.getPrice()+"'\n"
                + "           ,'"+product.getImage()+"'\n"
                + "           ,'"+product.getDescription()+"'\n"
                + "           ,'"+product.getStatus()+"'\n"
                + "           ,'"+product.getCateID()+"')";
        
        Statement state;
        
        try {
            state = conn.createStatement();
            n = state.executeUpdate(sql);
        } catch (SQLException ex) {
            Logger.getLogger(DAOProduct.class.getName()).log(Level.SEVERE, null, ex);
        }
        return n;
    }
    public static void main(String[] args) {
        DAOProduct dao = new DAOProduct();
        int n = dao.AddProduct(new Product("P01", "Jordan", 10, 89000,
                "https://shopgiayreplica.com/wp-content/uploads/2021/04/Jordan-1-Retro-High-Twist-Panda.jpeg",
                "Very nice shoes", 0, 1));
        if (n > 0) {
            System.out.println("Inserted");
        }
    }
}
