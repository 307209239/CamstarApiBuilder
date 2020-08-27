// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteProcessObjectService : ProcessObjectTxnBase
  {
    public CompleteProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(CompleteProcessObject completeProcessObject)
    {
      return this.CreateParametricData(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.CreateParametricData(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).GetActions(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetActions(CompleteProcessObject completeProcessObject)
    {
      return this.GetActions(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetActions(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.GetActions(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(CompleteProcessObject completeProcessObject)
    {
      return this.GetDataPoints(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.GetDataPoints(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(CompleteProcessObject completeProcessObject)
    {
      return this.GetWIPMsgs(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.GetWIPMsgs(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).Load(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus Load(CompleteProcessObject completeProcessObject)
    {
      return this.Load(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus Load(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.Load(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(CompleteProcessObject completeProcessObject)
    {
      return this.LoadESigDetails(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.LoadESigDetails(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(CompleteProcessObject completeProcessObject)
    {
      return this.ProcessComputation(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.ProcessComputation(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Parameters parameters,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, completeProcessObject, parameters, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(completeProcessObject, CompleteProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompleteProcessObject) null, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteProcessObject completeProcessObject)
    {
      return this.ResolveParametricData(completeProcessObject, (CompleteProcessObject_Parameters) null, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteProcessObject completeProcessObject,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.ResolveParametricData(completeProcessObject, (CompleteProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus actions = this.GetActions((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompleteProcessObject) completeProcessObject, (CompleteProcessObject_Parameters) parameters, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      try
      {
        CompleteProcessObjectMethod[] methods = new CompleteProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteProcessObject cdo,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      try
      {
        return ((ICompleteProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((CompleteProcessObject) cdo, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.GetEnvironment((CompleteProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompleteProcessObject cdo,
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      result = (CompleteProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteProcessObjectMethod(cdo, CompleteProcessObjectMethods.ExecuteTransaction, (CompleteProcessObject_Parameters) null));
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
        CompleteProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompleteProcessObject) cdo, (CompleteProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompleteProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteProcessObject_Request) null, out CompleteProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteProcessObject_Request request,
      out CompleteProcessObject_Result result)
    {
      return this.ExecuteTransaction((CompleteProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompleteProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteProcessObjectMethod(cdo, CompleteProcessObjectMethods.AddDataTransaction, (CompleteProcessObject_Parameters) null));
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
        return this.AddDataTransaction((CompleteProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
