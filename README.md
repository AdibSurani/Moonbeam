# Moonbeam
A MBM&lt;->XML converter with a Spanish dictionary
Abre una consola y aplica los parametros correspondientes junto a la ruta del archivo.
Por ejemplo:
"Moonbeam.exe -e "C:\carpeta""
El programa tiene varios parametros y modos de uso.
Los primeros dos parametros que hay que insertar son los siguientes:
	- "-e" para exportar de MBM a XML
	- "-i" para importar de XML a MBM
Tras esto, hay dos formas de usar el programa: el modo explicito y el modo recursivo.

El modo explicito se activa al introducir en la ruta directamente el archivo a convertir y solo tratará dicho archivo.
Por ejemplo:
"Moonbeam.exe -e "C:\carpeta\archivo.mbm""

El modo recursivo se activa al introducir en la ruta un directorio, dejando implicito que dentro de ese directorio hay archivos,
la busqueda recursiva tratará de buscar todos los archivos a convertir dentro de una ruta.
Por ejemplo:
"Moonbeam.exe -e "C:\carpeta\"
