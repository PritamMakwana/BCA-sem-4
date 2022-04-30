public class A27_wrapper_using {
    public static void main(String[] args){
        //converting int into Integer
        System.out.println("Wrapper Auto Boxing");
        int a = 20;
        //converting Integer to int Inplishet
        Integer i = Integer.valueOf(a);
        Integer j = a; //auto Boxing

        System.out.println(a+" "+i+" "+j);

        System.out.println("Wrapper UnAuto Boxing");
         //converting Integer to int
        Integer x = new Integer(3);
        //converting Integer to int Explicite
        int y = x.intValue();
        int z = x; //UnAuto Boxing
        System.out.println(x+" "+y+" "+z);
    }
}
