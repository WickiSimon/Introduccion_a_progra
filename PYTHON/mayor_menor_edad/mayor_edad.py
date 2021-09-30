print("Ingrese su edad")
edad = int(input())

if edad >= 0 and edad <=130:
    if edad >= 18:
        print("Es mayor de edad")
    else:
        print("Es menor de edad")     
else:
    print("Error: Valor edad no permitida")