// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainersTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ContainersTxnService : ShopFloorBase
  {
    public ContainersTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IContainersTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).CreateParametricData(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus CreateParametricData(ContainersTxn containersTxn)
    {
      return this.CreateParametricData(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.CreateParametricData(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).GetActions(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetActions(ContainersTxn containersTxn)
    {
      return this.GetActions(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetActions(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.GetActions(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetContainers(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (GetContainers), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).GetContainers(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.GetContainers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetContainers), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetContainers()
    {
      return this.GetContainers((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetContainers(ContainersTxn containersTxn)
    {
      return this.GetContainers(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetContainers(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.GetContainers(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).GetDataPoints(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetDataPoints(ContainersTxn containersTxn)
    {
      return this.GetDataPoints(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.GetDataPoints(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).GetWIPMsgs(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(ContainersTxn containersTxn)
    {
      return this.GetWIPMsgs(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.GetWIPMsgs(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus InitQueryParameters(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (InitQueryParameters), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).InitQueryParameters(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.InitQueryParameters, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitQueryParameters), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitQueryParameters()
    {
      return this.InitQueryParameters((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus InitQueryParameters(ContainersTxn containersTxn)
    {
      return this.InitQueryParameters(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus InitQueryParameters(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.InitQueryParameters(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).Load(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus Load(ContainersTxn containersTxn)
    {
      return this.Load(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus Load(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.Load(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadContainerDetails(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (LoadContainerDetails), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).LoadContainerDetails(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.LoadContainerDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadContainerDetails), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadContainerDetails()
    {
      return this.LoadContainerDetails((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus LoadContainerDetails(ContainersTxn containersTxn)
    {
      return this.LoadContainerDetails(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus LoadContainerDetails(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.LoadContainerDetails(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ContainersTxn containersTxn,
      ContainersTxn_LoadESigDetails_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).LoadESigDetails(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.LoadESigDetails, (ContainersTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ContainersTxn) null, (ContainersTxn_LoadESigDetails_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus LoadESigDetails(ContainersTxn containersTxn)
    {
      return this.LoadESigDetails(containersTxn, (ContainersTxn_LoadESigDetails_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.LoadESigDetails(containersTxn, (ContainersTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PopulateList(
      ContainersTxn containersTxn,
      ContainersTxn_PopulateList_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateList), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).PopulateList(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.PopulateList, (ContainersTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateList), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateList()
    {
      return this.PopulateList((ContainersTxn) null, (ContainersTxn_PopulateList_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateList(ContainersTxn containersTxn)
    {
      return this.PopulateList(containersTxn, (ContainersTxn_PopulateList_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateList(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.PopulateList(containersTxn, (ContainersTxn_PopulateList_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService(
      ContainersTxn containersTxn,
      ContainersTxn_PopulateService_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).PopulateService(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.PopulateService, (ContainersTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService()
    {
      return this.PopulateService((ContainersTxn) null, (ContainersTxn_PopulateService_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService(ContainersTxn containersTxn)
    {
      return this.PopulateService(containersTxn, (ContainersTxn_PopulateService_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.PopulateService(containersTxn, (ContainersTxn_PopulateService_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_ESigs(
      ContainersTxn containersTxn,
      ContainersTxn_PopulateService_ESigs_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService_ESigs), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).PopulateService_ESigs(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.PopulateService_ESigs, (ContainersTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_ESigs), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_ESigs()
    {
      return this.PopulateService_ESigs((ContainersTxn) null, (ContainersTxn_PopulateService_ESigs_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_ESigs(ContainersTxn containersTxn)
    {
      return this.PopulateService_ESigs(containersTxn, (ContainersTxn_PopulateService_ESigs_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_ESigs(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.PopulateService_ESigs(containersTxn, (ContainersTxn_PopulateService_ESigs_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_Specific(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService_Specific), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).PopulateService_Specific(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.PopulateService_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_Specific), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_Specific()
    {
      return this.PopulateService_Specific((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_Specific(ContainersTxn containersTxn)
    {
      return this.PopulateService_Specific(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_Specific(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.PopulateService_Specific(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_User(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService_User), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).PopulateService_User(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.PopulateService_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_User), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_User()
    {
      return this.PopulateService_User((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_User(ContainersTxn containersTxn)
    {
      return this.PopulateService_User(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus PopulateService_User(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.PopulateService_User(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).ProcessComputation(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus ProcessComputation(ContainersTxn containersTxn)
    {
      return this.ProcessComputation(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.ProcessComputation(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ContainersTxn containersTxn,
      ContainersTxn_Parameters parameters,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) containersTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).ResolveParametricData(this._UserProfile, containersTxn, parameters, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(containersTxn, ContainersTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) containersTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ContainersTxn) null, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus ResolveParametricData(ContainersTxn containersTxn)
    {
      return this.ResolveParametricData(containersTxn, (ContainersTxn_Parameters) null, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      ContainersTxn containersTxn,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.ResolveParametricData(containersTxn, (ContainersTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus actions = this.GetActions((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ContainersTxn) containersTxn, (ContainersTxn_LoadESigDetails_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.Load((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject containersTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ContainersTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ContainersTxn) containersTxn, (ContainersTxn_Parameters) parameters, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      try
      {
        ContainersTxnMethod[] methods = new ContainersTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IContainersTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainersTxn cdo,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      try
      {
        return ((IContainersTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ContainersTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((ContainersTxn) cdo, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.GetEnvironment((ContainersTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ContainersTxn cdo,
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      result = (ContainersTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IContainersTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ContainersTxnMethod(cdo, ContainersTxnMethods.ExecuteTransaction, (ContainersTxn_Parameters) null));
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
        ContainersTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ContainersTxn) cdo, (ContainersTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ContainersTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (ContainersTxn_Request) null, out ContainersTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ContainersTxn_Request request,
      out ContainersTxn_Result result)
    {
      return this.ExecuteTransaction((ContainersTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ContainersTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ContainersTxnMethod(cdo, ContainersTxnMethods.AddDataTransaction, (ContainersTxn_Parameters) null));
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
        return this.AddDataTransaction((ContainersTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
