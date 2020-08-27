// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegateDateInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DelegateDateInquiryService : InquiryBase
  {
    public DelegateDateInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDelegateDateInquiryService), userProfile);
    }

    public ResultStatus GetTasks(
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Parameters parameters,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      result = (DelegateDateInquiry_Result) null;
      this.OnBeforeCall(nameof (GetTasks), (DCObject) delegateDateInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateDateInquiryService) this._Channel).GetTasks(this._UserProfile, delegateDateInquiry, parameters, request, out result) : this.AddMethod((Method) new DelegateDateInquiryMethod(delegateDateInquiry, DelegateDateInquiryMethods.GetTasks, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTasks), res, (DCObject) delegateDateInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTasks()
    {
      return this.GetTasks((DelegateDateInquiry) null, (DelegateDateInquiry_Parameters) null, (DelegateDateInquiry_Request) null, out DelegateDateInquiry_Result _);
    }

    public ResultStatus GetTasks(DelegateDateInquiry delegateDateInquiry)
    {
      return this.GetTasks(delegateDateInquiry, (DelegateDateInquiry_Parameters) null, (DelegateDateInquiry_Request) null, out DelegateDateInquiry_Result _);
    }

    public ResultStatus GetTasks(
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      return this.GetTasks(delegateDateInquiry, (DelegateDateInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Parameters parameters,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      result = (DelegateDateInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) delegateDateInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateDateInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, delegateDateInquiry, parameters, request, out result) : this.AddMethod((Method) new DelegateDateInquiryMethod(delegateDateInquiry, DelegateDateInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) delegateDateInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DelegateDateInquiry) null, (DelegateDateInquiry_Parameters) null, (DelegateDateInquiry_Request) null, out DelegateDateInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(DelegateDateInquiry delegateDateInquiry)
    {
      return this.GetWIPMsgs(delegateDateInquiry, (DelegateDateInquiry_Parameters) null, (DelegateDateInquiry_Request) null, out DelegateDateInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DelegateDateInquiry delegateDateInquiry,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      return this.GetWIPMsgs(delegateDateInquiry, (DelegateDateInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject delegateDateInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DelegateDateInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DelegateDateInquiry) delegateDateInquiry, (DelegateDateInquiry_Parameters) parameters, (DelegateDateInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      result = (DelegateDateInquiry_Result) null;
      try
      {
        DelegateDateInquiryMethod[] methods = new DelegateDateInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDelegateDateInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DelegateDateInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DelegateDateInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateDateInquiry cdo,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      result = (DelegateDateInquiry_Result) null;
      try
      {
        return ((IDelegateDateInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DelegateDateInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((DelegateDateInquiry) cdo, (DelegateDateInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      return this.GetEnvironment((DelegateDateInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DelegateDateInquiry cdo,
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      result = (DelegateDateInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDelegateDateInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DelegateDateInquiryMethod(cdo, DelegateDateInquiryMethods.ExecuteTransaction, (DelegateDateInquiry_Parameters) null));
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
        DelegateDateInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DelegateDateInquiry) cdo, (DelegateDateInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DelegateDateInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (DelegateDateInquiry_Request) null, out DelegateDateInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DelegateDateInquiry_Request request,
      out DelegateDateInquiry_Result result)
    {
      return this.ExecuteTransaction((DelegateDateInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DelegateDateInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DelegateDateInquiryMethod(cdo, DelegateDateInquiryMethods.AddDataTransaction, (DelegateDateInquiry_Parameters) null));
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
        return this.AddDataTransaction((DelegateDateInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
