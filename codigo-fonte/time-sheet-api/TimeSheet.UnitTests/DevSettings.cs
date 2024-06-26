﻿using Microsoft.EntityFrameworkCore;
using System.Text;
using TimeSheet.Configuration;
using TimeSheet.Infrastructure;
using TimeSheet.Models;
using TimeSheet.Services;

namespace TimeSheet.UnitTests {
    public static class DevSettings {
        public static AppOptions GetAppOptions() {
            return new AppOptions {
                ConnectionString = string.Empty,
                JwtBearer = new JwtBearerOptions {
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    SecretKey = "115d6db863da2f536f8534e8c7f84ee0f5925a38e8c029a0140d6cfa45e6713c",
                    Expires = 8
                }
            };
        }
        private static TimeSheetContext InMemoryContextInstance = null!;
        public static TimeSheetContext GetInMemoryContext() {

            if (InMemoryContextInstance is not null) {
                return InMemoryContextInstance;
            }

            var options = new DbContextOptionsBuilder<TimeSheetContext>().
                UseInMemoryDatabase("time-sheet").
                UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).
                Options;

            var context = new TimeSheetContext(options);

            SeedDatabase(context);

            InMemoryContextInstance = context;

            return context;
        }
        private static void SeedDatabase(TimeSheetContext context) {
            context.Users.AddRange(DefaultUsers());
            context.SaveChanges();

            context.ChangeTracker.Clear();
        }
        private static List<User> DefaultUsers() {

            var passwordService = new PasswordService();

            return new List<User> {
                new User() {
                    Id = Guid.Parse("ba56273d-0c8b-4ea6-90ac-691494d1f402"),
                    Name = "Bruce Wayne",
                    CPF = "04037535033",
                    WorkTime = 9,
                    LunchTime = 2,
                    Password = passwordService.EncryptPassword("Teste@123"),
                    Role = UserRole.Administrator,
                    Status = UserStatus.Active
                },
                new User() {
                    Id = Guid.Parse("b6a5e02a-40cd-4a47-960c-1a189ecd821a"),
                    Name = "Robin Francis",
                    CPF = "12995490041",
                    WorkTime = 8,
                    LunchTime = 1.30,
                    Password = passwordService.EncryptPassword("Teste@123"),
                    Role  = UserRole.Employee,
                    Status = UserStatus.Inactive
                },
                new User() {
                    Id = Guid.Parse("b6a5e04a-60cd-4a47-960c-1a189ecd221a"),
                    Name = "Maria Julieta",
                    CPF = "31207413020",
                    WorkTime = 8,
                    LunchTime = 1.0,
                    Password = passwordService.EncryptPassword("Senha@123"),
                    Role  = UserRole.Employee,
                    Status = UserStatus.Active
                },
            };
        }
    }

    public static class AsyncHelper {
        public static TResult RunSync<TResult>(this Task<TResult> task) {
            return task.GetAwaiter().GetResult();
        }
    }
    public static class StringUtils {
        public static string CreateLongString(string pattern, int times) {

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < times; i++) {
                stringBuilder.Append(pattern);
            }

            return stringBuilder.ToString();
        }
    }
}
