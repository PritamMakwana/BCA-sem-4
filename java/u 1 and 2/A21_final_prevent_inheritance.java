final class A2{
    void get(){
        System.out.println("class A");
    }
}

//class B2 extends A2{
//    error can not B a sub class can't inherit
//}


public class A21_final_prevent_inheritance {
    public static  void main(String[] args){
     A2 a2= new A2();
     a2.get();
    }
}
