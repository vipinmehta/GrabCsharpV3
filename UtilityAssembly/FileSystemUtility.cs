using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UtilityAssembly
{
    
    public class FileSystemUtility 
    {
        public void CreateTextFileV1(string directoryName)
        {//
            //Thread
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        public void CreateTextFileV2(string directoryName)
        {
            //Task
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        public void CreateDirectory(string directoryName)
        {
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        public void DeleteDirectory(string directoryName, bool recursive)
        {
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, recursive);
            }
        }

        public bool DirectoryExists(string directoryName)
        {
            return Directory.Exists(directoryName);
        }

        public IEnumerable<DirectoryModel> GetDirectories(string directoryName)
        {
            return new DirectoryInfo(directoryName).GetDirectories().Select(a => new DirectoryModel
            {
                CreationTimeUtc = a.CreationTimeUtc,
                Name = a.Name,
                FullName = a.FullName
            });
        }

        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public FileStream CreateFile(string filePath)
        {
            return File.Create(filePath);
        }
        public void DeleteFile(string fileName)
        {
            if (FileExists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public IEnumerable<FileModel> GetFiles(string directoryName, string searchPattern)
        {
            return new DirectoryInfo(directoryName).GetFiles(searchPattern).Select(a => new FileModel
            {
                CreationTimeUtc = a.CreationTimeUtc,
                Name = a.Name,
                FullName = a.FullName
            });
        }

        public FileInfo GetFirstFile(string directoryName)
        {
            return new DirectoryInfo(directoryName).GetFiles().First();
        }
    }

    public interface IFileSystemService
    {
        void CreateDirectory(string directoryName);
        void DeleteDirectory(string directoryName, bool recursive);
        void WriteAllText(string path, string contents);
        string ReadAllText(string path);
        bool DirectoryExists(string directoryName);
        IEnumerable<DirectoryModel> GetDirectories(string directoryName);
        IEnumerable<FileModel> GetFiles(string directoryName, string searchPattern);
        FileInfo GetFirstFile(string directoryName);
        bool FileExists(string fileName);
        void DeleteFile(string fileName);
    }

    public class DirectoryModel
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime CreationTimeUtc { get; set; }
    }
    public class FileModel
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime CreationTimeUtc { get; set; }
    }
}