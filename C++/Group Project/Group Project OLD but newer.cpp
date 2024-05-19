// ideas: ability to choose whats on burger/pizza and customize price accordingly 


#include <iostream>
#include <iomanip>
#include <string.h>

int displayMenu(); //Function Prototype to display the menu 
int paymentMethod(double, double&, double&); //Function prototype to ask and receive payment
void orderReceipt(double, double, double, int, int, int, int, double, double, int); //Function Prototype to display the receipt at the end

using namespace std;

int main() 
{
	int burgerQuantity = 0, pizzaQuantity = 0, icecreamQuantity = 0, sandwichQuantity = 0, people, choice;
    double burgerTotal = 0, pizzaTotal = 0, icecreamTotal = 0, sandwichTotal = 0, paymentAmount = 0, change = 0, totalPrice = 0, govTax = 0, totalPriceWithTax = 0, burger, pizza, icecream, sandwich;
    cout<<"How many people would like to order: ";
    cin>>people;

    for (int i = 0; i < people; i++) 
	{
        int itemCode = displayMenu();
        
        switch (itemCode) 
		{
            case 1: burger = 34 /* burger() */ ; burgerTotal += burger; burgerQuantity++; break;
            case 2: pizza = 34 /* pizza() */ ; pizzaTotal += pizza; pizzaQuantity++; break;
            case 3: icecream = 34/* iceCream() */ ; icecreamTotal += icecream; icecreamQuantity++; break;
            case 4: sandwich = 34/* sandwich() */ ; sandwichTotal += sandwich; sandwichQuantity++; break;
        }
    }
    
    totalPrice = burgerTotal + pizzaTotal + icecreamTotal + sandwichTotal;
    govTax = totalPrice * 6/100;
    totalPriceWithTax = totalPrice + govTax;
    
    
    choice = paymentMethod(totalPriceWithTax, paymentAmount, change);
    orderReceipt(totalPrice, govTax, totalPriceWithTax, burgerQuantity, pizzaQuantity, icecreamQuantity, sandwichQuantity, paymentAmount, change, choice);
    
	
}

int displayMenu() // This contains the entire menu of our food ordering system
{
	int itemCode;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<setw(32)<<"RESTAURANT MENU"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"| Item Code |        Item Name       |   Price (RM)   |"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"|     1     | Pizza                  |     23.40      |"<<endl;
    cout<<"|     2     | Burger                 |     30.50      |"<<endl;
    cout<<"|     3     | Ice Cream              |     8.94       |"<<endl;
    cout<<"|     4     | Sandwich               |     25.20      |"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    
    do
    {
    	cout<<"Please enter item code to order: ";
    	cin>>itemCode;
    
    	if (itemCode < 0 || itemCode > 4)
    	{
    		cout<<"Incorrect item code. Please try again."<<endl;
		}
    }while (itemCode < 0 || itemCode > 4);
	
	return itemCode;
}

int paymentMethod(double totalPriceWithTax, double &paymentAmount, double &change)
{
	int choice;
	cout<<"Total Cost: RM"<<totalPriceWithTax<<endl;
	cout<<"Select a payment method: "<<endl;
	cout<<"1. Cash"<<endl;
	cout<<"2. Credit/Debit Card"<<endl;
	cout<<"3. E-Wallet"<<endl;
	cout<<"4. FPX"<<endl;
	cout<<"Enter your choice (1-4): ";
	cin>>choice;
	
	while (choice < 1 || choice > 4)
	{
		cout<<"Invalid choice. Please enter a valid choice (1-4): ";
        cin>>choice;
	}
	
			
	cout<<"Enter the payment amount: RM";
	cin>>paymentAmount;	
		
	while (paymentAmount < totalPriceWithTax) 
	{
       	cout<<"Insufficient payment. Please enter a sufficient amount: RM";
    	cin>>paymentAmount;
    }
		
	change = paymentAmount - totalPriceWithTax;
	
	return choice;
}

void orderReceipt(double totalPrice, double govTax, double totalPriceWithTax, int burgerQuantity, int pizzaQuantity, int icecreamQuantity, int sandwichQuantity, double paymentAmount, double change, int choice)
{
	char method[20];
	
	switch (choice)
	{
		case 1: strcpy(method, "Cash"); break;
		case 2: strcpy(method, "Credit/Debit Card"); break;
		case 3: strcpy(method, "E-Wallet"); break;
		case 4: strcpy(method, "FPX"); break;
	}
	
	cout<<"*****ORDER RECEIPT*****"<<endl;
	cout<<setw(15)<<"Item"<<setw(10)<<"Quantity"<<endl;
    cout<<setw(15)<<"Burger"<<setw(10)<<burgerQuantity<<endl;
    cout<<setw(15)<<"Pizza"<<setw(10)<<pizzaQuantity<<endl;
    cout<<setw(15)<<"Ice Cream"<<setw(10)<<icecreamQuantity<<endl;
    cout<<setw(15)<<"Sandwich"<<setw(10)<<sandwichQuantity<<endl;
    cout<<setw(15)<<"Subtotal: RM"<<totalPrice<<endl;
    cout<<setw(15)<<"6% Service Tax: RM"<<govTax<<endl;
    cout<<setw(15)<<"Total Price: RM"<<totalPriceWithTax<<endl;
    cout<<setw(15)<<"Payment Method: "<<method<<endl;
    cout<<setw(15)<<"Payment Amount: RM"<<paymentAmount<<endl;;
    cout<<setw(15)<<"Change: RM"<<change<<endl;
    
}
