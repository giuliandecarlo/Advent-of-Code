from itertools import islice

#---------[PART 1]---------
f=open('day3.txt')
sum=0

def calcValue(ch):
    val=0
    if(ch.isupper()):
        val=ord(ch)-64+26
    else:
        val=ord(ch)-96
    return(val)


while True:
    line=f.readline()
    string3=""
    if not line:
        break
    string1,string2=line[:len(line)//2],line[len(line)//2:]
    stringChar=list(string1)
    for n in stringChar:
        if (n in string2 and n not in string3):
            string3=string3+n
            sum=sum+calcValue(n)

print("Part 1: "+str(sum))

#---------[PART 2]---------

sum=0
n=0
f=open('day3.txt')


for i in range(100):
    str3=""
    lines3=islice(f,n,n+3,1)
    ll=list(lines3)
    strCh1=list(ll[0])
    for c in strCh1[:len(strCh1)-1]:
        if (c in ll[1] and c in ll[2] and c not in str3):
            str3=str3+c
            sum=sum+calcValue(c)

print("Part 2: "+str(sum))
