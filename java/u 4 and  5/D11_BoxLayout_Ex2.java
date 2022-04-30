import java.awt.*;    
import javax.swing.*;   

public class D11_BoxLayout_Ex2 extends Frame{
    Button buttons[];
    
    public D11_BoxLayout_Ex2(){
        buttons = new Button[5];
        setComponentOrientation(ComponentOrientation.RIGHT_TO_LEFT);

        for( int i = 0 ; i<5 ; i++){
        buttons[i] = new Button("button "+(i+1));  
            add(buttons[i]);
    }
            setLayout(new BoxLayout(this,BoxLayout.LINE_AXIS));
            setSize(400,400);
            setVisible(true);
        }
      
        public static void main(String[] args){
            D11_BoxLayout_Ex2 b = new D11_BoxLayout_Ex2();
        }

    }
