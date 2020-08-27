// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UnitStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UnitStartService : StartBase
  {
    public UnitStartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUnitStartService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).CreateParametricData(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus CreateParametricData(UnitStart unitStart)
    {
      return this.CreateParametricData(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus CreateParametricData(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.CreateParametricData(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).GetActions(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetActions(UnitStart unitStart)
    {
      return this.GetActions(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetActions(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.GetActions(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).GetDataPoints(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetDataPoints(UnitStart unitStart)
    {
      return this.GetDataPoints(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetDataPoints(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.GetDataPoints(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).GetWIPMsgs(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetWIPMsgs(UnitStart unitStart)
    {
      return this.GetWIPMsgs(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.GetWIPMsgs(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).Load(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus Load(UnitStart unitStart)
    {
      return this.Load(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus Load(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.Load(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UnitStart unitStart,
      UnitStart_LoadESigDetails_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).LoadESigDetails(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.LoadESigDetails, (UnitStart_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UnitStart) null, (UnitStart_LoadESigDetails_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus LoadESigDetails(UnitStart unitStart)
    {
      return this.LoadESigDetails(unitStart, (UnitStart_LoadESigDetails_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus LoadESigDetails(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.LoadESigDetails(unitStart, (UnitStart_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).ProcessComputation(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus ProcessComputation(UnitStart unitStart)
    {
      return this.ProcessComputation(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus ProcessComputation(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.ProcessComputation(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) unitStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).ResolveParametricData(this._UserProfile, unitStart, parameters, request, out result) : this.AddMethod((Method) new UnitStartMethod(unitStart, UnitStartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) unitStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UnitStart) null, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus ResolveParametricData(UnitStart unitStart)
    {
      return this.ResolveParametricData(unitStart, (UnitStart_Parameters) null, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.ResolveParametricData(unitStart, (UnitStart_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus actions = this.GetActions((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UnitStart) unitStart, (UnitStart_LoadESigDetails_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus resultStatus = this.Load((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject unitStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UnitStart_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UnitStart) unitStart, (UnitStart_Parameters) parameters, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      try
      {
        UnitStartMethod[] methods = new UnitStartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUnitStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UnitStart_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UnitStart cdo,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      try
      {
        return ((IUnitStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UnitStart_Result result1;
        ResultStatus environment = this.GetEnvironment((UnitStart) cdo, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.GetEnvironment((UnitStart) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UnitStart cdo,
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      result = (UnitStart_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUnitStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UnitStartMethod(cdo, UnitStartMethods.ExecuteTransaction, (UnitStart_Parameters) null));
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
        UnitStart_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UnitStart) cdo, (UnitStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UnitStart cdo)
    {
      return this.ExecuteTransaction(cdo, (UnitStart_Request) null, out UnitStart_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UnitStart_Request request,
      out UnitStart_Result result)
    {
      return this.ExecuteTransaction((UnitStart) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UnitStart cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UnitStartMethod(cdo, UnitStartMethods.AddDataTransaction, (UnitStart_Parameters) null));
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
        return this.AddDataTransaction((UnitStart) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
