using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface People {
        void Create();
        void Delete();
        void Edit();

        object Find();

    }
    
    public class Professor : People
    {
        public void Create()
        {
            // Rules
            throw new NotImplementedException();
        }

        public void Delete()
        {
            // Rules
            throw new NotImplementedException();
        }

        public void Edit()
        {
            // Rules
            throw new NotImplementedException();
        }

        public object Find()
        {
            // Rules
            throw new NotImplementedException();
        }
    }
    public class Pupil : People
    {
        public void Create()
        {
            // Rules
            throw new NotImplementedException();
        }

        public void Delete()
        {
            // Rules
            throw new NotImplementedException();
        }

        public void Edit()
        {
            // Rules
            throw new NotImplementedException();
        }

        public object Find()
        {
            // Rules
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
