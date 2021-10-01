print("Ingrese algun diametro a su gusto po, sapo reqlo")
x = float(input())
while x <= 0:
    print("Ingrese algun diametro pero correcto po, COMO TAN WEON")
    x = float(input())

pi = 3.14

perimetro = pi * x
area = (pi * x * x) / 4

print("El perimetro es ", end="")
print(perimetro)
print("El area es ", end="")
print(area)