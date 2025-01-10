namespace DependencyInjectionLifetime.Services
{
    public class TransientGuidService : ITransientGuidService
    {
        private Guid _guid;
        public TransientGuidService()
        {
            _guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
