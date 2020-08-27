// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AddSPCAnnotationService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AddSPCAnnotationService : SPCTxnBase
  {
    public AddSPCAnnotationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAddSPCAnnotationService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).CreateParametricData(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus CreateParametricData(AddSPCAnnotation addSPCAnnotation)
    {
      return this.CreateParametricData(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus CreateParametricData(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.CreateParametricData(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).GetActions(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetActions(AddSPCAnnotation addSPCAnnotation)
    {
      return this.GetActions(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetActions(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.GetActions(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).GetDataPoints(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetDataPoints(AddSPCAnnotation addSPCAnnotation)
    {
      return this.GetDataPoints(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetDataPoints(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.GetDataPoints(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).GetWIPMsgs(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetWIPMsgs(AddSPCAnnotation addSPCAnnotation)
    {
      return this.GetWIPMsgs(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.GetWIPMsgs(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).Load(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus Load(AddSPCAnnotation addSPCAnnotation)
    {
      return this.Load(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus Load(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.Load(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_LoadESigDetails_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).LoadESigDetails(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.LoadESigDetails, (AddSPCAnnotation_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AddSPCAnnotation) null, (AddSPCAnnotation_LoadESigDetails_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus LoadESigDetails(AddSPCAnnotation addSPCAnnotation)
    {
      return this.LoadESigDetails(addSPCAnnotation, (AddSPCAnnotation_LoadESigDetails_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus LoadESigDetails(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.LoadESigDetails(addSPCAnnotation, (AddSPCAnnotation_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).ProcessComputation(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus ProcessComputation(AddSPCAnnotation addSPCAnnotation)
    {
      return this.ProcessComputation(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus ProcessComputation(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.ProcessComputation(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Parameters parameters,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).ResolveParametricData(this._UserProfile, addSPCAnnotation, parameters, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(addSPCAnnotation, AddSPCAnnotationMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) addSPCAnnotation, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AddSPCAnnotation) null, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus ResolveParametricData(AddSPCAnnotation addSPCAnnotation)
    {
      return this.ResolveParametricData(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus ResolveParametricData(
      AddSPCAnnotation addSPCAnnotation,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.ResolveParametricData(addSPCAnnotation, (AddSPCAnnotation_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus actions = this.GetActions((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_LoadESigDetails_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.Load((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject addSPCAnnotation,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AddSPCAnnotation_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AddSPCAnnotation) addSPCAnnotation, (AddSPCAnnotation_Parameters) parameters, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      try
      {
        AddSPCAnnotationMethod[] methods = new AddSPCAnnotationMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAddSPCAnnotationService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AddSPCAnnotation cdo,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      try
      {
        return ((IAddSPCAnnotationService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AddSPCAnnotation_Result result1;
        ResultStatus environment = this.GetEnvironment((AddSPCAnnotation) cdo, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.GetEnvironment((AddSPCAnnotation) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AddSPCAnnotation cdo,
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      result = (AddSPCAnnotation_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAddSPCAnnotationService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AddSPCAnnotationMethod(cdo, AddSPCAnnotationMethods.ExecuteTransaction, (AddSPCAnnotation_Parameters) null));
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
        AddSPCAnnotation_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AddSPCAnnotation) cdo, (AddSPCAnnotation_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AddSPCAnnotation cdo)
    {
      return this.ExecuteTransaction(cdo, (AddSPCAnnotation_Request) null, out AddSPCAnnotation_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AddSPCAnnotation_Request request,
      out AddSPCAnnotation_Result result)
    {
      return this.ExecuteTransaction((AddSPCAnnotation) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AddSPCAnnotation cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AddSPCAnnotationMethod(cdo, AddSPCAnnotationMethods.AddDataTransaction, (AddSPCAnnotation_Parameters) null));
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
        return this.AddDataTransaction((AddSPCAnnotation) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
