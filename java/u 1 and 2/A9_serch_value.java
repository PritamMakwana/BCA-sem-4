import java.util.*;

public class A9_serch_value {

    public  static void main(String[] args){

        Scanner input = new Scanner(System.in);

        int [] a = new int [10];

        for(int i=0; i<a.length; i++){
            System.out.println("Enter value of " + (i+1) + " number :-");
            a[i] = input.nextInt();
        }

        System.out.println("Search value inter ");
        int serach_value = input.nextInt();

        int tamp = 0,index = 0;

        for(int i=0; i<a.length; i++){
            if(a[i] == serach_value ){
                tamp = 1;
                serach_value = a[i];
                index = i+1;
            }
        }

        if(tamp == 1){
            System.out.println("value found ");
            System.out.println("index is :- "+index);
            System.out.println("value is :- "+serach_value);
        }
       else {
            System.out.println(" not input this value");
        }

    }
}
