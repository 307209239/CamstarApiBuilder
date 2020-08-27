// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActivationInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActivationInquiryService : ChangePackageInquiryBase
  {
    public ActivationInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActivationInquiryService), userProfile);
    }

    public ResultStatus GetPackages(
      ActivationInquiry activationInquiry,
      ActivationInquiry_Parameters parameters,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      result = (ActivationInquiry_Result) null;
      this.OnBeforeCall(nameof (GetPackages), (DCObject) activationInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivationInquiryService) this._Channel).GetPackages(this._UserProfile, activationInquiry, parameters, request, out result) : this.AddMethod((Method) new ActivationInquiryMethod(activationInquiry, ActivationInquiryMethods.GetPackages, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPackages), res, (DCObject) activationInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPackages()
    {
      return this.GetPackages((ActivationInquiry) null, (ActivationInquiry_Parameters) null, (ActivationInquiry_Request) null, out ActivationInquiry_Result _);
    }

    public ResultStatus GetPackages(ActivationInquiry activationInquiry)
    {
      return this.GetPackages(activationInquiry, (ActivationInquiry_Parameters) null, (ActivationInquiry_Request) null, out ActivationInquiry_Result _);
    }

    public ResultStatus GetPackages(
      ActivationInquiry activationInquiry,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      return this.GetPackages(activationInquiry, (ActivationInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActivationInquiry activationInquiry,
      ActivationInquiry_Parameters parameters,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      result = (ActivationInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) activationInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivationInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, activationInquiry, parameters, request, out result) : this.AddMethod((Method) new ActivationInquiryMethod(activationInquiry, ActivationInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) activationInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActivationInquiry) null, (ActivationInquiry_Parameters) null, (ActivationInquiry_Request) null, out ActivationInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ActivationInquiry activationInquiry)
    {
      return this.GetWIPMsgs(activationInquiry, (ActivationInquiry_Parameters) null, (ActivationInquiry_Request) null, out ActivationInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActivationInquiry activationInquiry,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      return this.GetWIPMsgs(activationInquiry, (ActivationInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject activationInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActivationInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActivationInquiry) activationInquiry, (ActivationInquiry_Parameters) parameters, (ActivationInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      result = (ActivationInquiry_Result) null;
      try
      {
        ActivationInquiryMethod[] methods = new ActivationInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActivationInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActivationInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActivationInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivationInquiry cdo,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      result = (ActivationInquiry_Result) null;
      try
      {
        return ((IActivationInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActivationInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ActivationInquiry) cdo, (ActivationInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      return this.GetEnvironment((ActivationInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActivationInquiry cdo,
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      result = (ActivationInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActivationInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActivationInquiryMethod(cdo, ActivationInquiryMethods.ExecuteTransaction, (ActivationInquiry_Parameters) null));
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
        ActivationInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActivationInquiry) cdo, (ActivationInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActivationInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ActivationInquiry_Request) null, out ActivationInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActivationInquiry_Request request,
      out ActivationInquiry_Result result)
    {
      return this.ExecuteTransaction((ActivationInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActivationInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActivationInquiryMethod(cdo, ActivationInquiryMethods.AddDataTransaction, (ActivationInquiry_Parameters) null));
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
        return this.AddDataTransaction((ActivationInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
