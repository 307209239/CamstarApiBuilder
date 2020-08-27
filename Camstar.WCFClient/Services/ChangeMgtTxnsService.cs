// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeMgtTxnsService : ShopFloorBase
  {
    public ChangeMgtTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeMgtTxnsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).CreateParametricData(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus CreateParametricData(ChangeMgtTxns changeMgtTxns)
    {
      return this.CreateParametricData(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.CreateParametricData(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).GetActions(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetActions(ChangeMgtTxns changeMgtTxns)
    {
      return this.GetActions(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetActions(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.GetActions(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).GetDataPoints(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetDataPoints(ChangeMgtTxns changeMgtTxns)
    {
      return this.GetDataPoints(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.GetDataPoints(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeMgtTxns changeMgtTxns)
    {
      return this.GetWIPMsgs(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.GetWIPMsgs(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).Load(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus Load(ChangeMgtTxns changeMgtTxns)
    {
      return this.Load(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus Load(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.Load(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_LoadESigDetails_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).LoadESigDetails(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.LoadESigDetails, (ChangeMgtTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeMgtTxns) null, (ChangeMgtTxns_LoadESigDetails_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeMgtTxns changeMgtTxns)
    {
      return this.LoadESigDetails(changeMgtTxns, (ChangeMgtTxns_LoadESigDetails_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.LoadESigDetails(changeMgtTxns, (ChangeMgtTxns_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_PopulateService_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).PopulateService(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.PopulateService, (ChangeMgtTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService()
    {
      return this.PopulateService((ChangeMgtTxns) null, (ChangeMgtTxns_PopulateService_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService(ChangeMgtTxns changeMgtTxns)
    {
      return this.PopulateService(changeMgtTxns, (ChangeMgtTxns_PopulateService_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.PopulateService(changeMgtTxns, (ChangeMgtTxns_PopulateService_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_Specific(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService_Specific), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).PopulateService_Specific(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.PopulateService_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_Specific), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_Specific()
    {
      return this.PopulateService_Specific((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService_Specific(ChangeMgtTxns changeMgtTxns)
    {
      return this.PopulateService_Specific(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService_Specific(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.PopulateService_Specific(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_User(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService_User), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).PopulateService_User(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.PopulateService_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_User), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_User()
    {
      return this.PopulateService_User((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService_User(ChangeMgtTxns changeMgtTxns)
    {
      return this.PopulateService_User(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus PopulateService_User(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.PopulateService_User(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).ProcessComputation(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus ProcessComputation(ChangeMgtTxns changeMgtTxns)
    {
      return this.ProcessComputation(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.ProcessComputation(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Parameters parameters,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).ResolveParametricData(this._UserProfile, changeMgtTxns, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(changeMgtTxns, ChangeMgtTxnsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeMgtTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeMgtTxns) null, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeMgtTxns changeMgtTxns)
    {
      return this.ResolveParametricData(changeMgtTxns, (ChangeMgtTxns_Parameters) null, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeMgtTxns changeMgtTxns,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.ResolveParametricData(changeMgtTxns, (ChangeMgtTxns_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus actions = this.GetActions((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_LoadESigDetails_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.Load((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeMgtTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeMgtTxns) changeMgtTxns, (ChangeMgtTxns_Parameters) parameters, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      try
      {
        ChangeMgtTxnsMethod[] methods = new ChangeMgtTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeMgtTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtTxns cdo,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      try
      {
        return ((IChangeMgtTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeMgtTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeMgtTxns) cdo, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.GetEnvironment((ChangeMgtTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtTxns cdo,
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      result = (ChangeMgtTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeMgtTxnsMethod(cdo, ChangeMgtTxnsMethods.ExecuteTransaction, (ChangeMgtTxns_Parameters) null));
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
        ChangeMgtTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeMgtTxns) cdo, (ChangeMgtTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeMgtTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeMgtTxns_Request) null, out ChangeMgtTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtTxns_Request request,
      out ChangeMgtTxns_Result result)
    {
      return this.ExecuteTransaction((ChangeMgtTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeMgtTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeMgtTxnsMethod(cdo, ChangeMgtTxnsMethods.AddDataTransaction, (ChangeMgtTxns_Parameters) null));
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
        return this.AddDataTransaction((ChangeMgtTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
