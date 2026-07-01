# 📒 Agenda Electrónica

## 👨‍💻 Autor

**Gabriel Rodriguez Vasquez**

Carrera: Desarrollo de Software  
Instituto Tecnológico de Las Américas (ITLA)

---

# 📌 Descripción del proyecto

Agenda Electrónica desarrollada en **C# Windows Forms** utilizando **SQL Server** como sistema gestor de base de datos.

La aplicación permite administrar contactos personales mediante operaciones CRUD (Crear, Buscar, Modificar).

---

# 🚀 Funcionalidades

✔ Guardar contactos

✔ Buscar contactos

✔ Modificar contactos

✔ Base de datos en SQL Server

✔ Conexión mediante ADO.NET

✔ Interfaz desarrollada con Windows Forms

---

# 🛠 Tecnologías utilizadas

- C#
- Windows Forms (.NET Framework)
- SQL Server Express
- SQL Server Management Studio (SSMS)
- ADO.NET
- Visual Studio 2022
- Git
- GitHub

---

# 📂 Estructura del proyecto

```
AgendaElectronica
│
├── AgendaElectronica
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Conexion.cs
│   ├── Program.cs
│   └── App.config
│
├── AgendaElectronica.sln
│
├── AgendaElectronica.sql
│
├── .gitignore
├── .gitattributes
└── README.md
```

---

# 💻 Requisitos

Antes de ejecutar el proyecto es necesario instalar:

## Visual Studio 2022

Descargar desde:

https://visualstudio.microsoft.com/es/downloads/

Durante la instalación seleccionar:

- Desarrollo de escritorio con .NET

---

## SQL Server Express

Descargar desde:

https://www.microsoft.com/es-es/sql-server/sql-server-downloads

---

## SQL Server Management Studio (SSMS)

Descargar desde:

https://aka.ms/ssmsfullsetup

---

# 📥 Descargar el proyecto

## Opción 1 (Recomendada)

1. Entrar al repositorio de GitHub.
2. Presionar el botón verde **Code**.
3. Seleccionar **Download ZIP**.
4. Extraer el archivo ZIP.
5. Abrir **AgendaElectronica.sln** con Visual Studio.

---

## Opción 2 (Git)

Abrir una terminal y ejecutar:

```bash
git clone https://github.com/TU-USUARIO/AgendaElectronica.git
```

Luego abrir:

```
AgendaElectronica.sln
```

---

# 🗄 Configuración de la Base de Datos

Antes de ejecutar el programa es obligatorio crear la base de datos.

## Paso 1

Abrir SQL Server Management Studio.

## Paso 2

Abrir el archivo:

```
AgendaElectronica.sql
```

## Paso 3

Presionar:

```
Execute
```

Esto creará automáticamente:

- Base de datos
- Tabla Contactos
- Campos necesarios
- Datos (si fueron incluidos)

---

# 🔌 Configuración de la conexión

Si el nombre del servidor SQL es diferente, modificar la cadena de conexión en:

```
Conexion.cs
```

Ejemplo:

```csharp
Data Source=GABRIEL\SQLEXPRESS;
Initial Catalog=AgendaElectronica;
Integrated Security=True;
```

Cambiar únicamente el nombre del servidor si es necesario.

---

# ▶ Ejecutar el proyecto

1. Abrir:

```
AgendaElectronica.sln
```

2. Esperar que Visual Studio cargue el proyecto.

3. Presionar:

```
F5
```

o

```
Iniciar
```

La aplicación iniciará automáticamente.

---

# 📸 Funciones disponibles

## Guardar

Permite registrar un nuevo contacto.

---

## Buscar

Busca un contacto por nombre y llena automáticamente todos los campos.

---

## Modificar

Actualiza la información de un contacto existente.

---

# 📋 Base de datos

Tabla utilizada:

```
Contactos
```

Campos:

- Id
- Nombre
- Apellido
- FechaNacimiento
- Direccion
- Genero
- EstadoCivil
- Movil
- Telefono
- Correo

---

# 📷 Capturas

Puedes agregar aquí imágenes del funcionamiento del proyecto.

Ejemplo:

- Pantalla principal
- Registro guardado
- Búsqueda
- Modificación

---

# 📖 Aprendizajes

Durante el desarrollo de este proyecto se aplicaron los siguientes conocimientos:

- Programación orientada a objetos.
- Windows Forms.
- ADO.NET.
- SQL Server.
- CRUD.
- Git y GitHub.
- Manejo de eventos.
- Conexión entre C# y SQL Server.

---

# 📄 Licencia

Proyecto realizado únicamente con fines académicos.

---

# 👨‍🎓 Autor

**Gabriel Rodriguez Vasquez**

ITLA - Desarrollo de Software

Año: 2026
