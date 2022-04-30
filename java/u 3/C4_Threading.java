class ABC implements Runnable 
{
    public void run(){
        try{
        Thread.sleep(100);
        }catch(InterruptedException ie){
            ie.printStackTrace();
        }

     System.out.println("The state of thread t1 while it invoked the method join() on thread on thread t2 " + C4_Threading.t1.getState() );

     try{
         Thread.sleep(200);
     }catch(InterruptedException ie){
         ie.printStackTrace();
     }

    }

}

public class C4_Threading implements Runnable{

    public static Thread t1;
    public static C4_Threading obj;

    public static void main(String[] args){
        obj = new C4_Threading();
        t1 = new Thread(obj);

        System.out.println("The static of thread t1 after spawing t1 " +  t1.getState());

        t1.start();

        System.out.println("The state of thread t1 after  invorking the method start() on it " + t1. getState());
    }


    public void run(){
        ABC myobj = new ABC();
    
        Thread t2 = new Thread(myobj);
        
        System.out.println("The state of Thread t2 After spawing it " + t2.getState());

        t2.start();

        System.out.println("The state of thread t2  after calling the method start() on it " + t2.getState());

        try{
            Thread.sleep(200);
        }catch(InterruptedException ie){
            ie.printStackTrace();
        }

        System.out.println("The state at thread t2 after invorking the method sleep() an it " + t2.getState());

        try{
            t2.join();
        }catch(InterruptedException ie){
            ie.printStackTrace();
        }

       System.out.println("The state of thread t2 when  it has completed its execution " + t2.getState());
    
    }

}
/*
The static of thread t1 after spawing t1 NEW
The state of thread t1 after  invorking the method start() on it RUNNABLE
The state of Thread t2 After spawing it NEW
The state of thread t2  after calling the method start() on it RUNNABLE
The state of thread t1 while it invoked the method join() on thread on thread t2 TIMED_WAITING
The state at thread t2 after invorking the method sleep() an it TIMED_WAITING
The state of thread t2 when  it has completed its execution TERMINATED */