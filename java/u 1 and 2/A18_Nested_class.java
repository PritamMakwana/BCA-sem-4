class OuterDemo
{
    int outer_x = 100;
    void test(){
        Inner i = new Inner();
        i.display();
    }
    class Inner {
        void display(){
            System.out.println("display  outer_x = "+ outer_x);
        }

    }
}

class Nested_class{
    public static void main(String[] args){
        OuterDemo o = new OuterDemo();
        o.test();
    }
}