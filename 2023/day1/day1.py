#---------[PART 1]---------
f=open('day1.txt')
sum = 0
while True:
    line = f.readline()
    if not line:
        break
    first = None
    last = None
    for c in line:
        if c.isnumeric():
            if first == None:
                first = c
            last = c
    sum += int(first+last)
print(sum)

#---------[PART 2]---------
f=open('day1.txt')
sum = 0
numbers = {"one":1,
            "two":2,
            "three":3,
            "four":4,
            "five":5,
            "six":6,
            "seven":7,
            "eight":8,
            "nine":9}
while True:
    line = f.readline()
    if not line:
        break
    for key, value in numbers.items():
        line = line.replace(key,key+str(value)+key)
    first = 0
    last = 0
    for c in line:
        if c.isnumeric():
            if first == 0:
                first = c
            last = c
    sum += int(first + last)
print(sum)