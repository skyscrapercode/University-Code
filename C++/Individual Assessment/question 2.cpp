/*
Name			: SHEIKH ADAM BAJUNID BIN MOHD FAISAL
Sid				: 2023135385
Course			: CSC126 
Group			: 1A
Due Date		: 14 June 2023 5:00 pm
Question No		: 2
Program Description	: This program can calculate the final price for Bloom & Care while taking into account the fact the person may have a membership and choose different package plans
*/

#include <iostream>
#include <string.h>
using namespace std;

int main()
{
	double pricePerHour, discount, totalPrice, hours;
	char membershipStatus[10], packageType[10];
	
	cout<<"Please enter your membership status of Bloom & Care (M for Member, N for Non-member): ";
	cin>>membershipStatus;
	
	if (strcmp(membershipStatus, "M") == 0 || strcmp(membershipStatus, "m") == 0)
	{
		cout<<"There are 3 types of packages to choose from (G for Galaxy, S for Star and N for Normal): ";
		cin>>packageType;
		
		strcpy(membershipStatus, "Member");
		
		if (strcmp(packageType, "G") == 0 || strcmp(packageType, "g") == 0)
		{
			pricePerHour = 70;
			discount = 23;
			strcpy(packageType, "Galaxy");
		}
		else if (strcmp(packageType, "S") == 0 || strcmp(packageType, "s") == 0)
		{
			pricePerHour = 45;
			discount = 20;
			strcpy(packageType, "Star");
		}
		else if (strcmp(packageType, "N") == 0 || strcmp(packageType, "n") == 0)
		{
			pricePerHour = 30;
			discount = 15;
			strcpy(packageType, "Normal");
		}
		else
		{
			cout<<"Invalid type of package or package code";
			return 0;
		}
		
	}
	else if (strcmp(membershipStatus, "N") == 0 || strcmp(membershipStatus, "n") == 0)
	{
		cout<<"There are 3 types of packages to choose from (G for Galaxy, S for Star and N for Normal): ";
		cin>>packageType;
		
		strcpy(membershipStatus, "Non-member");
		
		if (strcmp(packageType, "G") == 0 || strcmp(packageType, "g") == 0)
		{
			pricePerHour = 78;
			discount = 18;
			strcpy(packageType, "Galaxy");
		}
		else if (strcmp(packageType, "S") == 0 || strcmp(packageType, "s") == 0)
		{
			pricePerHour = 55;
			discount = 15;
			strcpy(packageType, "Star");
		}
		else if (strcmp(packageType, "N") == 0 || strcmp(packageType, "n") == 0)
		{
			pricePerHour = 35;
			discount = 10;
			strcpy(packageType, "Normal");
		}
		else
		{
			cout<<"Invalid type of package or package code";
			return 0;
		}
		
	}
	else
	{
		cout<<"Invalid membership status";
		return 0;
	}
	
	cout<<"How many hours would you like to book for: ";
	cin>>hours;
	
	totalPrice = ( pricePerHour * hours ) - ((pricePerHour * hours) * discount/100 );
	
	cout<<"****Bloom & Care****"<<endl;
	cout<<"Membership Status: "<<membershipStatus<<endl;
	cout<<"Package Type: "<<packageType<<endl;
	cout<<"Price Per Hour: RM"<<pricePerHour<<endl;
	cout<<"Hours Booked: "<<hours<<endl;
	cout<<"Discount: "<<discount<<"%"<<endl;
	cout<<"Total Price: RM"<<totalPrice<<endl;
	
	return 0;
}

