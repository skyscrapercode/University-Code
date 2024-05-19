
/**
 * Write a description of class ZakatUiTMQueue here.
 *
 * @author (your name)
 * @version (a version number or a date)
 */
public class ZakatUiTMQueue
{
    public static void main(String args[])
    {
        //Assume data is already stored
        
        Queue ZakatUiTM = new Queue();
        
        //Question i
        Queue qTemp = new Queue();
        
        double totalZakat = 0;
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.dequeue();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            qTemp.enqueue(z);
            
            totalZakat += z.getAmount();
            
        }
        
        while (!qTemp.isEmpty())
        {
            ZakatUiTM.enqueue(qTemp.dequeue());
        }
        
        System.out.println("The total amount of UiTM Zakat in the year 2021:" + totalZakat);
        
        //Question ii
        int count = 0;
        
        Queue tempQ = new Queue();
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.dequeue();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            tempQ.enqueue(z);
            count++;
        }
        
        while (!tempQ.isEmpty())
        {
            ZakatUiTM.enqueue(tempQ.dequeue());
        }
        
        System.out.println("The amount of zakat UiTM Recepient is " + count);
        
        
        
        //Question iii
        
        double highestAmountPoor = 0, lowestAmountPoor = 99999, highestAmountAsnaf = 0, lowestAmountAsnaf = 99999;
        int countAsnaf = 0, countPoor = 0; 
        Queue TempQ = new Queue();
        
        while (!ZakatUiTM.isEmpty())
        {
            Object obj = ZakatUiTM.dequeue();
            ZakatUiTMRecepient2021 z = (ZakatUiTMRecepient2021) obj;
            TempQ.enqueue(z);
            
            if (z.getCategory() == '1')
            {
                countAsnaf++;
                if (z.getAmount() > highestAmountAsnaf)
                {
                    highestAmountAsnaf = z.getAmount();
                }
                
                if (z.getAmount() < lowestAmountAsnaf )
                {
                    lowestAmountAsnaf = z.getAmount();
                }
            }
            else
            {
                countPoor++;
                if (z.getAmount() > highestAmountPoor)
                {
                    highestAmountPoor = z.getAmount();
                }
                
                if (z.getAmount() < lowestAmountPoor )
                {
                    lowestAmountPoor = z.getAmount();
                }
            }
        }
        
        while (!TempQ.isEmpty())
        {
            ZakatUiTM.enqueue(TempQ.dequeue());
        }
        
        System.out.println("The amount of people that receive zakat Asnaf is " + countAsnaf + "\nThe amount of people that receive zakat Poor is " + countPoor);
        System.out.println("The highest Zakat Asnaf amount is RM" +highestAmountAsnaf+" and the lowest amount Zakat Asnaf is RM" +lowestAmountAsnaf);
        System.out.println("The highest Zakat Poor amount is RM" +highestAmountPoor+" and the lowest amount Zakat Poor is RM" + lowestAmountPoor);
    }
}
