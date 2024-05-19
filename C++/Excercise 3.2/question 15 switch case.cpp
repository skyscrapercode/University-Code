#include <iostream>
#include <math.h>
#include <string.h>
using namespace std;

int main()
{
    int planets;
    double weight;
    
	cout<<"Enter your weight: ";
	cin>>weight;
	
	cout<<"(1 = mercury,2 = venus,3 = mars,4 = jupiter,5 = saturn,6 = uranus,7 = neptune,8 = pluto)\n";
    cout<<"Enter which number planet: ";
    cin>>planets;
    
    switch (planets)
    {
	case 1: cout<<weight * 0.37<<"KG\n";
		   break;
	case 2: cout<<weight * 0.88<<"KG\n";
		   break;
	case 3: cout<<weight * 0.38<<"KG\n";
		   break;
	case 4: cout<<weight * 2.64<<"KG\n";
		   break;
	case 5: cout<<weight * 1.15<<"KG\n";
		   break;
	case 6: cout<<weight * 1.15<<"KG\n";
		   break;
	case 7: cout<<weight * 1.12<<"KG\n";
		   break;
	case 8: cout<<weight * 0.04<<"KG\n";
		   break;
	default: cout<<"You can only choose the 1,";
		cout<<"2 ,3 ,4 ,5 ,6 ,7 and 8.\n";
    }
    
    cout<<"You choose"<<planets<<" and your weight on planet:" <<weight ;
    
    return 0;
}
