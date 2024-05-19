#include <iostream>

using namespace std;

double average(double, double, double);
double gradePoint(double);


int main()
{
	double s1, s2, s3, avg, point;
	cout<<"Enter 3 scores: ";
	cin>>s1>>s2>>s3;
	
	avg = average(s1,s2,s3);
	point = gradePoint(avg);
	
}

double average(double s1, double s2, double s3)
{
	double avg;
	avg = (s1 + s2 + s3)/ 3;
	cout<<"The average score is "<<avg<<endl;
	return avg;
}

double gradePoint(double avg)
{
	double point;
	if (avg >= 81 && avg <= 100)
	{
		point = 4.00;
	}
	else if (avg >= 71 && avg < 81)
	{
		point = 3.00;
	}
	else if (avg >= 51 && avg < 71)
	{
		point = 2.00;
	}
	else if (avg >= 31 && avg < 51)
	{
		point = 1.00;
	}
	else if (avg >= 0 && avg < 31)
	{
		point = 0.00;
	}
	else
	{
		cout<<"Out of Range (0 - 100)!!!!";
		return 0;
	}
	cout<<"The grade point is "<<point<<endl;
	return point;
}
