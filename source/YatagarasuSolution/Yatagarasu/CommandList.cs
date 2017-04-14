using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Yatagarasu
{
    [System.Runtime.Serialization.DataContract]
    class CommandList
    {
        [System.Runtime.Serialization.DataMember()]
        public List<UserCommand> UserCommands { get; set; }

        public CommandList()
        {
            UserCommands = new List<UserCommand>();
        }
        public static CommandList Create()
        {
            var list = new CommandList();
            list.Add(new UserCommand() { Name = "quit", Command = @"" });
            list.Add(new UserCommand() { Name = "version", Command = @"" });
            return list;
        }

        void Add(UserCommand userCommand)
        {
            UserCommands.Add(userCommand);
        }

        public bool IsExists(string commandName)
        {
            return UserCommands.Find(x => x.Name.ToLower() == commandName.ToLower()) != null;
        }

        public void Execute(string commandName)
        {
            UserCommands.Find(x => x.Name.ToLower() == commandName.ToLower()).Execute();
        }

        public ObservableCollection<UserCommand> GetSource()
        {
            var source = new ObservableCollection<UserCommand>();
            foreach (var each in UserCommands)
            {
                source.Add(each);
            }
            return source;
        }

        private static string GetPathUserDataFile()
        {
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string appDirPath = Path.GetDirectoryName(appPath);
            return Path.Combine(appDirPath, "yatagarasu-commandlist.json");
        }

        public void Save()
        {
            using (var stream = new FileStream(GetPathUserDataFile(), FileMode.OpenOrCreate))
            {
                var serializer = new DataContractJsonSerializer(this.GetType());
                serializer.WriteObject(stream, this);
            }
        }

        public static CommandList Load()
        {
            var filepath = GetPathUserDataFile();

            if (!File.Exists(filepath))
            {
                return CommandList.Create();
            }

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CommandList));

            //読み込むファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                filepath, new System.Text.UTF8Encoding(false));

            using (sr)
            {
                //XMLファイルから読み込み、逆シリアル化する
                CommandList obj = (CommandList)ser.ReadObject(sr.BaseStream);
                //ファイルを閉じる
                sr.Close();
                return obj;
            }
        }
    }
}
