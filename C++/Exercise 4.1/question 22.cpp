#include <iostream>
#include <string.h>
using namespace std;

int main()
{
	double catAge, price = 0, totalPrice, govTax;
	char name[20], catName[20], choice, serviceType[20], shampooCharge[10];
	
	do
	{
		cout<<"Welcome to Cats@Home!"<<endl;
		cout<<"What is your name: ";
		cin.getline(name, 20);
		cin.ignore();
		cout<<"What is your cat/kittens name: ";
		cin.getline(catName, 20);
		cin.ignore();
		cout<<"How old is your cat(in months): ";
		cin>>catAge;
		cin.ignore();
	
		cout<<"What type of service would you like(1 for Nail Trimming, 2 for Kitten Bath and Brush): ";
		cin.getline(serviceType, 20);
	
		if (catAge <= 5)
		{
			if (strcmp(serviceType, "1") == 0 )
			{
				
				price = 15;
				strcpy(serviceType, "Nail Trimming");
			}
			else if (strcmp(serviceType, "2") == 0 )
			{
				price = 50;
				cout<<"Do you want to add medicated shampoo for an additional price of RM 5(yes or no): ";
				cin>>shampooCharge;
				strcpy(serviceType, "Kitten Bath and Brush");
				if (strcmp(shampooCharge, "yes") == 0 )
				{
					price = price + 5;
				}
			}
		}
		else if (catAge > 5)
		{
			if (strcmp(serviceType, "1") == 0 )
			{
			price = 20;
			strcpy(serviceType, "Nail Trimming");
			}
			else if (strcmp(serviceType, "2") == 0 )
			{
				price = 60;
				cout<<"Do you want to add medicated shampoo for an additional price of RM 5(yes or no): ";
				cin>>shampooCharge;
				strcpy(serviceType, "Kitten Bath and Brush");
				if (strcmp(shampooCharge, "yes") == 0 )
				{
					price = price + 5;
				}
			}
		}
		else
		{
			cout<<"Wrong Input";
			return 0;
		}
	
		
		govTax = price * 6/100;
		totalPrice = price + govTax;
	
		cout<<"----------Cat@Home----------"<<endl;
		cout<<"Owner's name: "<<name<<endl;
		cout<<"Cat's name: "<<catName<<endl;
		cout<<"Service Type: "<<serviceType<<endl;
		cout<<"Fee: RM "<<price<<endl;
		cout<<"Tax: RM "<<govTax<<endl;
		cout<<"Total Fee: RM "<<totalPrice<<endl;
	
		cout<<"Do you want to continue? (Y for yes, N for no): ";
		cin>>choice;
	
	}while (choice == 'Y');

	
}
