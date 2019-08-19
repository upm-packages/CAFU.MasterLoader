using JetBrains.Annotations;

namespace CAFU.MasterLoader.Data.DataStore.Implement
{
    [PublicAPI]
    public abstract class MasterLoaderBase<T>
    {
        protected MasterLoaderBase(T asset)
        {
            Asset = asset;
        }

        protected T Asset { get; }
    }
}