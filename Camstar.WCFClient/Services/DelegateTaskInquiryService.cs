// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegateTaskInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegateTaskInquiryService : InquiryBase
  {
    public DelegateTaskInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegateTaskInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTaskInquiry delegateTaskInquiry,
      DelegateTaskInquiry_Parameters parameters,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      result = (DelegateTaskInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegateTaskInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, delegateTaskInquiry, parameters, request, out result) : this.AddMethod((Method) new DelegateTaskInquiryMethod(delegateTaskInquiry, DelegateTaskInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegateTaskInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegateTaskInquiry) null, (DelegateTaskInquiry_Parameters) null, (DelegateTaskInquiry_Request) null, out DelegateTaskInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(DelegateTaskInquiry delegateTaskInquiry)
    {
      return this.GetWIPMsgs(delegateTaskInquiry, (DelegateTaskInquiry_Parameters) null, (DelegateTaskInquiry_Request) null, out DelegateTaskInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegateTaskInquiry delegateTaskInquiry,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      return this.GetWIPMsgs(delegateTaskInquiry, (DelegateTaskInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegateTaskInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateTaskInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegateTaskInquiry) delegateTaskInquiry, (DelegateTaskInquiry_Parameters) parameters, (DelegateTaskInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      result = (DelegateTaskInquiry_Result) null;
      try
      {
        DelegateTaskInquiryMethod[] methods = new DelegateTaskInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegateTaskInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegateTaskInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegateTaskInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTaskInquiry cdo,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      result = (DelegateTaskInquiry_Result) null;
      try
      {
        return ((IDelegateTaskInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegateTaskInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegateTaskInquiry) cdo, (DelegateTaskInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      return this.GetEnvironment((DelegateTaskInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTaskInquiry cdo,
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      result = (DelegateTaskInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateTaskInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegateTaskInquiryMethod(cdo, DelegateTaskInquiryMethods.ExecuteTransaction, (DelegateTaskInquiry_Parameters) null));
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
        DelegateTaskInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegateTaskInquiry) cdo, (DelegateTaskInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegateTaskInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegateTaskInquiry_Request) null, out DelegateTaskInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegateTaskInquiry_Request request,
      out DelegateTaskInquiry_Result result)
    {
      return this.ExecuteTransaction((DelegateTaskInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegateTaskInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegateTaskInquiryMethod(cdo, DelegateTaskInquiryMethods.AddDataTransaction, (DelegateTaskInquiry_Parameters) null));
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
        return this.AddDataTransaction((DelegateTaskInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
