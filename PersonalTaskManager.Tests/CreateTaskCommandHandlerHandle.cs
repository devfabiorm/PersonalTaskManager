using Microsoft.EntityFrameworkCore;
using Moq;
using PersonalTaskManager.Application.Commands.CreateTask;
using PersonalTaskManager.Core.Models;
using PersonalTaskManager.Infrastructure.Persistence;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Implementation;
using PersonalTaskManager.Infrastructure.Persistence.Repository.Interface;

namespace PersonalTaskManager.Tests
{
    public class CreateTaskCommandHandlerHandle
    {
        [Fact]
        public async Task ShallPersisteInDatabaseGivenAValidInput()
        {
            //Arrange
            const int expected = 0;
            var command = new CreateTaskCommand("Teste de inserção", "Testando inserção na demonstração", new DateOnly(2024, 7, 2), new Category { Label = "Estudo"});
            var options = new DbContextOptionsBuilder<PersonalTaskManagerDbContext>()
                .UseInMemoryDatabase("PersonalTaskManagerDb")
                .Options;
            var context = new PersonalTaskManagerDbContext(options);
            var repository = new TaskRepository(context);
            var handler = new CreateTaskCommandHandler(repository);

            //Act
            var actual = await handler.Handle(command);

            //Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public async Task ShallCallCreateAsyncOnlyOneTimeGivenValidInput()
        {
            //Arrange
            var command = new CreateTaskCommand("Teste de inserção", "Testando inserção na demonstração", new DateOnly(2024, 7, 2), new Category { Label = "Estudo" });
            var repositoryMock = new Mock<ITaskRepository>();
            var handler = new CreateTaskCommandHandler(repositoryMock.Object);

            //Act
            await handler.Handle(command);

            //Assert
            repositoryMock.Verify(x => x.CreateAsync(It.IsAny<PersonalTask>()), Times.Once);
        }
    }
}
