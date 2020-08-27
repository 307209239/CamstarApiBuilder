// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessTimerInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessTimerInquiryService : InquiryBase
  {
    public ProcessTimerInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessTimerInquiryService), userProfile);
    }

    public ResultStatus GetTimers(
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Parameters parameters,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      result = (ProcessTimerInquiry_Result) null;
      this.OnBeforeCall(nameof (GetTimers), (DCObject) processTimerInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerInquiryService) this._Channel).GetTimers(this._UserProfile, processTimerInquiry, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerInquiryMethod(processTimerInquiry, ProcessTimerInquiryMethods.GetTimers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTimers), res, (DCObject) processTimerInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTimers()
    {
      return this.GetTimers((ProcessTimerInquiry) null, (ProcessTimerInquiry_Parameters) null, (ProcessTimerInquiry_Request) null, out ProcessTimerInquiry_Result _);
    }

    public ResultStatus GetTimers(ProcessTimerInquiry processTimerInquiry)
    {
      return this.GetTimers(processTimerInquiry, (ProcessTimerInquiry_Parameters) null, (ProcessTimerInquiry_Request) null, out ProcessTimerInquiry_Result _);
    }

    public ResultStatus GetTimers(
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      return this.GetTimers(processTimerInquiry, (ProcessTimerInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Parameters parameters,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      result = (ProcessTimerInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processTimerInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, processTimerInquiry, parameters, request, out result) : this.AddMethod((Method) new ProcessTimerInquiryMethod(processTimerInquiry, ProcessTimerInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processTimerInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessTimerInquiry) null, (ProcessTimerInquiry_Parameters) null, (ProcessTimerInquiry_Request) null, out ProcessTimerInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ProcessTimerInquiry processTimerInquiry)
    {
      return this.GetWIPMsgs(processTimerInquiry, (ProcessTimerInquiry_Parameters) null, (ProcessTimerInquiry_Request) null, out ProcessTimerInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessTimerInquiry processTimerInquiry,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      return this.GetWIPMsgs(processTimerInquiry, (ProcessTimerInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processTimerInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessTimerInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessTimerInquiry) processTimerInquiry, (ProcessTimerInquiry_Parameters) parameters, (ProcessTimerInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      result = (ProcessTimerInquiry_Result) null;
      try
      {
        ProcessTimerInquiryMethod[] methods = new ProcessTimerInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessTimerInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessTimerInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessTimerInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerInquiry cdo,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      result = (ProcessTimerInquiry_Result) null;
      try
      {
        return ((IProcessTimerInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessTimerInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessTimerInquiry) cdo, (ProcessTimerInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      return this.GetEnvironment((ProcessTimerInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerInquiry cdo,
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      result = (ProcessTimerInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessTimerInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessTimerInquiryMethod(cdo, ProcessTimerInquiryMethods.ExecuteTransaction, (ProcessTimerInquiry_Parameters) null));
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
        ProcessTimerInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessTimerInquiry) cdo, (ProcessTimerInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessTimerInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessTimerInquiry_Request) null, out ProcessTimerInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessTimerInquiry_Request request,
      out ProcessTimerInquiry_Result result)
    {
      return this.ExecuteTransaction((ProcessTimerInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessTimerInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessTimerInquiryMethod(cdo, ProcessTimerInquiryMethods.AddDataTransaction, (ProcessTimerInquiry_Parameters) null));
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
        return this.AddDataTransaction((ProcessTimerInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
