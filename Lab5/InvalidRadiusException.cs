namespace Lab5
{
    //Our created exception class to catch negative or infinity radius errors
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(string message) : base(message) { }
    }
}