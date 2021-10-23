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

  R// Input.GetAxis e Input.GetAxisRaw la diferencia entre estos dos comandos es que GetAxis es analógico (tiene valores intermedios entre [-1,1]), en cambio GetAxisRaw es digital, no tiene valores intermedios y pasa directamente de 0 a 1 o de 0 a -1.

  - Cuál se deberia usar? (Pregunta capciosa...).

  R// Depende de gamefeel que se le quiera dar al juego, o el sistema para el que se necesite usar.

  - Qué hace `input.magnitude`? Por qué es util?

  R// input.magnitude retorna la longitud del vector input. Es útil porque puede ayudarnos a saber la distancia
  entre el origen de coordenadas y el vector.

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?

  R// Normalizar un vector es hacer que el vector ahora tenga magnitud 1, pero siga apuntando a la misma dirección. Esto es útil pues ayuda a conocer la dirección de un vector y permite trabajar más fácil las operaciones con estos vectores.

- **Reto (Opcional):** Implementar una mécanica de dash en base al código dado. ✅

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