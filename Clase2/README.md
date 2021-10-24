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
    Respuesta: `Input.GetAxis` devuelve valores continuos entre -1 y 1, es decir, con un aumento o disminución el el tiempo.
               `Input.GetAxisRaw` devuelve valores discretos, específicamente -1, 0 y 1.
  - Cuál se deberia usar? (Pregunta capciosa...).
    Respuesta: Dependerá del uso que se quiera dar, por ejemplo el juegos donde los botones solo muestran dos estados, como parar o caminar, o disparar o no disparar, para estos será mejor usar `Input.GetAxisRaw`, mientras que en juegos donde se quiera un tipo de sensibilidad, por ejemplo los joysticks de los controles de consolas será adecuado usar `Input.GetAxis`.
  - Qué hace `input.magnitude`? Por qué es util?
    Respuesta: `input.magnitude` nos arroja la magnitud del vector asociado, esta magnitud se calcula como sqrt(horizontal^2 + vertical^2)
    Es útil porque toma un valor unico positivo y esto sirve para programar condicionales o ciclos a partir de esto, porque nos indica que hay movimiento.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    Normalizar el vector significa dividir el vector por su magnitud, lo que nos genera que el vector siempre tenga magnitud de valor 1 y esto útil porque será más fácil realizar calculos de movimiento, escalado, dirección, es decir aplicación de fuerzas. 
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