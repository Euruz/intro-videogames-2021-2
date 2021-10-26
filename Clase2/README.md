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
    Respuesta: GetAxis toma valores entre -1 y 1 (incluyendo los decimales en medio) pero GetAxisRaw solo toma -1 y 1, por ejemplo con GetAxis al presionar D va desde 0 y pasa por varios decimales hasta llegar a 1, con GetAxisRaw cambia de 0 directamente a 1.
  - Cuál se deberia usar? (Pregunta capciosa...).
    Respuesta: Depende de como se quiere implementar el movimiento, GetAxis serviría por ejemplo si queremos que la velocidad del movimiento usando la palanca de un control dependa de que tanto empujamos la palanca, si no nos interesa que tanto se movio la palanca y el movimiento va a ser igual incluso si la palanca no se empuja tanto como se puede, entonces GetAxisRaw es suficiente.
  - Qué hace `input.magnitude`? Por qué es util?
    Respuesta: devuelve la magnitud (longitud) del vector input, en este caso es útil para saber si el valor del eje vertical u horizontal ha cambiado y así establecer si habrá movimiento o no.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    Respuesta: Normalizar un vector es dividir el vector entre su magnitud para convertirlo en un vector de magnitud 1 que vaya en la misma dirección del vector con el que estamos trabajando, es útil para usar la dirección de un vector sin tener valores extras que pueden afectar cálculos.
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