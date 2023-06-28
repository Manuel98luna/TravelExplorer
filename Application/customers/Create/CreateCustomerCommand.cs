using MediatR;

namespace Application.Customers.Create;


public record CreateCustomerCommand(String Name,
String Description,
String Ubication,
String address,
String active ) :IRequest<Unit>;
