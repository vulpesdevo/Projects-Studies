print (' Enter bill amount (pesos):')
billAmount = input()
billAmount = float(billAmount)
print ('Enter amount tendered (pesos):')
amountTendered = input()
amountTendered = float(amountTendered)
amount = float(amountTendered)
amount = float(billAmount)
amount = float(amount)

if amount <0:
  print('Amount entered not allowed!' + ', Please enter amount again')
if amountTendered < billAmount:
  print('Tendered amount is less than bill amount!'+', please enter new amount')
elif amount >=0:
 print('The change is:')
 total=amountTendered - billAmount
 input(amountTendered - billAmount)
 
 
 print('QTY\t'+'Denomination\n'+'---\t--------------')
 
 for1000pesos = total//1000
 if for1000pesos>=1:
  print(str(int(for1000pesos))+'\t1000 peso note/s')
  total = total%1000.00

 for500pesos = total//500
 if for500pesos>=1:
  print(str(int(for500pesos))+'\t500 peso note/s')
  total = total%500.00

 for200pesos = total//200
 if for200pesos>=1:
  print(str(int(for200pesos))+'\t200 peso note/s')
  total = total%200.00

 for100pesos = total//100
 if for100pesos>=1:
  print(str(int(for100pesos))+'\t100 peso note/s')
  total = total%100.00

 for50pesos = total//50
 if for50pesos>=1:
  print(str(int(for50pesos))+'\t50 peso note/s')
  total = total%50.00

 for20pesos = total//20
 if for20pesos>=1:
  print(str(int(for20pesos))+'\t20 peso note/s')
  total = total%20.00

 for10pesos = total//10
 if for10pesos>=1:
  print(str(int(for10pesos))+'\t10 peso coin/s')
  total = total%10.00

 for5pesos = total//5
 if for5pesos>=1:
  print(str(int(for5pesos))+'\t5 peso coin/s')
  total = total%5.00

 for2pesos = total//2
 if for2pesos>=1:
  print(str(int(for2pesos))+'\t2 peso coin/s')
  total = total%2.00

 for1pesos = total//1
 if for1pesos>=1:
  print(str(int(for1pesos))+'\t1 peso coin/s')
  total = total%1.0

 for50cents = total//0.50
 if for50cents>=1:
  print(str(int(for50cents))+'\t50 cent/s')
  total = total%0.50

 for25cents = total//0.25
 if for25cents>=1:
  print(str(int(for25cents))+'\t25 cent/s')
  total = total%0.25

 for10cents = total//0.10
 if for10cents>=1:
  print(str(int(for10cents))+'\t10 cent/s')
  total = total%.10
 
 for5cents = total//0.05
 if for5cents>=1:
  print(str(int(for5cents))+'\t5 cent/s')
  total = total%0.05

 for1cent = total//0.01
 if for1cent>=1:
  print(str(int(for1cent))+'\t1 cent/s')
  
 
else:
  print('No Change' )
