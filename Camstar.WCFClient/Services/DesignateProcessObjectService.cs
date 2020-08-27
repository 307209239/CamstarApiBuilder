// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DesignateProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DesignateProcessObjectService : ProcessObjectTxnBase
  {
    public DesignateProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDesignateProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      DesignateProcessObject designateProcessObject)
    {
      return this.CreateParametricData(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.CreateParametricData(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).GetActions(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetActions(DesignateProcessObject designateProcessObject)
    {
      return this.GetActions(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetActions(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.GetActions(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(DesignateProcessObject designateProcessObject)
    {
      return this.GetDataPoints(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.GetDataPoints(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(DesignateProcessObject designateProcessObject)
    {
      return this.GetWIPMsgs(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.GetWIPMsgs(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).Load(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus Load(DesignateProcessObject designateProcessObject)
    {
      return this.Load(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus Load(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.Load(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(DesignateProcessObject designateProcessObject)
    {
      return this.LoadESigDetails(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.LoadESigDetails(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(DesignateProcessObject designateProcessObject)
    {
      return this.ProcessComputation(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.ProcessComputation(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Parameters parameters,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) designateProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, designateProcessObject, parameters, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(designateProcessObject, DesignateProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) designateProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DesignateProcessObject) null, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      DesignateProcessObject designateProcessObject)
    {
      return this.ResolveParametricData(designateProcessObject, (DesignateProcessObject_Parameters) null, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      DesignateProcessObject designateProcessObject,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.ResolveParametricData(designateProcessObject, (DesignateProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus actions = this.GetActions((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject designateProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DesignateProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DesignateProcessObject) designateProcessObject, (DesignateProcessObject_Parameters) parameters, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      try
      {
        DesignateProcessObjectMethod[] methods = new DesignateProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDesignateProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DesignateProcessObject cdo,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      try
      {
        return ((IDesignateProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DesignateProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((DesignateProcessObject) cdo, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.GetEnvironment((DesignateProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DesignateProcessObject cdo,
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      result = (DesignateProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDesignateProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DesignateProcessObjectMethod(cdo, DesignateProcessObjectMethods.ExecuteTransaction, (DesignateProcessObject_Parameters) null));
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
        DesignateProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DesignateProcessObject) cdo, (DesignateProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DesignateProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (DesignateProcessObject_Request) null, out DesignateProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DesignateProcessObject_Request request,
      out DesignateProcessObject_Result result)
    {
      return this.ExecuteTransaction((DesignateProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DesignateProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DesignateProcessObjectMethod(cdo, DesignateProcessObjectMethods.AddDataTransaction, (DesignateProcessObject_Parameters) null));
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
        return this.AddDataTransaction((DesignateProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
