import java.io.*;

public class C14_DataOutputStream {

 public static void main(String[] args) throws IOException{

    FileOutputStream file = new FileOutputStream ("D:\\note.txt");

    DataOutputStream data = new DataOutputStream(file);

    data.writeInt(65);
    
    System.out.println("success...");
}

}