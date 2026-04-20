using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Compartido
{
    public class Compartido
    {
        public static string CifrarAES(string textoPlano, string clave)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = GenerarClave(clave, aes.KeySize / 8);
                    aes.IV = GenerarClave(clave, aes.BlockSize / 8); // IV derivado de la clave (puedes usar uno aleatorio y guardarlo)

                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] datos = Encoding.UTF8.GetBytes(textoPlano);
                        cs.Write(datos, 0, datos.Length);
                        cs.FlushFinalBlock();
                        return Convert.ToBase64String(ms.ToArray()); // Salida en Base64
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cifrar: " + ex.Message);
            }
        }


        // Descifra un texto cifrado con AES
        public static string DescifrarAES(string textoCifrado, string clave)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = GenerarClave(clave, aes.KeySize / 8);
                    aes.IV = GenerarClave(clave, aes.BlockSize / 8);

                    byte[] datosCifrados = Convert.FromBase64String(textoCifrado);

                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(datosCifrados, 0, datosCifrados.Length);
                        cs.FlushFinalBlock();
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al descifrar: " + ex.Message);
            }
        }

        // Genera una clave de tamaño fijo a partir de una cadena
        private static byte[] GenerarClave(string clave, int longitud)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(clave));
                Array.Resize(ref keyBytes, longitud);
                return keyBytes;
            }
        }

        public static string convertirSHA256(string texto)
        {
            //Se convierte la contraseña a SHA256 para compararla con la contraseña almacenada en la base de datos
            StringBuilder Sb = new StringBuilder();
            using (var hash = System.Security.Cryptography.SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }

        public static string decodificarSHA256(string texto)
        {
            //Se decodifica la contraseña para mostrarla en caso de ser necesario
            byte[] data = Convert.FromBase64String(texto);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }
    }
}
