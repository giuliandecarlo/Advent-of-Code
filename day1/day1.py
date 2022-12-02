
#---------[PART 1]---------

f=open('day1.txt')
list_elf=[]
sumCal=0

while True:
    line=f.readline()
    if not line:
        break
    if (line=="\n"):
        list_elf.append(sumCal)
        sumCal=0
    else:
        sumCal=sumCal+int(line)

maxL=max(list_elf)
print("Max: "+str(maxL))

#---------[PART 2]---------

list_elf.sort(reverse=True)
sum=0
for elf in list_elf[:3]:
    sum=sum+elf
print("Sum: "+str(sum))
