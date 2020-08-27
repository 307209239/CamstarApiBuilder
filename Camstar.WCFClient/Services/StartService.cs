// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class StartService : ContainerTxnBase
  {
    public StartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IStartService), userProfile);
    }

    public ResultStatus AttachCarrier(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (AttachCarrier), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).AttachCarrier(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.AttachCarrier, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AttachCarrier), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AttachCarrier()
    {
      return this.AttachCarrier((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus AttachCarrier(Start start)
    {
      return this.AttachCarrier(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus AttachCarrier(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.AttachCarrier(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ContainerTxn_Validations(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ContainerTxn_Validations), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ContainerTxn_Validations(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ContainerTxn_Validations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ContainerTxn_Validations), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ContainerTxn_Validations()
    {
      return this.ContainerTxn_Validations((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ContainerTxn_Validations(Start start)
    {
      return this.ContainerTxn_Validations(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ContainerTxn_Validations(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ContainerTxn_Validations(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).CreateParametricData(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus CreateParametricData(Start start)
    {
      return this.CreateParametricData(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus CreateParametricData(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.CreateParametricData(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).GetActions(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetActions(Start start)
    {
      return this.GetActions(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetActions(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.GetActions(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).GetDataPoints(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetDataPoints(Start start)
    {
      return this.GetDataPoints(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetDataPoints(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.GetDataPoints(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus GetTransactionWIPMsgs(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (GetTransactionWIPMsgs), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).GetTransactionWIPMsgs(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.GetTransactionWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTransactionWIPMsgs), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTransactionWIPMsgs()
    {
      return this.GetTransactionWIPMsgs((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetTransactionWIPMsgs(Start start)
    {
      return this.GetTransactionWIPMsgs(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetTransactionWIPMsgs(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.GetTransactionWIPMsgs(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).GetWIPMsgs(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetWIPMsgs(Start start)
    {
      return this.GetWIPMsgs(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.GetWIPMsgs(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).Load(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus Load(Start start)
    {
      return this.Load(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus Load(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.Load(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Start start,
      Start_LoadESigDetails_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).LoadESigDetails(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.LoadESigDetails, (Start_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Start) null, (Start_LoadESigDetails_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus LoadESigDetails(Start start)
    {
      return this.LoadESigDetails(start, (Start_LoadESigDetails_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus LoadESigDetails(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.LoadESigDetails(start, (Start_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessChildAutoNumber(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ProcessChildAutoNumber), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ProcessChildAutoNumber(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ProcessChildAutoNumber, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessChildAutoNumber), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessChildAutoNumber()
    {
      return this.ProcessChildAutoNumber((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessChildAutoNumber(Start start)
    {
      return this.ProcessChildAutoNumber(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessChildAutoNumber(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ProcessChildAutoNumber(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ProcessComputation(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessComputation(Start start)
    {
      return this.ProcessComputation(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessComputation(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ProcessComputation(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ProcessOnlyChildAutoNumber(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ProcessOnlyChildAutoNumber), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ProcessOnlyChildAutoNumber(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ProcessOnlyChildAutoNumber, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessOnlyChildAutoNumber), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessOnlyChildAutoNumber()
    {
      return this.ProcessOnlyChildAutoNumber((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessOnlyChildAutoNumber(Start start)
    {
      return this.ProcessOnlyChildAutoNumber(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ProcessOnlyChildAutoNumber(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ProcessOnlyChildAutoNumber(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ResolveParametricData(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ResolveParametricData(Start start)
    {
      return this.ResolveParametricData(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ResolveParametricData(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ResolveParametricData(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_StartSetupSampling(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (Sampling_StartSetupSampling), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).Sampling_StartSetupSampling(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.Sampling_StartSetupSampling, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_StartSetupSampling), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_StartSetupSampling()
    {
      return this.Sampling_StartSetupSampling((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus Sampling_StartSetupSampling(Start start)
    {
      return this.Sampling_StartSetupSampling(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus Sampling_StartSetupSampling(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.Sampling_StartSetupSampling(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus SetWFStack(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (SetWFStack), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).SetWFStack(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.SetWFStack, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetWFStack), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetWFStack()
    {
      return this.SetWFStack((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus SetWFStack(Start start)
    {
      return this.SetWFStack(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus SetWFStack(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.SetWFStack(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ShopFloor_ApplyDetails(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ShopFloor_ApplyDetails), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ShopFloor_ApplyDetails(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ShopFloor_ApplyDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ShopFloor_ApplyDetails), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ShopFloor_ApplyDetails()
    {
      return this.ShopFloor_ApplyDetails((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ShopFloor_ApplyDetails(Start start)
    {
      return this.ShopFloor_ApplyDetails(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ShopFloor_ApplyDetails(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ShopFloor_ApplyDetails(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCarrier(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ValidateCarrier), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ValidateCarrier(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ValidateCarrier, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCarrier), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCarrier()
    {
      return this.ValidateCarrier((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ValidateCarrier(Start start)
    {
      return this.ValidateCarrier(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ValidateCarrier(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ValidateCarrier(start, (Start_Parameters) null, request, out result);
    }

    public ResultStatus ValidateResource(
      Start start,
      Start_Parameters parameters,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ValidateResource), (DCObject) start, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ValidateResource(this._UserProfile, start, parameters, request, out result) : this.AddMethod((Method) new StartMethod(start, StartMethods.ValidateResource, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateResource), res, (DCObject) start, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateResource()
    {
      return this.ValidateResource((Start) null, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ValidateResource(Start start)
    {
      return this.ValidateResource(start, (Start_Parameters) null, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ValidateResource(
      Start start,
      Start_Request request,
      out Start_Result result)
    {
      return this.ValidateResource(start, (Start_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus actions = this.GetActions((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Start) start, (Start_LoadESigDetails_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus resultStatus = this.Load((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject start,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Start_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Start) start, (Start_Parameters) parameters, (Start_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      try
      {
        StartMethod[] methods = new StartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Start_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Start cdo,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      try
      {
        return ((IStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Start_Result result1;
        ResultStatus environment = this.GetEnvironment((Start) cdo, (Start_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Start_Request request, out Start_Result result)
    {
      return this.GetEnvironment((Start) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Start cdo,
      Start_Request request,
      out Start_Result result)
    {
      result = (Start_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new StartMethod(cdo, StartMethods.ExecuteTransaction, (Start_Parameters) null));
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
        Start_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Start) cdo, (Start_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Start cdo)
    {
      return this.ExecuteTransaction(cdo, (Start_Request) null, out Start_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Start_Request request,
      out Start_Result result)
    {
      return this.ExecuteTransaction((Start) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Start cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new StartMethod(cdo, StartMethods.AddDataTransaction, (Start_Parameters) null));
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
        return this.AddDataTransaction((Start) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
