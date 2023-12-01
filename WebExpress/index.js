const express = require('express');
const app = express();
const PORT = 3000;

// Ruta principal
app.get('/', (req, res) => {
  res.send('¡Hola, esta es la ruta principal!');
});

// Ruta secundaria
app.get('/ruta-secundaria', (req, res) => {
  res.send('¡Hola, esta es la ruta secundaria!');
});

// Ruta "about"
app.get('/about', (req, res) => {
  res.send('¡Bienvenido a la página "Acerca de nosotros"!');
});

// Ruta "contact"
app.get('/contact', (req, res) => {
  res.send('¡Encuéntranos en la página de contacto!');
});

// Iniciar el servidor
app.listen(PORT, () => {
  console.log(`Servidor escuchando en el puerto ${PORT}`);
});
