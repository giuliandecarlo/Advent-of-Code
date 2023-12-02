#---------[PART 1]---------
f=open('day2.txt')
sum = 0
while True:
    line = f.readline()
    if not line:
        break
    check = True
    set_game = line.split(":")
    game = set_game[0]
    set_game = set_game[1].split(";")
    game = int(game.replace("Game ",""))
    for sets in set_game:
        red,blue,green = 0,0,0
        cubes = sets.split()
        for i in range(len(cubes)):
            if i%2==0:
                if "red" in cubes[i+1]:
                    red = int(cubes[i])
                if "blue" in cubes[i+1]:
                    blue = int(cubes[i])
                if "green" in cubes[i+1]:
                    green = int(cubes[i])
            if ((red > 12) or (blue > 14) or (green > 13)):
                check = False
                break
        if(check==False): break    
    if check == True:
        sum += game
print(sum)

#---------[PART 2]---------
f=open('day2.txt')
sum = 0
while True:
    line = f.readline()
    if not line:
        break
    check = True
    set_game = line.split(":")
    game = set_game[0]
    game = int(game.replace("Game ",""))
    cubes = set_game[1].split()
    red,blue,green = 0,0,0
    for i in range(len(cubes)):
        if i%2==0:
            if "red" in cubes[i+1]:
                red = max(int(cubes[i]),red)
            if "blue" in cubes[i+1]:
                blue = max(int(cubes[i]),blue)
            if "green" in cubes[i+1]:
                green = max(int(cubes[i]),green)
    sum += red*green*blue
print(sum)