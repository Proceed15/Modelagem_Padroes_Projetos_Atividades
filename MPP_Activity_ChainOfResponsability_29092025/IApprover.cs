// Interface do Handler
    public interface IApprover
    {
        void SetNext(IApprover next);
        void Approve(PurchaseRequest request);
    }