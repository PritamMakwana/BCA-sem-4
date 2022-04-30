
public class A4_operator {

    public static  void main(String[] args){

        System.out.println("1.Arithmetic Operator");
        System.out.println();

        float a=20.f,b=2.4f;

        System.out.println("a="+a);
        System.out.println("b="+b);

        System.out.println("a+b="+(a+b));
        System.out.println("a-b="+(a-b));
        System.out.println("a*b="+(a*b));
        System.out.println("a/b="+(a/b));
        System.out.println("a%b="+(a%b));

        System.out.println();
        System.out.println("2.Comparison Operators");
        System.out.println();

        float c=15.0f,d=20.75f,e=15.0f;

        System.out.println("A="+c);
        System.out.println("B="+d);
        System.out.println("C="+e);

        System.out.println("A<B = "+ (c<d));
        System.out.println("A>B = "+ (c>d));
        System.out.println("A==B = "+ (c==d));
        System.out.println("A<=B = "+ (c<=d));
        System.out.println("A>=B = "+ (c>=d));
        System.out.println("A!=B = "+ (c!=d));

        System.out.println();
        System.out.println("3.Logical Operators");
        System.out.println();

        int w=15, x=30,y=15,z=30;

        if(w==y && x==z){
            System.out.println("Equal");
        }
        else if(w<x || w<y){
            System.out.println("A is smaller than any than Any other values");
        }
        else if(w!=x){
            System.out.println("the value  of A and B are not equal");
        }

        System.out.println();
        System.out.println("4.Ternary Operator ");
        System.out.println();

        Ternary_Operator();

    }

    private static void Ternary_Operator() {

        int a = 10,b =15;

        int x = 0;

        x =(a>b) ? a : b ;

        System.out.println("X =" + x);

    }

}
