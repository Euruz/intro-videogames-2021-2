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
  - Cuál es la diferencia entre `Input.GetAxis` y `Input.GetAxisRaw`?: Input.GetAxis pasa un valor entre el rango [-1,1] y va incrementando o disminuyendo de poco a poco,
    esto quiere decir que puede devolver el valor 0.5,mientrasque Input.GetAxisRaw solo devuelve los siguiente valores: -1, 0 y 1. 
  - Cuál se deberia usar? (Pregunta capciosa...): Depende de lo que se necesite. Por ejemplo Input.GetAxis se puede usar para dar la sensación de aceleración 
   en el movimiento mientras que Input.GetAxisRaw no la da. Input.GetAxisRaw es util para saber si tengo algún input, es decir si estoy oprimiendo algo.
  - Qué hace `input.magnitude`? Por qué es util?: input.magnitude devuelve la longitud del vector input. Es util para saber si el usuario está oprimiendo una tecla  
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?: normalizar un vector, es hacer que el vector tenga una magnitud
  de 1. Esto es util para sacar la dirección del vector,sirve para hacer cosas relacionadas con el movimiento.Tambien sirve para ver la posición de donde está el jugador.
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