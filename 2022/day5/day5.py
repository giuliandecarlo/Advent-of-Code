#---------[PART 1]---------

stacks=[['F','H','B','V','R','Q','D','P'],
        ['L','D','Z','Q','W','V'],
        ['H','L','Z','Q','G','R','P','C'],
        ['R','D','H','F','J','V','B'],
        ['Z','W','L','C'],
        ['J','R','P','N','T','G','V','M'],
        ['J','R','L','V','M','B','S'],
        ['D','P','J'],
        ['D','C','N','W','V']]

f=open('day5.txt')
while True:
    line=f.readline()
    if not line:
        break
    if 'move' in line:
        l=line.split()
        n=int(l[1])
        start=int(l[3])-1
        destination=int(l[5])-1
        for i in range(n):
            el=stacks[start].pop()
            stacks[destination].append(el)

result=""
for y in range(len(stacks)):
    result=result+stacks[y][-1]

print("Part 1: "+result)

#---------[PART 2]---------

stacks=[['F','H','B','V','R','Q','D','P'],
        ['L','D','Z','Q','W','V'],
        ['H','L','Z','Q','G','R','P','C'],
        ['R','D','H','F','J','V','B'],
        ['Z','W','L','C'],
        ['J','R','P','N','T','G','V','M'],
        ['J','R','L','V','M','B','S'],
        ['D','P','J'],
        ['D','C','N','W','V']]

f=open('day5.txt')
while True:
    line=f.readline()
    if not line:
        break
    if 'move' in line:
        l=line.split()
        n=int(l[1])
        start=int(l[3])-1
        destination=int(l[5])-1
        for i in range(n):
            el=stacks[start].pop(len(stacks[start])-n+i)
            stacks[destination].append(el)

result=""
for y in range(len(stacks)):
    result=result+stacks[y][-1]

print("Part 2: "+result)