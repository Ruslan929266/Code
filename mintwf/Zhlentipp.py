import random
t = random.randint(1, 20)
print("Zahlentipp")
print("===========")
print("")
x = 0
while x != 20:
    x = int(input("Bitte eine Zahl zwischen 1 und 20 eingeben: "))
    print("Du hast die Zahl")