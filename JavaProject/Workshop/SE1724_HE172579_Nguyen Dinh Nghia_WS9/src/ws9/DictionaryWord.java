/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws9;

/**
 *
 * @author ADMIN
 */
public class DictionaryWord implements Comparable{
    private String word;
    private String meanings;

    public DictionaryWord(String word, String meanings) {
        this.word = word;
        this.meanings = meanings;
    }

    public String getWord() {
        return word;
    }

    public void setWord(String word) {
        this.word = word;
    }

    public String getMeanings() {
        return meanings;
    }

    public void setMeanings(String meanings) {
        this.meanings = meanings;
    }
    
    public void showWord(int index){
        System.out.println("<<" +(index+1)+ ">>,<<" +word+ ">>");
        System.out.println("<<" + meanings + ">>");
    }

    @Override
    public int compareTo(Object obj) {
        return this.word.compareTo(((DictionaryWord)obj).word);
    }
}
