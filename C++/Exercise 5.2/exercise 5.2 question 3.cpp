#include <iostream>
#include <math.h>
#include <string.h>

double calCircleArea();
double calRectangularArea();
double calCirclePerimeter();
double calRectanglePerimeter();
double calSphereVol();
double calBoxVol();

using namespace std;

int main()
{
	char choice[5];
	
	cout<<"Enter CA to calculate the area of a circle\n";
	cout<<"Enter RA to calculate the area of a rectangle\n";
	cout<<"Enter CP to calculate the perimeter of a circle\n";
	cout<<"Enter RP to calculate the perimeter of a rectangle\n";
	cout<<"Enter SV to calculate the volume of a sphere\n";
	cout<<"Enter BV to calculate the volume of a box\n";
	cout<<"Enter your choice: ";
	cin.getline(choice, 4);
	
	if (strcmp(choice, "CA") == 0)
	{
		calCircleArea();
	}
	else if (strcmp(choice, "RA") == 0)
	{
		calRectangularArea();
	}
	else if (strcmp(choice, "CP") == 0)
	{
		calCirclePerimeter();
	}
	else if (strcmp(choice, "RP") == 0)
	{
		calRectanglePerimeter();
	}
	else if (strcmp(choice, "SV") == 0)
	{
		calSphereVol();
	}
	else if (strcmp(choice, "BV") == 0)
	{
		calBoxVol();
	}
	return 0;
}

double calCircleArea()
{
	double RA, r;
	cout<<"Enter radius: ";
	cin>>r;
	RA = 3.142 * pow(r, 2);
	cout<<"The Circle Area is "<<RA;
}

double calRectangularArea()
{
	double length, width, area;
	cout<<"Enter length and width: ";
	cin>>length>>width;
	area = length * width;
	cout<<"The Area of the rectangle is "<<area;
}

double calCirclePerimeter()
{
	double r, perimeter;
	cout<<"Enter radius: ";
	cin>>r;
	perimeter = 2 * 3.142 * r;
	cout<<"The Perimeter of a Circle is "<<perimeter;
}

double calRectanglePerimeter()
{
	double length, width, perimeter;
	cout<<"Enter length and width: ";
	cin>>length>>width;
	perimeter = (length * 2) + (width * 2);
	cout<<"The perimeter of a rectangle is "<<perimeter;
}

double calSphereVol()
{
	double r, volume;
	cout<<"Enter radius: ";
	cin>>r;
	volume = 4/3 * 3.142 * r;
	cout<<"The Volume of Sphere is "<<volume;
}

double calBoxVol()
{
	double length, width, height, volume;
	cout<<"What is the length, width and height: ";
	cin>>length>>width>>height;
	volume = length * width * height;
	cout<<"the Volume of the Box is "<<volume;
}
