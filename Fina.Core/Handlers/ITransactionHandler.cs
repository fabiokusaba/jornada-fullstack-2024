using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;
using Transaction = System.Transactions.Transaction;

namespace Fina.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Models.Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Models.Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Models.Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Models.Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<PagedResponse<List<Models.Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
}