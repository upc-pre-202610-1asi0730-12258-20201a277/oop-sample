 # Guion para la Lección 6: Consejos, errores comunes y próximos pasos

## Inicio de la lección

Hola a todos. Bienvenidos a la lección 6. En la lección anterior construimos una página llamada **“Mi Perfil Digital”**, usando HTML y CSS. Esa página tenía una tarjeta de perfil con una imagen, un título, un subtítulo, una lista de intereses y un botón que nos llevaba a GitHub.

En esta última lección no vamos a crear una página totalmente nueva desde cero. Lo que haremos será revisar el proyecto que ya tenemos, entender por qué funciona, ver algunos errores comunes que pueden aparecer y aprender pequeñas mejoras que podemos aplicar para que nuestro código sea más claro, más ordenado y más fácil de mantener.

Esto es importante porque, cuando uno recién empieza, no basta con que la página “se vea bonita”. También debemos aprender a revisar nuestro código, corregir errores y entender qué parte cumple cada función. Esa es una habilidad básica para seguir avanzando en desarrollo web.

---

## Parte 1: Recordemos qué hicimos en la lección anterior

Primero, vamos a recordar la estructura general de nuestra página. En HTML colocamos el contenido. Es decir, colocamos la imagen, el título, el texto, la lista de intereses y el enlace. Luego, con CSS, le dimos estilo: centramos la tarjeta, agregamos colores, bordes, sombras, redondeamos la imagen y creamos un efecto cuando el mouse pasa por encima del botón.

Podemos pensar en HTML y CSS de esta manera: HTML es como el esqueleto de la página, porque organiza las partes principales. CSS es como la ropa o el diseño visual, porque cambia cómo se ve cada elemento.

Ahora vamos a mirar el HTML base que venimos usando.

```html
<!-- Este es el documento principal de la página -->
<!DOCTYPE html>
<html lang="es">
<head>
  <!-- Permite usar caracteres especiales como tildes y ñ -->
  <meta charset="UTF-8">

  <!-- Hace que la página se adapte mejor a celulares y computadoras -->
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <!-- Título que aparece en la pestaña del navegador -->
  <title>Mi Perfil Digital</title>

  <!-- Conectamos el archivo CSS con el HTML -->
  <link rel="stylesheet" href="style.css">
</head>
<body>

  <!-- Esta es la tarjeta principal del perfil -->
  <div class="tarjeta-perfil">
    
    <!-- Imagen de perfil -->
    <img src="https://avatar.iran.liara.run/public/60" alt="Foto de perfil" class="foto-perfil">
    
    <!-- Título principal -->
    <h1>Hola, soy [Tu Nombre]</h1>

    <!-- Subtítulo de la tarjeta -->
    <p class="subtitulo">Estudiante de Secundaria y Aprendiz Web</p>
    
    <hr>

    <!-- Sección de intereses -->
    <h3>Mis intereses:</h3>

    <ul class="lista-intereses">
      <li>Desarrollo de videojuegos y tecnología</li>
      <li>Práctica de deportes y actividades al aire libre</li>
      <li>Lectura y diseño de páginas web</li>
    </ul>

    <!-- Enlace con apariencia de botón -->
    <a href="https://github.com" target="_blank" class="boton-enlace">Ver mi GitHub</a>

  </div>

</body>
</html>
```

En este ejemplo podemos ver algo importante: cada parte tiene una función. El `h1` sirve para el título principal. El párrafo con clase `subtitulo` sirve para una descripción corta. La lista `ul` sirve para mostrar varios intereses. Y el enlace `a` sirve para llevarnos a otra página, en este caso GitHub.

Una buena práctica es leer nuestro HTML como si fuera una historia ordenada. Primero aparece la imagen, luego el nombre, luego una descripción, luego los intereses y finalmente el botón. Si nuestro código se puede leer con facilidad, también será más fácil corregirlo después.

---

## Parte 2: Revisemos el CSS principal

Ahora vamos a revisar el CSS. Recordemos que CSS es el lenguaje que usamos para darle estilo a la página. En nuestro proyecto, el CSS permite que la tarjeta quede centrada, que el fondo tenga un degradado, que la imagen sea circular y que el botón cambie de color al pasar el mouse.

