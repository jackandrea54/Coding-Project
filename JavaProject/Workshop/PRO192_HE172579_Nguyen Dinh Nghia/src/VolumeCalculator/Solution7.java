/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package VolumeCalculator;

/**
 *
 * @author ADMIN
 */
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.reflect.*;
import java.security.Permission;

class Calculate {

    public Scanner scanner = new Scanner(System.in);

    Output output = new Output();

    public int getINTVal() throws IOException {
        int input = scanner.nextInt();
        if (input <= 0) {
            throw new NumberFormatException("All the values must be positive");
        }
        return input;
    }

    public int readInt() {
        return scanner.nextInt();
    }

    public static Volume get_Vol() {
        return new Volume();
    }

    public double getDoubleVal() throws IOException {
        double input = scanner.nextDouble();
        if (input <= 0) {
            throw new NumberFormatException("All the values must be positive");
        }
        return input;
    }
}

class Volume {

    public double main(int a) {
        return a * a * a;
    }

    public double main(int l, int b, int h) {
        return l * b * h;
    }

    public double main(double r) {
        return (2 * Math.PI * r * r * r) / 3;
    }

    public double main(double r, double h) {
        return Math.PI * (r * r) * h;
    }
}

class Output {

    void display(double num) {
        System.out.println(String.format("%.3f", num));
    }
}

public class Solution7 {

    public static void main(String[] args) {
        Do_Not_Terminate.forbidExit();
        try {
            Calculate cal = new Calculate();
            int T = cal.getINTVal();
            while (T-- > 0) {
                double volume = 0.0d;
                int ch = cal.getINTVal();
                if (ch == 1) {

                    int a = cal.getINTVal();
                    volume = Calculate.get_Vol().main(a);

                } else if (ch == 2) {

                    int l = cal.getINTVal();
                    int b = cal.getINTVal();
                    int h = cal.getINTVal();
                    volume = Calculate.get_Vol().main(l, b, h);

                } else if (ch == 3) {

                    double r = cal.getDoubleVal();
                    volume = Calculate.get_Vol().main(r);

                } else if (ch == 4) {

                    double r = cal.getDoubleVal();
                    double h = cal.getDoubleVal();
                    volume = Calculate.get_Vol().main(r, h);

                }
                cal.output.display(volume);
            }

        } catch (NumberFormatException e) {
            System.out.print(e);
        } catch (IOException e) {
            e.printStackTrace();
        } catch (Do_Not_Terminate.ExitTrappedException e) {
            System.out.println("Unsuccessful Termination!!");
        }

    }
}

/**
 * This class prevents the user from using System.exit(0) from terminating the
 * program abnormally.
 */
class Do_Not_Terminate {

    public static class ExitTrappedException extends SecurityException {
    }

    public static void forbidExit() {
        final SecurityManager securityManager = new SecurityManager() {
            @Override
            public void checkPermission(Permission permission) {
                if (permission.getName().contains("exitVM")) {
                    throw new ExitTrappedException();
                }
            }
        };
        System.setSecurityManager(securityManager);
    }
}//end of Do_Not_Terminate	
