using System;
using Xunit;
using ToDoFiGroupApi.Models;

namespace ToDoFiGroupApi.Tests
{
    public class ToDoItemTests
    {
        [Fact]
        public void Constructor_SetsUID()
        {
            // Arrange & Act
            var item = new ToDoItem();

            // Assert
            Assert.NotEqual(Guid.Empty, item.UID);
        }

        [Fact]
        public void Tarea_DefaultValueIsNull()
        {
            // Arrange & Act
            var item = new ToDoItem();

            // Assert
            Assert.Null(item.Tarea);
        }

        [Fact]
        public void Completado_DefaultValueIsFalse()
        {
            // Arrange & Act
            var item = new ToDoItem();

            // Assert
            Assert.False(item.Completado);
        }

        [Fact]
        public void Orden_DefaultValueIsZero()
        {
            // Arrange & Act
            var item = new ToDoItem();

            // Assert
            Assert.Equal(0, item.Orden);
        }
    }
}
