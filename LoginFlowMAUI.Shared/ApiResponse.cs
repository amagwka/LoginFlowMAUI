namespace LoginFlowMAUI.Shared; 

public sealed class ApiResponse<TData> {
    public ApiResponse(TData data = default!) => Data = data;

    public bool Status { get; set; } = true;
    public IEnumerable<string>? Errors { get; set; }
    public int StatusCode { get; set; } = 200;
    public TData Data { get; set; }

    public static ApiResponse<TData>
}