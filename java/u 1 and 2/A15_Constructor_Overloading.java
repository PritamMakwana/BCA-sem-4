public class A15_Constructor_Overloading {

    int id;
    String name;
    A15_Constructor_Overloading(){
        System.out.println("this is the defualt Constructor");
    }
    A15_Constructor_Overloading(int i ,String n){
        id = i;
        name = n;
    }
    public static void main(String[] args){
        A15_Constructor_Overloading obj = new A15_Constructor_Overloading();
        System.out.println("\n defualt constructor values");
        System.out.println("\n student id = " + obj.id + "\n student name = "+obj.name );

        System.out.println("\n Parameterized Constructor values \n");
        A15_Constructor_Overloading obj1 = new A15_Constructor_Overloading(1,"ABC");
        System.out.println("\n student id = " + obj1.id + "\n student name = "+obj1.name );

    }

}
