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
  - Cuál se deberia usar? (Pregunta capciosa...).
  - Qué hace `input.magnitude`? Por qué es util?
  - Que significa normalizar un Vector (`Normalize`)? Por qué es util cuando se trabaja con movimiento?
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

Solución taller 2 by jledesmap:

1. GetAxis y GetAxisRaw son funciones de Unity que toman valores entre [1,1] con 0 como posición inicial/neutral, utiliza los Inputs del Mouse, Joystick y Teclado.

GetAxis y GetAxisRaw se diferencian en que el primero varia su valor de manera fluida y paulatina, se puede percibir intuitivamente que el cambio de los valores se adapta al movimiento igualmente fluido de las palancas del joystick o el desplazamiento del Mouse, para el caso del teclado se percibe como un incremento en medida que la tecla lleva tiempo presionada. GetAxisRaw varía entre -1, 0 y 1 en forma de "escalera" o "interruptor", sin interpolar los valores que están entre estos.

2. Depende del caso específico la función que vayamos a usar, una puede desempeñarse mejor que la otra en algunos casos, pero en general ambas son útiles. Tratándose de experiencia de usuario y movimiento: GetAxis puede brindar una mejor sensación de control sobre, por ejemplo, el personaje jugable, mientras que GetaxisRaw terminara dando movimientos más erráticos.

3. La función Magnitude evalúa un vector y retorna el valor de su longitud, siendo esta definida como "la raíz cuadrada de la suma de los cuadrados de cada componente del vector".

||(x, y, z, ... ,n)|| = √(x^2 + y^2 + z^2 + ... + n^2)

4. La función Normalize evalúa un vector y devuelve otro con igual dirección, pero de longitud 1, este tipo de vectores son conocidos como vectores unitarios. Esta función permite concentrarse solo en la dirección, ignorando la información sobre la magnitud y es la base para hacer cálculos de movimiento de forma intuitivamente consistente.