Vamos a mirar el CSS base.

```css
/* Configuración del fondo general de la página */
body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: linear-gradient(135deg, #74b9ff, #a29bfe);

  /* Centramos la tarjeta horizontal y verticalmente */
  display: flex;
  justify-content: center;
  align-items: center;

  height: 100vh;
  margin: 0;
}

/* Contenedor principal en forma de tarjeta */
.tarjeta-perfil {
  background-color: #ffffff;
  border-radius: 20px;
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.15);
  padding: 30px;
  max-width: 350px;
  text-align: center;
  border: 3px solid #6c5ce7;
}

/* Estilo para redondear la imagen de perfil */
.foto-perfil {
  width: 100px;
  height: 100px;
  border-radius: 50%;
  border: 4px solid #6c5ce7;
  background-color: #f5f5f5;
}

/* Estilos de texto */
h1 {
  color: #2d3436;
  font-size: 24px;
  margin: 15px 0 5px 0;
}

.subtitulo {
  color: #636e72;
  font-size: 14px;
  margin-bottom: 20px;
}

hr {
  border: 0;
  height: 1px;
  background-color: #dfe6e9;
  margin: 20px 0;
}

h3 {
  color: #6c5ce7;
  font-size: 16px;
  text-align: left;
}

/* Lista de intereses sin viñetas predeterminadas */
.lista-intereses {
  list-style: none;
  padding: 0;
  text-align: left;
}

.lista-intereses li {
  margin-bottom: 10px;
  font-size: 14px;
  color: #2d3436;
}

/* Botón interactivo inferior */
.boton-enlace {
  display: inline-block;
  margin-top: 20px;
  padding: 10px 20px;
  background-color: #6c5ce7;
  color: white;
  text-decoration: none;
  border-radius: 25px;
  font-weight: bold;
  transition: background 0.3s ease;
}

/* Cambio de color interactivo al pasar el cursor */
.boton-enlace:hover {
  background-color: #5352ed;
}
```

Aquí podemos destacar varias cosas. Primero, el `body` usa `display: flex`, `justify-content: center` y `align-items: center`. Esto sirve para centrar la tarjeta en la pantalla. Es una forma muy común de centrar elementos usando CSS.

Segundo, la clase `.tarjeta-perfil` controla la caja blanca donde está todo nuestro contenido. Tiene fondo blanco, bordes redondeados, sombra, espacio interno y un ancho máximo. Esto hace que la página se vea como una tarjeta moderna.

Tercero, la clase `.foto-perfil` usa `border-radius: 50%`. Eso convierte la imagen en un círculo. Si quitamos esa línea, la imagen volvería a verse cuadrada o rectangular.

Y cuarto, el botón realmente es un enlace. En HTML usamos la etiqueta `a`, pero en CSS le damos apariencia de botón usando color de fondo, borde redondeado, padding y texto blanco.

---

## Parte 3: Primer consejo — revisar que HTML y CSS estén conectados

Uno de los errores más comunes cuando comenzamos es escribir el HTML y el CSS correctamente, pero olvidarnos de conectarlos. Si el CSS no está conectado, la página aparecerá sin estilos. Es decir, se verá como texto normal, sin tarjeta, sin colores y sin diseño.

La línea que conecta el CSS está dentro del `head`.

```html
<!-- Esta línea conecta el archivo style.css con nuestro documento HTML -->
<link rel="stylesheet" href="style.css">
```

Si estamos trabajando en CodePen, normalmente no necesitamos esta línea porque CodePen ya separa automáticamente la zona de HTML y la zona de CSS. Pero si trabajamos con archivos normales, por ejemplo `index.html` y `style.css`, entonces esta línea sí es necesaria.

Un error común sería escribir mal el nombre del archivo.

```html
<!-- Error: el archivo se llama style.css, pero aquí escribimos estilos.css -->
<link rel="stylesheet" href="estilos.css">
```

En ese caso, el navegador busca un archivo llamado `estilos.css`. Si ese archivo no existe, el diseño no se aplicará.

