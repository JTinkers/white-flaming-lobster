using Wfl.Domain.Entities.Payloads;

namespace Wfl.Domain
{
    public interface ISampleDomainService
    {
        SampleResponse SampleMethod(SampleRequest request);

        // The convention is: asynchronous methods end with 'Async'
        Task<AnotherSampleResponse> AnotherSampleMethodAsync(int a);
    }
}
