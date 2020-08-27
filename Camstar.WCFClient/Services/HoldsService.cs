// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HoldsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HoldsService : HoldStatusTxnsBase
  {
    public HoldsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHoldsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).CreateParametricData(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus CreateParametricData(Holds holds)
    {
      return this.CreateParametricData(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus CreateParametricData(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.CreateParametricData(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).GetActions(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetActions(Holds holds)
    {
      return this.GetActions(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetActions(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.GetActions(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).GetDataPoints(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetDataPoints(Holds holds)
    {
      return this.GetDataPoints(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetDataPoints(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.GetDataPoints(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).GetWIPMsgs(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetWIPMsgs(Holds holds)
    {
      return this.GetWIPMsgs(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.GetWIPMsgs(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).Load(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus Load(Holds holds)
    {
      return this.Load(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus Load(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.Load(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Holds holds,
      Holds_LoadESigDetails_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).LoadESigDetails(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.LoadESigDetails, (Holds_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Holds) null, (Holds_LoadESigDetails_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus LoadESigDetails(Holds holds)
    {
      return this.LoadESigDetails(holds, (Holds_LoadESigDetails_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus LoadESigDetails(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.LoadESigDetails(holds, (Holds_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).ProcessComputation(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus ProcessComputation(Holds holds)
    {
      return this.ProcessComputation(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus ProcessComputation(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.ProcessComputation(holds, (Holds_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Holds holds,
      Holds_Parameters parameters,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) holds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).ResolveParametricData(this._UserProfile, holds, parameters, request, out result) : this.AddMethod((Method) new HoldsMethod(holds, HoldsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) holds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Holds) null, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus ResolveParametricData(Holds holds)
    {
      return this.ResolveParametricData(holds, (Holds_Parameters) null, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus ResolveParametricData(
      Holds holds,
      Holds_Request request,
      out Holds_Result result)
    {
      return this.ResolveParametricData(holds, (Holds_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus actions = this.GetActions((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Holds) holds, (Holds_LoadESigDetails_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus resultStatus = this.Load((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject holds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Holds_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Holds) holds, (Holds_Parameters) parameters, (Holds_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      try
      {
        HoldsMethod[] methods = new HoldsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHoldsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Holds_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Holds cdo,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      try
      {
        return ((IHoldsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Holds_Result result1;
        ResultStatus environment = this.GetEnvironment((Holds) cdo, (Holds_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Holds_Request request, out Holds_Result result)
    {
      return this.GetEnvironment((Holds) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Holds cdo,
      Holds_Request request,
      out Holds_Result result)
    {
      result = (Holds_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HoldsMethod(cdo, HoldsMethods.ExecuteTransaction, (Holds_Parameters) null));
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
        Holds_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Holds) cdo, (Holds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Holds cdo)
    {
      return this.ExecuteTransaction(cdo, (Holds_Request) null, out Holds_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Holds_Request request,
      out Holds_Result result)
    {
      return this.ExecuteTransaction((Holds) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Holds cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HoldsMethod(cdo, HoldsMethods.AddDataTransaction, (Holds_Parameters) null));
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
        return this.AddDataTransaction((Holds) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
