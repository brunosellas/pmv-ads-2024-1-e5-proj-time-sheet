﻿namespace TimeSheet.Commands {
    public class AuthenticateCommandHandler
        : ICommandHandler<AuthenticateCommand, AuthenticateCommandResult> {

        private readonly UserRepository _repository;
        private readonly TokenService _tokenService;
        private readonly PasswordService _passwordService;
        public AuthenticateCommandHandler(
            UserRepository repository,
            TokenService tokenService,
            PasswordService passwordService) {

            _repository = repository;
            _tokenService = tokenService;
            _passwordService = passwordService;
        }

        public async Task<AuthenticateCommandResult> Handle(AuthenticateCommand command) {

            try {

                var cpf = command.CPF;

                CPFValidations.Normalize(ref cpf);

                var user = await _repository.FindUser(cpf);

                if (user is null) {
                    return new AuthenticateCommandResult {
                        Message = "Usuário ou senha incorretos.",
                        Status = AuthenticateCommandStatus.UserNotFound
                    };
                }

                if (user.Status is Models.UserStatus.Inactive) {
                    return new AuthenticateCommandResult {
                        Message = "Usuário desabilitado",
                        Status = AuthenticateCommandStatus.UserDisabled
                    };
                }

                if (!_passwordService
                    .VerifyPassword(command.Password, user.Password)) {
                    return new AuthenticateCommandResult {
                        Message = "Usuário ou senha incorretos.",
                        Status = AuthenticateCommandStatus.UserNotFound
                    };
                }

                var token = _tokenService.GenerateToken(user);

                return new AuthenticateCommandResult {
                    Id = user.Id,
                    Token = token,
                    Status = AuthenticateCommandStatus.UserAuthenticated,
                    Message = $"Usuário '{user.Name}' autenticado."
                };

            } catch(Exception exc) {
                return new AuthenticateCommandResult {
                    Message = $"{exc.Message} | {exc.GetType()}",
                    Status = AuthenticateCommandStatus.Error
                };
            }
        }
    }
}
