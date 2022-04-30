class  C1_Exception_demo{

    public static void main(String[] args) {
        
      try{
       int j = 5/0;
       System.out.println("Exception demo");
      }catch(ArithmeticException e){
          System.out.println(e);
      }

      System.out.println("Rest of all code");

    }


}