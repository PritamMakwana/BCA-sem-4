
import java.io.*;

public class C16_OutputStream {

 public static void main(String[] args) {

 String data = "ram and laxman.";

 try {

    OutputStream out = new FileOutputStream ("D:\\note.txt"); 
    byte[]  datatype = data.getBytes();
    out.write(datatype);
    System.out.println("Data is written to the file");
    out.close();

 } catch (Exception e) {
    e.getStackTrace();
 }

}

}