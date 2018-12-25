using System;
using System.Collections.Generic;

using System.IO;
using EsercitazioneApiDirectoryFile.ProgettoApi.Models;
using Microsoft.Extensions.Configuration;

namespace EsercitazioneApiDirectoryFile.Dati
{
    public class DatiFolder :IDati
    {
        string _connectionString;
        DirectoryInfo DirInfo;
        public DatiFolder(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("baseFolder");
             DirInfo = new DirectoryInfo(_connectionString);
    }
      

        public IEnumerable<FileModel> GetFile(DirectoryInfo DirInfo)
        { List<FileModel> list = new List<FileModel>();
            if (!(DirInfo.EnumerateFiles() == null))
            {
                foreach (var dir in DirInfo.EnumerateFiles())

                {
                    var x = new FileModel();
                    x.Name = dir.Name;
                    x.Size = (int)dir.Length;
                    list.Add(x);



                }
            }
                return list;

        }
        public IEnumerable<FolderModel> GetFolders(DirectoryInfo DirInfo)
        {
            List<FolderModel> listDirectory = new List<FolderModel>();
            if (!(DirInfo.EnumerateDirectories() == null))
            {
               
                foreach(var dir in DirInfo.EnumerateDirectories())

                {
                    var m = new FolderModel();
                    m.Name = dir.Name;

                    m.FileChildren = GetFile(dir);
                    m.FolderChildren = GetFolders(dir);
                    listDirectory.Add(m);


                }
            }
           
            return listDirectory;

        }


        public FolderModel GetFolder()
        {
           
            var folderModel = new FolderModel();
            folderModel.Name = DirInfo.Name;
            folderModel.FolderChildren = GetFolders(DirInfo);
            folderModel.FileChildren = GetFile(DirInfo);

            return folderModel;
        }
       


    }

}
