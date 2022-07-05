using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genasys_test_viewer
{
    static class Constants
    {
        // Path of the CSV file.
        public const string PATH = "Z:\\Kevin Pham\\450XL Test Log (Post-Test).csv";

        // Error messages.
        public const string ERR_1 = " column cannot be found";
        public const string ERR_2 = "Date is missing for row ";
        public const string ERR_3 = "Time is missing for row ";
        public const string ERR_4 = "Missing header row";

        // Miscellaneous constants.
        public const string MINIMIZE = "🗕";
        public const string MAXIMIZE = "🗖";
        public const string CHT_HEADER_UNIT_SN = "Unit SN";
        public const string CHT_HEADER_OPERATOR = "Operator";
        public const string CHT_HEADER_WONum = "WO No";
        public const string CHT_HEADER_DATE = "Date";
        public const string CHT_HEADER_TIME = "Time";
        public const string CHT_HEADER_MODEL = "Model";
        public const string CHT_HEADER_DRIVER = "Driver";
        public const string CHT_HEADER_SN = "SN";
        public const string CHT_HEADER_PASS_FAIL = "System P/F";
        public const string LBL_TESTS_FOUND = " test(s) found";
        public const string LBL_PASSED = "PASSED";
        public const string LBL_INCONCLUSIVE = "INCONCLUSIVE";
        public const string LBL_FAILED = "FAILED";
    }
}
