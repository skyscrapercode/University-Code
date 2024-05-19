
/**
 * Write a description of class PatientMain here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */

import javax.swing.JOptionPane;
public class PatientMain
{
    public static void main (String args[])
    {
        double discount;
        String ageLessThan18andFemale = "", illnessCancer = "", illnessDiabetic = "";
        boolean searching = false;
        
        char test = JOptionPane.showInputDialog(null, "Input a letter: ").charAt(0);
        JOptionPane.showMessageDialog(null, test);
        
        Patient[] patientData = new Patient[2];
        
        for (int i = 0; i < patientData.length; i++)
        {
            String name = JOptionPane.showInputDialog(null, "What is Patient " + (i + 1) + " name? ");
            
            String illness = JOptionPane.showInputDialog(null, "What is Patient " + (i + 1) + " illness? " );
            
            String gender = JOptionPane.showInputDialog(null, "What is Patient " + (i + 1) + " gender? " );
            
            int yearOfBirth = Integer.parseInt(JOptionPane.showInputDialog(null, "What is Patient " + (i + 1) + " year of birth? " ));
            
            double charge = Double.parseDouble(JOptionPane.showInputDialog(null, "What is Patient " + (i + 1) + " charge? " ));
            
            patientData[i] = new Patient(name, illness, yearOfBirth, gender, charge);
            
            
            if (( 2023 - patientData[i].getYearOfBirth()) < 18 && patientData[i].getGender().equalsIgnoreCase("female"))
            {
                ageLessThan18andFemale += "\n Name: " + patientData[i].getName() + " illness: " + patientData[i].getIllness(); 
            }
            
            if (patientData[i].isVeteran() == true)
            {
                JOptionPane.showMessageDialog(null, "You're entitled to veteran discount and get " + 50 + "%. The final price is RM" + (patientData[i].getCharge() * 50/100));
            }
            else 
            {
                JOptionPane.showMessageDialog(null, "The final price is RM" + patientData[i].getCharge());
            }
            
            
            
        }
        
        
        for (int i = 0; i < patientData.length; i++)
        {
            if(patientData[i].getIllness().equalsIgnoreCase("cancer"))
            {
                searching = true;
            }
            
            if (searching == true)
            {
                illnessCancer += "\nillness: " + patientData[i].getIllness() + " Name: " + patientData[i].getName();
                searching = false;
            }
        }
        
        for (int i = 0; i < patientData.length; i++)
        {
            if(patientData[i].getIllness().equalsIgnoreCase("diabetic"))
            {
                searching = true;
            }
            
            if (searching == true)
            {
                illnessDiabetic += "\nillness: " + patientData[i].getIllness() + " Name: " + patientData[i].getName();
                searching = false;
            }
        }
        
        JOptionPane.showMessageDialog(null, "The people less than 18 and is a Female: " + ageLessThan18andFemale);
        JOptionPane.showMessageDialog(null, "The people that are diabetic: " + illnessDiabetic);
        JOptionPane.showMessageDialog(null, "The people with cancer: " + illnessCancer);
        
    }
}
