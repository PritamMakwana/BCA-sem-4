class MultiThreadingExtendingDemo extends Thread{

public void run(){
    try{
        System.out.println("Thread" + Thread.currentThread().getId());
    }
    catch(Exception e){
        System.out.println("Exception caught");
    }
}
}

public class C5_MultiThreading_extending{
    public static void main(String[] args){
        int n = 8 ;
        for (int i = 0 ; i <8 ; i++){
            MultiThreadingExtendingDemo object = new MultiThreadingExtendingDemo();
            object.start();
        }
    }
}

// Thread8
// Thread11
// Thread14
// Thread10
// Thread9
// Thread15
// Thread13
// Thread12