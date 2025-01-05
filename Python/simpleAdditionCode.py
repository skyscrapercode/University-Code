# Simple Addition Calculator, I made for fun

def addition_calculator():
    print("Welcome to the Addition Calculator!")
    
    try:
        num1 = float(input("Enter the first number: "))
        num2 = float(input("Enter the second number: "))
        
        result = num1 + num2
        
        print(f"The result of {num1} + {num2} is: {result}")
    except ValueError:
        print("Please enter valid numbers!")

if __name__ == "__main__":
    addition_calculator()
