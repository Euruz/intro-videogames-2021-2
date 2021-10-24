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
  - Cuál es la diferencia entre `Input.GetAxis` y `Input.GetAxisRaw`? La diferencia entre el comando `Input.GetAxis` y `Input.GetAxisRaw` es que el comando `Input.GetAxisRaw` no tiene en cuenta la "inercia" del objeto, mientras que el comando `Input.GetAxis` si tiene en cuenta la "inercia" del objeto.
  - Cuál se deberia usar? (Pregunta capciosa...). Se debería usar el uno o el otro dependiendo de las caracteristicas del objeto o del personaje, por ejemplo, se usaría `Input.GetAxisRaw` en un personaje con la habilidad de cambiar facilmente de dirección o `Input.GetAxis` en un personaje más lento con dificultades para cambiar de dirección.
  - Qué hace `input.magnitude`? Por qué es util? El método `.magnitude` saca la magnitud del vector, permite diferenciar el vector del vector nulo con magnitud 0, lo que permite diferenciar si existe o no movimiento.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento? Normalizar un vector significa dividir todas las componentes del vector por su magnitud de tal manera que el vector resultante conserva la dirección del vector original pero su magnitud es igual a 1. Es util en movimiento para modificar la rapidez o magnitud de aceleración sin modificar la dirección del movimiento.
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