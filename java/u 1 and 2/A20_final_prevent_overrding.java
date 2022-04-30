class A1{
    final void meth(){
        System.out.println("This is a final method");
    }
}
class B1 extends A1{
    //void meth(){
        //error can not be overriden
     //  System.out.println("illegle");
    //}
}

public class A20_final_prevent_overrding {
    public static void main(String[] args){
        B1 obgb1 = new B1();
        obgb1.meth();
    }
}
