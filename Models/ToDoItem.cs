using System;

namespace ToDoFiGroupApi.Models
{
    public class ToDoItem
    {
        public Guid UID { get; set; }
        public string? Tarea { get; set; }
        public bool Completado { get; set; }
        public int Orden { get; set; }

        public ToDoItem()
        {
            UID = Guid.NewGuid();
        }
    }
}