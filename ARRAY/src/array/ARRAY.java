package array;

import java.util.ArrayList;
import java.util.Scanner;

public class ARRAY {

    public static void main(String[] args) {
        Scanner entrada =new Scanner (System.in);
        ArrayList<String>p;
        p=new ArrayList<String>();
        p.add("Hola");
        p.add("Como");
        p.add("Estas");
        for (int i=0;i<p.size();i++){
            System.out.println("-"+p.get(i));
        }
    }
    
}
