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
  R// La principal diferencia es que uno me permite hacer moviminetos infinitecimales de 0-1 movimientos suavizados (.getaxis), mientras que el otro solo permite hacer pasos de -1,0,1
  - Cuál se deberia usar? (Pregunta capciosa...).
  R// dependerá del objetivo del juego, pues para jugar la culebrita seria genial el uso de .GetAxisRaw, mientras que para jugar mario cart es necesario tener la suavidad de los controles de derecha  a izquierda del movimiento de los carritos 
  - Qué hace `input.magnitude`? Por qué es util?
  R// permite conocer el valor de la magnitud de un vetor usado, definiendo las referencias de los rangos de movimiento del juego, por ejemplo la magnitud de la aceleracion de un personaje, peude estar dada por la magnitud de un vector 
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
  R// normalizar un vector me permite conocer la direccion en cuestion en la que se desea mover un objeto dentro del juego sin depender de la magnitud de este, odria usarse para posicionar la mira o el escenario de un juego, pues al conocer el sentido y la fuerza con la que se desplaza un personaje, bastaria para moverlo pero podria manipularse a decuadamente su direccion
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