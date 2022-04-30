import java.util.*;

public class A8_matix_sum {

    public static void main(String[] args){

        Scanner input = new Scanner(System.in);

        int[][] first_array = new int [2][2];

        System.out.println("input Matix A values:-");

        for(int i=0; i<first_array.length; i++){
            for(int j=0; j<first_array[i].length; j++) {
                first_array[i][j] = input.nextInt();
            }
        }
        int[][] Second_array = new int [2][2];

        System.out.println("input Matix B values:-");

        for(int i=0; i< Second_array.length; i++){
            for(int j=0; j< Second_array[i].length; j++) {
                Second_array[i][j] = input.nextInt();
            }
        }
        //---output

        System.out.println("Matix A");

        for(int i=0; i<first_array.length; i++){
            for(int j=0; j<first_array[i].length; j++) {
                System.out.print(first_array[i][j]+" ");
            }
            System.out.println();
        }

        System.out.println("Matix B");

        for(int i=0; i< Second_array.length; i++){
            for(int j=0; j< Second_array[i].length; j++) {
                System.out.print( Second_array[i][j]+" ");
            }
            System.out.println();
        }

        //-----sum-----

        System.out.println("sum");

        for(int i=0; i< Second_array.length; i++){
            for(int j=0; j< Second_array[i].length; j++) {
                System.out.print( first_array[i][j]+Second_array[i][j]+" ");
            }
            System.out.println();
        }
    }

}
