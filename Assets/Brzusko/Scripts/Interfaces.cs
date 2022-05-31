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

    public interface ICommand : ISpawnable
    {
        CommandSO CommandData { get; }
    }

    public interface ICommandController
    {
        bool Register(ICommand commandToRegister);
    }
}
