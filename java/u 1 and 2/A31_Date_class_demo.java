import java.util.*;

class A28_Date_class_demo{
 public static void main(String[] args){
     Date d1 = new Date(2000,11,21);
     Date d2 = new Date(); //current date
     Date d3 = new Date(2010,1,3);

     boolean a = d3.after(d1);

     System.out.println("Date d3 comes after "+"Date d2 "+a);
     System.out.println("current Date = " + d2);
     boolean b = d3.before(d2);
     System.out.println("Date d3 comes after "+"Date d2 "+b);

 }
}