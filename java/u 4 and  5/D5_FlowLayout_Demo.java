import java.awt.*;    
import java.awt.event.*;    
import javax.swing.*;    
    
 class Example extends JFrame{    
 JLabel b1,b2,b3,b4,b5;    
 Example(){

 FlowLayout layout = new FlowLayout();
 this.setLayout(new FlowLayout(FlowLayout.RIGHT));    
        
     b1=new JLabel("Label 1");    
     b2=new JLabel("Label 2");    
     b3=new JLabel("Label 3");    
     b4=new JLabel("Label 4");    
      b5=new JLabel("Label 5");    
  
    this.add(b1);
    this.add(b2); 
    this.add(b3); 
    this.add(b4); 
    this.add(b5);  
 }       
   
} 

class  D5_FlowLayout_Demo {
    
public static void main(String[] args) {    
   
    Example f  = new Example();
    f.setTitle("ExMPLE of layout ");
    f.setBounds(200,100,600,400);
    f.setVisible(true);

}    

}

