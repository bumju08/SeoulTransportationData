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
        public readonly string scriptFilePath = Program.Path + @"\lib\execute.py";
        public readonly string dataFilePath = Program.Path + @"\visual.db";
        public StringBuilder script = new StringBuilder(null);

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
        public void Ready()
        {
            Zip.Extract(dataFilePath, Program.Path + @"\lib");
        }


        /// <summary>
        /// 시각화 스크립트를 초기화합니다.
        /// </summary>
        public void ResetScript()
        {
            script.Clear();

            script.AppendLine("import visualizer\n");
            script.AppendLine("visual = visualizer.transport()");
        }

        /// <summary>
        /// 시각화 스크립트 파일을 삭제합니다.
        /// </summary>
        public void RemoveScriptFile()
        {
            try
            {
                File.Delete(scriptFilePath);
            }

            catch (Exception) { }
        }

        /// <summary>
        /// 현재 시각화 스크립트를 실행해 차트를 표시합니다.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="xLabel"></param>
        /// <param name="yLabel"></param>
        public void AddShowScript(string title, string xLabel, string yLabel)
        {
            StringBuilder new_script = new StringBuilder(null);

            foreach (string line in script.ToString().Trim().Split('\n'))
            {

                if (!line.Contains("showCharts"))
                {
                    new_script.AppendLine(line.Trim());
                }
            }

            new_script.AppendLine($"\nvisual.showCharts(\"{title}\", \"{xLabel}\", \"{yLabel}\")");

            File.WriteAllText(scriptFilePath, new_script.ToString(), new UTF8Encoding(false));
            File.SetAttributes(scriptFilePath, File.GetAttributes(scriptFilePath) | FileAttributes.Hidden);
        }

        /// <summary>
        /// 현재 시각화 차트에 바 데이터셋을 하나 추가합니다.
        /// </summary>
        /// <param name="dataModel">데이터 모델입니다. "bus", "subway", "population"</param>
        /// <param name="dataType">데이터 형태입니다. "dailyrate", "all", "in", "out"</param>
        /// <param name="sortType">데이터 정렬 형태입니다.  0=미정렬  1=오름차순  2=내림차순</param>
        /// <param name="label">차트 범례 이름입니다.</param>
        /// <param name="color_hex">막대 바의 색상 HEX 코드입니다.</param>
        public void AddChartBar(string dataModel, string dataType, byte sortType, string label, string color_hex)
        {
            script.AppendLine($"visual.addChartBar(\"{dataModel}\", \"{dataType}\", {sortType.ToString()}, \"{label}\", \"{color_hex}\")");
        }

    }
}
