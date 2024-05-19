#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double score;
	char grade[3];
	
	cout<<"What is your score: ";
	cin>>score;
	
	if (score >= 90 && score <=100)
	{
		grade = "A+";
	}
	else if (score >= 80 && score < 90)
	{
		grade = 'A';
	}
	else if (score >= 75 && score < 80)
	{
		grade = "A-";
	}
	else if (score >= 70 && score < 75)
	{
		grade = "B+";
	}
	else if (score >= 65 && score < 70)
	{
		grade = 'B';
	}
	else if (score >= 60 && score < 65)
	{
		grade = "B-";
	}
	else if (score >= 55 && score < 60)
	{
		grade = "C+";
	}
	else if (score >= 50 && score < 55)
	{
		grade = 'C';
	}
	else if (score >= 47 && score < 50)
	{
		grade = "C-";
	}
	else if (score >= 44 && score < 47)
	{
		grade = "D+";
	}
	else if (score >= 40 && score < 44)
	{
		grade = 'D';
	}
	else if (score >= 30 && score < 40)
	{
		grade = 'E';
	}
	else if (score >= 0 && score < 29)
	{
		grade = 'F';
	}
	else
	{
		cout<<"Wrong input";
		return 0;
	}
	
	cout<<"Your grade is "<<grade;
	
	return 0;
}
