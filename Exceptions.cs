namespace CastleDefense
{
    class CastleDefenseException : System.Exception
    {
        public CastleDefenseException()
        {
        }
        
        public CastleDefenseException(string message) : base(message)
        {
        }
    }
    
    class OutOfBoundsException : CastleDefenseException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
