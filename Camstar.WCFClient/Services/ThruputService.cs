// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ThruputService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ThruputService : ContainerTxnBase
  {
    public ThruputService(UserProfile userProfile)
    {
      this.Initialize(typeof (IThruputService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).CreateParametricData(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus CreateParametricData(Thruput thruput)
    {
      return this.CreateParametricData(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus CreateParametricData(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.CreateParametricData(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).GetActions(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetActions(Thruput thruput)
    {
      return this.GetActions(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetActions(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.GetActions(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).GetDataPoints(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetDataPoints(Thruput thruput)
    {
      return this.GetDataPoints(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetDataPoints(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.GetDataPoints(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).GetWIPMsgs(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetWIPMsgs(Thruput thruput)
    {
      return this.GetWIPMsgs(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.GetWIPMsgs(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).Load(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus Load(Thruput thruput)
    {
      return this.Load(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus Load(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.Load(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Thruput thruput,
      Thruput_LoadESigDetails_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).LoadESigDetails(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.LoadESigDetails, (Thruput_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Thruput) null, (Thruput_LoadESigDetails_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus LoadESigDetails(Thruput thruput)
    {
      return this.LoadESigDetails(thruput, (Thruput_LoadESigDetails_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus LoadESigDetails(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.LoadESigDetails(thruput, (Thruput_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).ProcessComputation(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus ProcessComputation(Thruput thruput)
    {
      return this.ProcessComputation(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus ProcessComputation(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.ProcessComputation(thruput, (Thruput_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Thruput thruput,
      Thruput_Parameters parameters,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) thruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).ResolveParametricData(this._UserProfile, thruput, parameters, request, out result) : this.AddMethod((Method) new ThruputMethod(thruput, ThruputMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) thruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Thruput) null, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus ResolveParametricData(Thruput thruput)
    {
      return this.ResolveParametricData(thruput, (Thruput_Parameters) null, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus ResolveParametricData(
      Thruput thruput,
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.ResolveParametricData(thruput, (Thruput_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus actions = this.GetActions((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Thruput) thruput, (Thruput_LoadESigDetails_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus resultStatus = this.Load((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject thruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Thruput_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Thruput) thruput, (Thruput_Parameters) parameters, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      try
      {
        ThruputMethod[] methods = new ThruputMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IThruputService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Thruput_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Thruput cdo,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      try
      {
        return ((IThruputService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Thruput_Result result1;
        ResultStatus environment = this.GetEnvironment((Thruput) cdo, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.GetEnvironment((Thruput) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Thruput cdo,
      Thruput_Request request,
      out Thruput_Result result)
    {
      result = (Thruput_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IThruputService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ThruputMethod(cdo, ThruputMethods.ExecuteTransaction, (Thruput_Parameters) null));
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
        Thruput_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Thruput) cdo, (Thruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Thruput cdo)
    {
      return this.ExecuteTransaction(cdo, (Thruput_Request) null, out Thruput_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Thruput_Request request,
      out Thruput_Result result)
    {
      return this.ExecuteTransaction((Thruput) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Thruput cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ThruputMethod(cdo, ThruputMethods.AddDataTransaction, (Thruput_Parameters) null));
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
        return this.AddDataTransaction((Thruput) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
