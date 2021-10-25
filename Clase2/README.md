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
    > La diferencia que hay entre estos dos metodos es que Input.GetAxisRaw nos retorna un valor que solo puede estar en {-1, 0, 1} mientras que Input.GetAxis nos da un valor decimal entre [-1, 1] y dependiendo del dispositivo que se este usando este metodo hara una transicion (por ejemplo, en el teclado esta transicion dependera de que tanto tiempo se haya presionado la tecla, mientras que en un joystick dependera de que tanto se ha movido).
  - Cuál se deberia usar? (Pregunta capciosa...).
    > Depende de que tipo del tipo de input que se quiera utilizar, por ejemplo, en un juego por turnos en el cual un jugador solo se puede mover un espacio por turno no tiene sentido usar Input.GetAxis, mientras que en un juego que requiera mas fluidez seria la mejor opcion.
  - Qué hace `input.magnitude`? Por qué es util?
    > Este metodo nos retorna la magnitud del vector y este dato nos sirve para saber si se esta moviendo el personaje.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    > Este metodo normaliza el vector, esto significa que lo convierte en un vector unitario (un vector con magnitud 1), y es util ya que es mucho mas facil trabajar con un vector unitario que con un vector con magnitud mayor (un ejemplo de esto se puede ver en Input.GetAxis e Input.GetAxisRaw, ambos retornan valores entre [-1, 1] y esto nos facilita hacer uso de esta informacion)
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
