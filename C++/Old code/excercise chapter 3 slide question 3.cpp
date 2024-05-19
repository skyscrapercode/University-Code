#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char cityName[20], state[20]; // do not declare it as string, we either won't or haven't learned it yet in this first sem
	cout<<"Enter your city's name: ";
	cin.getline(cityName, 20);
	
	if (strcmp(cityName, "Jengka") == 0)
	{
		strcpy(state, "Pahang");
	}
	else if (strcmp(cityName, "Sepanggar") == 0)
	{
		strcpy(state, "Sabah");
	}
	else if (strcmp(cityName, "Samarahan")== 0)
	{
		strcpy(state, "Sarawak");
	}
	else if (strcmp(cityName, "Shah Alam") == 0)
	{
		strcpy(state, "Selangor");
	}
	else if (strcmp(cityName, "Arau") == 0)
	{
		strcpy(state, "Perlis");
	}
	else if (strcmp(cityName, "Segamat") == 0)
	{
		strcpy(state, "Johor");
	}
	else if (strcmp(cityName, "Kuala Pilah") == 0)
	{
		strcpy(state, "Negeri Sembilan");
	}
	else if (strcmp(cityName, "Machang") == 0)
	{
		strcpy(state, "Kelantan");
	}
	else if (strcmp(cityName, "Dungun") == 0)
	{
		strcpy(state, "Terengganu");
	}
	else if (strcmp(cityName, "Bukit Mertajam") == 0)
	{
		strcpy(state, "Pulau Pinang");
	}
	else if (strcmp(cityName, "Merbok") == 0)
	{
		strcpy(state, "Kedah");
	}
	else if (strcmp(cityName, "Alor Gajah") == 0)
	{
		strcpy(state, "Melaka");
	}
	else if (strcmp(cityName, "Puncak Alam") == 0)
	{
		strcpy(state, "Selangor");
	}
	else
	{
		cout<<"You entered the wrong input!!!";
		return 0;
	}
	
	cout<<"Your city is "<<cityName<<endl;
	cout<<"Your state is "<<state;
	return 0;
	
}
