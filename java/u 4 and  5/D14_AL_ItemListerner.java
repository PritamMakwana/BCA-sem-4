
import java.awt.*;
import java.awt.event.*;
public class D14_AL_ItemListerner implements ItemListener{
    Checkbox checkbox1,checkbox2;
    Label label;

    D14_AL_ItemListerner(){
        Frame f  = new Frame("CheckBox Example");

        label = new Label();
        label.setAlignment(Label.CENTER);
        label.setSize(400,100);

        checkbox1 = new Checkbox("C++");
        checkbox1.setBounds(100,100,50,50);
        checkbox2 = new Checkbox("Java");
        checkbox2.setBounds(100,150,50,50);
         
        f.add(checkbox1);
        f.add(checkbox2);
        f.add(label);

        checkbox1.addItemListener(this);
        checkbox2.addItemListener(this);

        f.setSize(400,400);
        f.setLayout(null);
        f.setVisible(true);


    }

    public void itemStateChanged(ItemEvent e){
        if(e.getSource()==checkbox1)
        label.setText("C++ CheckBox : " + (e.getStateChange()==1?"checked":"unchecked"));
        if(e.getSource()==checkbox2)
        label.setText("Java CheckBox : " + (e.getStateChange()==1?"checked":"unchecked"));
    }

    public static void main(String[] args){
        new D14_AL_ItemListerner();
    }

}

