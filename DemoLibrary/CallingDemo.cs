namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();

            demo.PublicDemo();
            demo.InternalDemo();
            demo.ProtectedInternalDemo();
        }
    }
}
