namespace ComandaZap.Services
{
    public class Output<T>
    {
        public T Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public static Output<T> Success(T result)
        {
            var output = new Output<T>();
            output.IsSuccess = true;
            output.Result = result;
            return output;
        }

        public static Output<T> Failure(T result)
        {
            var output = new Output<T>();
            output.IsSuccess = false;
            output.Result = result;
            return output;
        }

        public Output<T> AddMessage(string message)
        {
            this.Message= message;
            return this;
        }
    }
}
