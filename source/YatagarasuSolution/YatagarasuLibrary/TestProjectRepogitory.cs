using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatagarasuLibrary
{
    public class TestProjectRepogitory : ITestProjectRepogitory
    {
        /// <summary>
        /// テストプロジェクトを新規追加する
        /// </summary>
        /// <param name="project"></param>
        public void Add(TestProject project)
        {

            Save(project);
        }

        public List<TestProject> SelectAll()
        {
            var list = new List<TestProject>();
            var idList = GetProjectIdListInDataFolder();
            foreach (var id in idList)
            {
                list.Add(SelectByProjectId(id));
            }
            return list;
        }

        public TestProject SelectByName(string projectName)
        {
            List<TestProject> list = new List<TestProject>();
            var allList = SelectAll();
            list.AddRange(
                allList
                .Where(d => d.Name == projectName)
                );
            return list[0];
        }
        private void SaveProject(TestProject project)
        {
            string projectDir = GetProjectsDir(project);

            string casesDir = GetCasesDir(project);
            string stepsDir = GetStepsDir(project);

            System.IO.Directory.CreateDirectory(casesDir);
            System.IO.Directory.CreateDirectory(stepsDir);

            string fileName = GetProjectDataFileName(project);

            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(TestProject));

            //書き込むファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));

            using (sw)
            {
                //シリアル化し、XMLファイルに保存する
                serializer.Serialize(sw, project);
                //ファイルを閉じる
                sw.Close();
            }
        }

        private void SaveCase(TestProject project, TestCase testCase)
        {
            string projectDir = GetProjectsDir(project);

            string casesDir = GetCasesDir(project);
            string stepsDir = GetStepsDir(project);

            System.IO.Directory.CreateDirectory(casesDir);
            System.IO.Directory.CreateDirectory(stepsDir);

            string fileName = GetCaseDataFileName(project, testCase);

            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(TestCase));

            //書き込むファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));

            using (sw)
            {
                //シリアル化し、XMLファイルに保存する
                serializer.Serialize(sw, testCase);
                //ファイルを閉じる
                sw.Close();
            }

            foreach (var step in testCase.List)
            {
                SaveStep(project, step);
            }
        }

        private void SaveStep(TestProject project, TestStep testStep)
        {
            string projectDir = GetProjectsDir(project);

            string casesDir = GetCasesDir(project);
            string stepsDir = GetStepsDir(project);

            System.IO.Directory.CreateDirectory(casesDir);
            System.IO.Directory.CreateDirectory(stepsDir);

            string fileName = GetStepDataFileName(project, testStep);

            //XmlSerializerオブジェクトを作成
            //オブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(TestStep));

            //書き込むファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));

            using (sw)
            {
                //シリアル化し、XMLファイルに保存する
                serializer.Serialize(sw, testStep);
                //ファイルを閉じる
                sw.Close();
            }
        }

        public void Save(TestProject project)
        {
            SaveProject(project);
            foreach (var testcase in project.List)
            {
                SaveCase(project, testcase);
            }
        }

        public TestProject SelectByProjectId(string id)
        {
            //保存元のファイル名
            string projectFileName = GetProjectFilePath(id);

            //XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(TestProject));

            //読み込むファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                projectFileName, new System.Text.UTF8Encoding(false));

            TestProject obj;

            //XMLファイルから読み込み、逆シリアル化する
            using (sr)
            {
                obj = (TestProject)serializer.Deserialize(sr);
                //ファイルを閉じる
                sr.Close();
            }

            return obj;
        }


        private string GetTestProjectsFolderDir()
        {
            // カレントディレクトリの取得
            string stCurrentDir = System.Environment.CurrentDirectory;
            string s = String.Format(@"{0}\testprojects", stCurrentDir);
            return s;
        }

        private string GetProjectsDir(TestProject project)
        {
            return GetProjectsDir(project.Id.ToString());
        }

        private string GetProjectsDir(string id)
        {
            string s = String.Format(@"{0}\{1}", GetTestProjectsFolderDir(), id);
            return s;
        }

        private string GetCasesDir(TestProject project)
        {
            return String.Format(@"{0}\{1}", GetProjectsDir(project), "TestCases");
        }

        private string GetCaseDataFileName(TestProject project, TestCase testcase)
        {
            return String.Format(@"{0}\{1}", GetCasesDir(project), testcase.Id.ToString());
        }

        private string GetStepDataFileName(TestProject project, TestStep teststep)
        {
            return String.Format(@"{0}\{1}", GetStepsDir(project), teststep.Id.ToString());
        }

        private string GetStepsDir(TestProject project)
        {
            return String.Format(@"{0}\{1}", GetProjectsDir(project), "TestSteps");
        }

        private string GetProjectDataFileName(TestProject project)
        {
            return String.Format(@"{0}\{1}", GetProjectsDir(project), project.Name);
        }

        private List<string> GetProjectIdListInDataFolder()
        {
            var list = new List<string>();
            var subFolders = System.IO.Directory.GetDirectories(
                                      GetTestProjectsFolderDir(), "*", System.IO.SearchOption.TopDirectoryOnly)
                                       .Select(d => new DirectoryInfo(d).Name);
            list.AddRange(subFolders);
            return list;
        }

        private string GetProjectNameByIdInDataFolder(string id)
        {
            string d = GetProjectsDir(id) + @"\";
            string[] files = Directory.GetFiles(d, "*" + GetProjectFileExtension());
            return System.IO.Path.GetFileNameWithoutExtension(files[0]);
        }

        private string GetProjectFileName(string projectName)
        {
            return String.Format("{0}{1}", projectName, GetProjectFileExtension());
        }

        private string GetProjectFilePath(string id)
        {
            string projectName = GetProjectNameByIdInDataFolder(id);
            string projectFileName = GetProjectFileName(projectName);
            return String.Format(@"{0}\{1}", GetProjectsDir(id), projectFileName);
        }

        private string GetProjectFileExtension()
        {
            return "";
        }

    }
}
