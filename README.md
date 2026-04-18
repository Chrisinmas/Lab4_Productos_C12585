# Lab 4 — Directorio de Productos

**Estudiante:** Christopher Gabriel Duarte Barahona  
**Carnet:** C12585  
**Curso:** Lenguajes para Aplicaciones Comerciales  
**Universidad:** Universidad de Costa Rica  

---

## Descripción

Aplicación web desarrollada en **ASP.NET Core MVC (.NET 10)** que implementa un directorio de productos con operaciones CRUD completas. Los datos se mantienen en memoria mediante un repositorio estático, siguiendo el patrón Modelo-Vista-Controlador.

---

## Funcionalidades

- Listar todos los productos registrados
- Ver detalles de un producto
- Crear nuevos productos con validación de datos
- Editar productos existentes
- Eliminar productos con confirmación previa
- Mensajes de validación en tiempo real sin recargar la página

---

## Arquitectura
Models/
├── Producto.cs               # Modelo con Data Annotations
└── ProductoRepositorio.cs    # Repositorio en memoria (List<Producto>)
Controllers/
└── ProductosController.cs    # Controlador con acciones CRUD
Views/
├── Productos/
│   ├── Index.cshtml          # Lista de productos
│   ├── Detalles.cshtml       # Detalle de un producto
│   ├── Crear.cshtml          # Formulario de creación
│   ├── Editar.cshtml         # Formulario de edición
│   └── Eliminar.cshtml       # Confirmación de eliminación
└── Shared/
└── _Layout.cshtml        # Layout compartido con navbar

---

## Tecnologías

- C# / .NET 10
- ASP.NET Core MVC
- Razor Views con Tag Helpers
- Bootstrap 5
- Data Annotations para validaciones

---

## Patrones aplicados

- **MVC** — separación de responsabilidades entre Modelo, Vista y Controlador
- **PRG (Post-Redirect-Get)** — evita el reenvío de formularios al recargar
- **Repository Pattern** — acceso a datos centralizado en `ProductoRepositorio`
- **Clean Code** — nombres descriptivos, métodos simples y sin lógica de negocio en el controlador

---

## Cómo ejecutar

1. Clonar el repositorio
2. Abrir `Lab4_Productos_C12585.sln` en Visual Studio
3. Presionar **F5** o el botón ▶ `https`
4. Navegar a `/Productos`