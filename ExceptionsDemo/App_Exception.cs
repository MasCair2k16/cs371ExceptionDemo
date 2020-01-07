using System;

[Serializable]
public class App_Exception : Exception
{

    public App_Exception() { }

    public App_Exception(string message) : base(message) { }

    public App_Exception(string message, System.Exception inner) : base(message, inner) { }

    protected App_Exception(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

}