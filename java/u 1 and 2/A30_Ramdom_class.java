import java .util.Random;
class A27_Ramdom_class{
  public static void main(String[] args){
      Random r = new Random();

      System.out.println("A Random int = "+ r.nextInt());
      System.out.println("A Random int from 0 to 49 = "+ r.nextInt(50));
      System.out.println("A Random double = "+ r.nextDouble());
      System.out.println("A Random float = "+ r.nextFloat());
  }
}