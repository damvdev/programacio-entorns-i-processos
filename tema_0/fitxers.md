# Fixters

Un **fitxer** és un recurs informàtic que s’utilitza per a registrar dades discretament en un dispositiu d'emmagatzematge informàtic. El format d'un arxiu es defineix pel seu contingut, ja que un arxiu és únicament un contenidor de dades, tot i que en alguns programes el format és indicat per l’extensió del fitxer, especificant les regles de com han d'organitzar-se i interpretar-se els bytes de manera significativa.

Hi ha diferents tipus d'arxius informàtics, dissenyats per a diferents propòsits. Un arxiu pot estar dissenyat per a emmagatzemar una imatge, un missatge escrit, un vídeo, un programa d'ordinador o una àmplia varietat d'altres tipus de dades. Alguns tipus d'arxius poden emmagatzemar diversos tipus d'informació alhora. En la majoria de sistemes operatius moderns, els fitxers són organitzats en arrays unidimensionals de bytes. El format d'un arxiu es defineix pel seu contingut, ja que un arxiu és únicament un contenidor de dades, tot i que en alguns programes el format és indicat per l’extensió del fitxer, especificant les regles de com han d'organitzar-se i interpretar-se els bytes de manera significativa. Per exemple, els bytes d'un fitxer de text senzill (.txt en Windows) és associat amb qualsevol ASCII o UTF-8 caràcters, mentre els bytes d'imatge, vídeo, i fitxers d'àudio són interpretats d’una altra manera. La majoria dels tipus d'arxiu també assignen uns pocs bytes per a les metadades, la qual cosa permet que un arxiu porti alguna informació bàsica sobre si mateix.

Exemples de tipus d’extensions tenim: .txt, jpg, .docx, .c, .py, .java,...

Mitjançant l'ús de programes informàtics, una persona pot obrir, llegir, canviar, guardar i tancar un arxiu informàtic. Els arxius poden ser oberts, modificats i copiats un nombre arbitrari de vegades. Les operacions més bàsiques que els programes poden realitzar en un arxiu són:
* Crear un nou arxiu
* Canviar els permisos d'accés i els atributs d'un arxiu
* Obrir un arxiu, la qual cosa fa que el contingut de l'arxiu estigui disponible per al programa
* Llegir les dades d'un arxiu
* Escriure dades en un arxiu
* Modificar/afegir dades en un arxiu
* Eliminar un arxiu
* Tancar un arxiu, acabant l'associació entre ell i el programa

Els arxius s'organitzen en un **sistema d'arxius** (file system), que manté un registre d'on es troben els arxius en el disc i permet l'accés de l'usuari. Per poder accedir a aquests arxius, hem d’especificar la seva ruta. Una ruta és la forma general d’un nom de fitxer o carpeta, de manera que identifica únicament la seva localització en el sistema de fitxers. Aquestes rutes poden ser absolutes o relatives.

Una **ruta absoluta** és aquella que es refereix a un element destinació a partir de la carpeta arrel d’un sistema de fitxers. En aquesta s’enumeren, una per una, totes les carpetes que hi ha entre la carpeta arrel fins a la carpeta que conté l’element destinació.

```
C:\Documents\Unitat6\Apartat1\Activitats.txt
/home/usr/Unitat6/Apartat1/Activitats.txt
```


Una **ruta relativa** és aquella que es considera que parteix des de la carpeta, o directori, de treball de l’aplicació. Aquesta carpeta pot ser diferent cada cop que s’executa el programa i depèn de la manera com s’ha dut a terme aquesta execució.

```
Unitat6\Apartat1\Activitats.txt
Unitat6/Apartat1/Activitats.txt
```
