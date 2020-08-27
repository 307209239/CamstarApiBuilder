// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpenQualityObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpenQualityObjectService : QualityTxnBase
  {
    public OpenQualityObjectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpenQualityObjectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).CreateParametricData(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(OpenQualityObject openQualityObject)
    {
      return this.CreateParametricData(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus CreateParametricData(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.CreateParametricData(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).GetActions(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetActions(OpenQualityObject openQualityObject)
    {
      return this.GetActions(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetActions(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.GetActions(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).GetDataPoints(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(OpenQualityObject openQualityObject)
    {
      return this.GetDataPoints(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetDataPoints(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.GetDataPoints(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).GetWIPMsgs(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(OpenQualityObject openQualityObject)
    {
      return this.GetWIPMsgs(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.GetWIPMsgs(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).Load(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus Load(OpenQualityObject openQualityObject)
    {
      return this.Load(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus Load(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.Load(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).LoadESigDetails(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(OpenQualityObject openQualityObject)
    {
      return this.LoadESigDetails(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus LoadESigDetails(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.LoadESigDetails(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).ProcessComputation(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(OpenQualityObject openQualityObject)
    {
      return this.ProcessComputation(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus ProcessComputation(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.ProcessComputation(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Parameters parameters,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) openQualityObject, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).ResolveParametricData(this._UserProfile, openQualityObject, parameters, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(openQualityObject, OpenQualityObjectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) openQualityObject, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((OpenQualityObject) null, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(OpenQualityObject openQualityObject)
    {
      return this.ResolveParametricData(openQualityObject, (OpenQualityObject_Parameters) null, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus ResolveParametricData(
      OpenQualityObject openQualityObject,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.ResolveParametricData(openQualityObject, (OpenQualityObject_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus parametricData = this.CreateParametricData((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus actions = this.GetActions((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.Load((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject openQualityObject,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OpenQualityObject_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OpenQualityObject) openQualityObject, (OpenQualityObject_Parameters) parameters, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      try
      {
        OpenQualityObjectMethod[] methods = new OpenQualityObjectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpenQualityObjectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenQualityObject cdo,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      try
      {
        return ((IOpenQualityObjectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OpenQualityObject_Result result1;
        ResultStatus environment = this.GetEnvironment((OpenQualityObject) cdo, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.GetEnvironment((OpenQualityObject) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OpenQualityObject cdo,
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      result = (OpenQualityObject_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenQualityObjectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpenQualityObjectMethod(cdo, OpenQualityObjectMethods.ExecuteTransaction, (OpenQualityObject_Parameters) null));
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
        OpenQualityObject_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OpenQualityObject) cdo, (OpenQualityObject_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OpenQualityObject cdo)
    {
      return this.ExecuteTransaction(cdo, (OpenQualityObject_Request) null, out OpenQualityObject_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OpenQualityObject_Request request,
      out OpenQualityObject_Result result)
    {
      return this.ExecuteTransaction((OpenQualityObject) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OpenQualityObject cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpenQualityObjectMethod(cdo, OpenQualityObjectMethods.AddDataTransaction, (OpenQualityObject_Parameters) null));
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
        return this.AddDataTransaction((OpenQualityObject) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
