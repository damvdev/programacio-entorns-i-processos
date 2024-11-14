#  1. Assembler. Programa amb màquina senzilla

### Instruccions en llenguatge màquina
Disposem d'una màquina senzilla que pot executar 4 operacions:
- Suma dos números naturals (operació ADD)
- Mou una información de una posición de memoria a una altra (operació MOV)
- Compara dos números naturals (operació CMP)
- Salta si dos números son iguals (operació BEQ)

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_1/Teoria/images/maquina-ordinador.jpg" width="300" height="300">

Cada una d'aquestes operacions té assignat un codi de bits que la identifica:

```sh
ADD -> 00 CMP -> 01 MOV-> 10 BEQ -> 11
```

Una instrucció conté 16 bits que identifica l'operació i els operands implicats:
```sh
00 0000011 0000111
00: suma dos operands
0000011: operand 1
0000111: operand 2
```

Cada posició de memòria conté diferents valors. En aquest cas, la màquina disposa d'una memòria RAM de 128 bits, on el rang [0-127] i es fan servir 7 bits per codificar cada adreça de memòria.

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_1/Teoria/images/direccions-ram.jpg" width="250" height="400">

Si tenim la següent instrucció en llenguatge màquina:
```sh
10 1100101 1101001
```
on
```sh
10: MOV
1100101: 101
1101001: 105
```

La instrucció és equivalent a enssamblador a:
```sh
MOV 101 105
```
De manera que en aquesta posició de memòria, la instrucció emmagatzemada indica que s'ha de moure el contingut de la posició de memòria **@101** a la posició de memòria **@105**.

### Com passem de LAN a llenguatge màquina?

<img src="https://github.com/damvdev/programacio-entorns-i-processos/blob/main/tema_1/Teoria/images/LAN-maquina.jpg" width="250" height="400">

A continuació estudiarem diferents exemples de codificació d'un algorisme en llenguatge ensamblador, seguint les especificacions de la màquina senzilla d'exemple:

1. Suposem que volem especificar un algorisme que sumi el contingut de dos variables i emmagatzemi en una tercera variable el resultat d'aquesta operació.
Sabem que la variable **_a_** està emmagatzemada en la posició @102, que la variable **_b_** està en la posició @103 i que el resultat **_c_** es guardarà en la posició @104.

|POSICIÓ   |CONTINGUT                    |           
|----------|-----------------------------|
|0         |`'MOV 102, 104'`             |
|1         |`'ADD 103, 104'`              |
|2         |`'FI'`                       |
|...       |                             |
|101       | 001                         |
|102       | a                           |
|103       | b                           |
|104       | c                           |


2. Suposem que volem especificar un algorisme que compari el contingut de dos variables i, si aquestes són diferents, emmagatzemi en una tercera variable el valor de la primera afegint-li un 1.
Sabem que la posició @101 conté un 1, que la variable **_a_** està emmagatzemada en la posició @102, que la variable **_b_** està en la posició @103 i que el resultat **_c_** es guardarà en la posició @104.

|POSICIÓ   |CONTINGUT                    |           
|----------|-----------------------------|
|0         |`'CMP 102,103'`              |
|1         | `'BEQ 4'`                   |
|2         |`'MOV 102, 104'`             |
|3         |`'ADD 101, 104'`             |
|4         |`'FI'`                       |
|...       |                             |
|101       | 001                         |
|102       | a                           |
|103       | b                           |
|104       | c                           |

3. Suposem que volem especificar un algorisme que compari el contingut de dos variables i, si aquestes són iguals, emmagatzemi en una tercera variable el valor de la primera afegint-li un 1. En cas contrari, emmagatzemarà en la tercera variable el valor de la segona, afegint-li un 1.
Sabem que la posició @101 conté un 1, que la variable **_a_** està emmagatzemada en la posició @102, que la variable **_b_** està en la posició @103 i que el resultat **_c_** es guardarà en la posició @104.

|POSICIÓ   |CONTINGUT                    |           
|----------|-----------------------------|
|0         |`'CMP 102,103'`              |
|1         | `'BEQ 6'`                   |
|2         |`'MOV 103, 104'`             |
|3         |`'ADD 101, 104'`             |
|4         |`'CMP 102,102'`              |
|5         | `'BEQ 8'`                   |
|6         | `'MOV 102, 104'`            |
|7         | `'ADD 101, 104'`            |
|8         | `'FI'`                      |
|...       |                             |
|101       | 001                         |
|102       | a                           |
|103       | b                           |
|104       | c                           |
