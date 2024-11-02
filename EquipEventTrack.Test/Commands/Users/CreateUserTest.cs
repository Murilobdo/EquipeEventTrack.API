using System.Reflection;
using EquipEventTrack.Domain.Handlers.Users;
using EquipEventTrack.Test.FakerData;

namespace EquipEventTrack.Test.Commands.Users;

[TestClass]
public class CreateUserTest : BaseTest
{
    private CreateCommand create;
    private CreateCommand empty;

    public CreateUserTest()
    {
        empty = new();
        create = FakeUserCommands.CreateCommand();
    }
    
    [TestMethod]
    public void Erro_ao_criar_usuario()
    {
        var validation = empty.IsValid();
        Assert.IsFalse(validation);
    }

    [TestMethod]
    public void Erro_ao_criar_usuario_sem_nome()
    {
        create.UserName = string.Empty;
        var errors = create.GetErrors();
        var hasError = HasSingleError(errors, "O nome e obrigatório");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Erro_ao_criar_usuario_sem_email()
    {
        create.Email = string.Empty;
        var errors = create.GetErrors();
        var hasError = HasSingleError(errors, "O e-mail e obrigatório");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Erro_ao_criar_usuario_com_email_invalido()
    {
        create.Email = "www.api.com";
        var errors = create.GetErrors();
        var hasError = HasSingleError(errors, "Insira um e-mail valido");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Erro_ao_criar_usuario_sem_senha()
    {
        create.Password = string.Empty;
        var errors = create.GetErrors();
        var hasError = HasSingleError(errors, "A senha e obrigatória");
        
        Assert.IsTrue(hasError);
    }

    [TestMethod]
    public void Sucesso_ao_criar_usuario()
    {
        var isValid = create.IsValid();
        Assert.IsTrue(isValid);
    }
}