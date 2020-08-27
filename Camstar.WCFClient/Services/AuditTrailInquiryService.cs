// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AuditTrailInquiryService : InquiryBase
  {
    public AuditTrailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAuditTrailInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      AuditTrailInquiry auditTrailInquiry,
      AuditTrailInquiry_Parameters parameters,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      result = (AuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) auditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAuditTrailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, auditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new AuditTrailInquiryMethod(auditTrailInquiry, AuditTrailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) auditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AuditTrailInquiry) null, (AuditTrailInquiry_Parameters) null, (AuditTrailInquiry_Request) null, out AuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(AuditTrailInquiry auditTrailInquiry)
    {
      return this.GetWIPMsgs(auditTrailInquiry, (AuditTrailInquiry_Parameters) null, (AuditTrailInquiry_Request) null, out AuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AuditTrailInquiry auditTrailInquiry,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      return this.GetWIPMsgs(auditTrailInquiry, (AuditTrailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject auditTrailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AuditTrailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AuditTrailInquiry) auditTrailInquiry, (AuditTrailInquiry_Parameters) parameters, (AuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      result = (AuditTrailInquiry_Result) null;
      try
      {
        AuditTrailInquiryMethod[] methods = new AuditTrailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAuditTrailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AuditTrailInquiry cdo,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      result = (AuditTrailInquiry_Result) null;
      try
      {
        return ((IAuditTrailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AuditTrailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((AuditTrailInquiry) cdo, (AuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      return this.GetEnvironment((AuditTrailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AuditTrailInquiry cdo,
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      result = (AuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAuditTrailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AuditTrailInquiryMethod(cdo, AuditTrailInquiryMethods.ExecuteTransaction, (AuditTrailInquiry_Parameters) null));
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
        AuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AuditTrailInquiry) cdo, (AuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AuditTrailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (AuditTrailInquiry_Request) null, out AuditTrailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AuditTrailInquiry_Request request,
      out AuditTrailInquiry_Result result)
    {
      return this.ExecuteTransaction((AuditTrailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AuditTrailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AuditTrailInquiryMethod(cdo, AuditTrailInquiryMethods.AddDataTransaction, (AuditTrailInquiry_Parameters) null));
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
        return this.AddDataTransaction((AuditTrailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
