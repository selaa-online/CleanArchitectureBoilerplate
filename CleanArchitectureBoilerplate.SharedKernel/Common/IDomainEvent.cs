namespace CleanArchitectureBoilerplate.SharedKernel.Common;

public interface IDomainEvent
{
    DateTime OccurredOn { get; }
} 