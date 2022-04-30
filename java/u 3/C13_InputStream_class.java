import java.io.FileInputStream;
import java.io.InputStream;

class C13_InputStream_class {

 public static void main(String[] args){
 
 byte[] array = new byte[100];

  try{

    InputStream input = new FileInputStream("D:\\note.txt");
    System.out.println("Available bytes in the File : " + input.available());
    input.read(array);
    System.out.println("Data read from the File : ");
    String data = new String(array);
    System.out.println(data);
    input.close();

  }catch(Exception e){
      e.getStackTrace();
  }


 }

}
// Available bytes in the File : 17
// Data read from the File : 
// Java
// Tutorials