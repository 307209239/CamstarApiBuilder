// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChgContainerAttributeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChgContainerAttributeService : ContainerTxnBase
  {
    public ChgContainerAttributeService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChgContainerAttributeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).CreateParametricData(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus CreateParametricData(ChgContainerAttribute chgContainerAttribute)
    {
      return this.CreateParametricData(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus CreateParametricData(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.CreateParametricData(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).GetActions(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetActions(ChgContainerAttribute chgContainerAttribute)
    {
      return this.GetActions(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetActions(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.GetActions(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).GetAttributes(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetAttributes(ChgContainerAttribute chgContainerAttribute)
    {
      return this.GetAttributes(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetAttributes(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.GetAttributes(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).GetDataPoints(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetDataPoints(ChgContainerAttribute chgContainerAttribute)
    {
      return this.GetDataPoints(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetDataPoints(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.GetDataPoints(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).GetWIPMsgs(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetWIPMsgs(ChgContainerAttribute chgContainerAttribute)
    {
      return this.GetWIPMsgs(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.GetWIPMsgs(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).Load(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus Load(ChgContainerAttribute chgContainerAttribute)
    {
      return this.Load(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus Load(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.Load(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_LoadESigDetails_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).LoadESigDetails(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.LoadESigDetails, (ChgContainerAttribute_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChgContainerAttribute) null, (ChgContainerAttribute_LoadESigDetails_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus LoadESigDetails(ChgContainerAttribute chgContainerAttribute)
    {
      return this.LoadESigDetails(chgContainerAttribute, (ChgContainerAttribute_LoadESigDetails_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.LoadESigDetails(chgContainerAttribute, (ChgContainerAttribute_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).ProcessComputation(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus ProcessComputation(ChgContainerAttribute chgContainerAttribute)
    {
      return this.ProcessComputation(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus ProcessComputation(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.ProcessComputation(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Parameters parameters,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).ResolveParametricData(this._UserProfile, chgContainerAttribute, parameters, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(chgContainerAttribute, ChgContainerAttributeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) chgContainerAttribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChgContainerAttribute) null, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChgContainerAttribute chgContainerAttribute)
    {
      return this.ResolveParametricData(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChgContainerAttribute chgContainerAttribute,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.ResolveParametricData(chgContainerAttribute, (ChgContainerAttribute_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus actions = this.GetActions((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_LoadESigDetails_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.Load((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject chgContainerAttribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChgContainerAttribute_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChgContainerAttribute) chgContainerAttribute, (ChgContainerAttribute_Parameters) parameters, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      try
      {
        ChgContainerAttributeMethod[] methods = new ChgContainerAttributeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChgContainerAttributeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChgContainerAttribute cdo,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      try
      {
        return ((IChgContainerAttributeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChgContainerAttribute_Result result1;
        ResultStatus environment = this.GetEnvironment((ChgContainerAttribute) cdo, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.GetEnvironment((ChgContainerAttribute) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChgContainerAttribute cdo,
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      result = (ChgContainerAttribute_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChgContainerAttributeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChgContainerAttributeMethod(cdo, ChgContainerAttributeMethods.ExecuteTransaction, (ChgContainerAttribute_Parameters) null));
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
        ChgContainerAttribute_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChgContainerAttribute) cdo, (ChgContainerAttribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChgContainerAttribute cdo)
    {
      return this.ExecuteTransaction(cdo, (ChgContainerAttribute_Request) null, out ChgContainerAttribute_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChgContainerAttribute_Request request,
      out ChgContainerAttribute_Result result)
    {
      return this.ExecuteTransaction((ChgContainerAttribute) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChgContainerAttribute cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChgContainerAttributeMethod(cdo, ChgContainerAttributeMethods.AddDataTransaction, (ChgContainerAttribute_Parameters) null));
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
        return this.AddDataTransaction((ChgContainerAttribute) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
