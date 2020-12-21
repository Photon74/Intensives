using System;

namespace Ex00Crutches
{

    class TTest_Class
    {
        
        const Double пи = 3.1415;
        static public int k__BackingField;

        static public void set_MyProperty(int value)
        {
            k__BackingField = value;
        }

        static public int get_MyProperty()
        {
            return k__BackingField;
        }
        static public int MyProperty { get; set; }
    }
}
