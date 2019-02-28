# Hundir La Flota
Proyecto para aplicación de consola sobre el famoso juego de "Hundir La Flota" en C#. Para el curso FPII Desarrollo de Aplicaciones Multiplataforma (DAM).

### Inicio del juego
Para empezar tenemos la clase Juego.cs donde el primer jugador, en este caso tú, empezará colocando los barcos en un tablero 8x8. Los barcos se colocarán según las siguientes reglas: no se pueden colocar unos encima de otros y no se pueden salir del tablero 8x8.
Seguidamente el ordenador colocará sus barcos aleatoriamente siguiendo las reglas anteriores.

### Desarrollo
El juego se desarrolla por turnos, primero será el jugador: elegirá una fila y una columna, comprobará que en el tablero enemigo haya agua o barco, y seguidamente si hubiera barco comprobará si está hundido o no.
El turno del ordenador es igual pero las filas y columnas son aleatorias.

### Fin del juego
La partida finalizará cuando cualquiera de los dos gane primero. Es decir, que todos los barcos del oponente hayan sido hundidos.
