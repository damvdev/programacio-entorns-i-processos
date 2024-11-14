# Classes d'Equivalència, Valors Límit i Casos de Prova

## 1. Classes d'Equivalència
   - Definició: 
     - Conjunt de dades d'entrada que, per les seves característiques similars, poden ser tractades com una única unitat en proves de programari.
     - Redueixen el nombre de proves necessàries, ja que cada classe representa un tipus de comportament esperat.

   - Exemples:
     - Divisió per 3: 
       - **residu 0**: Nombres divisibles per 3 (ex. -3, 0, 3).
       - **residu 1**: Nombres amb residu 1 en dividir per 3 (ex. -2, 1, 4).
       - **residu 2**: Nombres amb residu 2 en dividir per 3 (ex. -1, 2, 5).

## 2. Valors Límit
   - Definició: 
     - Dades situades en la frontera de les classes d'equivalència.
     - Són propenses a errors perquè representen canvis de comportament en el sistema.

   - Importància:
     - Provar aquests valors ajuda a assegurar que el sistema gestiona correctament les transicions entre classes d'equivalència.
     
   - Exemples:
     - Divisió per 3:
       - Límits entre residu 2 i residu 0: 2 (residu 2) i 3 (residu 0).
       - Límits entre residu 0 i residu 1: 0 (residu 0) i -1 (residu 2).

## 3. Casos de Prova
   - Definició:
     - Proves específiques dissenyades per validar cada classe d'equivalència i els valors límit.
     - Asseguren que el sistema respon correctament per a totes les entrades possibles.

   - Components d'un cas de prova:
     - **Descripció**: Breu descripció de la prova.
     - **Entrada**: Dada o dades d'entrada que s'introdueixen en el sistema.
     - **Accions**: Passes específiques per executar la prova.
     - **Resultat esperat**: Resultat que s’espera que el sistema produeixi.

   - Exemple:
     - Cas de prova per a residu 0 en divisió per 3:
       - **Descripció**: Comprova un nombre positiu divisible per 3.
       - **Entrada**: 6.
       - **Accions**: Crida al mètode amb 6 com a argument.
       - **Resultat esperat**: residu = 0.

## 4. Relació entre Classes d'Equivalència, Valors Límit i Casos de Prova
   - Les classes d'equivalència defineixen els grups o categories d'entrada que s'han de provar.
   - Els valors límit es fan servir per provar les fronteres entre aquestes classes.
   - Els casos de prova s’elaboren per cobrir totes les classes i límits, garantint així que el sistema funciona correctament per a totes les entrades possibles.