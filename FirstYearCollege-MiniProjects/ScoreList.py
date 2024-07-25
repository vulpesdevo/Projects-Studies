import statistics # Module Statistic
# input the length of the score
S = int(input('How many score: ')) 
scorelist = []
#Input a list of scores
for i in range (S):
    score = int(input('Enter Score: '))
    scorelist.append(score)
# Statistical functions for  Median, Average and Standard Deviation.
    M= statistics.median(scorelist)
    avg = statistics.mean(scorelist)
    Stdev= statistics.pstdev(scorelist)

# print the Scorelist, Median, Average, Highest number, Lowest Number and Standard Deviation.
print ('\nScores: ', scorelist)
print('\nAverage: ' + str(float(round(avg,3))))#for average
print ('Median:'+ str(float(M))) #for median
print('Highest number: ' + str(max(scorelist)))#for highest number in the list
print('Lowest number: '+ str(min(scorelist)))#for lowest number in the list
print ('Standard Deviation: ' + str(float(round(Stdev,3)))) #round off standard deviation

# If the program is done press Enter
print('\nThe program is done press Enter >>>')
