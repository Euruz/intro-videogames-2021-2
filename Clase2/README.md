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

GetAxisRaw no tiene un escalamiento o suavizado de movimiento. Solo toma valores absolutos -1, 0, 1.
GetAxis hace una interpolación o suavizado para el cambio de movimiento. Toma valores decimales entre -1 y 1.

  - Cuál se deberia usar? (Pregunta capciosa...).

Depende de lo que se quiera. Si se quiere verificar que el usuario esté ingresando algún input (oprimiendo alguna tecla), es recomendable usar Input.GetAxisRaw.
Si en cambio solo se requiere tomar un "valor" de movimiento o desplazamiento, se debería usar Input.GetAxis.

  - Qué hace `input.magnitude`? Por qué es util?

Detecta si el usuario está oprimiento alguna tecla, es decir, si el input tiene algún valor, para así determinar si es necesario ejecutar determinada acción al respecto
(reproducir animaciones, sonidos, ejecutar movimiento, etc).

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?

Normalizar un vector es cambiar el valor de su magnitud a 1. Esto es útil para "deshacerse" de valores extras y tener mayor control en los cálculos  (velocidad, direccionalidad) y el propio movimiento.

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