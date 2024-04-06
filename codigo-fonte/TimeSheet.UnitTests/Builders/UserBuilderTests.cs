﻿using TimeSheet.Builders;
using TimeSheet.Common;
using TimeSheet.Services;

namespace TimeSheet.UnitTests.Builders {
    [TestClass]
    public class UserBuilderTests {

        private readonly UserBuilder _builder;
        public UserBuilderTests() {
            _builder = new UserBuilder(new PasswordService());
        }

        [TestMethod]
        public void Build_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.Build());
        }

        [TestMethod]
        public void WithName_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithName(string.Empty));
        }

        [TestMethod]
        public void WithName_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var buildResult = _builder.
                CreateNew().
                WithName(null).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithName_BlankName_ReturnsFailureWithPropertyIsBlankError() {

            var buildResult = _builder.
                CreateNew().
                WithName(string.Empty).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyIsBlankError));
        }

        [TestMethod]
        public void WithName_NameLengthTooShort_ReturnsFailureWithPropertyLengthTooShortError() {

            var buildResult = _builder.
                CreateNew().
                WithName("a").
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooShortError));
        }

        [TestMethod]
        public void WithName_NameLengthTooLong_ReturnsFailureWithPropertyLengthTooLongError() {

            var buildResult = _builder.
                CreateNew().
                WithName(StringUtils.CreateLongString("aa", 30)).
                Build();

            Assert.IsTrue(buildResult.IsFailed);
            Assert.IsInstanceOfType(buildResult.Errors[0], typeof(PropertyLengthTooLongError));
        }

        [TestMethod]
        public void WithName_ValidName_ReturnsSuccess() {

            var buildResult = _builder.
                CreateNew().
                WithName("Batman").
                Build();

            Assert.IsTrue(buildResult.IsSuccess);
            Assert.AreEqual(buildResult.Value.Name, "Batman");
        }

        [TestMethod]
        public void WithCPF_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithCPF(""));
        }

        [TestMethod]
        public void WithCPF_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _builder.
                CreateNew().
                WithCPF(null).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithCPF_BlankCPF_ReturnsFailureWithCPFIsBlankError() {

            var result = _builder.
                CreateNew().
                WithCPF(string.Empty).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(CPFIsBlankError));
        }

        [TestMethod]
        [DataRow("11111111111111111111")]
        [DataRow("22")]
        public void WithCPF_InvalidLength_ReturnsFailureWithCPFLengthError(string cpf) {

            var result = _builder.
                CreateNew().
                WithCPF(cpf).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(CPFLengthError));
        }

        [TestMethod]
        [DataRow("11111111111")]
        [DataRow("22222222222")]
        public void WithCPF_CPFWithAllDigitsSame_ReturnsFailureWithCPFAllDigitsSameError(string cpf) {

            var result = _builder.
                CreateNew().
                WithCPF(cpf).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(CPFAllDigitsSameError));
        }

        [TestMethod]
        [DataRow("98765432109")]
        [DataRow("12345678900")]
        public void WithCPF_InvalidCPF_ReturnsFailureWithCPFIsInvalidError(string cpf) {

            var result = _builder.
                CreateNew().
                WithCPF(cpf).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(CPFIsInvalidError));
        }

        [TestMethod]
        [DataRow("79007129090")]
        public void WithCPF_ValidCPF_ReturnsSuccess(string cpf) {

            var result = _builder.
                CreateNew().
                WithCPF(cpf).
                Build();

            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public void WithPassword_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithPassword(""));
        }

        [TestMethod]
        public void WithPassword_ArgumentNull_ReturnsFailureWithArgumentNullError() {

            var result = _builder.
                CreateNew().
                WithPassword(null).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ArgumentNullError));
        }

        [TestMethod]
        public void WithPassword_BlankPassword_ReturnsFailureWithPasswordIsBlankError() {

            var result = _builder.
                CreateNew().
                WithPassword(string.Empty).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(PasswordIsBlankError));
        }

        [TestMethod]
        [DataRow("pas")]
        [DataRow("pas123")]
        [DataRow("pass@123")]
        [DataRow("pass 123")]
        [DataRow("Pass123")]
        [DataRow("123")]
        [DataRow("@123")]
        [DataRow("Pass/123")]
        public void WithPassword_InvalidPassword_ReturnsFailureWithPasswordIsInvalidError(string password) {

            var result = _builder.
                CreateNew().
                WithPassword(password).
                Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(PasswordIsInvalidError));
        }

        [TestMethod]
        [DataRow("Pass@123")]
        public void WithPassword_ValidPassword_ReturnsSuccess(string password) {

            var result = _builder.
                CreateNew().
                WithPassword(password).
                Build();

            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public void EncryptPassword_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.EncryptPassword());
        }

        [TestMethod]
        public void EncryptPassword_WithoutAddPassword_ReturnsFailure() {
            var result = _builder
                .CreateNew()
                .EncryptPassword()
                .Build();

            Assert.IsTrue(result.IsFailed);
        }

        [TestMethod]
        public void WithWorkJourney_WithoutCallCreateNewMethod_ThrowInvalidOperationException() {
            Assert.ThrowsException<InvalidOperationException>(() => _builder.WithWorkJourney(0, 0));
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(25)]
        public void WithWorkJourney_TotalTimeOutsideTimeBounds_ReturnsFailureWithValueOutsideTimeBoundsError(double totalTime) {
            var result = _builder
                .CreateNew()
                .WithWorkJourney(totalTime, lunchTime: 2)
                .Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ValueOutsideTimeBoundsError));
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(25)]
        public void WithWorkJourney_LunchTimeOutsideTimeBounds_ReturnsFailureWithValueOutsideTimeBoundsError(double lunchTime) {
            var result = _builder
                .CreateNew()
                .WithWorkJourney(totalTime: 8, lunchTime)
                .Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(ValueOutsideTimeBoundsError));
        }

        [TestMethod]
        public void WithWorkJourney_LunchTimeLongerThanTotalTime_ReturnsFailureWithInconsistentLunchTimeError() {
            var result = _builder
                .CreateNew()
                .WithWorkJourney(totalTime: 1, lunchTime: 8)
                .Build();

            Assert.IsTrue(result.IsFailed);
            Assert.IsInstanceOfType(result.Errors[0], typeof(InconsistentLunchTimeError));
        }

        [TestMethod]
        public void WithWorkJourney_ValidValues_ReturnsSuccess() {
            var result = _builder
                .CreateNew()
                .WithWorkJourney(totalTime: 8, lunchTime: 1.30)
                .Build();

            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(result.Value.TotalTime, 8);
            Assert.AreEqual(result.Value.LunchTime, 1.30);
        }
    }
}
