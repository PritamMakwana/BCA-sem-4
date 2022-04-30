public class A11_loops {

    public static void main(String[] args){

        System.out.println("1.while loop");
        int i = 1;
        while(i<=3){
            System.out.println("i = " + i);
            i++;
        }
        System.out.println("---end---");

        System.out.println("2.for loop");

        for(int j = 1 ; j<=3 ; j++){
            System.out.println("j = " + j);
        }
        System.out.println("---end---");

        System.out.println("3.do-while loop");
        int k = 1;
        do{
            System.out.println("k = " + k);
            k++;
        }while(k<=3);
        System.out.println("---end---");

    }

}
