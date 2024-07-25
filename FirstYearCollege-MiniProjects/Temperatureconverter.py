#TEMPERATURE CONVERTER

# F to C for Fahrenheit to Celsius  
# C to F for Celsius to Fahrenheit
T = input("\n F to C for Fahrenheit to Celsius \n C to F for Celsius to Fahrenheit \n Please enter temperature you want to Convert: ")

if T.upper() == "F TO C": 
  temp = float(input (" Enter Number of Temperature: ")) # ENTER the number of fahrenheit
  f1 = temp-32
  F = f1 *5/9
  print ("\n The "+ str(int(temp)) + " Degree Fahrenheit in Celsius is " + str(float(round(F,2)))+" °C")
if T.upper() == "C TO F":
  temp = float(input (" Enter Number of Temperature: ")) # ENTER the number of celsius
  C = temp*9/5+32 
  print ("\n The "+ str(int(temp)) + " Degree Celsius to Fahrenheit is " + str(float(round(C,2)))+" °F")


print('\n The program is done press ENTER >>>\n')
