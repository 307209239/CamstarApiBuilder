// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCREscalateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCREscalateService : NCRTxnBase
  {
    public NCREscalateService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCREscalateService), userProfile);
    }

    public ResultStatus CreateParametricData(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).CreateParametricData(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus CreateParametricData(NCREscalate nCREscalate)
    {
      return this.CreateParametricData(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus CreateParametricData(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.CreateParametricData(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).GetActions(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetActions(NCREscalate nCREscalate)
    {
      return this.GetActions(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetActions(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.GetActions(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).GetDataPoints(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetDataPoints(NCREscalate nCREscalate)
    {
      return this.GetDataPoints(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetDataPoints(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.GetDataPoints(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).GetWIPMsgs(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetWIPMsgs(NCREscalate nCREscalate)
    {
      return this.GetWIPMsgs(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.GetWIPMsgs(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).Load(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus Load(NCREscalate nCREscalate)
    {
      return this.Load(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus Load(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.Load(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCREscalate nCREscalate,
      NCREscalate_LoadESigDetails_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).LoadESigDetails(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.LoadESigDetails, (NCREscalate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCREscalate) null, (NCREscalate_LoadESigDetails_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus LoadESigDetails(NCREscalate nCREscalate)
    {
      return this.LoadESigDetails(nCREscalate, (NCREscalate_LoadESigDetails_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.LoadESigDetails(nCREscalate, (NCREscalate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).ProcessComputation(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus ProcessComputation(NCREscalate nCREscalate)
    {
      return this.ProcessComputation(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus ProcessComputation(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.ProcessComputation(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCREscalate nCREscalate,
      NCREscalate_Parameters parameters,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCREscalate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).ResolveParametricData(this._UserProfile, nCREscalate, parameters, request, out result) : this.AddMethod((Method) new NCREscalateMethod(nCREscalate, NCREscalateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCREscalate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCREscalate) null, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus ResolveParametricData(NCREscalate nCREscalate)
    {
      return this.ResolveParametricData(nCREscalate, (NCREscalate_Parameters) null, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCREscalate nCREscalate,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.ResolveParametricData(nCREscalate, (NCREscalate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus actions = this.GetActions((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCREscalate) nCREscalate, (NCREscalate_LoadESigDetails_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.Load((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCREscalate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCREscalate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCREscalate) nCREscalate, (NCREscalate_Parameters) parameters, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      try
      {
        NCREscalateMethod[] methods = new NCREscalateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCREscalateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCREscalate cdo,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      try
      {
        return ((INCREscalateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCREscalate_Result result1;
        ResultStatus environment = this.GetEnvironment((NCREscalate) cdo, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.GetEnvironment((NCREscalate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCREscalate cdo,
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      result = (NCREscalate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCREscalateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCREscalateMethod(cdo, NCREscalateMethods.ExecuteTransaction, (NCREscalate_Parameters) null));
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
        NCREscalate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCREscalate) cdo, (NCREscalate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCREscalate cdo)
    {
      return this.ExecuteTransaction(cdo, (NCREscalate_Request) null, out NCREscalate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCREscalate_Request request,
      out NCREscalate_Result result)
    {
      return this.ExecuteTransaction((NCREscalate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCREscalate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCREscalateMethod(cdo, NCREscalateMethods.AddDataTransaction, (NCREscalate_Parameters) null));
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
        return this.AddDataTransaction((NCREscalate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
