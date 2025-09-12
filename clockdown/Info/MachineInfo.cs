using System;

namespace clockdown
{
    public class MachineInfo
    {
        public string KeyRecord { get; set; }
        public int MachineNumber { get; set; }
        public int IndRegID { get; set; }
        public string DateTimeRecord { get; set; }

        public int VerifyMode { get; set; }

        public int InOutMode { get; set; }

        public int WorkCode { get; set; }

        public DateTime DateOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("dd/MM/yyyy")); }
        }
        public DateTime TimeOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("HH:mm:ss tt")); }
        }

    }
}
