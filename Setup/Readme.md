# Instalacion por medio de ubuntu
# 1.Instalacion de dotnet core 2.2 
### Ingresamos ala pagina de [dotnet](https://dotnet.microsoft.com/) ,al entrar ala pagina selecionamos la instalacion que diga build app.
![](../Pictures/dotnet.PNG)
### Despues selecionamos la opcion de ubuntu.
### nos proporcionaran un codigo el cual ingresaremos ala terminal.
``` sudo dpkg -i packages-microsoft-prod.deb
    sudo apt-get install apt-transport-https
    sudo apt-get update
    sudo apt-get install dotnet-sdk-2.2 
```
### al ingresar este codigo,ya tendremos instalado dotnet core.

# 2.Instalación y configuración de Visual Studio Code para C#

### Ingresamos ala pagina de [visual code](https://code.visualstudio.com/) 
![](../Pictures/visual.PNG)
### Seleccionamos la version de .deb
### Entramos ala terminal
### por medio del cd nos vamos al Downloads (cd Downlods/)
### al entrar ala carpeta de descargas ingresamos "Downloads ls" funcion que sirve para ver archivos en esta carpeta 
### al ver el nombre del archivo que descargamos ,ingresamos "sudo dpkg -i" y el nombre del archivo completo.
### Al ingresar ese codigo se comenzara la descarga de visual code ,al finalizar selecionamos la opcion de extensiones en la parte izquierda para descargar c##.

# 3.Instalación de git. conectado a tu cuenta de GitHub y VSC.
### Ingresamos ala pagina de [git](https://git-scm.com/) selecionamos la version de ubuntu
![](../Pictures/git.PNG)
### Abrimos nuestra terminal para ingresar el codigo que nos proporcionan 
``` sudo apt-get install git
    sudo add-apt-repository ppa:git-core/ppa 
    sudo apt update; apt install git
```
### Terminamos entrando a visual code y bajando una extension de git.
