// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerHistoryInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerHistoryInquiryService : InquiryBase
  {
    public ContainerHistoryInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerHistoryInquiryService), userProfile);
    }

    public ResultStatus GetHistories(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetHistories), (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).GetHistories(this._UserProfile, containerHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(containerHistoryInquiry, ContainerHistoryInquiryMethods.GetHistories, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetHistories), res, (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetHistories()
    {
      return this.GetHistories((ContainerHistoryInquiry) null, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetHistories(ContainerHistoryInquiry containerHistoryInquiry)
    {
      return this.GetHistories(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetHistories(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.GetHistories(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetHistoryDisplayTexts(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetHistoryDisplayTexts), (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).GetHistoryDisplayTexts(this._UserProfile, containerHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(containerHistoryInquiry, ContainerHistoryInquiryMethods.GetHistoryDisplayTexts, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetHistoryDisplayTexts), res, (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetHistoryDisplayTexts()
    {
      return this.GetHistoryDisplayTexts((ContainerHistoryInquiry) null, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetHistoryDisplayTexts(
      ContainerHistoryInquiry containerHistoryInquiry)
    {
      return this.GetHistoryDisplayTexts(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetHistoryDisplayTexts(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.GetHistoryDisplayTexts(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, containerHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(containerHistoryInquiry, ContainerHistoryInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerHistoryInquiry) null, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerHistoryInquiry containerHistoryInquiry)
    {
      return this.GetWIPMsgs(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.GetWIPMsgs(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus InitInquiryDetail(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (InitInquiryDetail), (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).InitInquiryDetail(this._UserProfile, containerHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(containerHistoryInquiry, ContainerHistoryInquiryMethods.InitInquiryDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitInquiryDetail), res, (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitInquiryDetail()
    {
      return this.InitInquiryDetail((ContainerHistoryInquiry) null, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus InitInquiryDetail(
      ContainerHistoryInquiry containerHistoryInquiry)
    {
      return this.InitInquiryDetail(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus InitInquiryDetail(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.InitInquiryDetail(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, request, out result);
    }

    public ResultStatus SetSelectedHistoryItem(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Parameters parameters,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (SetSelectedHistoryItem), (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).SetSelectedHistoryItem(this._UserProfile, containerHistoryInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(containerHistoryInquiry, ContainerHistoryInquiryMethods.SetSelectedHistoryItem, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetSelectedHistoryItem), res, (DCObject) containerHistoryInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetSelectedHistoryItem()
    {
      return this.SetSelectedHistoryItem((ContainerHistoryInquiry) null, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus SetSelectedHistoryItem(
      ContainerHistoryInquiry containerHistoryInquiry)
    {
      return this.SetSelectedHistoryItem(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus SetSelectedHistoryItem(
      ContainerHistoryInquiry containerHistoryInquiry,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.SetSelectedHistoryItem(containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerHistoryInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerHistoryInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerHistoryInquiry) containerHistoryInquiry, (ContainerHistoryInquiry_Parameters) parameters, (ContainerHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      try
      {
        ContainerHistoryInquiryMethod[] methods = new ContainerHistoryInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerHistoryInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerHistoryInquiry cdo,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      try
      {
        return ((IContainerHistoryInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerHistoryInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerHistoryInquiry) cdo, (ContainerHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.GetEnvironment((ContainerHistoryInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerHistoryInquiry cdo,
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      result = (ContainerHistoryInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerHistoryInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerHistoryInquiryMethod(cdo, ContainerHistoryInquiryMethods.ExecuteTransaction, (ContainerHistoryInquiry_Parameters) null));
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
        ContainerHistoryInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerHistoryInquiry) cdo, (ContainerHistoryInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerHistoryInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerHistoryInquiry_Request) null, out ContainerHistoryInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerHistoryInquiry_Request request,
      out ContainerHistoryInquiry_Result result)
    {
      return this.ExecuteTransaction((ContainerHistoryInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerHistoryInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerHistoryInquiryMethod(cdo, ContainerHistoryInquiryMethods.AddDataTransaction, (ContainerHistoryInquiry_Parameters) null));
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
        return this.AddDataTransaction((ContainerHistoryInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
