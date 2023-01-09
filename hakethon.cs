using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sampleconsoleapp
{
    class PatientDetail
    {
        public string PatintName { get; set; }
        public string DesieseName { get; set; }
        public string SymtomsName { get; set; }
        public string Description { get; set; }

        public static implicit operator Array(PatientDetail v)
        {
            throw new NotImplementedException();
        }

    }
    class PatientManegeMent
    {
        private Array[] _accounts = null;
        private int _size = 0;
        public PatientManegeMent(int size)
        {
            _size = size;
            _accounts = new Array[_size];

        }

        public void Addsymptoms(PatientDetail patientDetail)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_accounts[i] == null)
                {
                    _accounts[i] = new PatientDetail { PatintName = patientDetail.PatintName, DesieseName = patientDetail.DesieseName, SymtomsName = patientDetail.SymtomsName, Description = patientDetail.Description };
                    return;
                }

            }
        }

    }

    //class UserI
    //{
    //    public const string menu = "patient detail\n  " +
    //        "To add the Desies";

    //}


    class Patient
    {
        int id;
        string name;
        string PatienDe;


        public int PatiId
        {
            get { return id; }
            set { id = value; }
        }
        public string PatiName
        {
            get { return name; }
            set { name = value; }
        }
        public string PatiDis
        {
            get { return PatienDe; }
            set { PatienDe = value; }

        }
    }


        class Hakethon
        {

            static void Main(string[] args)
            {

                Patient patient = new Patient { PatiId = 101, PatiName = "raju", PatiDis = "maleria" };
                Console.WriteLine("the patient ID is " + patient.PatiId);
                Console.WriteLine("the patient name is " + patient.PatiName);
                Console.WriteLine(" the patient Disease "+patient.PatiDis);



            }
        }
}


