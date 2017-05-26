namespace DP.Creational.Singleton
{
    //Ensure a class allows only one object to be created, providing a single point of access to it.
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SerialNumberGenerator();
                }

                return instance;
            }
        }

        private SerialNumberGenerator()
        {
            
        }

        private int count;

        public virtual int NextSerial
        {
            get
            {
                return count++;
            }
        }
    }
}
