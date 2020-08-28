namespace Camstar.Api.Exceptions
{
  public class AdHocException : CamstarException
  {
      public AdHocException(string id, string message)
    {
      this.Id = id;
      this.Message = message;
      this.Key = this.GetType().Name;
    }

    public AdHocException(string id, string key, string message)
    {
      this.Id = id;
      this.Message = message;
      this.Key = key;
    }

    public override string Message { get; } = string.Empty;

    public override string Id { get; } = string.Empty;

    public override string Key { get; } = string.Empty;
  }
}
