# Resolución de Examen Técnico - Analista Desarrolladora Jr

Este repositorio contiene la resolución del examen técnico, abarcando:
* Diseño de base de datos con su respectiva normalización y diagrama ER,
* Arquitectura backend de API en capas: Data, Models, Services & Controllers.
* Desarrollo de UI con consumo de API suministrada. 

El objetivo principal de este repositorio es demostrar buenas prácticas de programación, código limpio y separación de responsabilidades.

## Tecnologías utilizadas:

### Base de Datos
* **SQL:** Utilicé Workbench para la creación de tablas, inserción de datos de prueba, consulta requerida y realizar el Diagrama Entidad-Relación. 
Apliqué reglas de normalización 3FN.

### Backend
* **C# / ASP.NET:** Creación de API con arquitectura en capas (Data, Models, Services & Controllers) conectada a la base de datos creada en el punto anterior.
El servicio contiene la funcionalidad requerida: - Obtener la fecha con más ventas.
Además agregué una funcionalidad básica para listar todos los productos.
* ** Swagger UI:** Visual Studio me facilitó ésta herramienta para poder visualizar la API.

### Frontend
* **HTML5 / CSS3 / JavaScript:** Separación estricta de estructura, estilos y lógica.
* **Bootstrap:** Utilizado para garantizar una maquetación ágil, limpia y responsiva en la gestión de empleados.
* **Fetch API:** Consumo asíncrono de servicios REST públicos.

---

## Estructura del Proyecto

El repositorio está dividido en tres carpetas principales correspondientes a los requerimientos del examen:

```text
📁 /1-database
   📄 script_ventas.sql       # Script de creación, inserción y consultas.
   📄 diagrama_DER.png        # Imagen del modelo normalizado.

📁 /2-cartasur-layers
   📁 /Data                   # Capa de persistencia
   📁 /Models                 # Modelos, entidades.
   📁 /Services               # Capa de lógica de negocios.
   📁 /Controllers            # Contiene los endpoints.

📁 /3-frontend
   📄 index.html              # Estructura principal.
      📁 /css                 # Estilos personalizados.
      📁 /js                  # Lógica de gestión en memoria y consumo de API.
      📁 /img                 # Logo.

---

**Romina Avalos;