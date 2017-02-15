namespace TreeDefense
{
    class TreeDefenseException : System.Exception
    {
        public TreeDefenseException()
        {
        }
        
        public TreeDefenseException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : TreeDefenseException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
