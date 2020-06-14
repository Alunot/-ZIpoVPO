using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scan;

namespace ScanObjectBuilder
{
    public class ScanBuilder
    {
        public bool Object_builder(string path_to_file)
        {
            CheckFile chck_file = new CheckFile(path_to_file);
            ScanObject scanObject = new ScanObject();
            if (chck_file.IsFilePE())
            {
                return scanObject.Read(1, path_to_file);
            }
            else
            {
                if (chck_file.IsFileZip())
                {
                    return scanObject.Read(2, path_to_file);
                }
                else
                {
                    if (chck_file.IsFileDir())
                    {
                        return scanObject.Read(3, path_to_file);
                    }
                    else
                        return false;
                }
            }

            
            
        }

     
    }
}
