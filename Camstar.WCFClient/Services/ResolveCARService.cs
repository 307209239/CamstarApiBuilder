// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResolveCARService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResolveCARService : CloseQualityObjectBase
  {
    public ResolveCARService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResolveCARService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).CreateParametricData(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus CreateParametricData(ResolveCAR resolveCAR)
    {
      return this.CreateParametricData(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus CreateParametricData(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.CreateParametricData(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).GetActions(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetActions(ResolveCAR resolveCAR)
    {
      return this.GetActions(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetActions(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.GetActions(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).GetDataPoints(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetDataPoints(ResolveCAR resolveCAR)
    {
      return this.GetDataPoints(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetDataPoints(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.GetDataPoints(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).GetWIPMsgs(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetWIPMsgs(ResolveCAR resolveCAR)
    {
      return this.GetWIPMsgs(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.GetWIPMsgs(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).Load(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus Load(ResolveCAR resolveCAR)
    {
      return this.Load(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus Load(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.Load(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).LoadESigDetails(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus LoadESigDetails(ResolveCAR resolveCAR)
    {
      return this.LoadESigDetails(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.LoadESigDetails(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).ProcessComputation(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus ProcessComputation(ResolveCAR resolveCAR)
    {
      return this.ProcessComputation(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus ProcessComputation(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.ProcessComputation(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ResolveCAR resolveCAR,
      ResolveCAR_Parameters parameters,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) resolveCAR, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).ResolveParametricData(this._UserProfile, resolveCAR, parameters, request, out result) : this.AddMethod((Method) new ResolveCARMethod(resolveCAR, ResolveCARMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) resolveCAR, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ResolveCAR) null, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus ResolveParametricData(ResolveCAR resolveCAR)
    {
      return this.ResolveParametricData(resolveCAR, (ResolveCAR_Parameters) null, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus ResolveParametricData(
      ResolveCAR resolveCAR,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.ResolveParametricData(resolveCAR, (ResolveCAR_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus actions = this.GetActions((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.Load((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resolveCAR,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResolveCAR_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResolveCAR) resolveCAR, (ResolveCAR_Parameters) parameters, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      try
      {
        ResolveCARMethod[] methods = new ResolveCARMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResolveCARService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResolveCAR cdo,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      try
      {
        return ((IResolveCARService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResolveCAR_Result result1;
        ResultStatus environment = this.GetEnvironment((ResolveCAR) cdo, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.GetEnvironment((ResolveCAR) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResolveCAR cdo,
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      result = (ResolveCAR_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResolveCARService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResolveCARMethod(cdo, ResolveCARMethods.ExecuteTransaction, (ResolveCAR_Parameters) null));
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
        ResolveCAR_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResolveCAR) cdo, (ResolveCAR_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResolveCAR cdo)
    {
      return this.ExecuteTransaction(cdo, (ResolveCAR_Request) null, out ResolveCAR_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResolveCAR_Request request,
      out ResolveCAR_Result result)
    {
      return this.ExecuteTransaction((ResolveCAR) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResolveCAR cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResolveCARMethod(cdo, ResolveCARMethods.AddDataTransaction, (ResolveCAR_Parameters) null));
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
        return this.AddDataTransaction((ResolveCAR) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
