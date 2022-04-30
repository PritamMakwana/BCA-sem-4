class MyThread1 extends Thread{

    public void run(){
        System.out.println("Non - Daemon thread");
    }

}

class C8_Daemon_Thread{

    public static void main(String[] args){
        MyThread1 mt = new MyThread1();

      System.out.println("Before using setDaemon() method : ");
      System.out.println("IS " + mt.getName() + " a Daemon THread : " + mt.isDaemon() );
      
      mt.setDaemon(true);
     
      System.out.println("After using setDaemon() method : ");
      System.out.println("IS " + mt.getName() + " a Daemon THread : " + mt.isDaemon() );

    }

}
// Before using setDaemon() method : 
// IS Thread-0 a Daemon THread : false
// After using setDaemon() method : 
// IS Thread-0 a Daemon THread : true