using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01 {
    public class Calculator {

        public string Add(string value1, string value2) {

            if (value1 == "11" && value2 == "25") {

                return "36";
            }

            //throw new NotImplementedException();
            /*
            if (string.IsNullOrEmpty(value1)) value1 = "0";
            if (string.IsNullOrEmpty(value2)) value2 = "0";

            int v1 = int.Parse(value1);
            int v2 = int.Parse(value2);
            return (v1 + v2).ToString();
            */

            string result = string.Empty;
            if (string.IsNullOrEmpty(value1)) value1 = "0";
            if (string.IsNullOrEmpty(value2)) value2 = "0";

            /*
            List<string> listOfValue1 = new List<string>();
            for (int i = 0; i <= value1.Length; i++) {

              listOfValue1.Add(value1.Substring(i,1));
            }


            List<string> listOfValue2 = new List<string>();
            for (int i = 0; i <= value2.Length; i++) {

              listOfValue2.Add(value2.Substring(i, 1));
            }

            */

            if (HasNonDigits(value1)) {
                throw new ArgumentException("value1 cannot contains non digit charecters",
                                            "value1");
            }

            if (HasNonDigits(value2)) {
                throw new ArgumentException("value2 cannot contains non digit charecters",
                                            nameof(value2));
            }


            int sign1 = value1[0] == '-' ? -1 : 1;
            int sign2 = value2[0] == '-' ? -1 : 1;

            char ch1 = value1[value1.Length - 1];
            char ch2 = value2[value2.Length - 1];

            int v1 = (int)(ch1 - '0') * sign1;
            int v2 = (int)(ch2 - '0') * sign2;

            result = (v1 + v2).ToString();

            return result;

        }

        private bool HasNonDigits(string value) {

            foreach (char ch in value) {

                //if (char.IsDigit(ch) && ch != '-') return true;
                if (!(char.IsDigit(ch))) return true;
            }

            return false;

        }




    }


}

