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
    - `Input.GetAxis` retorna un número entre -1 y 1 suavizado dándo la oportunidad de obtener un aumento paulatino de la cifra, mientras que `Input.GetAxisRaw` es un salto inmediato de -1 a 0 y de 0 a 1. Esto anterior para un teclado, en control da medidas iguales con los dos métodos
  - Cuál se deberia usar? (Pregunta capciosa...).
    - Depende del caso y lo que se quiera, por ejemplo, en un salto, solo se necesita saber si saltó o no, pero en algo como la aceleración de un carro, importa saber qué tanto acelera.
  - Qué hace `input.magnitude`? Por qué es util?
    - Es la longitud de un vector, tomando el ejemplo de una flecha que está lanzando un personaje aparte de saber la trayectoria, es útil saber qué tan fuerte o suave se está lanzando, ahí entra a jugar la magnitud. 
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
    - Reduce o aumenta la magnitud de un vector a 1, igual que en geometría, es útil en casos en los que se está acumulando algo, para evitar descontrol en los movimientos
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