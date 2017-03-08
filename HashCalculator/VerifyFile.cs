

namespace HashCalculator
{
    class VerifyFile
    {
        public bool verify(string file)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(file);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
