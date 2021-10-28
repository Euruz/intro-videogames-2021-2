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
    - La diferencia entre estos dos métodos es que el primero ( Input.GetAxis ) tiene una entrada más suave, que puede ser usada en un Joystick, por ejemplo, pues entrega valores decimales entre el -1 y el 1 dependiendo del input, mientras el otro método entrega valores enteros, haciendo de esta una mejor opción para entradas como botones, teclados, etc. 

  - Cuál se deberia usar? (Pregunta capciosa...).
    - Respondí esta en la otra xd, pero básicamente cuando la entrada puede tener valores intermedios es mejor usar el Input.GetAxis, mientras que si es una entrada que no tiene valores intermedios, como botones, es mejor usar el Input.GetAxisRaw.

  - Qué hace `input.magnitude`? Por qué es util?
    - Sirve para calcular la magnitud de un vector, en este caso tenemos la magnitud de la entrada, esta magnitud nos sirve para entradas que pueden tener valores intermedios, permitiendonos, por ejemplo, hacer variar la velocidad del jugador con respecto al movimiento, o inclinacion del joystick.

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    - Normalizar un vector es llevarlo a su representación unitaria, esto nos sirve para identificar la dirección de un movimiento con base en la entrada que se entrega en ejes perpendiculares entre sí, normalizando un vector podemos implementar de manera más sencilla el movimiento, pues teniendo la dirección podemos escalar el vector normalizado y hacer que el personaje se mueva más rápido, o más lento.
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
