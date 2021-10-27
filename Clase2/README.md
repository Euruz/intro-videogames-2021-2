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

  ```
    Sabemos que el valor de Input.GetAxis e Input.GetAxisRaw oscila entre -1 y 1. 
    
    Input.GetAxisRaw obtiene el valor 'puro' del dispositivo de entrada, mientras que Input.GetAxis aplica un filtro que no deja que el valor llegue de gople a -1 o 1 realizando aumentos o decrecimientos graduales. Esto se ve de mejor forma cuando vamos a usar un teclado o dispositivo que no poseea un sensor de presión o fuerza.
  ```
  - Cuál se deberia usar? (Pregunta capciosa...).
  ```  
    Si se requiere mayor control sobre la entrada del dispositivo, se debería usar Input.GetAxisRaw.    
  ```
  - Qué hace `input.magnitude`? Por qué es util?
  ```  
    Nos permite saber si hay movimiento.  
  ```
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
   ```  
    Básicamente es desechar la magnitud para solo quedarnos con la información de la dirección y es útil porque nos facilita los cálculos, adicionalmente logrando establecer una nueva magnitud del mismo sin alterar su dirección.    
  ```
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