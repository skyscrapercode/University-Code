#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	int hours = 0, highly = 0, satisfactory = 0, overpaid = 0, totalHours,  lowestHours, highestHours;
	char name[40], rating[40], highestHoursName[40], lowestHoursName[40], choice;
	
	cout<<"What is your name: ";
	cin.getline(name, 40);
		
	cout<<"How many hours did you work this week: ";
	cin>>hours;
	
	lowestHours = hours;
	highestHours = hours;
	
	while( choice != 'N' ) 
	{
		cout<<"Do you want to continue(Y for yes, N for no): ";
		cin>>choice;
		
		if (choice == 'N')
		{
			break;
		}
		
		cout<<"What is your name: ";
		cin.ignore();
		cin.getline(name, 40);
		cout<<"How many hours did you work this week: ";
		cin>>hours;
 
		
		if (hours > 55)
		{
			strcpy(rating, "HIGHLY PRODUCTIVE");
			highly++;
		}
		else if (hours >= 35 && hours <= 55)
		{
			strcpy(rating, "SATISFACTORY");
			satisfactory++;
		}
		else if (hours < 35 )
		{
			strcpy(rating, "OVERPAID");
			overpaid++;
		}
		else
		{
			cout<<"Wrong Input";
			return 0;	
		}
		
		if (hours < lowestHours )
		{
			lowestHours = hours;
			strcpy(highestHoursName, name);
		}
		
		if (hours > highestHours)
		{
			highestHours = hours;
			strcpy(lowestHoursName, name);
		}
		
	totalHours = totalHours + hours;
		
	}
		
		cout<<"The number of employee that are highly productive is "<<highly<<endl;
		cout<<"The number of employee that are satisfactory is "<<satisfactory<<endl;
		cout<<"The number of employee that are overpaid is "<<overpaid<<endl;
		cout<<"The name of the employee with the highest number of hours worked is "<<highestHoursName<<" with "<<highestHours<<" hours"<<endl;
		cout<<"The name of the employee with the lowest number of hours worked is "<<lowestHoursName<<" with "<<lowestHours<<" hours"<<endl;
		cout<<"The average hours worked is "<<totalHours / (highly + satisfactory + overpaid);
	
	
}
