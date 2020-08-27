// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CreateSamplingLotService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CreateSamplingLotService : SamplingLotTxnBase
  {
    public CreateSamplingLotService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICreateSamplingLotService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).CreateParametricData(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus CreateParametricData(CreateSamplingLot createSamplingLot)
    {
      return this.CreateParametricData(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.CreateParametricData(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).GetActions(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetActions(CreateSamplingLot createSamplingLot)
    {
      return this.GetActions(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetActions(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.GetActions(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).GetDataPoints(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetDataPoints(CreateSamplingLot createSamplingLot)
    {
      return this.GetDataPoints(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetDataPoints(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.GetDataPoints(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).GetWIPMsgs(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetWIPMsgs(CreateSamplingLot createSamplingLot)
    {
      return this.GetWIPMsgs(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.GetWIPMsgs(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).Load(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus Load(CreateSamplingLot createSamplingLot)
    {
      return this.Load(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus Load(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.Load(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_LoadESigDetails_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).LoadESigDetails(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.LoadESigDetails, (CreateSamplingLot_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CreateSamplingLot) null, (CreateSamplingLot_LoadESigDetails_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus LoadESigDetails(CreateSamplingLot createSamplingLot)
    {
      return this.LoadESigDetails(createSamplingLot, (CreateSamplingLot_LoadESigDetails_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus LoadESigDetails(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.LoadESigDetails(createSamplingLot, (CreateSamplingLot_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).ProcessComputation(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus ProcessComputation(CreateSamplingLot createSamplingLot)
    {
      return this.ProcessComputation(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus ProcessComputation(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.ProcessComputation(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Parameters parameters,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) createSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).ResolveParametricData(this._UserProfile, createSamplingLot, parameters, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(createSamplingLot, CreateSamplingLotMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) createSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CreateSamplingLot) null, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus ResolveParametricData(CreateSamplingLot createSamplingLot)
    {
      return this.ResolveParametricData(createSamplingLot, (CreateSamplingLot_Parameters) null, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateSamplingLot createSamplingLot,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.ResolveParametricData(createSamplingLot, (CreateSamplingLot_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus actions = this.GetActions((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_LoadESigDetails_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.Load((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject createSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateSamplingLot_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CreateSamplingLot) createSamplingLot, (CreateSamplingLot_Parameters) parameters, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      try
      {
        CreateSamplingLotMethod[] methods = new CreateSamplingLotMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICreateSamplingLotService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateSamplingLot cdo,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      try
      {
        return ((ICreateSamplingLotService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CreateSamplingLot_Result result1;
        ResultStatus environment = this.GetEnvironment((CreateSamplingLot) cdo, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.GetEnvironment((CreateSamplingLot) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CreateSamplingLot cdo,
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      result = (CreateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateSamplingLotService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CreateSamplingLotMethod(cdo, CreateSamplingLotMethods.ExecuteTransaction, (CreateSamplingLot_Parameters) null));
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
        CreateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CreateSamplingLot) cdo, (CreateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CreateSamplingLot cdo)
    {
      return this.ExecuteTransaction(cdo, (CreateSamplingLot_Request) null, out CreateSamplingLot_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CreateSamplingLot_Request request,
      out CreateSamplingLot_Result result)
    {
      return this.ExecuteTransaction((CreateSamplingLot) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CreateSamplingLot cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CreateSamplingLotMethod(cdo, CreateSamplingLotMethods.AddDataTransaction, (CreateSamplingLot_Parameters) null));
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
        return this.AddDataTransaction((CreateSamplingLot) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
