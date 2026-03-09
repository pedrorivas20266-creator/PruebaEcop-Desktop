# Sistema de Gestión de Pedidos - Aplicación de Escritorio

Aplicación Windows Forms para la gestión de clientes, productos y pedidos, conectada a un backend mediante API REST.

## Tecnologías Utilizadas

- **.NET Framework 4.8** - Framework principal de la aplicación
- **Windows Forms** - Interfaz gráfica de usuario
- **MetroFramework** - Librería UI para el diseño moderno de formularios
- **Newtonsoft.Json** - Serialización y deserialización de datos JSON
- **HttpClient** - Comunicación con la API REST del backend
- **System.Configuration** - Manejo de configuraciones de la aplicación

## Patrón de Diseño

El proyecto implementa el patrón **MVP (Model-View-Presenter)** para separar las responsabilidades y facilitar el mantenimiento del código.

### Estructura del Patrón

- **Model**: Representan los datos y la lógica de negocio (DTOs, entidades, enums)
- **View**: Interfaces gráficas que muestran los datos al usuario y capturan sus acciones
- **Presenter**: Actúa como intermediario entre la vista y los servicios, manejando la lógica de presentación

Además, se utiliza el patrón **Service Layer** para abstraer la comunicación con la API, y **Dependency Injection** mediante el ServiceLocator para inyectar las dependencias necesarias.

## Estructura del Proyecto

## Configuración del Backend

Para conectar la aplicación con el backend, es necesario modificar la URL base de la API en el archivo `App.config`.

### Cómo cambiar la URL del backend:

1. Abre el archivo `App.config` ubicado en la raíz del proyecto

2. Busca la sección `<appSettings>` y modifica el valor de `ApiBaseUrl`:
