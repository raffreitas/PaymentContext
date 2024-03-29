using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Queries;

[TestClass]
public class StudentQueriesTests
{

    private IList<Student> _students = [];

    public StudentQueriesTests()
    {
        for (int i = 0; i < 10; i++)
        {
            _students.Add(
                new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("111111111" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "@test.com")
                )
            );
        }
    }

    [TestMethod]
    public void ShouldReturnNullWhenDocumentNotExists()
    {
        var exp = StudentQueries.GetStudentInfo("12345678911");
        var student = _students.AsQueryable().Where(exp).FirstOrDefault();
        Assert.AreEqual(null, student);
    }

    [TestMethod]
    public void ShouldReturnStudentWhenDocumentNotExists()
    {
        var exp = StudentQueries.GetStudentInfo("1111111111");
        var student = _students.AsQueryable().Where(exp).FirstOrDefault();
        Assert.AreNotEqual(null, student);
    }
}
