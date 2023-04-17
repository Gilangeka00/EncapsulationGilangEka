using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsuletion;

namespace Encapsuletion
{
    internal class laptop
    {
        //field
        public string MEREK;
        public string MODEL;
        protected string TAHUN;

        //propeties
        public string merek
        {
            get { return MEREK; }
            set { MEREK = value; }
        }
        public string model
        {
            get { return MODEL; }
            set { MODEL = value; }
        }

        public string tahun
        {
            get { return TAHUN; }
            set { TAHUN = value; }
        }
        //method
        public void SetLaptop(string merek, string model)
        {
            this.MEREK = merek;
            this.MODEL = model;
            Console.WriteLine("Merek Laptop : {0}", this.MEREK);
            Console.WriteLine("Model Laptop : {0}", this.MODEL);
           
        }
        public void SetTahunkeluar(string tahun)
        {
            this.TAHUN = tahun;
            Console.WriteLine("Tahun Keluaran : {0}", this.TAHUN);
        }
    }
}
