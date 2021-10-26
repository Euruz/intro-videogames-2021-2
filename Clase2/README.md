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
	R/ La diferencia entre estas dos clases de Unity, es que el Input.GetAxis, entrega valores dependiendo del tipo de control que se esté usando para jugar. 
	Por ejemplo para un joystick solo podrá tener valores de -1, 0 y 1, lo que significa que el control se movió a la derecha, a la izquierda, o que 
	directamente no se movió. Si el movimiento del personaje se va a hacer con el mouse, el valor ya no estará en el rango entre -1 y 1, sinó que dependerá
	del "delta" del mouse y de la sensibilidad del eje definido (vertical, horizontal o profundidad). Es útil porque se pueden definir los controles y tamaños.
	Por otro lado, la clase Input.GetAxisRaw entrega siempre -1, 0 y 1, independientemente del tipo de control que se esté usando. 


  - Cuál se deberia usar? (Pregunta capciosa...).
	R/ La clase a usar dependerá directamente de la apicación que se tenga, si solo importa la dirección en la que se moverá el personaje, es indiferente cual
	de los dos se use. Pero si se busca una mayor presición en el movimiento, como por ejemplo en jugos donde se tiene vista de primera persona y se quiere
	hacer un barrido de todo el campo visual, sería preferible usar Input.GetAxis	

  - Qué hace `input.magnitude`? Por qué es util?
	R/ Esta clase entrega por respuesta la magnitud de un vector, es decir, su longitud. Es útil para calibrar rangos de movimiento de los personajes con base
	en el sistema de coordenadas establecido. 

  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
	R/ Significa mantener su dirección, pero hacer su longitud igual a 1. Esto funciona muy bien a la hora de hacer operaciones con vectores en las cuales es 
	irrelevante su longitud y solo importa su dirección. Así pues, se hace la operación y luego simplemente se hace una multiplicación por escalar, por el 
	valor de su magnitud, que puede ser obtenida con el input.magnitude

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