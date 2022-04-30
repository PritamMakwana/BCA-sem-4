class MultiThreadingRunnableDemo implements Runnable{

    public void run(){
        try{
            System.out.println("Thread" + Thread.currentThread().getId());
        }
        catch(Exception e){
            System.out.println("Exception caught");
        }
    }
    }
    
    public class C6_MultiThreading_Runnable{
        public static void main(String[] args){
            int n = 8 ;
            for (int i = 0 ; i <8 ; i++){
                Thread object = new Thread(new MultiThreadingRunnableDemo());
                object.start();
            }
        }
    }
    // Thread8
    // Thread11
    // Thread10
    // Thread9
    // Thread14
    // Thread13
    // Thread12
    // Thread15