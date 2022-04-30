import java.awt.*;    


 class AWTButton extends Frame {

    AWTButton(){
        Button b = new Button("Click Here");   
        b.setBounds(50,100,80,30);       
        add(b);    
        setSize(400,400);    
        setLayout(null);    
        setVisible(true);     

    }

}

public class D4_Framebutton_use_extends {    
public static void main (String[] args) {   
  
AWTButton f = new AWTButton();
}    
}    