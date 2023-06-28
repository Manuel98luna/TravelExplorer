using Domain.Customers;
using Domain.Primitives;
using Domain.ValueObjects;
using MediatR;
namespace Application.Customers.Create;

internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Unit>
{

    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository ??throw new ArgumentNullException(nameof(customerRepository));
        _unitOfWork = unitOfWork ??throw new ArgumentNullException(nameof(unitOfWork));
    }

    
    public async Task<Unit>Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
    {//evalua que sea tipo phone number numero de telñefono
        if(PhoneNumber.Create(command.PhoneNumber)is not PhoneNumber phoneNumber)
        {
            throw new ArgumentException(nameof(phoneNumber));
        }
     
        var customer = new Customer{
            new CustomerId(Guid.NewGuid()),
            command.Name,
            command.Description,
            command.Ubication,
            command.address,
            command.phoneNumber,
            true
        };


    }
}