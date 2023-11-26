using AmberjackRazorTest.Pages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.ComponentModel.DataAnnotations;

namespace AmberjackRazorTest.Tests
{
    public class Tests
    {
        [Test]
        public void EmailRequired()
        {
            // missing email address
            var model = new IndexModel(new NullLogger<IndexModel>()) { Email = "" };
            Assert.That(ValidateModel(model).Any(
                v => v.MemberNames.Contains("Email") &&
                     v.ErrorMessage.Contains("required")), Is.True);
        }

        [Test]
        public void EmailInvalid()
        {
            // invalid email address
            var model = new IndexModel(new NullLogger<IndexModel>()) { Email = "c" };
            Assert.That(ValidateModel(model).Any(
                v => v.MemberNames.Contains("Email") &&
                     v.ErrorMessage.Contains("valid")), Is.True);
        }

        [Test]
        public void EmailValid()
        {
            // happy case
            var model = new IndexModel(new NullLogger<IndexModel>()) { Email = "tester@example.com" };
            Assert.That(ValidateModel(model).Any(
                v => v.MemberNames.Contains("Email")), Is.False);
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }
    }
}