La forma correcta sería:

```html
<!-- Correcto: el nombre coincide con el archivo real -->
<link rel="stylesheet" href="style.css">
```

Entonces, primera recomendación: si tu página no tiene estilos, revisa primero si el HTML está conectado correctamente con el CSS.

---

## Parte 4: Segundo consejo — usar nombres de clases claros

Otro consejo importante es usar nombres de clases que se entiendan fácilmente. En nuestro código usamos nombres como `tarjeta-perfil`, `foto-perfil`, `lista-intereses` y `boton-enlace`.

Estos nombres son buenos porque nos dicen qué representa cada elemento. Por ejemplo, si leemos `tarjeta-perfil`, entendemos que es la tarjeta principal. Si leemos `foto-perfil`, entendemos que es la imagen del perfil.

Veamos este ejemplo.

```html
<!-- Buen nombre de clase: se entiende qué representa -->
<div class="tarjeta-perfil">
  <h1>Hola, soy Ana</h1>
</div>
```

```css
/* El CSS usa exactamente el mismo nombre de clase */
.tarjeta-perfil {
  background-color: white;
  padding: 30px;
  border-radius: 20px;
}
```

Ahora veamos un ejemplo menos recomendable.

```html
<!-- Nombre poco claro -->
<div class="caja1">
  <h1>Hola, soy Ana</h1>
</div>
```

```css
/* Funciona, pero el nombre no explica mucho */
.caja1 {
  background-color: white;
  padding: 30px;
  border-radius: 20px;
}
```

Aunque `caja1` puede funcionar, no es tan claro. Si después tenemos `caja2`, `caja3` y `caja4`, puede ser difícil recordar qué hace cada una.

Por eso es mejor usar nombres que expliquen la función del elemento. Cuando nuestro proyecto crezca, esto nos ayudará mucho.

---

## Parte 5: Tercer consejo — revisar que las clases coincidan

Ahora vamos a ver un error muy común: escribir una clase con un nombre en HTML y con otro nombre en CSS.

Por ejemplo, en nuestro HTML tenemos esto:

```html
<!-- En HTML la clase se llama tarjeta-perfil -->
<div class="tarjeta-perfil">
  <h1>Hola, soy Ana</h1>
</div>
```

Entonces, en CSS debemos escribir exactamente el mismo nombre:

```css
/* Correcto: el nombre coincide con el HTML */
.tarjeta-perfil {
  background-color: white;
  border-radius: 20px;
  padding: 30px;
}
```

Pero si escribimos esto:

```css
/* Error: esta clase no existe en el HTML */
.tarjeta {
  background-color: white;
  border-radius: 20px;
  padding: 30px;
}
```

El navegador no aplicará esos estilos a la tarjeta, porque en el HTML no existe una clase llamada `tarjeta`. La clase se llama `tarjeta-perfil`.

Esto es como llamar a una persona por un nombre que no tiene. Si el nombre no coincide, no responde. En CSS pasa lo mismo: si el selector no coincide con el HTML, el estilo no se aplica.

También es importante recordar que cuando usamos clases en CSS, debemos poner un punto antes del nombre.

```css
/* Correcto: el punto indica que estamos usando una clase */
.boton-enlace {
  background-color: #6c5ce7;
}
```

Pero esto estaría mal:

```css
/* Error: falta el punto antes del nombre de la clase */
boton-enlace {
  background-color: #6c5ce7;
}
```

El punto es pequeño, pero muy importante.

---

## Parte 6: Cuarto consejo — cuidar las imágenes y el atributo alt

En nuestra página usamos una imagen de perfil. La imagen tiene dos partes importantes: el `src` y el `alt`.

```html
<!-- src indica la ruta de la imagen y alt describe la imagen -->
<img src="https://avatar.iran.liara.run/public/60" alt="Foto de perfil" class="foto-perfil">
```

El atributo `src` indica de dónde viene la imagen. En este caso, usamos una imagen desde internet. El atributo `alt` sirve para describir la imagen. Esto es útil si la imagen no carga o si una persona usa un lector de pantalla.

