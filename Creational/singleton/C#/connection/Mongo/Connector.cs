using System;

namespace connection
{
    public class Connector
    {
        private static Connector _connector;
        private string _name;

        private Connector(){}

        public static Connector GetInstance()
        {
            if (_connector == null)
            {
                _connector = new Connector();
                _connector.SetName();
            }

            return _connector;
        }

        public void SetName()
        {
            _name = "instance-id-" + DateTime.Now.ToString("hh:mm:ss.ff");
            Console.WriteLine(_name);
        }

        public void Connect()
        {
            Console.WriteLine("connected to db with {0}", _name);
        }
    }
}