// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveWithThruputService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveWithThruputService : CompoundTxnBase
  {
    public MoveWithThruputService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveWithThruputService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).CreateParametricData(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus CreateParametricData(MoveWithThruput moveWithThruput)
    {
      return this.CreateParametricData(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.CreateParametricData(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).GetActions(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetActions(MoveWithThruput moveWithThruput)
    {
      return this.GetActions(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetActions(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.GetActions(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).GetDataPoints(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetDataPoints(MoveWithThruput moveWithThruput)
    {
      return this.GetDataPoints(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.GetDataPoints(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).GetWIPMsgs(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveWithThruput moveWithThruput)
    {
      return this.GetWIPMsgs(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.GetWIPMsgs(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).Load(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus Load(MoveWithThruput moveWithThruput)
    {
      return this.Load(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus Load(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.Load(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_LoadESigDetails_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).LoadESigDetails(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.LoadESigDetails, (MoveWithThruput_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveWithThruput) null, (MoveWithThruput_LoadESigDetails_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus LoadESigDetails(MoveWithThruput moveWithThruput)
    {
      return this.LoadESigDetails(moveWithThruput, (MoveWithThruput_LoadESigDetails_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.LoadESigDetails(moveWithThruput, (MoveWithThruput_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).ProcessComputation(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus ProcessComputation(MoveWithThruput moveWithThruput)
    {
      return this.ProcessComputation(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.ProcessComputation(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Parameters parameters,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveWithThruput, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).ResolveParametricData(this._UserProfile, moveWithThruput, parameters, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(moveWithThruput, MoveWithThruputMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveWithThruput, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveWithThruput) null, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus ResolveParametricData(MoveWithThruput moveWithThruput)
    {
      return this.ResolveParametricData(moveWithThruput, (MoveWithThruput_Parameters) null, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveWithThruput moveWithThruput,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.ResolveParametricData(moveWithThruput, (MoveWithThruput_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus actions = this.GetActions((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveWithThruput) moveWithThruput, (MoveWithThruput_LoadESigDetails_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.Load((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveWithThruput,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveWithThruput_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveWithThruput) moveWithThruput, (MoveWithThruput_Parameters) parameters, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      try
      {
        MoveWithThruputMethod[] methods = new MoveWithThruputMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveWithThruputService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveWithThruput cdo,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      try
      {
        return ((IMoveWithThruputService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveWithThruput_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveWithThruput) cdo, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.GetEnvironment((MoveWithThruput) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveWithThruput cdo,
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      result = (MoveWithThruput_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveWithThruputService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveWithThruputMethod(cdo, MoveWithThruputMethods.ExecuteTransaction, (MoveWithThruput_Parameters) null));
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
        MoveWithThruput_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveWithThruput) cdo, (MoveWithThruput_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveWithThruput cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveWithThruput_Request) null, out MoveWithThruput_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveWithThruput_Request request,
      out MoveWithThruput_Result result)
    {
      return this.ExecuteTransaction((MoveWithThruput) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveWithThruput cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveWithThruputMethod(cdo, MoveWithThruputMethods.AddDataTransaction, (MoveWithThruput_Parameters) null));
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
        return this.AddDataTransaction((MoveWithThruput) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
