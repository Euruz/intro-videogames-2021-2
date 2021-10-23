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
  - Cuál es la diferencia entre `Input.GetAxis` y `Input.GetAxisRaw`?
  - Cuál se deberia usar? (Pregunta capciosa...).
  - Qué hace `input.magnitude`? Por qué es util?
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
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

---

### Answers

- What's the difference if we use Input.GetAxisRaw instead?

  > The difference is that Input.GetAxisRaw returns a integer and discrete axis value {-1, 0, 1} while Input.GetAxis returns a float and continuous axis value [-1, 1]

- Which one should we use? (GetAxis or GetAxisRaw)

  > This depends on how we want the game controls to feel. If we use Input.GetAxisRaw, the player will feel less control of the character because of the discrete range of values it returns. In the other hand if we use Input.GetAxis, the player will feel more control of the character. I think Input.GetAxisRaw can be use with the current code for example, if the character is over a slippery  ground

- What does .magnitude?

  > .magnitude returns the distance between the head of the vector and the origin (0, 0, 0). It is useful because if it is greatest that 0 this means that the player is trying to move the character in some direction (horizontal axis, vertical axis or both)

- What means to normalize a Vector? And why it's useful when we apply movement?

  > When we normalize a vector we get a new vector that has the same direction of the source vector but with magnitude equals to 1. This is useful when we just want to know the player's movement direction
