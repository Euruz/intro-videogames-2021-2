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

   El Input.GetAxis se emplea para los valores del eje horizontal y vertical ya sea con un joystick o con el mouse. La diferencia entre estos dos es que el GetAxis brinda un valor entre -1 y 1 de manera decimal, mientras GetAxisRaw brinda los valores -1 y 1 indicando simplemente la direccion de movimiento, diciendo si esta oprimido o no.

  - Cuál se deberia usar? (Pregunta capciosa...).

 No hay uno que deba ser usado en todos los casos, depende de la necesidad, si sólo se requiere verificar si se esta presionando una tecla, se emplea GetAxisRaw, mientras Getaxis se emplearia en el caso de ser necesario saber que tanto se esta presionando la tecla y ademas la sensibilidad de la tecla.

  - Qué hace `input.magnitude`? Por qué es util?

  El imput.magnitude me permite saber la magnitud de un vector. Es util para saber si el imput posee algun valor y cual es su magnitud, por lo tanto habrá alguna direccion en x o y.

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?

   Matematicamente normalizar un vector significa tenerlo en un rango comparable con todos los vectores haciendo su magnitud igual a 1, por lo tanto los valores que cambian son los de x y y, empleando las funciones trigonometricas basicas de seno y coseno.
   
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