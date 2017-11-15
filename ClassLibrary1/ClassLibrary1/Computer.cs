using System;

namespace ClassLibrary1
{
    public interface Computer
    {
        //Property
        string Name
        {
            get;
        }

        //This method is like a contract. All classes
        //must implement this method in order to inherit
        double Execute(params string[] values);
    }
}
