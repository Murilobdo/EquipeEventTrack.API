using EquipEventTrack.Domain.Handlers.Users.Delete;

namespace EquipEventTrack.Test.Commands.Users;

[TestClass]
public class DeleteUserTest
{

    [TestMethod]
    public void Erro_ao_deletar_um_usuario_sem_id()
    {
        var isValid = new DeleteCommand(0).IsValid();
        Assert.IsFalse(isValid);
    }
    
    [TestMethod]
    public void Sucesso_ao_deletar_um_usuario_com_id()
    {
        var isValid = new DeleteCommand(3).IsValid();
        Assert.IsTrue(isValid);
    }
}