using System;
namespace ArchitectureCS.SRP.Refactored
{
    public interface ICanOperateWithCash
    {
        void AcceptCash();
        void DispenseCharge();
    }
}
