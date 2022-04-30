
abstract class A{
    abstract void callme();

    void callmetwo() {
        System.out.println("This is a method ");
    }
}
class B extends A {


    @Override
    void callme() {
        System.out.println("B's impletantion call me ");
    }
}

public class A19_Abstract_class {
    public static void main(String[] args){
        B b1 = new B();
        b1.callme();
        b1.callmetwo();
    }
}
