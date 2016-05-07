using System;
using System.IO;
using System.Windows.Forms;

namespace viñedos.Auxiliares
{
    static class Auxiliares
    {
        public static void CerrarFormulariosAbiertos(string formActual)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name != formActual&& Application.OpenForms[index].Name!= "LogIn")
                {
                    Application.OpenForms[index].Dispose();
                }
            }
        }
        public static string GetTempFilePathWithExtension()
        {
            string extension = "";
            var path = Path.GetTempPath();
            var fileName = Guid.NewGuid() + extension;
            return Path.Combine(path, fileName);
        }
    }
}