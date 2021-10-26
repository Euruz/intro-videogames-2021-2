# Clase #2

## Contenido

- Manejo de la memoria.
  - Manejo de la memoria en game engines.
  - Stack, Heap y Garbage collector.
- GameLoop y GameObjects en game engines.
- GameLoop y GameObjects en Unity.
  - GameObject y Transform
  - Components
- Basic Movement en Unity

## Taller

### Fecha de entrega
> Miércoles 27 de Octubre, 11:59 pm (media noche).

### Descripción
- Clone el [repositorio](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2).
- Cree una nueva rama a partir del branch `sessions/session-2` con el siguiente formato: `student/[usuario-unal]/session-2`
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, la rama para hacer la entrega de la clase 2 debe ser `student/pedrito/session-2`.
```
- Ubique y abra el proyecto de Unity.
- Revise y juegue con el código `PlayerBasicMovement`.
- Responda las siguientes preguntas:

  - Cuál es la diferencia entre `Input.GetAxis` y `Input.GetAxisRaw`?:
      GetAxis devuelve el valor del eje virtual entre -1  y 1 (Con el eje horizontal de un joystick, un valor de 1 significa que el joystick se empuja completamente hacia la derecha y un valor de -1 significa que está completamente hacia la izquierda; un valor de 0 significa que el joystick está en su posición neutral.) mientras que GetAxisRaw nos devuelve el valor de -1, 0 o 1 que básicamente nos dice si se presionó una tecla o si se movió el joystick de un control.

  - Cuál se deberia usar? (Pregunta capciosa...):
      Depende de la forma como se quiera usar y de como se quieran las sensaciones del juego. Por ejemplo si se usa un control lo idea sería que el movimiento sea directamente proporcional al movimiento del joystick, para este caso se utilizaría "Input.GetAxis".

  - Qué hace `input.magnitude`? Por qué es util?:

      Devuele la magnitud del vector. Es util para saber si existe movimiento o no.

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?:

      Normalizar un vector  es dividirlo por su propia magnitud, el resultado es un vector con una magnitud de 1, es decir, su dirección. Si un vector normalizado es multiplicado por un escalar entonces la magnitud del resultado va a ser igual al valor del escalar. Esto es útil cuándo la dirección de una fuerza es constante pero la fuerza es controlable, como por ejemplo, la fuerza de la llanta de un automóvil siempre empuja hacia el frente pero el poder es controlado por el conductor.

- **Reto (Opcional):** Implementar una mécanica de dash en base al código dado.

### Como hacer la entrega:
- Edite el [README de la clase 2](https://github.com/UNAL-IntroVideojuegos-2021-2/intro-videogames-2021-2/blob/main/Clase2/README.md) para agreguar las respuestas a las preguntas. Por favor que sean respuestas cortas y concisas. Puede ser en Español o Ingles.
- Haga PR al branch `sessions/session-2`. 
- Para el nombre del PR usar el mensaje: `Solución Taller 2 by [usuario-unal]`. 
```
 Ejemplo: Si su correo es pedrito@unal.edu.co, el título del PR debe ser: `Solución Taller 2 by pedrito`.
```
- En la descripción del PR puede escribir lo que considere pertinente (aclaraciones, dudas, comentarios...).

## NOTA!!!!!!!!!
**Si no tiene permisos para: clonar el repositorio, crear una nueva branch, hacer Pull, hacer Push, hacer Pull Request, o cualquier otro inconveniente relacionado al repositorio, por favor contactenos para resolver el problema lo mas pronto posible!!!!**