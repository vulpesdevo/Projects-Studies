# Burger Customizer
# "YourBurger!,YourChoice!
# I put a input function to put the costumer's name to begin customizing
#These are the list of Burger Components
BurgerComponents = ['MEAT','FRUIT AND VEG','SPICES','CHEESE','SAUCES','BREAD','SALAD','BACON']
# These are the list of choices for every components
meats=[' no meat',' beef',' lamb',' pork',' chicken']
fruitandveg =[' no fruitsandveggies',' onion',' celery',' courgette',' red pepper',' fresh apples',' apricots',' mushroom']
spices = [' no spices'," 5spices",' ginger',' herbs',' currypaste', ' parsley', ' rosemary', ' chili flakes', ' garlic',' mint']
cheese=  [' no cheese',' cheddar',' stilton',' feta',' mozzarella']
sauce = [ ' no sauces', ' pesto',' tomato puree',' bbq',' hotsauce',' sweet chili',' marmalade',' chutney',' ketchup',' mayo']
bread = [' no bread',' wrap',' gluten free',' bao',' bun',' wholemeal',' sesame',' pitta',' bagutte',' brioche',' naan',' bagel']
salad = [' no salad',' pineapple',' pepper',' avocado',' tomato',' celery',' lettuce',' beetroot',' pickle',' cucumber',]
bacon = [' no bacon',' lean baked bacon',' bacon',' turkey bacon']

#user's name to proceed to customize
name = input('Hello there! Welcome to "YourBurger!,YourChoice!"'+'\nPlease input your name to show Burger Components list: ')
print('\nHi '+ name.title() + ' These are the list of components for your Burger :')
# Listing the Burger Components and for the list of type of each component,I used FOR LOOP
for Burgercomponents in BurgerComponents:
    print( Burgercomponents)
# Random choosing function to let user choose what Component they want to costumize first;
#WHILE LOOP
while True:
  if BurgerComponents:
    pickedComponent = input('Please enter Burger Component to be customize: ')
    if pickedComponent.upper() in BurgerComponents:  
       BurgerComponents.remove(pickedComponent.upper())
       if pickedComponent.upper() =='MEAT':
         print('\nMeats choices:')
         for meat in meats:
           print(meat)
         Meat = input('Choose your meat: ')
         print('\nRemaining Burger Components:')
         for BC in BurgerComponents:
          print(BC)
#for Fruit and Veggies
       if pickedComponent.upper()== 'FRUIT AND VEG':
          print('\nFruits and Veggies choices:')
          for FandV in fruitandveg:
            print(FandV)
          fAv = input('Choose your Fruit and Veg: ')
          print('\nRemaining Burger Components:')
          for BC in BurgerComponents:
             print(BC)
       if pickedComponent.upper()== 'SPICES':
          print('\nSpices Choices:')
          for Sp in spices:
            print(Sp) 
          Spice = input('Choose your spice: ') 
#If the user choose the "5 spices" option...
          if Spice.lower()=="5spices":
            print('\nSpices Choices:')
            spices.remove(' no spices')
            spices.remove(' 5spices')     
            for Sp in spices:
             print(Sp)
            print('You chose 5 spices option!!! \nPlease list you spices below\n')
         # For loop to list the 5 spices
            f = []
            for i in range(5):
             fivespice= input('Enter your choice: ')
             f.append(fivespice)
            print('\nRemaining Burger Components:')
            for BC in BurgerComponents:
              print(BC)
          else:
             print('\nRemaining Burger Components:')
             for BC in BurgerComponents:
               print(BC)
       if pickedComponent.upper()=='CHEESE':
         print('\nCheese Choices:')
         for C in cheese:
             print(C)
         Cheese = input('Choose your cheese: ')
         print('\nRemaining Burger Components:')
         for BC in BurgerComponents:
            print(BC)
#for Sauces
       if pickedComponent.upper()== 'SAUCES':
          print('\nSauces Choices: ')
          for Sauce in sauce:
            print(Sauce)
          Sauce = input('Choose your sauce: ')
          print('\nRemaining Burger Components:')
          for BC in BurgerComponents:
             print(BC)
# for Bread
       if pickedComponent.upper()== 'BREAD':
          print('\nBread Choices:')
          for Br in bread:
             print(Br)
          Bread = input('Choose your bread: ')
          print('\nRemaining Burger Components:')
          for BC in BurgerComponents:
            print(BC)
#for Salad
       if pickedComponent.upper()== 'SALAD':
          print('\nSalad Choices:')
          for S in salad:
            print(S)
          Salad = input('Choose your salad: ')
          print('\nRemaining Burger Components:')
          for BC in BurgerComponents:
           print(BC)
#Choices for Bacon
       if pickedComponent.upper()== 'BACON':
          print('\nBacon Choices:')
          for B in bacon:
            print(B)
          Bacon = input('Choose your bacon: ')
          print('\nRemaining Burger Components:')
          for BC in BurgerComponents:
             print(BC)
    else:
       print('Your choice is not on the list\n please choose again ') #if the user input unlisted component
       
  else:
      ans = input('There are no Components left, Enter to repeat your order..')
      break
 # These are the functions to repeat and list the orders 
 # Outputs
 # I used .title()
print ('\nHi '+ name.title() + ' This is your order:')
print('Meat: '+ Meat.title())
print('Fruit and Veg: '+ fAv.title())
if Spice.lower()=="5spices":
        print('Spices: ',f) # to show the list of 5 spices
if Spice.lower()!="5spices":
        print('Spices: '+Spice.title())
print('Cheese: '+ Cheese.title())
print('Sauce: '+ Sauce.title())
print('Bread: '+ Bread.title())
print('Salad: '+ Salad.title())
print('Bacon: '+ Bacon.title())

print ( '\nThank you!!!\thave a Great and YUMMY BURGER!')
