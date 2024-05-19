#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double weight, height;
	cout<<"Input your weight in kilograms: " ;
	cin>>weight;
	cout<<"The weight you entered is: " <<weight <<endl ;
	cout<<"Input your height in centimeters: ";
	cin>>height;
	double height2 = height / 100;
	double height3 = height2 * height2;
	double BMI = weight / height3;
	cout<<"Your BMI is " <<BMI;
	
	
}
