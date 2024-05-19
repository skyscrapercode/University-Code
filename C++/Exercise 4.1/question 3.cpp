#include <iostream>

using namespace std;

int main()
{
	int years, leapYear, year = 1920, day, total_days = 0;
	while (year <= 2020 )
	{
		if(year % 4 == 0)
		{
			day = 366;
		}
		else
		{
			day = 365;
		}
		cout<<"The year is "<<year<<endl;
		year++;
		cout<<"There are "<<day<<" days"<<endl;
		total_days = total_days + day;
	}
	cout<<"The total amount of days between 1920 to 2020 is "<<total_days<<endl;
}
