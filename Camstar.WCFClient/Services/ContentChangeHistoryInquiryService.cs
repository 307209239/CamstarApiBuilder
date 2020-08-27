// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContentChangeHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContentChangeHistoryInquiryService : ChangePackageInquiryBase
  {
    public ContentChangeHistoryInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContentChangeHistoryInquiryService), userProfile);
    }

    public ResultStatus GetAuditTrailHeaders(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAuditTrailHeaders), (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).GetAuditTrailHeaders(this._UserProfile, contentChangeHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(contentChangeHistoryInquiry, ContentChangeHistoryInquiryMethods.GetAuditTrailHeaders, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAuditTrailHeaders), res, (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAuditTrailHeaders()
    {
      return this.GetAuditTrailHeaders((ContentChangeHistoryInquiry) null, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry)
    {
      return this.GetAuditTrailHeaders(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.GetAuditTrailHeaders(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, contentChangeHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(contentChangeHistoryInquiry, ContentChangeHistoryInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContentChangeHistoryInquiry) null, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry)
    {
      return this.GetWIPMsgs(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.GetWIPMsgs(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus SetEndTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (SetEndTimestamp), (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).SetEndTimestamp(this._UserProfile, contentChangeHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(contentChangeHistoryInquiry, ContentChangeHistoryInquiryMethods.SetEndTimestamp, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetEndTimestamp), res, (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetEndTimestamp()
    {
      return this.SetEndTimestamp((ContentChangeHistoryInquiry) null, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetEndTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry)
    {
      return this.SetEndTimestamp(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetEndTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.SetEndTimestamp(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus SetInstances(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (SetInstances), (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).SetInstances(this._UserProfile, contentChangeHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(contentChangeHistoryInquiry, ContentChangeHistoryInquiryMethods.SetInstances, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetInstances), res, (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetInstances()
    {
      return this.SetInstances((ContentChangeHistoryInquiry) null, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetInstances(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry)
    {
      return this.SetInstances(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetInstances(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.SetInstances(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus SetStartTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Parameters parameters,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (SetStartTimestamp), (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).SetStartTimestamp(this._UserProfile, contentChangeHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(contentChangeHistoryInquiry, ContentChangeHistoryInquiryMethods.SetStartTimestamp, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetStartTimestamp), res, (DCObject) contentChangeHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetStartTimestamp()
    {
      return this.SetStartTimestamp((ContentChangeHistoryInquiry) null, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetStartTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry)
    {
      return this.SetStartTimestamp(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus SetStartTimestamp(
      ContentChangeHistoryInquiry contentChangeHistoryInquiry,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.SetStartTimestamp(contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject contentChangeHistoryInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContentChangeHistoryInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContentChangeHistoryInquiry) contentChangeHistoryInquiry, (ContentChangeHistoryInquiry_Parameters) parameters, (ContentChangeHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      try
      {
        ContentChangeHistoryInquiryMethod[] methods = new ContentChangeHistoryInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContentChangeHistoryInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContentChangeHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContentChangeHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContentChangeHistoryInquiry cdo,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      try
      {
        return ((IContentChangeHistoryInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContentChangeHistoryInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ContentChangeHistoryInquiry) cdo, (ContentChangeHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.GetEnvironment((ContentChangeHistoryInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContentChangeHistoryInquiry cdo,
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      result = (ContentChangeHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContentChangeHistoryInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(cdo, ContentChangeHistoryInquiryMethods.ExecuteTransaction, (ContentChangeHistoryInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContentChangeHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContentChangeHistoryInquiry) cdo, (ContentChangeHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContentChangeHistoryInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ContentChangeHistoryInquiry_Request) null, out ContentChangeHistoryInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContentChangeHistoryInquiry_Request request,
      out ContentChangeHistoryInquiry_Result result)
    {
      return this.ExecuteTransaction((ContentChangeHistoryInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContentChangeHistoryInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContentChangeHistoryInquiryMethod(cdo, ContentChangeHistoryInquiryMethods.AddDataTransaction, (ContentChangeHistoryInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ContentChangeHistoryInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
