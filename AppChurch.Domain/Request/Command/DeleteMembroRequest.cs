using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;

namespace AppChurch.Domain.Request.Command
{
    public class DeleteMembroRequest : IRequest<Result<bool>>, IValidatable
    {
        public DeleteMembrosViewModel _viewModel;
        public DeleteMembroRequest(DeleteMembrosViewModel viewModel) 
        {
            _viewModel = viewModel;
        }
    }
}
