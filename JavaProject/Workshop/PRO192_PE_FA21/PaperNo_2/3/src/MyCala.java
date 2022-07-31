
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
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
public class MyCala implements ICala{

    @Override
    public int f1(List<Cala> t) {
        int count = 0;
        for (Cala x : t) {
            if (Character.isDigit(x.getOwner().charAt(1))) {
                count++;
            }
        }
        return count;
    }

    @Override
    public void f2(List<Cala> t) {
        int check = findSecondMax(t, findMax(t));
        if(check >= 0)
            t.remove(check);
    }

    public int findMax(List<Cala> t) {
        int indexMax = 0;
        for (int i = 1; i < t.size(); i++) {
            if (t.get(i).getPrice() > t.get(indexMax).getPrice()) {
                indexMax = i;
            }
        }
        return indexMax;
    }

    public int findSecondMax(List<Cala> t, int indexMax) {
        for (int i = indexMax + 1; i < t.size(); i++) {
            if (t.get(indexMax).getPrice() == t.get(i).getPrice()) {
                return i;
            }
        }
        return -1;
    }

    @Override
    public void f3(List<Cala> t) {
        Comparator<Cala> compareObj = new Comparator<Cala>() {
            @Override
            public int compare(Cala t1, Cala t2) {
//                    int d = t1.getOwner().codePointAt(1) - t2.getOwner().codePointAt(1);
//                    return d;
                    return t1.getOwner().substring(1,2).compareTo(t2.getOwner().substring(1,2));
            }
        };
        
        Collections.sort(t,compareObj);
    }

    
    
}
