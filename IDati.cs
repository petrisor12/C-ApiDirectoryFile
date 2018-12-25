using System;
using System.Collections.Generic;
using System.IO;
using EsercitazioneApiDirectoryFile.ProgettoApi.Models;

namespace EsercitazioneApiDirectoryFile.Dati
{
    public interface IDati
    {
        IEnumerable<FileModel> GetFile(DirectoryInfo DirInfo);
       FolderModel GetFolder();
    }
  
}
