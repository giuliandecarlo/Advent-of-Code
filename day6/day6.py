#---------[PART 1]---------

f=open('day6.txt')
checkList=""
content=f.read()
charList=list(content)

for i in range(len(charList)):
    for n in range(4):
        if(charList[n+i] not in checkList):
            checkList=checkList+charList[n+i]
        else:
            checkList=""
            break
    if(len(checkList)==4):
        print("Part 1: "+str(n+i+1))
        break

#---------[PART 2]---------

for i in range(len(charList)):
    for n in range(14):
        if(charList[n+i] not in checkList):
            checkList=checkList+charList[n+i]
        else:
            checkList=""
            break
    if(len(checkList)==14):
        print("Part 2: "+str(n+i+1))
        break
