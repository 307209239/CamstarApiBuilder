// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SystemInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SystemInfoInquiryService : InquiryBase
  {
    public SystemInfoInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISystemInfoInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      SystemInfoInquiry systemInfoInquiry,
      SystemInfoInquiry_Parameters parameters,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      result = (SystemInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) systemInfoInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISystemInfoInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, systemInfoInquiry, parameters, request, out result) : this.AddMethod((Method) new SystemInfoInquiryMethod(systemInfoInquiry, SystemInfoInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) systemInfoInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SystemInfoInquiry) null, (SystemInfoInquiry_Parameters) null, (SystemInfoInquiry_Request) null, out SystemInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(SystemInfoInquiry systemInfoInquiry)
    {
      return this.GetWIPMsgs(systemInfoInquiry, (SystemInfoInquiry_Parameters) null, (SystemInfoInquiry_Request) null, out SystemInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SystemInfoInquiry systemInfoInquiry,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      return this.GetWIPMsgs(systemInfoInquiry, (SystemInfoInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject systemInfoInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SystemInfoInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SystemInfoInquiry) systemInfoInquiry, (SystemInfoInquiry_Parameters) parameters, (SystemInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      result = (SystemInfoInquiry_Result) null;
      try
      {
        SystemInfoInquiryMethod[] methods = new SystemInfoInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISystemInfoInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SystemInfoInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SystemInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SystemInfoInquiry cdo,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      result = (SystemInfoInquiry_Result) null;
      try
      {
        return ((ISystemInfoInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SystemInfoInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((SystemInfoInquiry) cdo, (SystemInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      return this.GetEnvironment((SystemInfoInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SystemInfoInquiry cdo,
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      result = (SystemInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISystemInfoInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SystemInfoInquiryMethod(cdo, SystemInfoInquiryMethods.ExecuteTransaction, (SystemInfoInquiry_Parameters) null));
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
        SystemInfoInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SystemInfoInquiry) cdo, (SystemInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SystemInfoInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (SystemInfoInquiry_Request) null, out SystemInfoInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SystemInfoInquiry_Request request,
      out SystemInfoInquiry_Result result)
    {
      return this.ExecuteTransaction((SystemInfoInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SystemInfoInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SystemInfoInquiryMethod(cdo, SystemInfoInquiryMethods.AddDataTransaction, (SystemInfoInquiry_Parameters) null));
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
        return this.AddDataTransaction((SystemInfoInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
