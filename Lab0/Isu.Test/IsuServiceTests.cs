using Isu.Exceptions;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTests
{
    private readonly IsuService service;

    public IsuServiceTests()
    {
        service = new IsuService();
    }

    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent() { }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException() { }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("123fqw")]
    [InlineData("12rf3")]
    public void AddGroupWithInvalidName_ThrowException(string invalidGroupName)
    {
        Assert.Throws<InvalidGroupNameException>(() => service.AddGroup(invalidGroupName));
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged()
    {
        var group = service.AddGroup("");
        var student = service.AddStudent();

        service.ChangeStudentGroup(student, group);

        var actualStudent = service.GetStudent(student.Id)

        Assert.Equal(student.Group, actualStudent.Group);
    }
}