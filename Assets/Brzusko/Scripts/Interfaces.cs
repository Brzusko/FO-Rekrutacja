namespace Brzusko.Interfaces
{
    public interface IUnitBuilder
    {
        void Build(UnitSO unitData);
    }

    public interface ISpawnable
    {
        void InjectData<T>(T dataToInject) where T: class;
        void Spawn();
    }
}
