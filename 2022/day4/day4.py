#---------[PART 1]---------
f=open('day4.txt')
count=0
while True:
    line=f.readline()
    if not line:
        break
    L=line.split(",")
    s1,e1=L[0].split("-")
    s2,e2=L[1].split("-")
    if((int(s1)<=int(s2) and int(e1)>=int(e2))or(int(s1)>=int(s2) and int(e1)<=int(e2))):
        count=count+1
   
print("Part 1: "+str(count))

#---------[PART 2]---------
f=open('day4.txt')
count=0
while True:
    flag=0
    line=f.readline()
    if not line:
        break
    L=line.split(",")
    s1,e1=L[0].split("-")
    s2,e2=L[1].split("-")
    if not((int(e1)<int(s2)) or (int(s1)>int(e2))):
        count=count+1

print("Part 2: "+str(count))