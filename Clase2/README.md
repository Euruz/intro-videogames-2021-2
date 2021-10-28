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
    R/ el metodo Input.GetAxis modifica de manera continua (gradualmente) el valor de posicion entre -1 y 1 permitiendo asi que el movimiento sea suave, mientras que Input.GetAxisRaw modifica los valores discretamente, es decir, pueden ser -1, 0 o 1 por lo que el cambio en la posicion es instaneo
  - Cuál se deberia usar? (Pregunta capciosa...).
    R/ Para responder esa pregunta primero se debe tener claro si el juego es 2D o 3D. en un juego 3D se recomienda el Input.GetAxis ya que el control resultara mas fluido, en cambio en un juego 2D solo se necesita conocer el cambio de direccion por lo que Input.GetAxisRaw funcionara bien
  - Qué hace `input.magnitude`? Por qué es util?
    R/ el metodo input.magnitude la longitud de un vector, lo cual es muty util por ejemplo para calcular velocidades
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    R/ normalizar un vector es convertir su magnitud es 1 sin modificar su direccion. esto es muy util a la hora de realizar modificaciones en la direccion del vector sin alterar valores de velocidad o aceleracion. 
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