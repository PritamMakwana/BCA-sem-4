import java.awt.*;    
import javax.swing.*;   

public class D10_BoxLayout_Ex1 extends Frame{
    Button buttons[];
    
    public D10_BoxLayout_Ex1(){
        buttons = new Button[5];
        for( int i = 0 ; i<5 ; i++){
        buttons[i] = new Button("button "+(i+1));  
            add(buttons[i]);
    }
            setLayout(new BoxLayout(this,BoxLayout.Y_AXIS));
            setSize(400,400);
            setVisible(true);
        }
      
        public static void main(String[] args){
            D10_BoxLayout_Ex1 b = new D10_BoxLayout_Ex1();
        }

    }
