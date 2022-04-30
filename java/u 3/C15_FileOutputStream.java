
import java.io.*;

public class C15_FileOutputStream {

 public static void main(String[] args) {
 try {
    FileOutputStream fout = new FileOutputStream ("D:\\note.txt"); 
    fout.write(65);
    System.out.println("success...");

 } catch (Exception e) {
    System.out.println(e);
 }

}

}