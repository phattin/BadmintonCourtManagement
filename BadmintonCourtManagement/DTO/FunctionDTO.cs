namespace BadmintonCourtManagement.DTO
{
    public class FunctionDTO
    {
        private string functionId = "";
        private string functionName = "";

        public string FunctionId { get => functionId; set => functionId = value; }
        public string FunctionName { get => functionName; set => functionName = value; }

        public FunctionDTO()
        {
            functionId = "";
            functionName = "";
        }

        public FunctionDTO(string functionId, string functionName)
        {
            this.functionId = functionId;
            this.functionName = functionName;
        }
    }
}