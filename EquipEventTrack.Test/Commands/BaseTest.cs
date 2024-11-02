namespace EquipEventTrack.Test.Commands;

public abstract class BaseTest
{
    public bool HasSingleError(List<string> errors, string errorMessage)
    {
        var hasError = errors
            .Any(p => string.Compare(p, errorMessage, StringComparison.OrdinalIgnoreCase) == 0);

        return hasError;
    }
}