namespace Camstar.Api.Exceptions
{
  public class InSiteException : CamstarException
  {
    private string mErrorCode = string.Empty;
    private string mErrorDescription = string.Empty;

    public InSiteException(
      string errorCode,
      string errorDescription,
      string errorSource,
      string errorSystemMessage,
      string fieldName,
      string severity)
      : base(nameof (InSiteException))
    {
      this.mErrorCode = errorCode;
      this.mErrorDescription = errorDescription;
      this.InSiteErrorSource = errorSource;
      this.InSiteErrorSystemMessage = errorSystemMessage;
      this.InSiteFieldName = fieldName;
      this.InSiteSeverity = severity;
    }

    public override string Id => !string.IsNullOrEmpty(this.mErrorCode) ? this.mErrorCode : base.Id;

    public override string Message => !string.IsNullOrEmpty(this.mErrorDescription) ? this.mErrorDescription : base.Message;

    public virtual string InSiteErrorCode => this.mErrorCode;

    public virtual string InSiteErrorDescription => this.mErrorDescription;

    public virtual string InSiteErrorSource { get; } = string.Empty;

    public virtual string InSiteErrorSystemMessage { get; } = string.Empty;

    public virtual string InSiteFieldName { get; } = string.Empty;

    public virtual string InSiteSeverity { get; } = string.Empty;
  }
}
