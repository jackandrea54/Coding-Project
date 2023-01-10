/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package dao;

import entity.Category;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.DBConnect;

/**
 *
 * @author ADMIN
 */
public class DAOCategory extends DBConnect{
    public int AddCategory(Category cate) {
        int n = 0;
        String sql = "USE [SE1704]\n" +
                    "INSERT INTO [Category]\n" +
                    "           ([cateName]\n" +
                    "           ,[status])\n" +
                    "     VALUES\n" +
                    "           ('"+cate.getCateName()+"'\n" +
                    "           ,"+cate.getStatus()+")";

        try {
            //Tao lenh
            Statement state = conn.createStatement();
            //Chay lenh va nhan ket qua
            n = state.executeUpdate(sql);
        } catch (SQLException ex) {
            Logger.getLogger(DAOCustomer.class.getName()).log(Level.SEVERE, null, ex);
        }
        return n;
    }

    public static void main(String[] args) {
        DAOCategory dao = new DAOCategory();
        int n = dao.AddCategory(new Category("Shoes",1));
        if (n > 0) {
            System.out.println("inserted");
        }
    }
}
