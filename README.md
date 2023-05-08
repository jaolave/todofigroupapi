# Fi Group ToDo Back End API

Este proyecto es una API RESTful que proporciona funcionalidades b�sicas para gestionar una lista de tareas (ToDo list) utilizando ASP.NET Core, para Fi Group c�mo prueba t�cnica.


## Requisitos

- .NET 7 SDK
- Base de datos SQL Server


## Configuraci�n

1. Clona este repositorio en tu m�quina local:

`git clone URL repositorio`

2. Navega a la carpeta del proyecto:

`cd ToDoFiGroupApi`

3. Configura la cadena de conexi�n a la base de datos en `appsettings.json`:

`json
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
}`

4. Ejecuta las migraciones para crear las tablas en la base de datos:

`dotnet ef database update`


## Ejecuci�n

Ejecuta el proyecto usando el comando:

`dotnet run`

La API estar� disponible en https://localhost:5001 (o en el puerto que se muestre en la consola).


## Endpoints

GET /api/todo: Obtiene la lista de tareas.
POST /api/todo: Crea una nueva tarea.
PUT /api/todo/{uid}: Actualiza una tarea existente (Tarea y Estado).
DELETE /api/todo/{uid}: Elimina una tarea existente.


## Pruebas

1. Mueve la carpeta ToDoFiGroupApi.Tests al mismo nivel de ToDoFiGroupApi

2. Navega a la carpeta de los tests:

`cd ToDoFiGroupApi.Tests`

3. Para ejecutar las pruebas unitarias, usa el siguiente comando:

`dotnet test`

