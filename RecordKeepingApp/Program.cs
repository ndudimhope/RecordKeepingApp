using RecordKeepingApp.Library;
using System;

namespace RecordKeepingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an attendance register that meets lecturers needs
            IRecordKeeper<string, bool> attendanceRegister1 = new RecordKeeper<string, bool>();

            //Populate the attendance register
            attendanceRegister1.AcceptInput("UNILAG/1001", true);
            attendanceRegister1.AcceptInput("UNILAG/1002", true);
            attendanceRegister1.AcceptInput("UNILAG/1003", false);
            attendanceRegister1.AcceptInput("UNILAG/1004", true);


            //Createinstance for the receptionist
            IRecordKeeper<DateTime, string> visitorRegister = new RecordKeeper<DateTime, string>();

            //Populate the attendance register
            visitorRegister.AcceptInput(DateTime.Now, "Tunde Badmus");
        }
    }
}
