namespace DemoLibrary
{
    public class AccessDemo
    {
        private int test;

        private void Demo()
        {
            PrivateDemo();
            AccessDemo demo = new AccessDemo();

        }

        private void PrivateDemo()
        {

        }

        private protected void PrivateProtectedDemo()
        {

        }

        protected void ProtectedDemo()
        {

        }

        protected internal void ProtectedInternalDemo()
        {

        }

        internal void InternalDemo()
        {

        }

        public void PublicDemo()
        {

        }

    }


}
