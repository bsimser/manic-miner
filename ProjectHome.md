A Manic miner remake (probably will not get to be a complete one), created using C# and Tao.Sdl (version using XNA also available).

Docs, comments and variable/function names in the source code are in Spanish.

Each release contains binaries, source code, DLLs and Projects for Visual Studio 2008 and Sharp Develop 2.2 / Visual Studio 2005.

---

Un "remake" parcial de Manic Miner, creado usando C# y la librería Tao.Sdl (también existe una versión que usa XNA).

Cada versión contiene ejecutables, código fuente, DLLs y proyectos para Visual Studio 2008 y Sharp Develop 2.2 / Visual Studio 2005.

Entregas ya realizadas:

  1. Esqueleto vacío de ejemplo
  1. Añadir un enemigo que se mueva solo.
  1. Añadir un fondo repetitivo, usando arrays.
  1. Comprobar colisiones con el fondo (no cruzar paredes ni suelos).
  1. Salto del personaje (sin gravedad).
  1. Pantalla de créditos con texto real. Presentación con animación.
  1. Comprobar colisiones con enemigo, perder vidas, reiniciar partida.
  1. Gravedad (caer al final de una plataforma). Mejoras gráficas.
  1. Recoger objetos del fondo (y obtener puntos).
  1. Añadir clase Marcador, que muestre vidas, puntos, aire
  1. Añadir dos niveles más. Abrir la puerta que permite pasar de un nivel a otro cuando se recogen todas las llaves. También se puede pasar de un nivel a otro pulsando T+N (truco).
  1. Personaje y enemigo animados
  1. Incluir los 20 niveles del juego original (aunque no con todas sus imágenes reales y sin enemigos)
  1. Enemigos distintos en cada nivel, con posibilidad de distinto movimiento (lineal)
  1. (Prueba intermedia que usa XNA en vez de Tao.SDL) Más enemigos y fondos del juego original.

Previsión para las siguientes entregas (el orden puede variar):

  * Animación al morir.
  * Casillas más reales en los niveles superiores al 1.
  * Fondos "cambiantes" 1: suelo que se hunde.
  * Fondos "cambiantes" 2: suelo que se mueve.
  * Morir al caer desde las alturas
  * Corrección de pequeños errores: choque en el salto con las paredes laterales, altura incorrecta en el salto, colisiones "demasiado exigentes"
  * Dos juegos de imágenes (retro / calidad mejorada), seleccionables desde Opciones
  * Leer mapas de niveles adicionales desde fichero.
  * ...