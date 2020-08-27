// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.VoidProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class VoidProcessObjectService : ProcessObjectTxnBase
  {
    public VoidProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IVoidProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(VoidProcessObject voidProcessObject)
    {
      return this.CreateParametricData(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.CreateParametricData(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).GetActions(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetActions(VoidProcessObject voidProcessObject)
    {
      return this.GetActions(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetActions(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.GetActions(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(VoidProcessObject voidProcessObject)
    {
      return this.GetDataPoints(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.GetDataPoints(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(VoidProcessObject voidProcessObject)
    {
      return this.GetWIPMsgs(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.GetWIPMsgs(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).Load(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus Load(VoidProcessObject voidProcessObject)
    {
      return this.Load(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus Load(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.Load(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(VoidProcessObject voidProcessObject)
    {
      return this.LoadESigDetails(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.LoadESigDetails(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(VoidProcessObject voidProcessObject)
    {
      return this.ProcessComputation(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.ProcessComputation(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Parameters parameters,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) voidProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, voidProcessObject, parameters, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(voidProcessObject, VoidProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) voidProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((VoidProcessObject) null, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(VoidProcessObject voidProcessObject)
    {
      return this.ResolveParametricData(voidProcessObject, (VoidProcessObject_Parameters) null, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      VoidProcessObject voidProcessObject,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.ResolveParametricData(voidProcessObject, (VoidProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus actions = this.GetActions((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject voidProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VoidProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((VoidProcessObject) voidProcessObject, (VoidProcessObject_Parameters) parameters, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      try
      {
        VoidProcessObjectMethod[] methods = new VoidProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IVoidProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidProcessObject cdo,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      try
      {
        return ((IVoidProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        VoidProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((VoidProcessObject) cdo, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.GetEnvironment((VoidProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      VoidProcessObject cdo,
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      result = (VoidProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVoidProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new VoidProcessObjectMethod(cdo, VoidProcessObjectMethods.ExecuteTransaction, (VoidProcessObject_Parameters) null));
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
        VoidProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((VoidProcessObject) cdo, (VoidProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(VoidProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (VoidProcessObject_Request) null, out VoidProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      VoidProcessObject_Request request,
      out VoidProcessObject_Result result)
    {
      return this.ExecuteTransaction((VoidProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(VoidProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new VoidProcessObjectMethod(cdo, VoidProcessObjectMethods.AddDataTransaction, (VoidProcessObject_Parameters) null));
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
        return this.AddDataTransaction((VoidProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
