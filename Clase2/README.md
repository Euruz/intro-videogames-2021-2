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

    - R: `Input.GetAxis` realiza un cambio gradual en el invervalo de (0) a (-1) o de (0) a (1), lo cual se puede ver como un movimiento suave, por otro lado, `Input.GetAxisRaw` retorna un solo valor, ya sea (0), (-1) o (1), lo cual puede verse como un movimiento más brusco o inmediato.

  - Cuál se deberia usar? (Pregunta capciosa...).

    - Depende de lo que se quiera lograr, si se desea un movimiento suave como caminar o un srpint considero que lo más adecuado es usar `Input.GetAxis`, pero si se quiere realizar un movimiento inmediato como una teletransportación coonsidero que lo más adecuado sería usar `Input.GetAxisRaw`.
  - Qué hace `input.magnitude`? Por qué es util?

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?

    - La normalización consiste en eliminar la magnitud del vector convirtiendolo en unitario, permitiendo obtener su dirección y prescindiendo de la longitud, lo cual es parcularmente util para que los cambios de dirección no afecten la velocidad o aceleración del personaje.

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