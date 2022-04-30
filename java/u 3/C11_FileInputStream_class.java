import java.io.FileInputStream;

public class C11_FileInputStream_class {
    public static void main(String[] args){
        try{
             FileInputStream fin = new FileInputStream("D:\\note.txt");
             int i = fin.read();
             System.out.println((char) i);
             fin.close();
        }catch(Exception e){
            System.out.println(e);
        } 
    }
}
//j