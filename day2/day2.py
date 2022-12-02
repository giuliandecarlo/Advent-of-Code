#---------[PART 1]---------

f=open('day2.txt')
x=1 #ROCK
y=2 #PAPER
z=3 #SCISSORS
win=6
draw=3
points=0

while True:
    line=f.readline()
    if not line:
        break
    L=line.split()

    match(L[1]):
        case 'X':
            points=points+x
            if(L[0]=='C'):
                points=points+win
            if(L[0]=='A'):
                points=points+draw
        case 'Y':
            points=points+y
            if(L[0]=='A'):
                points=points+win
            if(L[0]=='B'):
                points=points+draw
        case 'Z':
            points=points+z
            if(L[0]=='B'):
                points=points+win
            if(L[0]=='C'):
                points=points+draw

print(points)

#---------[PART 2]---------

f1=open('day2.txt')

points2=0
while True:
    line=f1.readline()
    if not line:
        break
    L=line.split()

    match(L[1]):
        case 'X':
            if(L[0]=='A'):
                points2=points2+3
            elif(L[0]=='B'):
                points2=points2+1
            elif(L[0]=='C'):
                points2=points2+2
        case 'Y':
            points2=points2+draw
            if(L[0]=='A'):
                points2=points2+1
            elif(L[0]=='B'):
                points2=points2+2
            elif(L[0]=='C'):
                points2=points2+3
        case 'Z':
            points2=points2+win
            if(L[0]=='A'):
                points2=points2+2
            elif(L[0]=='B'):
                points2=points2+3
            elif(L[0]=='C'):
                points2=points2+1

print(points2)    