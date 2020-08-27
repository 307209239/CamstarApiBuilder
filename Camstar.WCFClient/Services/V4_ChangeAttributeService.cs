// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_ChangeAttributeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_ChangeAttributeService : ContainerTxnBase
  {
    public V4_ChangeAttributeService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_ChangeAttributeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).CreateParametricData(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus CreateParametricData(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.CreateParametricData(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus CreateParametricData(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.CreateParametricData(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).GetActions(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetActions(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.GetActions(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetActions(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.GetActions(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).GetDataPoints(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetDataPoints(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.GetDataPoints(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetDataPoints(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.GetDataPoints(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).GetWIPMsgs(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetWIPMsgs(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.GetWIPMsgs(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.GetWIPMsgs(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).Load(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus Load(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.Load(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus Load(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.Load(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_LoadESigDetails_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).LoadESigDetails(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.LoadESigDetails, (V4_ChangeAttribute_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((V4_ChangeAttribute) null, (V4_ChangeAttribute_LoadESigDetails_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus LoadESigDetails(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.LoadESigDetails(v4_ChangeAttribute, (V4_ChangeAttribute_LoadESigDetails_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus LoadESigDetails(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.LoadESigDetails(v4_ChangeAttribute, (V4_ChangeAttribute_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).ProcessComputation(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus ProcessComputation(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.ProcessComputation(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus ProcessComputation(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.ProcessComputation(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Parameters parameters,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).ResolveParametricData(this._UserProfile, v4_ChangeAttribute, parameters, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(v4_ChangeAttribute, V4_ChangeAttributeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) v4_ChangeAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((V4_ChangeAttribute) null, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus ResolveParametricData(V4_ChangeAttribute v4_ChangeAttribute)
    {
      return this.ResolveParametricData(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus ResolveParametricData(
      V4_ChangeAttribute v4_ChangeAttribute,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.ResolveParametricData(v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus parametricData = this.CreateParametricData((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus actions = this.GetActions((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_LoadESigDetails_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.Load((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_ChangeAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_ChangeAttribute_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_ChangeAttribute) v4_ChangeAttribute, (V4_ChangeAttribute_Parameters) parameters, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      try
      {
        V4_ChangeAttributeMethod[] methods = new V4_ChangeAttributeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_ChangeAttributeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ChangeAttribute cdo,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      try
      {
        return ((IV4_ChangeAttributeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_ChangeAttribute_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_ChangeAttribute) cdo, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.GetEnvironment((V4_ChangeAttribute) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_ChangeAttribute cdo,
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      result = (V4_ChangeAttribute_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_ChangeAttributeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_ChangeAttributeMethod(cdo, V4_ChangeAttributeMethods.ExecuteTransaction, (V4_ChangeAttribute_Parameters) null));
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
        V4_ChangeAttribute_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_ChangeAttribute) cdo, (V4_ChangeAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_ChangeAttribute cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_ChangeAttribute_Request) null, out V4_ChangeAttribute_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_ChangeAttribute_Request request,
      out V4_ChangeAttribute_Result result)
    {
      return this.ExecuteTransaction((V4_ChangeAttribute) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_ChangeAttribute cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_ChangeAttributeMethod(cdo, V4_ChangeAttributeMethods.AddDataTransaction, (V4_ChangeAttribute_Parameters) null));
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
        return this.AddDataTransaction((V4_ChangeAttribute) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
