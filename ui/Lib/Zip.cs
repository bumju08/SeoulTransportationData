using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeoulTransportationData.Lib
{
    /// <summary>
    /// 파일을 압축하거나 해제하는 클래스입니다.
    /// </summary>
    public static class Zip
    {

        public static bool IsValid(string filePath)
        {
            try
            {
                using (var zipFile = ZipFile.OpenRead(filePath))
                {
                    var entries = zipFile.Entries;

                    return true;
                }
            }

            catch (InvalidDataException)
            {
                return false;
            }
        }

        /// <summary>
        /// 압축파일(.zip)을 생성합니다.
        /// </summary>
        /// <param name="sourceDirPath">압축할 폴더의 경로입니다.</param>
        /// <param name="outputFilePath">생성될 압축파일(.zip)의 경로입니다.</param>
        /// <returns>압축의 성공 여부입니다.</returns>
        public static bool Create(string sourceDirPath, string outputFilePath)
        {
            try
            {
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }

                ZipFile.CreateFromDirectory(sourceDirPath, outputFilePath);

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 압축파일(.zip)을 해제합니다.
        /// </summary>
        /// <param name="zipPath">압축파일(.zip)입니다.</param>
        /// <param name="destDirPath">압축을 해제헤 저장할 폴더입니다.</param>
        /// <returns>압축 해제의 성공 여부입니다.</returns>
        public static bool Extract(string zipPath, string destDirPath)
        {
            try
            {
                if (Directory.Exists(destDirPath))
                {
                    Directory.Delete(destDirPath, recursive: true);
                }

                ZipFile.ExtractToDirectory(zipPath, destDirPath);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
