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
    La diferencia es que GetAxis varía entre 0 y 1 o entre 0 y -1 de forma gradual, mientras que GetAxisRaw toma únicamente los valores -1, 0, o 1 de forma instantánea.
  - Cuál se deberia usar? (Pregunta capciosa...).  
    El uso de uno u otro dependerá de lo que se quiera lograr. Si se quiere que el input se refleje de manera instantánea, es buena idea usar GetAxisRaw. Si se desea que el input se detecte de una forma más "suave", es mejor usar GetAxis.
  - Qué hace `input.magnitude`? Por qué es util?  
    El atributo "magnitude" retorna la longitud (o magnitud) de un vector. Por ejemplo, para un vector de 2 componentes (x, y), esta es calculada como la raíz cuadrada de (x * x + y * y). Esto puede ser útil, por ejemplo, para determinar la distancia de algún objeto respecto al origen, o respecto a algún punto determinado.
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?  
    Normalizar un vector significa transformarlo en un vector que tenga la misma dirección y sentido, pero que tenga una longitud igual a 1. Como los vectores normalizados conservan la dirección del vector original mas no la magnitud, pueden ser útiles para expresar la dirección en la cual se debe realizar el movimiento, sin que se afecten otros factores de este como la velocidad o aceleración.
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
