using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ReactiveUI;

namespace Bkng.Models;

public class Administrator: ModelBase
{
    private int _administratorId;
    private string _administratorFirstName = string.Empty;
    private string _administratorLastName  = string.Empty;
    private string _administratorLogin  = string.Empty;
    private string _administratorPassword  = string.Empty;

    [Key]
    public int AdministratorId
    {
        get => _administratorId;
        set => this.RaiseAndSetIfChanged(ref _administratorId, value);
    }

    public string AdministratorLastName
    {
        get => _administratorLastName;
        set => this.RaiseAndSetIfChanged(ref _administratorLastName, value);
    }

    public string AdministratorFirstName
    {
        get => _administratorFirstName;
        set => this.RaiseAndSetIfChanged(ref _administratorFirstName, value);
    }

    public string AdministratorLogin
    {
        get => _administratorLogin;
        set => this.RaiseAndSetIfChanged(ref _administratorLogin, value);
    }

    public string AdministratorPassword
    {
        get => _administratorPassword;
        set => this.RaiseAndSetIfChanged(ref _administratorPassword, value);
    }

    public override Administrator Clone()
    {
        return new Administrator
        {
            AdministratorId = AdministratorId,
            AdministratorLastName = AdministratorLastName,
            AdministratorFirstName = AdministratorFirstName,
            AdministratorLogin = AdministratorLogin,
            AdministratorPassword = AdministratorPassword
        };
    }
}