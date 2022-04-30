import java.io.*;

class C10_taking_string_input{
    public static void main(String[] args){
        try{
            String text;
            InputStreamReader isr = new InputStreamReader(System.in);

            BufferedReader br = new BufferedReader(isr);
            text = br.readLine();
            //readLine
            System.out.println(text);
        }catch(Exception e){

        }
    }
}

//Pritam   //input
//Pritam