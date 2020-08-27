// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveNonStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveNonStdService : MoveTxnBase
  {
    public MoveNonStdService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveNonStdService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).CreateParametricData(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus CreateParametricData(MoveNonStd moveNonStd)
    {
      return this.CreateParametricData(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.CreateParametricData(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).GetActions(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetActions(MoveNonStd moveNonStd)
    {
      return this.GetActions(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetActions(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.GetActions(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).GetDataPoints(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetDataPoints(MoveNonStd moveNonStd)
    {
      return this.GetDataPoints(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.GetDataPoints(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).GetWIPMsgs(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveNonStd moveNonStd)
    {
      return this.GetWIPMsgs(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.GetWIPMsgs(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).Load(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus Load(MoveNonStd moveNonStd)
    {
      return this.Load(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus Load(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.Load(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStd moveNonStd,
      MoveNonStd_LoadESigDetails_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).LoadESigDetails(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.LoadESigDetails, (MoveNonStd_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveNonStd) null, (MoveNonStd_LoadESigDetails_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus LoadESigDetails(MoveNonStd moveNonStd)
    {
      return this.LoadESigDetails(moveNonStd, (MoveNonStd_LoadESigDetails_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.LoadESigDetails(moveNonStd, (MoveNonStd_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).ProcessComputation(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus ProcessComputation(MoveNonStd moveNonStd)
    {
      return this.ProcessComputation(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.ProcessComputation(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStd moveNonStd,
      MoveNonStd_Parameters parameters,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).ResolveParametricData(this._UserProfile, moveNonStd, parameters, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(moveNonStd, MoveNonStdMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveNonStd) null, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus ResolveParametricData(MoveNonStd moveNonStd)
    {
      return this.ResolveParametricData(moveNonStd, (MoveNonStd_Parameters) null, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveNonStd moveNonStd,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.ResolveParametricData(moveNonStd, (MoveNonStd_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus actions = this.GetActions((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveNonStd) moveNonStd, (MoveNonStd_LoadESigDetails_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.Load((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveNonStd_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveNonStd) moveNonStd, (MoveNonStd_Parameters) parameters, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      try
      {
        MoveNonStdMethod[] methods = new MoveNonStdMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveNonStdService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStd cdo,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      try
      {
        return ((IMoveNonStdService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveNonStd_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveNonStd) cdo, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.GetEnvironment((MoveNonStd) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStd cdo,
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      result = (MoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveNonStdService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveNonStdMethod(cdo, MoveNonStdMethods.ExecuteTransaction, (MoveNonStd_Parameters) null));
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
        MoveNonStd_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveNonStd) cdo, (MoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveNonStd cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveNonStd_Request) null, out MoveNonStd_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveNonStd_Request request,
      out MoveNonStd_Result result)
    {
      return this.ExecuteTransaction((MoveNonStd) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveNonStd cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveNonStdMethod(cdo, MoveNonStdMethods.AddDataTransaction, (MoveNonStd_Parameters) null));
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
        return this.AddDataTransaction((MoveNonStd) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
