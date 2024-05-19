#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char typeOfStudy[40];
	double totalPerSem,amountPerSem, semester, CGPA, parentsYearlyIncome;
	
	
	cout<<"1. Diploma at Public University"<<endl;
	cout<<"2. Bachelor at Public University"<<endl;
	cout<<"3. Diploma at Private University"<<endl;
	cout<<"4. Bachelor at Private University"<<endl;
	cout<<"Enter your type of study: ";
	cin>>typeOfStudy;
	
	cout<<"What semester are you in: ";
	cin>>semester;
		
	if (semester < 2)
	{
		cout<<"You need to at least be in the second semester to apply!";
		return 0;
	}
	
	cout<<"What is your parents yearly income: ";
	cin>>parentsYearlyIncome;
	
	if (parentsYearlyIncome > 50000)
	{
		cout<<"Your parents yearly income must not be more then RM50000 to apply!";
		return 0;
	}
	
	cout<<"What is your CGPA: ";
	cin>>CGPA;
	
	if (strcmp(typeOfStudy, "1") == 0 && CGPA >= 3.3 ) 
	{
		strcpy(typeOfStudy, "Diploma at Public University");
		amountPerSem = 2000;
	}
	else if (strcmp(typeOfStudy, "2") == 0 && CGPA >= 3.0 )
	{
		strcpy(typeOfStudy, "Bachelor at Public University");
		amountPerSem = 3500;
	}
	else if (strcmp(typeOfStudy, "3") == 0 && CGPA >= 3.3 )
	{
		strcpy(typeOfStudy, "Diploma at Private University");
		amountPerSem = 3000;
	}
	else if (strcmp(typeOfStudy, "4") == 0 && CGPA >= 3.0 )
	{
		strcpy(typeOfStudy, "Bachelor at Private University");
		amountPerSem = 4500;
	}
	else
	{
		cout<<"You do not qualify for a scholarship from Yayasan Setia Bakti";
		return 0;
	}
	
	totalPerSem = amountPerSem * semester;
	
	cout<<"Congrats for "<<typeOfStudy<<" , you qualified for a scholarship from Yayasan Setia Bakti!"<<endl;
	cout<<"The amount you will receive per sem is RM"<<amountPerSem<<endl;
	cout<<"The total amount for the rest of you studies is RM"<<totalPerSem<<endl;
	
	return 0;
}
