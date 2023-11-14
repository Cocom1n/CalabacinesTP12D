# CalabacinesTP12D
- Alumno: Carrasco Candela Elisa Rosa
- Materia: Programación de Videojuegos
- Profesores: Ariel Alejandro Vega - Samuel Bustamante I
- Infinite Jumping “Calabacines”

 ## Mecanicas
 El jugador puede saltar sobre las nubes pero no puede mantenerse parado en estas, además de que las nubes desaparecerán en un tiempo determinado por lo que deberá subir lo más rápido que pueda antes de quedarse sin plataformas debajo.
 
 Existen dos formas de perder: Si pierde todos sus diamantes al ser golpeado por enemigos, y si se cae de las plataformas fuera del mapa

 ## Scripts 

**cameraMove:** Este era inicialmente para la cámara pero también lo tienen todos aquellos objetos que necesiten seguir el movimiento del Jugador en el eje Y: 
- Calabazas: el suelo que detecta si el jugador cae del escenario y que a su vez contiene las paredes laterales para que el jugador no se salga de la pantalla
- El fondo y todos los spawners: todos los espawners tienen dos puntos A y B que señalan el área de spawn para los distintos objetos, estos se ubican sobre la pantalla y seguir con la camara hace que estos siempre esten arriba

**damageObject:** Lo tienen todos los objetos que quiten diamantes, en este caso los ojos y los fantasmas, este detecta la colisión y llama al UIControler para manejar los diamantes
**KillObjet:** Este lo tiene directamente el suelo de calabazas, que detecta una colisión en la parte inferior fuera de la pantalla para saber si el jugador se ha caído

**Generador1 y Generador2:** El Generador1 lo usan los enemigos que caen desde la parte superior de la pantalla y los diamantes, estos son generados en un intervalo, posición y cantidad aleatorias. el generador 2 lo usan los enemigos que salen del lateral derecho, se generan en un intervalo y posición aleatoria
**PlataformasSpawn:** Genera 2 nubes en un intervalo fijo de 0,5 segundos en una posición aleatoria en x, a diferencia de los otros Generadores este funciona con corruitna

**UIControler:** Se encarga en general de gestionar los diamantes (mostrarlos en pantalla) y la condición de perder y reiniciar el juego. También para cambiar la canción una vez se pierde 

*Los demás scripts calculan el movimiento del jugador o los enemigos además de verificar las colisiones para  que el UIControler pueda gestionar los diamantes*
