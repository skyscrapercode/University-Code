#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	String name, flightNum, seatNum;
	int ticketType;
	char ticketCategory;
	
	cout<<"FLIGHT RESERVATION MANAGEMENT SYSTEM";
	cout<<"------------------------------------";
	cout<<"FLIGHT N0.  ORIGIN - DESTINATION              BOARD. DATE  BOARD. TIME  PRICE(RM)";
	cout<<"----------  -------------------------------   -----------  -----------  ---------";
	cout<<"  MH001     Kuala Lumpur - Kuala Terengganu    13/2/2016        11:35   [E] 200.00 / [B]  400.00";
	cout<<"  MH002     Kuala Terengganu - Kuala Lumpur    16/2/2016        13:45   [E] 200.00 / [B]  400.00";
	cout<<"  MH003     Kuala Lumpur - Kota Kinabalu       15/2/2016         6:00   [E] 600.00 / [B] 1200.00";
	cout<<"  MH004     Kota Kinabalu - Kuala Lumpur       20/2/2016        18:00   [E] 600.00 / [B] 1200.00";
	cout<<"  MH005     Kuala Lumpur - Kuching             20/3/2016        14:00   [E] 450.00 / [B]  900.00";
	cout<<"  MH006     Kuching - Kuala Lumpur              3/4/2016        12:00   [E] 450.00 / [B]  900.00";
	
	
	
	
	cout<<"Name:";
	cin>>name;
	
	cout<<"Flight number:"
	cin>>flightNum;
	
	cout<<"Type (E-Economy/B-Business):"
	cin>>ticketCategory;
	
	if (strcmp(ticketCategory, "B"))
	{
		cout<<"Choose seat number(A1/A2/A3/A/B1/B2/B3/B4/C1/C2/C3/C4/D1/D2/D3/D4): "
		cin>>seatNum;
	}
	else if (strcmp(ticketCatrgory, "E"))
	{
		seatNum = "B2"
	}
	else
	{
		cout<<"Wrong Input! Please try again";
		return 0;
	}
	
	cout<<"[1] One way trip / [2] Return trip :";
	cin>>ticketType;
	
	cout<<"[I] Infant / [A] Adult / [S] Senior / [D] Disable: "
	cin>>
	
	if (ticketType == 1)
	{
		if (strcmp(flightNum, "MH001"))
		{
			
		}
		else if (strcmp(flightNum, "MH003"))
		{
			
		}
		else if (strcmp(flightNum, "MH005"))
		{
			
		}
	}
	else if (ticketType == 2)
	{
		
	}
	else 
	{
		cout<<"Wrong Input! Please try again";
		return 0;
	}
	
		
}


