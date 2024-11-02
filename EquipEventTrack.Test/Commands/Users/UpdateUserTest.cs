using EquipEventTrack.Domain.Handlers.Users;
using EquipEventTrack.Domain.Handlers.Users.Update;
using EquipEventTrack.Test.FakerData;

namespace EquipEventTrack.Test.Commands.Users;

[TestClass]
public class UpdateUserTest : BaseTest
{
    private UpdateCommand update;
    private UpdateCommand empty;

    public UpdateUserTest()
    {
        empty = new();
        update = FakeUserCommands.UpdateCommand();
    }
    
    [TestMethod]
    public void Erro_ao_atualizar_usuario()
    {
        var validation = empty.IsValid();
        Assert.IsFalse(validation);
    }
    
    [TestMethod]
    public void Erro_ao_atualizar_usuario_sem_id()
    {
        update.Id = 0;
        var errors = update.GetErrors();
        var hasError = HasSingleError(errors, "Não foi possivel finalizar a ação");

        Assert.IsTrue(hasError);
    }

    [TestMethod]
    public void Erro_ao_atualizar_usuario_sem_nome()
    {
        update.UserName = string.Empty;
        var errors = update.GetErrors();
        var hasError = HasSingleError(errors, "O nome e obrigatório");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Erro_ao_atualizar_usuario_sem_email()
    {
        update.Email = string.Empty;
        var errors = update.GetErrors();
        var hasError = HasSingleError(errors, "O e-mail e obrigatório");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Erro_ao_atualizar_usuario_com_email_invalido()
    {
        update.Email = "www.api.com";
        var errors = update.GetErrors();
        var hasError = HasSingleError(errors, "Insira um e-mail valido");
        
        Assert.IsTrue(hasError);
    }
    
    [TestMethod]
    public void Sucesso_ao_atualizar_usuario()
    {
        var isValid = update.IsValid();
        Assert.IsTrue(isValid);
    }
}