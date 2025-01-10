namespace DependencyInjectionLifetime.Services
{
    public class ScopedGuidService : IScopedGuidService
    {
        private Guid _guid;
        public ScopedGuidService()
        {
                _guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
