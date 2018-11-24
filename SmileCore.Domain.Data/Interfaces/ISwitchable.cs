using SmileCore.Domain.Data.Enums;

namespace SmileCore.Domain.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
