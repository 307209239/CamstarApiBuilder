// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_SecurityAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_SecurityAuditTrailInquiryService : AuditTrailInquiryBase
  {
    public V4_SecurityAuditTrailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_SecurityAuditTrailInquiryService), userProfile);
    }

    public ResultStatus GetAuditTrailDetails(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAuditTrailDetails), (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SecurityAuditTrailInquiryService) this._Channel).GetAuditTrailDetails(this._UserProfile, v4_SecurityAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_SecurityAuditTrailInquiryMethod(v4_SecurityAuditTrailInquiry, V4_SecurityAuditTrailInquiryMethods.GetAuditTrailDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAuditTrailDetails), res, (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAuditTrailDetails()
    {
      return this.GetAuditTrailDetails((V4_SecurityAuditTrailInquiry) null, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailDetails(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry)
    {
      return this.GetAuditTrailDetails(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailDetails(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      return this.GetAuditTrailDetails(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetAuditTrailHeaders(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAuditTrailHeaders), (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SecurityAuditTrailInquiryService) this._Channel).GetAuditTrailHeaders(this._UserProfile, v4_SecurityAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_SecurityAuditTrailInquiryMethod(v4_SecurityAuditTrailInquiry, V4_SecurityAuditTrailInquiryMethods.GetAuditTrailHeaders, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAuditTrailHeaders), res, (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAuditTrailHeaders()
    {
      return this.GetAuditTrailHeaders((V4_SecurityAuditTrailInquiry) null, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry)
    {
      return this.GetAuditTrailHeaders(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      return this.GetAuditTrailHeaders(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Parameters parameters,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SecurityAuditTrailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, v4_SecurityAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new V4_SecurityAuditTrailInquiryMethod(v4_SecurityAuditTrailInquiry, V4_SecurityAuditTrailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_SecurityAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_SecurityAuditTrailInquiry) null, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry)
    {
      return this.GetWIPMsgs(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_SecurityAuditTrailInquiry v4_SecurityAuditTrailInquiry,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      return this.GetWIPMsgs(v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_SecurityAuditTrailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SecurityAuditTrailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_SecurityAuditTrailInquiry) v4_SecurityAuditTrailInquiry, (V4_SecurityAuditTrailInquiry_Parameters) parameters, (V4_SecurityAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      try
      {
        V4_SecurityAuditTrailInquiryMethod[] methods = new V4_SecurityAuditTrailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_SecurityAuditTrailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_SecurityAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_SecurityAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_SecurityAuditTrailInquiry cdo,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      try
      {
        return ((IV4_SecurityAuditTrailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_SecurityAuditTrailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_SecurityAuditTrailInquiry) cdo, (V4_SecurityAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      return this.GetEnvironment((V4_SecurityAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_SecurityAuditTrailInquiry cdo,
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      result = (V4_SecurityAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SecurityAuditTrailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_SecurityAuditTrailInquiryMethod(cdo, V4_SecurityAuditTrailInquiryMethods.ExecuteTransaction, (V4_SecurityAuditTrailInquiry_Parameters) null));
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
        V4_SecurityAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_SecurityAuditTrailInquiry) cdo, (V4_SecurityAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_SecurityAuditTrailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_SecurityAuditTrailInquiry_Request) null, out V4_SecurityAuditTrailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_SecurityAuditTrailInquiry_Request request,
      out V4_SecurityAuditTrailInquiry_Result result)
    {
      return this.ExecuteTransaction((V4_SecurityAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_SecurityAuditTrailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_SecurityAuditTrailInquiryMethod(cdo, V4_SecurityAuditTrailInquiryMethods.AddDataTransaction, (V4_SecurityAuditTrailInquiry_Parameters) null));
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
        return this.AddDataTransaction((V4_SecurityAuditTrailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
