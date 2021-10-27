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
    getaxis da un vector con la direccion y magnitud del movimiento, y getaxisraw solo dice si siesta señalando en alguna direccion levantando flags (-1, 0, 1) en las coordenadas del vector de forma discreta.

  - Cuál se deberia usar? (Pregunta capciosa...).
  pues depende de lo que se desee hacer, si solo es confirmar que se esta haciendo un movimiento o si se esta apuntando a una direccion cardinal(arriba, abajo, derecha, izquierda) en especifico pues getaxisraw, sino y lo que se desea es saber la direccion exata a la que se esta apuntando pues se usa getaxis.

  - Qué hace `input.magnitude`? Por qué es util?
  nos da la magnitud del vector de direccion (x^2 + y^2 + z^2)^(1/2).

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
  es reducir la magnitud de ese vector a 1, es util ya que nos permite definir una magnitud escalar especifica sin que la magnitud de la entrada la afecte.

- **Reto (Opcional):** Implementar una mécanica de dash en base al código dado.
  lo implemente, si se unde espacio se hace un dash.

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