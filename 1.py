# Ejercicio 2

nivel_seguridad = int(input("Cual es tu nivel de seguridad: "))
estado_activo = bool(input("Tu estas es: (True/False)"))
codigo_emergencia = bool(input("Tienes un codigo: (True/False)"))


#if (nivel_seguridad > 5 or estado_activo == True) or codigo_emergencia == True:
#    print("Tienes autorizacion")

if (nivel_seguridad > 5 or estado_activo) or codigo_emergencia:
    print("Tienes autorizacion")
else:
    print("No tienes autorizacion") 
