// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EligibleContainersInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EligibleContainersInquiryService : InquiryBase
  {
    public EligibleContainersInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEligibleContainersInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Parameters parameters,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      result = (EligibleContainersInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eligibleContainersInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEligibleContainersInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, eligibleContainersInquiry, parameters, request, out result) : this.AddMethod((Method) new EligibleContainersInquiryMethod(eligibleContainersInquiry, EligibleContainersInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eligibleContainersInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EligibleContainersInquiry) null, (EligibleContainersInquiry_Parameters) null, (EligibleContainersInquiry_Request) null, out EligibleContainersInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EligibleContainersInquiry eligibleContainersInquiry)
    {
      return this.GetWIPMsgs(eligibleContainersInquiry, (EligibleContainersInquiry_Parameters) null, (EligibleContainersInquiry_Request) null, out EligibleContainersInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      return this.GetWIPMsgs(eligibleContainersInquiry, (EligibleContainersInquiry_Parameters) null, request, out result);
    }

    public ResultStatus LoadEligibleContainers(
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_LoadEligibleContainers_Parameters parameters,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      result = (EligibleContainersInquiry_Result) null;
      this.OnBeforeCall(nameof (LoadEligibleContainers), (DCObject) eligibleContainersInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEligibleContainersInquiryService) this._Channel).LoadEligibleContainers(this._UserProfile, eligibleContainersInquiry, parameters, request, out result) : this.AddMethod((Method) new EligibleContainersInquiryMethod(eligibleContainersInquiry, EligibleContainersInquiryMethods.LoadEligibleContainers, (EligibleContainersInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadEligibleContainers), res, (DCObject) eligibleContainersInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadEligibleContainers()
    {
      return this.LoadEligibleContainers((EligibleContainersInquiry) null, (EligibleContainersInquiry_LoadEligibleContainers_Parameters) null, (EligibleContainersInquiry_Request) null, out EligibleContainersInquiry_Result _);
    }

    public ResultStatus LoadEligibleContainers(
      EligibleContainersInquiry eligibleContainersInquiry)
    {
      return this.LoadEligibleContainers(eligibleContainersInquiry, (EligibleContainersInquiry_LoadEligibleContainers_Parameters) null, (EligibleContainersInquiry_Request) null, out EligibleContainersInquiry_Result _);
    }

    public ResultStatus LoadEligibleContainers(
      EligibleContainersInquiry eligibleContainersInquiry,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      return this.LoadEligibleContainers(eligibleContainersInquiry, (EligibleContainersInquiry_LoadEligibleContainers_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eligibleContainersInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EligibleContainersInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EligibleContainersInquiry) eligibleContainersInquiry, (EligibleContainersInquiry_Parameters) parameters, (EligibleContainersInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      result = (EligibleContainersInquiry_Result) null;
      try
      {
        EligibleContainersInquiryMethod[] methods = new EligibleContainersInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEligibleContainersInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EligibleContainersInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EligibleContainersInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EligibleContainersInquiry cdo,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      result = (EligibleContainersInquiry_Result) null;
      try
      {
        return ((IEligibleContainersInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EligibleContainersInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((EligibleContainersInquiry) cdo, (EligibleContainersInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      return this.GetEnvironment((EligibleContainersInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EligibleContainersInquiry cdo,
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      result = (EligibleContainersInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEligibleContainersInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EligibleContainersInquiryMethod(cdo, EligibleContainersInquiryMethods.ExecuteTransaction, (EligibleContainersInquiry_Parameters) null));
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
        EligibleContainersInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EligibleContainersInquiry) cdo, (EligibleContainersInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EligibleContainersInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (EligibleContainersInquiry_Request) null, out EligibleContainersInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EligibleContainersInquiry_Request request,
      out EligibleContainersInquiry_Result result)
    {
      return this.ExecuteTransaction((EligibleContainersInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EligibleContainersInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EligibleContainersInquiryMethod(cdo, EligibleContainersInquiryMethods.AddDataTransaction, (EligibleContainersInquiry_Parameters) null));
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
        return this.AddDataTransaction((EligibleContainersInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
