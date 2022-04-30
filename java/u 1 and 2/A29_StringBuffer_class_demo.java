class A26_String_class_demo{
    public static void main(String[] args) {
        StringBuffer  s1 = new StringBuffer("Computer Science Department");
        StringBuffer  s2 = new StringBuffer("Saurashtra University");

        System.out.println("inserting value = "+ s1.insert(9,s2));
        System.out.println("Appending two String = "+ s1.append(s2));
        
    }
}