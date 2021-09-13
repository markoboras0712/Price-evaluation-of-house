using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class House
    {
        private string bedrooms;
        private string bathrooms;
        private string sqft_living;
        private string sqft_lot;
        private string floors;
        private string waterfront;
        private string view;
        private string condition;
        private string grade;
        private string yr_built;
        private string yr_renovated;
        private string zipcode;

        public House(string mbedrooms,string mbathrooms,string msqft_living,string msqft_lot,string mfloors, string mwaterfront,
            string mview, string mcondition, string mgrade, string myr_built, string myr_renovated, string mzipcode){
            bedrooms = mbedrooms;
            bathrooms = mbathrooms;
            sqft_living = msqft_living;
            sqft_lot = msqft_lot;
            floors = mfloors;
            waterfront = mwaterfront;
            view = mview;
            condition = mcondition;
            grade = mgrade;
            yr_built = myr_built;
            yr_renovated = myr_renovated;
            zipcode = mzipcode;

        }
        public string Bedrooms { get; set; }

        public string Bathrooms { get; set; }
        public string Sqft_living { get; set; }
        public string Sqft_lot { get; set; }
        public string Floors { get; set; }
        public string Waterfront { get; set; }
        public string View { get; set; }
        public string Condition { get; set; }
        public string Yr_built { get; set; }
        public string Yr_renovated { get; set; }
        public string Zipcode { get; set; }
        public string Grade { get; set; }


    }
}
