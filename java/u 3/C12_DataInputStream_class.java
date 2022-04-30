import java.io.*;

public class C12_DataInputStream_class {
    public static void main(String[] args) throws IOException {
        InputStream input = new FileInputStream("D:\\note.txt");

        DataInputStream inst = new DataInputStream(input);
        int count = input.available();
        byte[] ary = new byte[count];
        inst.read(ary);
        
        for(byte bt : ary ){
            char k = (char) bt;
            System.out.print(k + "-");
        }
    }
}
//--a-v-a-
//-T-u-t-o-r-i-a-l-s-
//-