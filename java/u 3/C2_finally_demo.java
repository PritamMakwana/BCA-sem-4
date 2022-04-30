class C2_finally_demo{
    public static void main(String[] args){

        try{
            int j = 5/2;
            System.out.println("Exception demo");
           }catch(ArithmeticException e){
               System.out.println(e);
           }finally{
               System.out.println("finally Block");
           }
     
           System.out.println("Rest of all code");
    
    }
}