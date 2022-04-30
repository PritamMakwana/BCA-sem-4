public class A10_Desition_making_statements {

    public static void main(String args[]){

        System.out.println("1.if statement");
        ifdemo();
        System.out.println("2.if...else statement");
        ifelsedemo();
        System.out.println("3.Nested if...else statement");
        nested_if_else_demo();
        System.out.println("4.switch...case statement");
        switchcasedemo();
    }

    private static void switchcasedemo() {

        int a = 2;

        switch(a){
            case 0:
                 System.out.println("i am in 0");
            break;
            case 1:
                System.out.println("i am in 1");
            break;
            case 2:
                System.out.println("i am in 2");
                break;
            default:
                System.out.println("i am in default");

        }

        System.out.println("out of switch");


    }

    private static void nested_if_else_demo() {

        int i = 10 , j = 15 , k = 20 ;

        if(i>j){
            if(i>k){
                System.out.println(" 10 is big value");
            }else{
                System.out.println(" 20 is big value ");
            }
        }else{
            if(j>k){
                System.out.println(" 15 is big value");
            }else{
                System.out.println(" 20 is big value ");
            }
        }


    }

    private static void ifelsedemo() {
        int j = 10 ;

        if(j < 15){
            System.out.println(" iam in if");
        }else{
            System.out.println("i am in else");
        }
        System.out.println("out of if..else");
    }

    private static void ifdemo() {
        int i  = 15 ;

        if(i > 10){
            System.out.println("i am in if");
        }
        System.out.println("i am out of if");
    }

}
