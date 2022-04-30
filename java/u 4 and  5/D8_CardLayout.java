import java.awt.*;    
import javax.swing.*;   
import java.awt.event.*;    
  
 class CardLayout_demo extends Frame implements  ActionListener  
{    
  
CardLayout card = new CardLayout(20,20);   
  
// constructor of the class  
CardLayout_demo()  
{    
  
setLayout(card);    
Button btn1,btn2,btn3;

btn1 = new Button("Apple");    
btn2 = new Button("Boy");    
btn3 = new Button("Cat");    
  
add(btn1,"card1"); // first card is the button btn1  
add(btn2,"card2"); // first card is the button btn2  
add(btn3,"card3");  // first card is the button btn3  
            
btn1.addActionListener(this);    
btn2.addActionListener(this);    
btn3.addActionListener(this);   
}    
public void actionPerformed(ActionEvent e)   
{    
card.next(this);    
}    
  
}
class D8_CardLayout {
public static void main(String args[])   
{     
CardLayout_demo crdl = new CardLayout_demo();  
crdl.setTitle("cardLayout in ava Example"); 
crdl.setSize(220, 150);    
crdl.setVisible(true);  
crdl.setResizable(false);
}    
}    