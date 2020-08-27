// Decompiled with JetBrains decompiler
// Type: Camstar.Exceptions.InSiteException
// Assembly: Camstar.Exceptions, Version=7.8.7004.31019, Culture=neutral, PublicKeyToken=null
// MVID: DCD1F3EE-20E6-4307-A2E0-3C6DF5B436BE
// Assembly location: E:\WCFServicesGenerator\Camstar.Exceptions.dll

namespace Camstar.Exceptions
{
  public class InSiteException : CamstarException
  {
    private string mErrorCode = string.Empty;
    private string mErrorDescription = string.Empty;
    private string mErrorSource = string.Empty;
    private string mErrorSystemMessage = string.Empty;
    private string mFieldName = string.Empty;
    private string mSeverity = string.Empty;

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
      this.mErrorSource = errorSource;
      this.mErrorSystemMessage = errorSystemMessage;
      this.mFieldName = fieldName;
      this.mSeverity = severity;
    }

    public override string Id
    {
      get
      {
        return this.mErrorCode != null && this.mErrorCode != string.Empty ? this.mErrorCode : base.Id;
      }
    }

    public override string Message
    {
      get
      {
        return this.mErrorDescription != null && this.mErrorDescription != string.Empty ? this.mErrorDescription : base.Message;
      }
    }

    public virtual string InSiteErrorCode
    {
      get
      {
        return this.mErrorCode;
      }
    }

    public virtual string InSiteErrorDescription
    {
      get
      {
        return this.mErrorDescription;
      }
    }

    public virtual string InSiteErrorSource
    {
      get
      {
        return this.mErrorSource;
      }
    }

    public virtual string InSiteErrorSystemMessage
    {
      get
      {
        return this.mErrorSystemMessage;
      }
    }

    public virtual string InSiteFieldName
    {
      get
      {
        return this.mFieldName;
      }
    }

    public virtual string InSiteSeverity
    {
      get
      {
        return this.mSeverity;
      }
    }
  }
}