Un error común sería dejar el `alt` vacío o no ponerlo.

```html
<!-- No recomendado: falta una descripción clara de la imagen -->
<img src="https://avatar.iran.liara.run/public/60" class="foto-perfil">
```

Una mejor versión sería:

```html
<!-- Mejor: la imagen tiene una descripción -->
<img src="https://avatar.iran.liara.run/public/60" alt="Avatar de mi perfil digital" class="foto-perfil">
```

También podemos mejorar el texto del `h1`. En la lección 5 aparece como `[Tu Nombre]`, porque era una plantilla. Pero al personalizarlo, cada estudiante puede colocar su propio nombre.

```html
<!-- Antes: texto de plantilla -->
<h1>Hola, soy [Tu Nombre]</h1>
```

```html
<!-- Después: texto personalizado -->
<h1>Hola, soy Camila</h1>
```

Esto hace que la página ya no se sienta como una plantilla vacía, sino como un perfil real.

---

## Parte 7: Quinta recomendación — mejorar la lista de intereses

La lista de intereses es una buena parte de nuestra página porque permite mostrar información personal de forma ordenada.

En el código original tenemos esto:

```html
<h3>Mis intereses:</h3>

<ul class="lista-intereses">
  <li>Desarrollo de videojuegos y tecnología</li>
  <li>Práctica de deportes y actividades al aire libre</li>
  <li>Lectura y diseño de páginas web</li>
</ul>
```

Esta lista está bien porque usa `ul` para una lista no ordenada y `li` para cada elemento. Es decir, cada interés está separado.

Podríamos personalizarla según cada estudiante. Por ejemplo:

```html
<!-- Ejemplo personalizado de intereses -->
<h3>Mis intereses:</h3>

<ul class="lista-intereses">
  <li>Crear páginas web sobre mis videojuegos favoritos</li>
  <li>Aprender diseño para mejorar mis proyectos</li>
  <li>Compartir mis trabajos en internet</li>
</ul>
```

También podemos mejorar visualmente la lista desde CSS. En el código original se quitaron las viñetas con `list-style: none`. Eso hace que la lista se vea más limpia.

```css
/* Quitamos las viñetas y alineamos el texto a la izquierda */
.lista-intereses {
  list-style: none;
  padding: 0;
  text-align: left;
}
```

Pero si queremos que cada elemento tenga un pequeño símbolo visual, podemos hacerlo escribiendo un carácter directamente en el HTML.

```html
<!-- Ejemplo simple usando símbolos en el texto -->
<ul class="lista-intereses">
  <li>• Crear páginas web personales</li>
  <li>• Aprender diseño con CSS</li>
  <li>• Compartir proyectos en GitHub</li>
</ul>
```

No es obligatorio, pero puede ayudar a que la lista se vea más clara para el usuario.

---

## Parte 8: Sexta recomendación — entender el botón y el hover

Ahora vamos a revisar el botón inferior. En realidad, no es un botón con la etiqueta `button`. Es un enlace con la etiqueta `a`, pero CSS lo hace parecer un botón.

```html
<!-- Este enlace parece botón gracias al CSS -->
<a href="https://github.com" target="_blank" class="boton-enlace">Ver mi GitHub</a>
```

Aquí, `href` indica la dirección a la que queremos ir. `target="_blank"` hace que el enlace se abra en una pestaña nueva. Y `class="boton-enlace"` sirve para aplicarle estilos.

El CSS del botón es este:

```css
/* Estilo principal del enlace convertido en botón */
.boton-enlace {
  display: inline-block;
  margin-top: 20px;
  padding: 10px 20px;
  background-color: #6c5ce7;
  color: white;
  text-decoration: none;
  border-radius: 25px;
  font-weight: bold;
  transition: background 0.3s ease;
}

/* Efecto cuando pasamos el mouse encima */
.boton-enlace:hover {
  background-color: #5352ed;
}
```

La parte más interesante es `:hover`. Esto significa: “cuando el usuario pasa el mouse por encima”. En nuestro caso, el botón cambia de color.

