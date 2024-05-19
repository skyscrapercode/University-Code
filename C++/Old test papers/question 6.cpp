#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	double pricePerUnit, amountOfMask, amountOfMask2, total_masks, price2ply, price3ply;
	char typeOfMask[20];
	
	cout<<"What type of mask would you like to buy(2ply, 3ply or both): ";
	cin>>typeOfMask;
	
	if (strcmp(typeOfMask, "2ply" ) == 0)
	{
		cout<<"How many pieces of mask would you like to buy: ";
		cin>>amountOfMask;
		pricePerUnit = 0.20;
		total_masks = amountOfMask * pricePerUnit;
		strcpy(typeOfMask, "2 ply");
	} 
	else if (strcmp(typeOfMask, "3ply" ) == 0)
	{
		cout<<"How many pieces of mask would you like to buy: ";
		cin>>amountOfMask;
		pricePerUnit = 0.50;
		total_masks = amountOfMask * pricePerUnit;
		strcpy(typeOfMask, "3 ply");
	}
	else if(strcmp(typeOfMask, "both") == 0 )
	{
		cout<<"How many 2 ply masks would you like to buy: ";
		cin>>amountOfMask;
		cout<<"How many 3 ply masks would you like to buy: ";
		cin>>amountOfMask2;
		price2ply = 0.20;
		price3ply = 0.50;
		total_masks = (amountOfMask * price2ply) + (amountOfMask2 * price3ply);
		strcpy(typeOfMask, "2 ply and 3 ply");
	} 
	else
	{
		cout<<"Invalid Input!";
		return 0;
	}
	
	cout<<"You have decided to buy "<<typeOfMask<<endl;
	cout<<"The total price is RM"<<total_masks;
	return 0;
}
