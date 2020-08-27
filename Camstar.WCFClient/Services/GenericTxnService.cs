// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GenericTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GenericTxnService : ShopFloorBase
  {
    public GenericTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGenericTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).CreateParametricData(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus CreateParametricData(GenericTxn genericTxn)
    {
      return this.CreateParametricData(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.CreateParametricData(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).GetActions(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetActions(GenericTxn genericTxn)
    {
      return this.GetActions(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetActions(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.GetActions(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).GetDataPoints(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetDataPoints(GenericTxn genericTxn)
    {
      return this.GetDataPoints(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.GetDataPoints(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).GetWIPMsgs(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(GenericTxn genericTxn)
    {
      return this.GetWIPMsgs(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.GetWIPMsgs(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).Load(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus Load(GenericTxn genericTxn)
    {
      return this.Load(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus Load(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.Load(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      GenericTxn genericTxn,
      GenericTxn_LoadESigDetails_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).LoadESigDetails(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.LoadESigDetails, (GenericTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((GenericTxn) null, (GenericTxn_LoadESigDetails_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus LoadESigDetails(GenericTxn genericTxn)
    {
      return this.LoadESigDetails(genericTxn, (GenericTxn_LoadESigDetails_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.LoadESigDetails(genericTxn, (GenericTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PostExecuteValidate(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (PostExecuteValidate), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).PostExecuteValidate(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.PostExecuteValidate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostExecuteValidate), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostExecuteValidate()
    {
      return this.PostExecuteValidate((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus PostExecuteValidate(GenericTxn genericTxn)
    {
      return this.PostExecuteValidate(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus PostExecuteValidate(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.PostExecuteValidate(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).ProcessComputation(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus ProcessComputation(GenericTxn genericTxn)
    {
      return this.ProcessComputation(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.ProcessComputation(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      GenericTxn genericTxn,
      GenericTxn_Parameters parameters,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) genericTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).ResolveParametricData(this._UserProfile, genericTxn, parameters, request, out result) : this.AddMethod((Method) new GenericTxnMethod(genericTxn, GenericTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) genericTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((GenericTxn) null, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus ResolveParametricData(GenericTxn genericTxn)
    {
      return this.ResolveParametricData(genericTxn, (GenericTxn_Parameters) null, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      GenericTxn genericTxn,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.ResolveParametricData(genericTxn, (GenericTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus actions = this.GetActions((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((GenericTxn) genericTxn, (GenericTxn_LoadESigDetails_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.Load((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject genericTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GenericTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GenericTxn) genericTxn, (GenericTxn_Parameters) parameters, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      try
      {
        GenericTxnMethod[] methods = new GenericTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGenericTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GenericTxn cdo,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      try
      {
        return ((IGenericTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GenericTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((GenericTxn) cdo, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.GetEnvironment((GenericTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GenericTxn cdo,
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      result = (GenericTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGenericTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GenericTxnMethod(cdo, GenericTxnMethods.ExecuteTransaction, (GenericTxn_Parameters) null));
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
        GenericTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GenericTxn) cdo, (GenericTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GenericTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (GenericTxn_Request) null, out GenericTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GenericTxn_Request request,
      out GenericTxn_Result result)
    {
      return this.ExecuteTransaction((GenericTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GenericTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GenericTxnMethod(cdo, GenericTxnMethods.AddDataTransaction, (GenericTxn_Parameters) null));
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
        return this.AddDataTransaction((GenericTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
