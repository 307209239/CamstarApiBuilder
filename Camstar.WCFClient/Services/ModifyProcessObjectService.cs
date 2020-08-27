// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ModifyProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ModifyProcessObjectService : ProcessObjectTxnBase
  {
    public ModifyProcessObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IModifyProcessObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).CreateParametricData(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(ModifyProcessObject modifyProcessObject)
    {
      return this.CreateParametricData(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus CreateParametricData(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.CreateParametricData(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).GetActions(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetActions(ModifyProcessObject modifyProcessObject)
    {
      return this.GetActions(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetActions(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.GetActions(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).GetDataPoints(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(ModifyProcessObject modifyProcessObject)
    {
      return this.GetDataPoints(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetDataPoints(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.GetDataPoints(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).GetWIPMsgs(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(ModifyProcessObject modifyProcessObject)
    {
      return this.GetWIPMsgs(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.GetWIPMsgs(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).Load(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus Load(ModifyProcessObject modifyProcessObject)
    {
      return this.Load(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus Load(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.Load(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).LoadESigDetails(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(ModifyProcessObject modifyProcessObject)
    {
      return this.LoadESigDetails(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.LoadESigDetails(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).ProcessComputation(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(ModifyProcessObject modifyProcessObject)
    {
      return this.ProcessComputation(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus ProcessComputation(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.ProcessComputation(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Parameters parameters,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).ResolveParametricData(this._UserProfile, modifyProcessObject, parameters, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(modifyProcessObject, ModifyProcessObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) modifyProcessObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ModifyProcessObject) null, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(ModifyProcessObject modifyProcessObject)
    {
      return this.ResolveParametricData(modifyProcessObject, (ModifyProcessObject_Parameters) null, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      ModifyProcessObject modifyProcessObject,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.ResolveParametricData(modifyProcessObject, (ModifyProcessObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus actions = this.GetActions((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.Load((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject modifyProcessObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModifyProcessObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ModifyProcessObject) modifyProcessObject, (ModifyProcessObject_Parameters) parameters, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      try
      {
        ModifyProcessObjectMethod[] methods = new ModifyProcessObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IModifyProcessObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModifyProcessObject cdo,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      try
      {
        return ((IModifyProcessObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ModifyProcessObject_Result result1;
        ResultStatus environment = this.GetEnvironment((ModifyProcessObject) cdo, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.GetEnvironment((ModifyProcessObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ModifyProcessObject cdo,
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      result = (ModifyProcessObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModifyProcessObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ModifyProcessObjectMethod(cdo, ModifyProcessObjectMethods.ExecuteTransaction, (ModifyProcessObject_Parameters) null));
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
        ModifyProcessObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ModifyProcessObject) cdo, (ModifyProcessObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ModifyProcessObject cdo)
    {
      return this.ExecuteTransaction(cdo, (ModifyProcessObject_Request) null, out ModifyProcessObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ModifyProcessObject_Request request,
      out ModifyProcessObject_Result result)
    {
      return this.ExecuteTransaction((ModifyProcessObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ModifyProcessObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ModifyProcessObjectMethod(cdo, ModifyProcessObjectMethods.AddDataTransaction, (ModifyProcessObject_Parameters) null));
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
        return this.AddDataTransaction((ModifyProcessObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
