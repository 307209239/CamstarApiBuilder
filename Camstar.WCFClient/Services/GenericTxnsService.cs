// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GenericTxnsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GenericTxnsService : ShopFloorBase
  {
    public GenericTxnsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGenericTxnsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).CreateParametricData(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus CreateParametricData(GenericTxns genericTxns)
    {
      return this.CreateParametricData(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus CreateParametricData(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.CreateParametricData(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).GetActions(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetActions(GenericTxns genericTxns)
    {
      return this.GetActions(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetActions(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.GetActions(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).GetDataPoints(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetDataPoints(GenericTxns genericTxns)
    {
      return this.GetDataPoints(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetDataPoints(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.GetDataPoints(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).GetWIPMsgs(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(GenericTxns genericTxns)
    {
      return this.GetWIPMsgs(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.GetWIPMsgs(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).Load(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus Load(GenericTxns genericTxns)
    {
      return this.Load(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus Load(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.Load(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      GenericTxns genericTxns,
      GenericTxns_LoadESigDetails_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).LoadESigDetails(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.LoadESigDetails, (GenericTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((GenericTxns) null, (GenericTxns_LoadESigDetails_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus LoadESigDetails(GenericTxns genericTxns)
    {
      return this.LoadESigDetails(genericTxns, (GenericTxns_LoadESigDetails_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus LoadESigDetails(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.LoadESigDetails(genericTxns, (GenericTxns_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService(
      GenericTxns genericTxns,
      GenericTxns_PopulateService_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).PopulateService(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.PopulateService, (GenericTxns_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService()
    {
      return this.PopulateService((GenericTxns) null, (GenericTxns_PopulateService_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService(GenericTxns genericTxns)
    {
      return this.PopulateService(genericTxns, (GenericTxns_PopulateService_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.PopulateService(genericTxns, (GenericTxns_PopulateService_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_Specific(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService_Specific), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).PopulateService_Specific(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.PopulateService_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_Specific), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_Specific()
    {
      return this.PopulateService_Specific((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService_Specific(GenericTxns genericTxns)
    {
      return this.PopulateService_Specific(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService_Specific(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.PopulateService_Specific(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_User(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (PopulateService_User), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).PopulateService_User(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.PopulateService_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_User), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_User()
    {
      return this.PopulateService_User((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService_User(GenericTxns genericTxns)
    {
      return this.PopulateService_User(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus PopulateService_User(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.PopulateService_User(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).ProcessComputation(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus ProcessComputation(GenericTxns genericTxns)
    {
      return this.ProcessComputation(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus ProcessComputation(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.ProcessComputation(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      GenericTxns genericTxns,
      GenericTxns_Parameters parameters,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) genericTxns, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).ResolveParametricData(this._UserProfile, genericTxns, parameters, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(genericTxns, GenericTxnsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) genericTxns, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((GenericTxns) null, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus ResolveParametricData(GenericTxns genericTxns)
    {
      return this.ResolveParametricData(genericTxns, (GenericTxns_Parameters) null, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus ResolveParametricData(
      GenericTxns genericTxns,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.ResolveParametricData(genericTxns, (GenericTxns_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus parametricData = this.CreateParametricData((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus actions = this.GetActions((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((GenericTxns) genericTxns, (GenericTxns_LoadESigDetails_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.Load((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject genericTxns,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxns_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GenericTxns) genericTxns, (GenericTxns_Parameters) parameters, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      try
      {
        GenericTxnsMethod[] methods = new GenericTxnsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGenericTxnsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GenericTxns cdo,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      try
      {
        return ((IGenericTxnsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GenericTxns_Result result1;
        ResultStatus environment = this.GetEnvironment((GenericTxns) cdo, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.GetEnvironment((GenericTxns) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GenericTxns cdo,
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      result = (GenericTxns_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GenericTxnsMethod(cdo, GenericTxnsMethods.ExecuteTransaction, (GenericTxns_Parameters) null));
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
        GenericTxns_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GenericTxns) cdo, (GenericTxns_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GenericTxns cdo)
    {
      return this.ExecuteTransaction(cdo, (GenericTxns_Request) null, out GenericTxns_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GenericTxns_Request request,
      out GenericTxns_Result result)
    {
      return this.ExecuteTransaction((GenericTxns) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GenericTxns cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GenericTxnsMethod(cdo, GenericTxnsMethods.AddDataTransaction, (GenericTxns_Parameters) null));
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
        return this.AddDataTransaction((GenericTxns) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
