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
        public const string PATH = "C:\\Users\\KEVIN PHAM\\Documents\\GitHub\\genasys-test-viewer\\test file.csv";

        // Error messages.
        public const string ERR_1 = " column cannot be found";

        // Miscellaneous constants.
        public const string CHT_HEADER_UNIT_SN = "Unit SN";
        public const string CHT_HEADER_DATE = "Date";
        public const string CHT_HEADER_TIME = "Time";
        public const string CHT_HEADER_PASS_FAIL = "Pass/Fail";
        public const string LBL_TESTS_FOUND = " test(s) found";
        public const string LBL_INCONCLUSIVE = "INCONCLUSIVE";
        public const int INIT_LOC_TIME_X = 3;
        public const int INIT_LOC_TIME_Y = 19;
        public const int SEARCH_SPACING = 17;
    }
}
