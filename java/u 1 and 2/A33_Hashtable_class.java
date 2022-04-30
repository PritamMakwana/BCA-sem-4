import java.util.*;

class A33_Hashtable_class{
    public static void main(String[] args){
        Hashtable<Integer,String> map = new Hashtable<Integer,String>();
        map.put(100,"Amit");
        map.put(102,"Ravi");
        map.put(101,"vijay");
        map.put(103,"Rahul");

        System.out.println("Before remove " + map);
        map.remove(102);

        System.out.println("After remove 102 " + map);
        System.out.println(map.getOrDefault(101,"No Default"));
        System.out.println(map.getOrDefault(105,"No Default"));
    }
}