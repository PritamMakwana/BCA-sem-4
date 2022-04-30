class MyThread extends Thread{
    
    public void run(){
        System.out.println("user Thread Daemon are not");
    }
}

class C7_Check_Thread_Daemon{
    public static void main(String[] args){
        MyThread mt = new MyThread();
        mt.start();
        System.out.println("IS " + mt.getName() + " a Daemon Thread " + mt.isDaemon());
        System.out.println("IS " + Thread.currentThread().getName() + " a Daemon Thread " + Thread.currentThread().isDaemon());
    }
}
/*
user Thread Daemon are not
IS Thread-0 a Daemon Thread false
IS main a Daemon Thread false
*/