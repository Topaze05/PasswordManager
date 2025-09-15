using System.Runtime.InteropServices;

namespace PasswordManager.Helper
{
    public static class CustomSecurity
    {
        [DllImport("..\\..\\..\\libs\\DatabaseCryptLibrary.dll")]
        public static extern int Test();

        public static void Great()
        {
            MessageBox.Show(Test().ToString());
        }
    }
}
