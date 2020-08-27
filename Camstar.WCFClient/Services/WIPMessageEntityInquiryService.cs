// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WIPMessageEntityInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WIPMessageEntityInquiryService : InquiryBase
  {
    public WIPMessageEntityInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWIPMessageEntityInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      WIPMessageEntityInquiry wIPMessageEntityInquiry,
      WIPMessageEntityInquiry_Parameters parameters,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      result = (WIPMessageEntityInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) wIPMessageEntityInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMessageEntityInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, wIPMessageEntityInquiry, parameters, request, out result) : this.AddMethod((Method) new WIPMessageEntityInquiryMethod(wIPMessageEntityInquiry, WIPMessageEntityInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) wIPMessageEntityInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WIPMessageEntityInquiry) null, (WIPMessageEntityInquiry_Parameters) null, (WIPMessageEntityInquiry_Request) null, out WIPMessageEntityInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(WIPMessageEntityInquiry wIPMessageEntityInquiry)
    {
      return this.GetWIPMsgs(wIPMessageEntityInquiry, (WIPMessageEntityInquiry_Parameters) null, (WIPMessageEntityInquiry_Request) null, out WIPMessageEntityInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WIPMessageEntityInquiry wIPMessageEntityInquiry,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      return this.GetWIPMsgs(wIPMessageEntityInquiry, (WIPMessageEntityInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject wIPMessageEntityInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMessageEntityInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WIPMessageEntityInquiry) wIPMessageEntityInquiry, (WIPMessageEntityInquiry_Parameters) parameters, (WIPMessageEntityInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      result = (WIPMessageEntityInquiry_Result) null;
      try
      {
        WIPMessageEntityInquiryMethod[] methods = new WIPMessageEntityInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWIPMessageEntityInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WIPMessageEntityInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WIPMessageEntityInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WIPMessageEntityInquiry cdo,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      result = (WIPMessageEntityInquiry_Result) null;
      try
      {
        return ((IWIPMessageEntityInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WIPMessageEntityInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((WIPMessageEntityInquiry) cdo, (WIPMessageEntityInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      return this.GetEnvironment((WIPMessageEntityInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WIPMessageEntityInquiry cdo,
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      result = (WIPMessageEntityInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMessageEntityInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WIPMessageEntityInquiryMethod(cdo, WIPMessageEntityInquiryMethods.ExecuteTransaction, (WIPMessageEntityInquiry_Parameters) null));
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
        WIPMessageEntityInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WIPMessageEntityInquiry) cdo, (WIPMessageEntityInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WIPMessageEntityInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (WIPMessageEntityInquiry_Request) null, out WIPMessageEntityInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WIPMessageEntityInquiry_Request request,
      out WIPMessageEntityInquiry_Result result)
    {
      return this.ExecuteTransaction((WIPMessageEntityInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WIPMessageEntityInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WIPMessageEntityInquiryMethod(cdo, WIPMessageEntityInquiryMethods.AddDataTransaction, (WIPMessageEntityInquiry_Parameters) null));
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
        return this.AddDataTransaction((WIPMessageEntityInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
