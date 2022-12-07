#---------[PART 1]---------
f=open('day7.txt')
root=[]
val={}

def upd_value(size):
    for i in range(len(root)):
        key="".join(root[:i+1])
        if key not in val:
            val[key]=size
        else:
            val[key]=val[key]+size

while True:
    line=f.readline()
    if not line:
        break
    l=line.split()
    if(l[0]=="$"):
        if(l[1]=="cd"):
            if(l[2]==".."):
                root.pop()
            else:
                root.append(l[2])
    elif(l[0]=="dir" or l[0]=="ls"):
        continue
    else:
        upd_value(int(l[0]))

    tot=0
    for v in val.values():
        if v<=100000:
            tot=tot+v

print("Part 1: "+str(tot))

#---------[PART 2]---------

req=val.get('/')-40000000
minVal=700000000
for v in val.values():
    if v>=req:
        if v<minVal:
            minVal=v

print("Part 2: "+str(minVal))
