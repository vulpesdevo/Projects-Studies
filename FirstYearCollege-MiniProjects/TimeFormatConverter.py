#Converting 24 hour time to 12 hour time
#Example input for converting 24 hour time to 12 hour time
#Input number should be like this 00:00:00 AM/PM >>> Hour : Min : Sec
#Example: 13:38:21 PM
name = input(' Hello there! please input your name to proceed : ')
T= input("\n Please enter your time: ") #Input the time in 24 hour time format
t = T.upper()
def converttime(t) :
    if (t[9:]=="AM" and t[:2]<='12'):
        return t[:9]
    elif(t[9:]=="PM" and t[:2]<='12'):   
        return t[:9]
    else:
        return str(int(t[:2])-12) + t[2:9]

ConvTime = t[9:]
if ConvTime =="PM" and t[:2]>='18':
    print ("\n Hi " + name.title() +" your time in 12 hour time is:  "+ converttime(t)+ " PM in the Evening.") #evening
if ConvTime =="PM" and t[:2]<='18' and t[:2]>=12:
    print ("\n Hi " + name.title() +" your time in 12 hour time is:  "+ converttime(t)+ " PM in the Afternoon.") #Afternoon
if ConvTime =="AM" and t[:2] <="12":
    print ("\n Hi " + name.title() +" your time in 12 hour time is: "+ converttime(t)+ " AM in the Morning") #Morning
if ConvTime =="PM" and t[:2]<='12':
    print ("\n Hi " + name.title() +" your time is still the same\n Its  "+ converttime(t)+ " PM")  




print("\n The program is done press ENTER >>>\n")
