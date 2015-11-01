import math,random;

running = True;

# Function to check if string can be converted to integer
def isInt(i):
    '''
    This function checks that 'i' can be converted to integer, by using try/except method,
        if value of 'i' can be converted to integer then True is returned, if not False is returned.

    Arguments: Function accepts any type of variable, in any format.

    Output: Function returns True/False, if conversion to integer has been sucessful/unsucessful.
    '''
    try:
        int(i);
        return True;
    except ValueError:
        return False;

while running:
    choice = raw_input("\nWhich tickable do you wanna see? ");

    if(not isInt(choice)):
        print("Please enter natural value");
    else:
        int_choice = abs(int(choice));
        # 1st step tickable
        if(int_choice == 1):
            print("\nPrinting simple message:\nHello World!!");
        # 2nd step tickable
        elif(int_choice == 2):
            print("\nThere's no tickable number 2");
        # 3rd step tickable
        elif(int_choice == 3):
            print("\nDefining different data types, and printing them out");

            num1 = 23
            print("Printing integer value stored in variable num1: " + str(num1));

            num2 = 23.5
            print("Printing float value stored in variable num2: " + str(num2));

            str1 = "Hello world";
            print("Printing string value stored in string str1: "+ str1);
        # 4th step
        elif(int_choice == 4):
                print("\n4th step is not a tickable");
        # 5th step
        elif(int_choice == 5):
            print("\nAssinging varable num to value of 5.2, then adding 7,\nthen multiplying it by 300, then dividing by 4, and then cubing it");
            num = 5.2;
            num += 7;
            num *= 300;
            num /= 4;
            num = num**3;
            print("Ans = "+str(num));
        # 6h step
        elif(int_choice == 6):
            print("\nManipulating strings");

            str1 = "This is a string that I will learn to manipulate";
            str2 = ", string manipulation is very useful.";

            # Combining strings
            string = str1 + str2;

            print("Combined string is: '" + string + "'.\nIt's length is " + str(len(string)) +" characaters."
                          +"\nCharacter at position 0 is "+string[0]
                          +"\nThe last character at position -1 is " + string[-1]
                          +"\nString of character between 3:7 is '" + string[3:7] +"'");
        # 7th step
        elif(int_choice == 7):
            print("\nThere's no tickable thing for step 7, but it's all about changing between diferent variable types");
        # 8th step
        elif(int_choice == 8):
            print("\nStep 8 doesn't have tickable thing, but it's about if statements");
        # 9th step
        elif(int_choice == 9):
            print("\nUsing raw_input function");

            inLoop = True;
            while inLoop:
                userInput = raw_input("\nPlease enter a string which is no more than 10 characters long (counting spaces)"
                                          +"\nenter 'q' to stop: ");
                if(userInput == 'q'):
                    break;
                elif(len(userInput)>10):
                    print(userInput + " is more than 10 characters, try again");
                else:
                    print(userInput + " is less than 10 character long. 'q' to stop");
        # 10th step
        elif(int_choice == 10):
            print("\nThere's no tickable for step 10. For loop is introduced");
        # 11th step
        elif(int_choice == 11):
            print("\nPrinting sum of first integers less than 1000 that are not divisible by 3"
                        +"\nI did not use the example code given");
                
            tmpSum = 0;
            for i in range(0,1000):
                if( i%3 != 0):
                    tmpSum += i;
            print("Sum is = " + str(tmpSum));
        # 12th step
        elif(int_choice == 12):
            print("\n12th step is not a tickable. Introduction of while loop");
        # 13th step
        elif(int_choice == 13):
            print("\nFinding value of N, for when sum of i**2 is > 20'000");

            tmpSum = 0;
            i = 0;
            limit = 20000;
            while(tmpSum <= limit):
                if(tmpSum + i**2 > limit):
                    break;
                else:
                    tmpSum += i**2;
                    i += 1;
            print("Value of N is " + str(i));
        # 14th step
        elif(int_choice == 14):
            print("\nChecking the sequence, starting at x0 = 1");

            kValue = int(raw_input("Enter value of K: "));
            steps = int(raw_input("Number of itterations: "));            

            kTmp = kValue;
            xTmp = 1;

            for i in range(1, steps+1):
                xTmp = 0.5 * ( xTmp + (kTmp)/xTmp);
                print("K = " + str(kTmp/xTmp) + ", sqrt(K) = "+ str(math.sqrt(kValue)) + "; itteration: " + str(i));

        # 15 step
        elif(int_choice == 15):
            print("\nSimple too high / too low game");
                
            lowerBound = input("Please enter lower bound: ");
            upperBound = input("Please enter upper bound: ");

            rangeN =  upperBound - lowerBound;

            if(rangeN <= 5):
                difficulty = "easy";
            elif(rangeN <= 20):
                difficulty = "normal";
            elif(rangeN <= 50):
                difficulty = "hard";
            elif(rangeN > 50):
                difficulty = "impossible";
            
            print("Can choose between " + str(rangeN) + " numbers. Difficulty = " + difficulty);

            chosenNum = random.randint(lowerBound,upperBound);

            tries = 1;
            
            gotItRight = False;
            while(not gotItRight):
                guess = input("I think the number is = ");

                if( (guess > upperBound) or (guess < lowerBound)):
                    print("Your guess isn't even the range you specified! [" +str(lowerBound) +","+str(upperBound)+"]");
                elif(guess > chosenNum):
                    print("Too high!");
                elif(guess < chosenNum):
                    print("Too low!");
                elif(guess == chosenNum):
                    print("You did it!! It took you " + str(tries) + " tries!");
                    break;
                tries += 1;
                
                
            
        
          
