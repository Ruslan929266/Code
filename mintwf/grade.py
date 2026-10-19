eingabe = input("Gib die Temperatur ein: ")

wert = float(eingabe[:-1])
einheit = eingabe[-1].upper()

if einheit == "C":
    fahrenheit = wert * 9 / 5 + 32
    print(f"{wert}°C sind {fahrenheit:.2f}°F")
elif einheit == "F":
    celsius = (wert - 32) * 5 / 9
    print(f"{wert}°F sind {celsius:.2f}°C")
else:
    print("Bitte benutze C für Celsius oder F für Fahrenheit.")
