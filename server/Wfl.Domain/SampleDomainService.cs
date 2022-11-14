using Wfl.Domain.Entities.Payloads;

namespace Wfl.Domain
{
    internal class SampleDomainService : ISampleDomainService
    {
        public Task<AnotherSampleResponse> AnotherSampleMethodAsync(int a)
        {
            throw new NotImplementedException();
        }

        public SampleResponse SampleMethod(SampleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
