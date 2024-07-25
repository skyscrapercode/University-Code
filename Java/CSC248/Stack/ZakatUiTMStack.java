
/**
 * Write a description of class ZakatUiTMStack here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class ZakatUiTMStack
{
    public static void main (String args[])
    {
        Stack ZakatUiTM = new Stack();
        
        //Assume data already inputed lol
        
        //Question iv
        
        double totalAmount = 0;
        
        Stack sTemp = new Stack();
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.pop();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            sTemp.push(z);
            totalAmount += z.getAmount();
        }
        
        while (!sTemp.isEmpty())
        {
            ZakatUiTM.push(sTemp.pop());
        }
        
        System.out.println("The total amount of Zakat UiTM distribution in 2021 is RM" + totalAmount);
        
        //Question v
        int count = 0;
        Stack tempS = new Stack();
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.pop();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            tempS.push(z);
            
            count++;
        }
        
        while (!tempS.isEmpty())
        {
            ZakatUiTM.push(tempS.pop());
        }
        
        System.out.println("The number of Zakat UiTM recepient is " + count);
        
        //Question vi
        Stack TempS = new Stack();
        
        double lowestZakatAsnaf = 99999, highestZakatAsnaf = 0, lowestZakatPoor = 99999, highestZakatPoor = 0;
        int countAsnaf = 0, countPoor = 0;
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.pop();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            TempS.push(z);
            
            if (z.getCategory() == '1')
            {
                countAsnaf++;
                if (z.getAmount() > highestZakatAsnaf)
                    highestZakatAsnaf = z.getAmount();
                
                if (z.getAmount() < lowestZakatAsnaf)
                    lowestZakatAsnaf = z.getAmount();
            }
            else
            {
                countPoor++;
                
                if (z.getAmount() > highestZakatPoor)
                    highestZakatPoor = z.getAmount();
                
                if (z.getAmount() < lowestZakatPoor)
                    lowestZakatPoor = z.getAmount();
            }
        }
        
        while (!TempS.isEmpty())
        {
            ZakatUiTM.push(TempS.pop());
        }
        
        System.out.println("Number of people Asnaf: " + countAsnaf + " and number of people Poor is " + countPoor);
        System.out.println("The highest amount for Asnaf is RM" + highestZakatAsnaf + " and the lowest amount for Asnaf is RM" + lowestZakatAsnaf);
        System.out.println("The highest amount for Poor is RM" + highestZakatPoor + " and lowest amount for Poor is RM" + lowestZakatPoor);
        
    }
}