Podemos probar una mejora pequeña. Por ejemplo, también podemos hacer que el botón suba un poquito cuando el usuario pasa el mouse.

```css
/* Versión mejorada del botón */
.boton-enlace {
  display: inline-block;
  margin-top: 20px;
  padding: 10px 20px;
  background-color: #6c5ce7;
  color: white;
  text-decoration: none;
  border-radius: 25px;
  font-weight: bold;

  /* Ahora la transición afecta color y movimiento */
  transition: background 0.3s ease, transform 0.3s ease;
}

/* Al pasar el mouse, cambia el color y sube un poco */
.boton-enlace:hover {
  background-color: #5352ed;
  transform: translateY(-3px);
}
```

Esta mejora es pequeña, pero hace que la página se sienta más interactiva. No estamos usando JavaScript, solo CSS.

---

## Parte 9: Séptima recomendación — hacer la tarjeta más adaptable

Una mejora importante es hacer que la tarjeta se vea bien en pantallas pequeñas. Nuestro código ya tiene una base buena porque usa `max-width: 350px`. Eso significa que la tarjeta puede tener un ancho máximo, pero no necesariamente ocupará toda la pantalla.

Sin embargo, podemos mejorarla agregando `width`.

```css
/* Mejoramos la tarjeta para que se adapte mejor a pantallas pequeñas */
.tarjeta-perfil {
  background-color: #ffffff;
  border-radius: 20px;
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.15);
  padding: 30px;

  /* La tarjeta ocupa el 90% disponible, pero no pasa de 350px */
  width: 90%;
  max-width: 350px;

  text-align: center;
  border: 3px solid #6c5ce7;
}
```

Con esto, si alguien abre la página desde un celular, la tarjeta no chocará tan fácilmente con los bordes. Ocupará hasta el 90% del espacio disponible, pero sin hacerse demasiado grande.

También podemos cambiar el `height: 100vh` del `body` por `min-height: 100vh`. Esto puede ser útil si el contenido crece.

```css
/* Antes */
body {
  height: 100vh;
}

/* Mejor */
body {
  min-height: 100vh;
}
```

La diferencia es sencilla. `height: 100vh` obliga al body a medir exactamente el alto de la pantalla. En cambio, `min-height: 100vh` dice que como mínimo mida el alto de la pantalla, pero si el contenido necesita más espacio, puede crecer.

Entonces, una versión mejorada del `body` sería:

```css
/* Fondo general mejorado */
body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: linear-gradient(135deg, #74b9ff, #a29bfe);
  display: flex;
  justify-content: center;
  align-items: center;

  /* Mejor que height cuando puede haber más contenido */
  min-height: 100vh;

  margin: 0;
}
```

---

## Parte 10: Errores comunes y cómo corregirlos

Ahora vamos a revisar algunos errores comunes que pueden pasar en este proyecto.

El primer error es olvidar cerrar etiquetas. En HTML, muchas etiquetas tienen apertura y cierre. Por ejemplo, si abrimos un título con `<h1>`, debemos cerrarlo con `</h1>`.

```html
<!-- Error: falta cerrar el h1 -->
<h1>Hola, soy Camila
```

La forma correcta sería:

```html
<!-- Correcto: el h1 tiene apertura y cierre -->
<h1>Hola, soy Camila</h1>
```

Otro error común es escribir mal una etiqueta. Por ejemplo:

```html
<!-- Error: title está mal escrito -->
<tilte>Mi Perfil Digital</tilte>
```

La forma correcta es:

```html
<!-- Correcto -->
<title>Mi Perfil Digital</title>
```

Otro error común es olvidar las comillas en los atributos.

```html
<!-- No recomendado: faltan comillas -->
<img src=https://avatar.iran.liara.run/public/60 alt=Foto de perfil>
```

La forma correcta es:

```html
<!-- Correcto: los valores de los atributos van entre comillas -->
<img src="https://avatar.iran.liara.run/public/60" alt="Foto de perfil">
```

Otro error común es olvidar el punto cuando usamos una clase en CSS.

```css
/* Error: falta el punto */
tarjeta-perfil {
  background-color: white;
}
```

