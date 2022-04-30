import java.awt.*;    
import java.awt.event.*;    
import javax.swing.*;  
 class BorderDemo extends JFrame   
{    
BorderDemo()  
{    
  JPanel pa = new JPanel();

  pa.setLayout(new BorderLayout());        
     
  pa.add(new JButton("welcome"),BorderLayout.NORTH);
  pa.add(new JButton("KSC"),BorderLayout.SOUTH);
  pa.add(new JButton("layout"),BorderLayout.EAST);
  pa.add(new JButton("Border"),BorderLayout.WEST);
  pa.add(new JButton("KSCPAC"),BorderLayout.CENTER);

  add(pa);
  setSize(300,300);
  setVisible(true);


}  
}
class D6_BorderLayout{
public static void main(String[] args) {    
   BorderDemo b = new BorderDemo();

}    
}    