namespace Odometer
{
    internal interface ISceneController
    {
        public void Destroy();

        public void Run(IData data);
    }
}