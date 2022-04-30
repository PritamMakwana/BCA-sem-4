using System;

class MyPreviousexp{
    private String[] mycompanys = new String[10];

    public String this[int index]{
        get{
            if(mycompanys[index]==null){
                return "null";
            }else{
                return mycompanys[index];
            }
        }

        set{
            if(index>0 || index <= 10){
                mycompanys[index] = value;
            }
        }
    }
}
class MyMainclass{
    public static void Main(){
        MyPreviousexp mp = new MyPreviousexp();
        mp[0] = "intel";
        mp[3] = "acer";
        mp[5] = "compoq";
       
       for(int i = 0; i<10 ;i++){
           Console.WriteLine(mp[i]);
       }
    }
}