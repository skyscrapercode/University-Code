#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char category[10], responded, preferred[10];
	int numOfPeople, i = 0, rose, orchid, tulip;
	double pricePerPerson, totalPayment, govTax, serviceTax, totalTax;
	
			
	cout<<"How many people will go on this cruise: ";
	cin>>numOfPeople;
	
	while (i < numOfPeople )
	{
		
		
		cout<<"What cruise would you like to ride on?(Rose, Orchid or Tulip): ";
		cin>>category;
		
		if (strcmp(category, "Rose") == 0)
		{
			pricePerPerson = 500;
			rose++;
		}
		else if (strcmp(category, "Orchid") == 0)
		{
			pricePerPerson = 350;
			orchid++;
		}
		else if (strcmp(category, "Tulip") == 0)
		{
			pricePerPerson = 200;
			tulip++;
		}
		else
		{
			cout<<"Wrong Input";
			return 0;
		}
		
		totalPayment = totalPayment + pricePerPerson;
		i++;
		
		
	}
	
	if (totalPayment > 5000 )
	{
		totalPayment = totalPayment - (totalPayment * 10/100);
	}
	else if (totalPayment > 10000)
	{
		totalPayment = totalPayment - (totalPayment * 15/100);
	}
	
	if (rose > orchid && rose > tulip)
	{
		strcpy(preferred, "Rose");
	}
	else if (orchid > rose && orchid > tulip)
	{
		strcpy(preferred, "Orchid");
	}
	else if (tulip > orchid && tulip > rose)
	{
		strcpy(preferred, "Tulip");
	}
	
	govTax = totalPayment * 5/100;
	serviceTax = totalPayment * 6/100;
	totalTax = totalPayment + (govTax + serviceTax);
	
	cout<<"The total collection of MawarMerah Holiday Cruise is RM"<<totalPayment<<endl;
	cout<<"The bill after plus 5% gov tax and 6% service tax is RM"<<totalTax<<endl;
	cout<<"The total number of customers for Rose is "<<rose<<endl;
	cout<<"The total number of customers for Orchid is "<<orchid<<endl;
	cout<<"The total number of customers for Tulip is "<<tulip<<endl;
	cout<<"The most preferred cruise category is "<<preferred<<endl;
	
	
	
}
