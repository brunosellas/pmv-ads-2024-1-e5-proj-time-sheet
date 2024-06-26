﻿namespace TimeSheet.Commands {
    public class CreateUserCommandHandler
        : ICommandHandler<CreateUserCommand, CreateUserCommandResult> {

        private readonly UserBuilder _builder;
        private readonly UserRepository _repository;
        public CreateUserCommandHandler(UserBuilder builder, UserRepository repository) {
            _builder = builder;
            _repository = repository;
        }
        public async Task<CreateUserCommandResult> Handle(CreateUserCommand command) {

            try {

                if (command is null) {
                    throw new ArgumentNullException(nameof(command));
                }

                var buildUserResult = _builder
                    .CreateNew()
                    .WithName(command.Name)
                    .WithCPF(command.CPF)
                    .WithWorkJourney(command.WorkTime, command.LunchTime)
                    .WithPassword(command.Password)
                    .WithRole(command.Role)
                    .EncryptPassword()
                    .Build();

                if (buildUserResult.IsFailed) {
                    return new CreateUserCommandResult {
                        Message = buildUserResult.Errors[0].Message,
                        Status = CommandResultStatus.InvalidUserData
                    };
                }

                var user = buildUserResult.Value;

                if (await _repository.UserExists(user.CPF)) {
                    return new CreateUserCommandResult {
                        Message = "Usuário já existe.",
                        Status = CommandResultStatus.UserAlreadyExists
                    };
                }

                await _repository.AddUser(user);

                return new CreateUserCommandResult {
                    Id = user.Id,
                    Message = "Usuário criado com sucesso.",
                    Status = CommandResultStatus.UserCreated
                };

            } catch(Exception exc) {
                return new CreateUserCommandResult {
                    Id = Guid.Empty,
                    Message = $"{exc.Message} | {exc.GetType()}",
                    Status = CommandResultStatus.Error
                };
            }
        }
    }
}
