import java.io.*;

class C9_reading_single_char{

public static void main(String[] args){

    try{

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        char c = (char) br.read();
        //reading a character
        System.out.println(c);
    }catch(Exception c){

    }

}

}
// abc                                              //input
// a