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
	R: El 'Input.GetAxis' incrementa o disminuye gradualmente el valor entre 0 y 1 o entre 0 y -1, haciendo que el cambio sea suave, mientras que 'Input.GetAxisRaw' otorga los valores exactos de 0, 1 y -1, teniendo un cambio inmediato.
  - Cuál se deberia usar? (Pregunta capciosa...).
	R: Para juegos 3D sería más recomendable usar el 'Input.GetAxis' debido a que genera mayor fluidez y control del movimiento, mientras que el 'Input.GetAxisRaw' puede resultar útil en algunos juegos 2D donde se requiere saber solo el cambio de dirección que hace el jugador, como por ejemplo Pacman o Snake.
  - Qué hace `input.magnitude`? Por qué es util?
	R: Devuelve la longitud de un vector. Se pueden hacer cálculos con la magnitud de este vector, por ejemplo, saber si un jugador se está desplazando, mostrar en pantalla la velocidad a la que se desplaza en el juego, y dependiendo de que se alcance cierta velocidad, se puedan desbloquear nuevas funciones.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
	R: Significa obtener la dirección del vector original, con un nuevo vector que es unitario (magnitud 1). Al trabajar con movimiento, es útil para realizar operaciones con la dirección del vector sin que se afecten otras unidades como la velocidad o aceleración.
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