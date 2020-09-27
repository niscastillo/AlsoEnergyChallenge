namespace ChallengeApi.Interfaces
{
    public interface IColorDb
    {
        void LoadList();
        string SelectRandomColor();
    }
}