La forma correcta es:

```css
/* Correcto */
.tarjeta-perfil {
  background-color: white;
}
```

Y otro error común es que el enlace no tenga una dirección real.

```html
<!-- Plantilla incompleta -->
<a href="#" class="boton-enlace">Ver mi GitHub</a>
```

Esto puede servir como prueba, pero si queremos que funcione, debemos colocar una dirección real.

```html
<!-- Enlace funcional -->
<a href="https://github.com" target="_blank" class="boton-enlace">Ver mi GitHub</a>
```

Estos errores parecen pequeños, pero pueden hacer que la página no se vea bien o que algunas partes no funcionen. Por eso siempre debemos revisar con calma.

---

## Parte 11: Validar el código

Ahora hablemos de validar. Validar significa revisar si nuestro código está escrito correctamente según las reglas de HTML y CSS.

Cuando recién empezamos, es normal cometer errores. A veces nos falta cerrar una etiqueta, escribimos mal una clase o colocamos una propiedad CSS incorrecta. Para eso existen herramientas online que nos ayudan a revisar.

Una buena costumbre es hacer tres revisiones:

Primero, revisar visualmente la página. Preguntarnos: ¿se ve como esperaba?, ¿la tarjeta está centrada?, ¿la imagen aparece?, ¿el botón funciona?

Segundo, revisar el código. Preguntarnos: ¿cerré bien las etiquetas?, ¿los nombres de las clases coinciden?, ¿el CSS está bien escrito?

Tercero, probar en distintos tamaños de pantalla. Por ejemplo, podemos reducir el ancho del navegador para ver cómo se vería en un celular.

En CodePen podemos hacer una revisión rápida mirando el resultado en vivo. Si cambiamos algo en el HTML o en el CSS, podemos ver el resultado inmediatamente. Esa es una ventaja para aprender.

---

## Parte 12: Versión final mejorada del HTML

Ahora voy a mostrar una versión ligeramente mejorada del HTML. No cambia la idea original del proyecto, solo lo deja un poco más personalizado y claro.

```html
<!-- Documento HTML de la página Mi Perfil Digital -->
<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">

  <!-- Ayuda a que la página se adapte a diferentes pantallas -->
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <title>Mi Perfil Digital</title>

  <!-- En CodePen esta línea no es necesaria, pero en archivos normales sí -->
  <link rel="stylesheet" href="style.css">
</head>
<body>

  <!-- Tarjeta principal del perfil -->
  <div class="tarjeta-perfil">
    
    <!-- Imagen de perfil con texto alternativo -->
    <img 
      src="https://avatar.iran.liara.run/public/60" 
      alt="Avatar de mi perfil digital" 
      class="foto-perfil"
    >
    
    <!-- Nombre del estudiante -->
    <h1>Hola, soy Camila</h1>

    <!-- Descripción corta -->
    <p class="subtitulo">Estudiante de Secundaria y Aprendiz Web</p>
    
    <hr>

    <!-- Lista de intereses personales -->
    <h3>Mis intereses:</h3>

    <ul class="lista-intereses">
      <li>Crear páginas web personales</li>
      <li>Aprender diseño con CSS</li>
      <li>Compartir mis proyectos en GitHub</li>
    </ul>

    <!-- Enlace externo con apariencia de botón -->
    <a href="https://github.com" target="_blank" class="boton-enlace">
      Ver mi GitHub
    </a>

  </div>

</body>
</html>
```

En esta versión cambiamos `[Tu Nombre]` por un nombre real. También mejoramos el texto alternativo de la imagen y ajustamos los intereses para que estén más conectados con el curso.

---

## Parte 13: Versión final mejorada del CSS

Ahora veamos una versión mejorada del CSS. La idea original se mantiene, pero agregamos algunas mejoras pequeñas: mejor adaptación a pantallas pequeñas y un efecto más dinámico en el botón.

