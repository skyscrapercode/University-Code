#include <iostream>

using namespace std;

int main()
{
	double charge, weight, weightPrice, totalIncome, totalPrice;
	int destination, i = 0;
	char name[40], receiver[40], address[40];
	
	
	do
	{
		cout<<"What is the customer's name(-999 to exit): ";
		cin.getline(name, 40);
		cout<<"What is the name of receiver(-999 to exit): ";
		cin.getline(receiver, 40);
		cout<<"What is the address(-999 to exit): ";
		cin.getline(address, 40);
		cout<<"Where is your parcel going(N for North, S for South or E for East)(-999 to exit): ";
		cin>>destination;
		cin.ignore();
		cout<<"What is the weight of your parcel in KG(-999 to exit): ";
		cin>>weight;
		
		if (destination == 'N')
		{
			charge = 12.50;
		}
		else if (destination == 'S')
		{
			charge = 23.75;
		}
		else if (destination == 'E')
		{
			charge = 46.50;
		}
		
		
		if (weight <= 2)
		{
			weightPrice = (weight * 1);
		}
		else if (weight <= 5)
		{
			weightPrice = 2 + ((weight - 2) * 1.5);
		}
		else if (weight <= 10)
		{
			weightPrice = 2 + 4.5 + ((weight - 5) * 1.5);
		}
		else if (weight > 10 )
		{
			weightPrice = 2 + 4.5 + ((weight - 10) * 1.5);
		}
		
		totalPrice = charge + weightPrice;		
		totalIncome = totalIncome + totalPrice;
		
		cout<<"****City Courier Service Bill****"<<endl;
		cout<<"Name: "<<name<<endl;
		cout<<"Name of Receiver: "<<receiver<<endl;
		cout<<"Address of receiver: "<<address<<endl;
		cout<<"Destination: "<<destination<<endl;
		cout<<"The total charge is RM "<<totalPrice<<endl;
	
	}while (i < -999);
	
	cout<<"The total income for the company is RM"<<totalIncome;
	
	
	
}
