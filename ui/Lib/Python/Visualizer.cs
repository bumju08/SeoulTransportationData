using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeoulTransportationData.Lib.Python
{
    /// <summary>
    /// 데이터 시각화 모듈을 작성하고 실행시킬 클래스입니다.
    /// </summary>
    class Visualizer : IDisposable
    {
        private readonly string dataFilePath = Program.Path + @"\visual.db";

        public void Dispose()
        {

        }

        /// <summary>
        /// 시각화에 사용될 데이터 파일이 존재하는지 확인합니다.
        /// </summary>
        public bool IsReady()
        {
            if (!File.Exists(dataFilePath))
            {
                return false;
            }

            FileInfo fInfo = new FileInfo(dataFilePath);
            if (fInfo.Length < 1500000)
            {
                return false;
            }

            if (!Zip.IsValid(dataFilePath))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 시각화에 필요한 모듈과 데이터베이스를 프로그램 폴더에 풀어 놓습니다.
        /// </summary>
        public void GenerateData()
        {
            Zip.Extract(dataFilePath, Program.Path + @"\lib");
        }



    }
}