```css
/* Fondo general de la página */
body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;

  /* Fondo con degradado */
  background: linear-gradient(135deg, #74b9ff, #a29bfe);

  /* Centramos la tarjeta */
  display: flex;
  justify-content: center;
  align-items: center;

  /* Permite que la página crezca si el contenido aumenta */
  min-height: 100vh;

  margin: 0;
}

/* Tarjeta principal del perfil */
.tarjeta-perfil {
  background-color: #ffffff;
  border-radius: 20px;

  /* Sombra suave */
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.15);

  padding: 30px;

  /* Mejor adaptación a pantallas pequeñas */
  width: 90%;
  max-width: 350px;

  text-align: center;
  border: 3px solid #6c5ce7;
}

/* Imagen de perfil circular */
.foto-perfil {
  width: 100px;
  height: 100px;

  /* Convierte la imagen en círculo */
  border-radius: 50%;

  border: 4px solid #6c5ce7;
  background-color: #f5f5f5;
}

/* Título principal */
h1 {
  color: #2d3436;
  font-size: 24px;
  margin: 15px 0 5px 0;
}

/* Subtítulo */
.subtitulo {
  color: #636e72;
  font-size: 14px;
  margin-bottom: 20px;
}

/* Línea separadora */
hr {
  border: 0;
  height: 1px;
  background-color: #dfe6e9;
  margin: 20px 0;
}

/* Título de la sección de intereses */
h3 {
  color: #6c5ce7;
  font-size: 16px;
  text-align: left;
}

/* Lista de intereses */
.lista-intereses {
  list-style: none;
  padding: 0;
  text-align: left;
}

/* Cada elemento de la lista */
.lista-intereses li {
  margin-bottom: 10px;
  font-size: 14px;
  color: #2d3436;
}

/* Enlace con apariencia de botón */
.boton-enlace {
  display: inline-block;
  margin-top: 20px;
  padding: 10px 20px;

  background-color: #6c5ce7;
  color: white;

  text-decoration: none;
  border-radius: 25px;
  font-weight: bold;

  /* Transición suave para color y movimiento */
  transition: background 0.3s ease, transform 0.3s ease;
}

/* Efecto al pasar el cursor */
.boton-enlace:hover {
  background-color: #5352ed;

  /* El botón sube un poco */
  transform: translateY(-3px);
}
```

Esta versión sigue siendo sencilla, pero ya tiene mejores prácticas. La tarjeta se adapta mejor a pantallas pequeñas y el botón tiene un efecto más visible.

---

## Parte 14: Próximos pasos para seguir aprendiendo

Para terminar, pensemos en qué podríamos aprender después de crear esta página.

El primer siguiente paso podría ser aprender más CSS. Por ejemplo, podríamos aprender Flexbox con más profundidad, Grid, animaciones, transiciones y diseño responsive.

El segundo paso podría ser aprender JavaScript. JavaScript nos permitiría hacer que la página reaccione a las acciones del usuario. Por ejemplo, podríamos hacer que un botón cambie el texto, que aparezca un mensaje de bienvenida o que se muestre información adicional.

El tercer paso podría ser aprender a publicar la página. Una opción para eso es GitHub Pages, que permite subir una página sencilla a internet.

Pero lo más importante es practicar. Una buena actividad final sería tomar esta página de perfil y personalizarla: cambiar el nombre, cambiar la imagen, modificar los intereses, probar otros colores y ajustar el botón.

---

## Cierre de la lección

En resumen, en esta lección aprendimos que terminar una página no significa solo verla bonita. También debemos revisar que el código esté ordenado, que el HTML y CSS estén conectados, que los nombres de las clases coincidan, que las imágenes tengan texto alternativo y que la página se pueda adaptar a diferentes pantallas.

También vimos errores comunes, como olvidar cerrar etiquetas, escribir mal una clase, olvidar el punto en CSS o colocar mal el nombre del archivo de estilos.

Con esta página de perfil digital ya tenemos una base importante para seguir aprendiendo desarrollo web. A partir de aquí, podemos mejorar el diseño con más CSS, agregar interactividad con JavaScript y publicar nuestros proyectos en internet.

Gracias por acompañarme en esta última lección. Ahora es tu turno de practicar: abre tu proyecto, cambia los datos por los tuyos, prueba nuevos colores y revisa que todo funcione correctamente.