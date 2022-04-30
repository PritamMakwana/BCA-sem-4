class C3_throw_demo{
    public static void main(String[] args){

        try{

           int i = 1;
           int j = 0;
           int k = i / j;

           if(k > 10){
               throw new ArithmeticException();
           }

           }catch(NullPointerException e){
               System.out.println(e);
           }catch(ArithmeticException e1){
            System.out.println(e1);
            System.out.println("using throw");
           }finally{
               System.out.println("I'm final");
           }
     
           System.out.println("Rest of all code");
    
    }
}