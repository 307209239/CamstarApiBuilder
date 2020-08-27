// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveNonStdsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveNonStdsService : MoveTxnsBase
  {
    public MoveNonStdsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveNonStdsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).CreateParametricData(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus CreateParametricData(MoveNonStds moveNonStds)
    {
      return this.CreateParametricData(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.CreateParametricData(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).GetActions(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetActions(MoveNonStds moveNonStds)
    {
      return this.GetActions(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetActions(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.GetActions(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).GetDataPoints(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetDataPoints(MoveNonStds moveNonStds)
    {
      return this.GetDataPoints(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.GetDataPoints(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).GetWIPMsgs(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveNonStds moveNonStds)
    {
      return this.GetWIPMsgs(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.GetWIPMsgs(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).Load(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus Load(MoveNonStds moveNonStds)
    {
      return this.Load(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus Load(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.Load(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStds moveNonStds,
      MoveNonStds_LoadESigDetails_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).LoadESigDetails(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.LoadESigDetails, (MoveNonStds_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveNonStds) null, (MoveNonStds_LoadESigDetails_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus LoadESigDetails(MoveNonStds moveNonStds)
    {
      return this.LoadESigDetails(moveNonStds, (MoveNonStds_LoadESigDetails_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.LoadESigDetails(moveNonStds, (MoveNonStds_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).ProcessComputation(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus ProcessComputation(MoveNonStds moveNonStds)
    {
      return this.ProcessComputation(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.ProcessComputation(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStds moveNonStds,
      MoveNonStds_Parameters parameters,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveNonStds, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).ResolveParametricData(this._UserProfile, moveNonStds, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(moveNonStds, MoveNonStdsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveNonStds, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveNonStds) null, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus ResolveParametricData(MoveNonStds moveNonStds)
    {
      return this.ResolveParametricData(moveNonStds, (MoveNonStds_Parameters) null, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStds moveNonStds,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.ResolveParametricData(moveNonStds, (MoveNonStds_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus actions = this.GetActions((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveNonStds) moveNonStds, (MoveNonStds_LoadESigDetails_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.Load((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveNonStds,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStds_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveNonStds) moveNonStds, (MoveNonStds_Parameters) parameters, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      try
      {
        MoveNonStdsMethod[] methods = new MoveNonStdsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveNonStdsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStds cdo,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      try
      {
        return ((IMoveNonStdsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveNonStds_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveNonStds) cdo, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.GetEnvironment((MoveNonStds) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStds cdo,
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      result = (MoveNonStds_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveNonStdsMethod(cdo, MoveNonStdsMethods.ExecuteTransaction, (MoveNonStds_Parameters) null));
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
        MoveNonStds_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveNonStds) cdo, (MoveNonStds_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveNonStds cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveNonStds_Request) null, out MoveNonStds_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStds_Request request,
      out MoveNonStds_Result result)
    {
      return this.ExecuteTransaction((MoveNonStds) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveNonStds cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveNonStdsMethod(cdo, MoveNonStdsMethods.AddDataTransaction, (MoveNonStds_Parameters) null));
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
        return this.AddDataTransaction((MoveNonStds) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
