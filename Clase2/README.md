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

# Kewin Evers Yagarí 

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
    Input.GetAxis: recibe el valor del eje de entrada y lo procesa como un valor flotante entre -1 a 1 por ejemplo valores como: 0.92.
    Input.GetAxisRaw: recibe el valor del eje de entrada y lo procesa como un valor entero entre -1 a 1. por lo que tendra valores como -1 , 0 y 1
  - Cuál se deberia usar? (Pregunta capciosa...).
    Depende de la funcionalidad que se quiera aplicar y el tipo de entrada que se plantee para el juego, ejemplo de ello es si la funcionalidad a implementar es hacer que un personaje camine o corra dependiendo 
    de la "intensidad" que un jugador usa sobre el joystick de un control, en ese caso se usuaria el Ingut.GetAxis. En un caso en donde el solo oprimir control implica movimiento o una acción, entonces se puede usar
    el InputGetAxisRaw.
  - Qué hace `input.magnitude`? Por qué es util?
    Input magnitude mide la magnitud del vector de entrada. Es decir que retorna la velocidad del vector de movimiento como un valor escalar (Es decir sin importar la dirección a la que vaya), y esto es útil porque se valida que la velocidad del vector input sea mayor a cero para así poder realizar el movimiento del objeto
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?

    Normalizar un vector, es obtener un vector unitario, es decir obtenemos un vector cuya magnitud es 1. Este es útil porque nos indica la dirección de un vector, en el caso del movimiento si queremos saber a que dirección va un objeto. Esto es útil en caso de que queramos implementar alguna acción que necesite de la dirección a la que va el personaje. Ejemplo tirar objectos, con un vector unitario podemos saber a que dirección mira el personaje, y con este vector podremos aplicar la fuerza con la que objeto sería lanzado.

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


