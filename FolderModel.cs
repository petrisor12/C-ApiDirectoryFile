using System;
using System.Collections;
using System.Collections.Generic;

namespace EsercitazioneApiDirectoryFile.ProgettoApi.Models
{
    public class FolderModel
    {
        public FolderModel()
        {
        }
       
        public string Name { get; set; }
        public IEnumerable<FileModel> FileChildren { get; set; }
        public IEnumerable<FolderModel> FolderChildren { get; set; }
    }
}
