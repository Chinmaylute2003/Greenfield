using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    public class OfficeBoy
    {
        private static OfficeBoy _ref = null;
        private OfficeBoy()
        {
            //Default constructor
        }

        public static OfficeBoy Create()
        {
            if( _ref == null)
            {
                _ref = new OfficeBoy();
                return _ref;
            }
            else
            {
                return _ref;
            }
        }

    }
}
