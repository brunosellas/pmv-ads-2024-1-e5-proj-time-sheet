﻿
using TimeSheet.Builders;
using TimeSheet.Repositories;

namespace TimeSheet.Commands {
    public class ChangeUserPasswordCommandHandler
        : ICommandHandler<ChangeUserPasswordCommand, ChangeUserPasswordCommandResult> {

        private readonly UserRepository _repository;
        private readonly UserBuilder _builder;
        public ChangeUserPasswordCommandHandler(
            UserRepository repository,
            UserBuilder builder) {
            _repository = repository;
            _builder = builder;
        }

        public async Task<ChangeUserPasswordCommandResult> Handle(ChangeUserPasswordCommand command) {

            var cpf = command.CPF;

            CPFValidations.Normalize(ref cpf);

            var user = await _repository
                .FindUser(cpf);

            if (user is null) {
                return new ChangeUserPasswordCommandResult {
                    Message = "Usuário não encontrado.",
                    Status = ChangeUserPasswordCommandResultStatus.UserNotFound
                };
            }

            var result = _builder
                .CreateNew()
                .WithPassword(command.Password)
                .EncryptPassword()
                .Build();

            if (result.IsFailed) {
                return new ChangeUserPasswordCommandResult {
                    Message = result.Errors[0].Message,
                    Status = ChangeUserPasswordCommandResultStatus.InvalidPassword
                };
            }

            user.Password = result.Value.Password;

            await _repository.SaveChanges();

            return new ChangeUserPasswordCommandResult {
                Message = "Senha alterada com sucesso.",
                Status = ChangeUserPasswordCommandResultStatus.PasswordChanged
            };
        }
    }
}