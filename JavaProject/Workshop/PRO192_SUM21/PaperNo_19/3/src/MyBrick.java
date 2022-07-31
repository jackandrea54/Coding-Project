
import java.util.Collections;
import java.util.List;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author ADMIN
 */
public class MyBrick implements IBrick {

    @Override
    public int f1(List<Brick> t) {
        int count = 0;
        for (Brick x : t) {
            if (x.getPlace().matches("^\\d.*[a-zA-Z]$")) {
                count++;
            }
        }

        return count;
    }

    @Override
    public void f2(List<Brick> t) {
        int maxOddIndex = 0;
        for (int i = 1; i < t.size(); i++) {
            if (t.get(i).getPrice() > t.get(maxOddIndex).getPrice()) {
                if (checkOdd(t.get(i).getPrice())) {
                    maxOddIndex = i;
                }
            }
        }
        t.get(maxOddIndex).setPlace("XX");
    }

    public boolean checkOdd(int num) {
        if (num % 2 != 0) {
            return true;
        }
        return false;
    }

    @Override
    public void f3(List<Brick> t) {
        int maxIndex = 0;
        for (int i = 1; i < t.size(); i++) {
            if (t.get(i).getPrice() > t.get(maxIndex).getPrice()) {
                maxIndex = i;
            }
        }
        List<Brick> t1 = t.subList(0, maxIndex);
        Collections.sort(t1);
        
    }

}
