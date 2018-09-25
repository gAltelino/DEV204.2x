using System;
using System.IO;

namespace Self1
{
    public abstract class Person : IDisposable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string PersonName()
        {
            return this.Name;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        private bool disposed = false;
        StreamReader sr;
        StreamWriter optFile;

        public void ReadDetails(string fileName)
        {
            sr = new StreamReader(fileName);

            try
            {
                using (sr)
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public void WriteDetails(string fileName)
        {
            optFile = new StreamWriter(fileName);

            string[] lines = { this.Name, this.Gender, this.Age.ToString() };

            try
            {
                using (optFile)
                {
                    foreach (string line in lines)
                    {
                        optFile.WriteLine(line);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("This file could not be written");
            }
            finally
            {
                optFile.Close();
                optFile = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (optFile != null)
                    {
                        optFile.Close();
                    }
                }
            }
            disposed = true;
        }

    }
}