// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerInfoInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerInfoInquiryService : InquiryBase
  {
    public ContainerInfoInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerInfoInquiryService), userProfile);
    }

    public ResultStatus ContainerInfoInquiry_GetContainerInfo(
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Parameters parameters,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      result = (ContainerInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (ContainerInfoInquiry_GetContainerInfo), (DCObject) containerInfoInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInfoInquiryService) this._Channel).ContainerInfoInquiry_GetContainerInfo(this._UserProfile, containerInfoInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerInfoInquiryMethod(containerInfoInquiry, ContainerInfoInquiryMethods.ContainerInfoInquiry_GetContainerInfo, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ContainerInfoInquiry_GetContainerInfo), res, (DCObject) containerInfoInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ContainerInfoInquiry_GetContainerInfo()
    {
      return this.ContainerInfoInquiry_GetContainerInfo((ContainerInfoInquiry) null, (ContainerInfoInquiry_Parameters) null, (ContainerInfoInquiry_Request) null, out ContainerInfoInquiry_Result _);
    }

    public ResultStatus ContainerInfoInquiry_GetContainerInfo(
      ContainerInfoInquiry containerInfoInquiry)
    {
      return this.ContainerInfoInquiry_GetContainerInfo(containerInfoInquiry, (ContainerInfoInquiry_Parameters) null, (ContainerInfoInquiry_Request) null, out ContainerInfoInquiry_Result _);
    }

    public ResultStatus ContainerInfoInquiry_GetContainerInfo(
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      return this.ContainerInfoInquiry_GetContainerInfo(containerInfoInquiry, (ContainerInfoInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Parameters parameters,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      result = (ContainerInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerInfoInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInfoInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, containerInfoInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerInfoInquiryMethod(containerInfoInquiry, ContainerInfoInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerInfoInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerInfoInquiry) null, (ContainerInfoInquiry_Parameters) null, (ContainerInfoInquiry_Request) null, out ContainerInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerInfoInquiry containerInfoInquiry)
    {
      return this.GetWIPMsgs(containerInfoInquiry, (ContainerInfoInquiry_Parameters) null, (ContainerInfoInquiry_Request) null, out ContainerInfoInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerInfoInquiry containerInfoInquiry,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      return this.GetWIPMsgs(containerInfoInquiry, (ContainerInfoInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerInfoInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerInfoInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerInfoInquiry) containerInfoInquiry, (ContainerInfoInquiry_Parameters) parameters, (ContainerInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      result = (ContainerInfoInquiry_Result) null;
      try
      {
        ContainerInfoInquiryMethod[] methods = new ContainerInfoInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerInfoInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerInfoInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerInfoInquiry cdo,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      result = (ContainerInfoInquiry_Result) null;
      try
      {
        return ((IContainerInfoInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerInfoInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerInfoInquiry) cdo, (ContainerInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      return this.GetEnvironment((ContainerInfoInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerInfoInquiry cdo,
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      result = (ContainerInfoInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInfoInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerInfoInquiryMethod(cdo, ContainerInfoInquiryMethods.ExecuteTransaction, (ContainerInfoInquiry_Parameters) null));
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
        ContainerInfoInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerInfoInquiry) cdo, (ContainerInfoInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerInfoInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerInfoInquiry_Request) null, out ContainerInfoInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerInfoInquiry_Request request,
      out ContainerInfoInquiry_Result result)
    {
      return this.ExecuteTransaction((ContainerInfoInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerInfoInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerInfoInquiryMethod(cdo, ContainerInfoInquiryMethods.AddDataTransaction, (ContainerInfoInquiry_Parameters) null));
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
        return this.AddDataTransaction((ContainerInfoInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
