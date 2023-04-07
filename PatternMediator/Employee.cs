
using PatternMediator;

abstract class Employee
{
    protected IMediator mediator;

    public Employee(IMediator mediator) => this.mediator = mediator;

    public void SetMediator(IMediator mediator) => this.mediator = mediator;
}

