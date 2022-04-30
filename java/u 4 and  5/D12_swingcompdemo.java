import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

  public class D12_swingcompdemo
  {
	D12_swingcompdemo()
	  {
	 
		  JFrame f =new JFrame("swing comp example");
		  JButton b =new JButton("click here");
		  b.setBounds(10,10,100,40);
		  f.add(b);
		  
		  JLabel textlbl = new JLabel("This is label.");
		  textlbl.setBounds(10,50,100,40);
		  f.add(textlbl);
		  
		  JTextField txtbox = new JTextField(20);
		  txtbox.setBounds(10,80,100,40);
		  f.add(txtbox);
		  
		  JTextArea textarea = new JTextArea("This is textarea",5,20);
		  textarea.setBounds(10,130,100,40);
		  f.add(textarea);
		  
		  JPasswordField pwdfield = new JPasswordField(15);
		  //char[] pwdvalue = pwdfield.getpassword();
		  pwdfield.setBounds(10,200,100,40);
		  f.add(pwdfield);
		  
		  JCheckBox chkbox = new JCheckBox("show help",true);
		  chkbox.setBounds(10,240,100,40);
		  f.add(chkbox);
		  
		  ButtonGroup radiogroup = new ButtonGroup();
		  JRadioButton rb1 = new JRadioButton("easy",true);
		  JRadioButton rb2 = new JRadioButton("medium");
		  JRadioButton rb3 = new JRadioButton("hard");
		  radiogroup.add(rb1);
		  radiogroup.add(rb2);
		  radiogroup.add(rb3);
		  rb1.setBounds(10,270,100,40);
		  rb2.setBounds(10,300,100,40);
		  rb3.setBounds(10,330,100,40);
		  f.add(rb1);
		  f.add(rb2);
		  f.add(rb3);
		  
		  String[] itemd = {"Amreli","Rajkot","Surat","Baroda"};
		  JList<String> list = new JList<>(itemd);
		  list.setBounds(150,100,75,75);
		  f.add(list);
		  
		  String[] citystring = {"Mumbai","London","New York","Sydny","Tokyo"};
		  JComboBox cities = new JComboBox(citystring);
		  cities.setSelectedIndex(3);
		  cities.setBounds(150,200,100,50);
		  f.add(cities);
		  
		  
		f.setSize(300,400);
		f.setLayout(null);
		f.setVisible(true);
		//f.setDefaultcloseoperation(JFrame. EXIT_ON_CLOSE);
	  }
		
  
public static void main(String[] args)
{
	new D12_swingcompdemo();
}
  }