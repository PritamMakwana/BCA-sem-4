class IIBDemo{
    //Instance Initialization Block
    {
        System.out.println("IIB block");
    }
    IIBDemo(){
        System.out.println("constructor call");
    }
}
class MIIBDemo{
    //multiple Instance Initialization Block
    {
        System.out.println("IIB block 1");
    }
    {
        System.out.println("IIB block 2");
    }
    MIIBDemo(){
        System.out.println("constructor call");
    }
    {
        System.out.println("IIB block 3");
    }
}




public class A16_IIB_used {
    public static  void main(String[] args){
        System.out.println("Instance Initialization Block");
        IIBDemo iibDemo = new IIBDemo();
        System.out.println("multiple Instance Initialization Block");
        MIIBDemo miibDemo = new MIIBDemo();

    }
}
