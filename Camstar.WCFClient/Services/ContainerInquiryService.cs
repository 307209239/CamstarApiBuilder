// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainerInquiryService : InquiryBase
  {
    public ContainerInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainerInquiryService), userProfile);
    }

    public ResultStatus GetChildContainers(
      ContainerInquiry containerInquiry,
      ContainerInquiry_GetChildContainers_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      this.OnBeforeCall(nameof (GetChildContainers), (DCObject) containerInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInquiryService) this._Channel).GetChildContainers(this._UserProfile, containerInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerInquiryMethod(containerInquiry, ContainerInquiryMethods.GetChildContainers, (ContainerInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChildContainers), res, (DCObject) containerInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChildContainers()
    {
      return this.GetChildContainers((ContainerInquiry) null, (ContainerInquiry_GetChildContainers_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetChildContainers(ContainerInquiry containerInquiry)
    {
      return this.GetChildContainers(containerInquiry, (ContainerInquiry_GetChildContainers_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetChildContainers(
      ContainerInquiry containerInquiry,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      return this.GetChildContainers(containerInquiry, (ContainerInquiry_GetChildContainers_Parameters) null, request, out result);
    }

    public ResultStatus GetContainers(
      ContainerInquiry containerInquiry,
      ContainerInquiry_GetContainers_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      this.OnBeforeCall(nameof (GetContainers), (DCObject) containerInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInquiryService) this._Channel).GetContainers(this._UserProfile, containerInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerInquiryMethod(containerInquiry, ContainerInquiryMethods.GetContainers, (ContainerInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetContainers), res, (DCObject) containerInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetContainers()
    {
      return this.GetContainers((ContainerInquiry) null, (ContainerInquiry_GetContainers_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetContainers(ContainerInquiry containerInquiry)
    {
      return this.GetContainers(containerInquiry, (ContainerInquiry_GetContainers_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetContainers(
      ContainerInquiry containerInquiry,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      return this.GetContainers(containerInquiry, (ContainerInquiry_GetContainers_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainerInquiry containerInquiry,
      ContainerInquiry_Parameters parameters,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containerInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, containerInquiry, parameters, request, out result) : this.AddMethod((Method) new ContainerInquiryMethod(containerInquiry, ContainerInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containerInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainerInquiry) null, (ContainerInquiry_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainerInquiry containerInquiry)
    {
      return this.GetWIPMsgs(containerInquiry, (ContainerInquiry_Parameters) null, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainerInquiry containerInquiry,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      return this.GetWIPMsgs(containerInquiry, (ContainerInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containerInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainerInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainerInquiry) containerInquiry, (ContainerInquiry_Parameters) parameters, (ContainerInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      try
      {
        ContainerInquiryMethod[] methods = new ContainerInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainerInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainerInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainerInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerInquiry cdo,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      try
      {
        return ((IContainerInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainerInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainerInquiry) cdo, (ContainerInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      return this.GetEnvironment((ContainerInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainerInquiry cdo,
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      result = (ContainerInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainerInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainerInquiryMethod(cdo, ContainerInquiryMethods.ExecuteTransaction, (ContainerInquiry_Parameters) null));
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
        ContainerInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainerInquiry) cdo, (ContainerInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainerInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainerInquiry_Request) null, out ContainerInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainerInquiry_Request request,
      out ContainerInquiry_Result result)
    {
      return this.ExecuteTransaction((ContainerInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainerInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainerInquiryMethod(cdo, ContainerInquiryMethods.AddDataTransaction, (ContainerInquiry_Parameters) null));
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
        return this.AddDataTransaction((ContainerInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
