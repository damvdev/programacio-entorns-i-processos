# GIT
GIT és un sistema que permet realitzar la gestió de les versions del codi que els desenvolupadors realitzen d’una manera que permet controlar-ne l’evolució i permet el treball col·laboratiu entre els desenvolupadors.
Habitualment es treballa amb repositoris de codi que són el punt central on s’emmagatzema el codi i està disponible per a tots els desenvolupadors involucrats en un projecte.
GitHub és un servei web que proporciona repositoris de forma online, per tant accessible des de qualsevol ordinador amb connectivitat a Internet, que permet la gestió dels repositoris i el treball dels diferents desenvolupadors en un projecte.

Git treballa en dos servidors: el local i el remot.
* Local: Es la còpia que es manté a l’ordinador i que no es sincronitza amb el remot fins que s’executen les comandes corresponents.
* Remot: Es el repositori que està ubicat remotament, per exemple a Github.
Amb les comandes git remote es permet veure i configurar els paràmetres del repositori remot.


## Control de versions en local (GIT). Operacions bàsiques

Per crear un repositori, cal que el directori sigui inicialitzat. Des de la terminal, situats dins del directori ja creat, executarem la comanda *git init*:
```
git init
```
<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_0/images/git_init.jpg">

i podem veure que ens ha creat una carpeta "oculta" de *git*.

Aquesta operació, no obstant, no l'inclou dins de l'àrea destinada per a fer-ne seguiment del control de versions (**staging area**):

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_0/images/git_status_2.jpg">

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_0/images/git_status.jpg">

Per afegir-la, farem:

```
git add README.md

```
Podem veure, llavors, que ens marca el fitxer amb color verd:

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_0/images/git_add.jpg">

La **commit area** o repositori local conté la versió confirmada més actual dels arxius i carpetes del repositori local dels quals se n'està fent control de versions així com tot l'històric dels canvis que han sofert. Per passar el fitxer des de l'stating area a la commit area caldrà executar un *commit*:

```
git commit -m "Initial commit"
```

Si no s’ha configurat prèviament en l'ordinador que estem fent servir, ens demanarà informar de les dades de l’usuari que farà el commit:
```
git config --local user.name "Nom usuari"
git config --global user.name "Nom usuari"

git config --local user.email "usuari@email"
git config --global user.email "usuari@email"
```

Les credencials d'usuari es poden definir a nivell *local* i només aplicaran al repositori de la carpeta on es trobem. A nivell *global* aplicaran a tots els repos que es creeïn amb l'usuari amb el que s'ha iniciat sessió amb l'ordinador. A nivell *system* aplicaran a tots els repos de tots els usuaris que es creeïn dins de l'aquell ordinador.

Per conèixer l'estat del nostre repositori local de la carpeta on ens trobem:
```
git status -s
```

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_0/images/git_commit.jpg">

## Control de versions en remot (GitHub). Operacions bàsiques

Per configurar el repositori perquè apunti al repositori remot:

```
git remote add origin https://github.com/damvdev/programacio-entorns-i-processos/proves-git.git
```

Un cop connectats, cal realitzar un *push* perquè pugi el contingut del repositori local al repositori remot:
```
git push -u origin main
```

En cas de voler actualitzar el repositori amb la versió en remot:

```
git pull
```

I si volem clonar un repositori remot al repositori local:

```
git clone https://github.com/damvdev/programacio-entorns-i-processos/proves-git.git
```

**Important!** Per poder realitzar les accions cal disposar de les credencials de GitHub.
