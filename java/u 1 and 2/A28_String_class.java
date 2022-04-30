public class A28_String_class {
    public static  void main(String[] args){
        String a = new String("ksc");
        String a2;
        a2 = a + " ," + a ;
        System.out.println(a2);

        String s1 = "Computor Science Department";
        int b = s1.length();
        System.out.println("total character " + a);
        System.out.println("s1.indexOf('C')"+s1.indexOf('C'));
        System.out.println("s1.lastindexOf('c')"+s1.lastIndexOf('c'));
    }
}
