import java.util.SortedSet;
import java.util.TreeSet;


class A35_SortedSet_class{
    public static void main(String[] args){

        SortedSet<Integer> n = new TreeSet<>();

        n.add(1);
        n.add(2);
        n.add(3);
        n.add(4);

        System.out.println("Sorted " + n);

        int fno = n.first();

        System.out.println("First " + fno);

        int lno = n.last();

        System.out.println("Last " + lno);

        boolean res = n.remove(2);

        System.out.println("2 removed  ?" + res);

    }
}