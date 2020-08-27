// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentIssueR2Service
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentIssueR2Service : ComponentIssueBase
  {
    public ComponentIssueR2Service(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentIssueR2Service), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).CreateParametricData(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus CreateParametricData(ComponentIssueR2 componentIssueR2)
    {
      return this.CreateParametricData(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.CreateParametricData(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).GetActions(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetActions(ComponentIssueR2 componentIssueR2)
    {
      return this.GetActions(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetActions(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.GetActions(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).GetDataPoints(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetDataPoints(ComponentIssueR2 componentIssueR2)
    {
      return this.GetDataPoints(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.GetDataPoints(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).GetWIPMsgs(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentIssueR2 componentIssueR2)
    {
      return this.GetWIPMsgs(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.GetWIPMsgs(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).Load(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus Load(ComponentIssueR2 componentIssueR2)
    {
      return this.Load(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus Load(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.Load(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_LoadESigDetails_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).LoadESigDetails(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.LoadESigDetails, (ComponentIssueR2_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentIssueR2) null, (ComponentIssueR2_LoadESigDetails_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentIssueR2 componentIssueR2)
    {
      return this.LoadESigDetails(componentIssueR2, (ComponentIssueR2_LoadESigDetails_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.LoadESigDetails(componentIssueR2, (ComponentIssueR2_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).ProcessComputation(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus ProcessComputation(ComponentIssueR2 componentIssueR2)
    {
      return this.ProcessComputation(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.ProcessComputation(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).ResolveParametricData(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentIssueR2 componentIssueR2)
    {
      return this.ResolveParametricData(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.ResolveParametricData(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    public ResultStatus SetMaterialListItemSettings(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Parameters parameters,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (SetMaterialListItemSettings), (DCObject) componentIssueR2, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).SetMaterialListItemSettings(this._UserProfile, componentIssueR2, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(componentIssueR2, ComponentIssueR2Methods.SetMaterialListItemSettings, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetMaterialListItemSettings), res, (DCObject) componentIssueR2, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetMaterialListItemSettings()
    {
      return this.SetMaterialListItemSettings((ComponentIssueR2) null, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus SetMaterialListItemSettings(ComponentIssueR2 componentIssueR2)
    {
      return this.SetMaterialListItemSettings(componentIssueR2, (ComponentIssueR2_Parameters) null, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus SetMaterialListItemSettings(
      ComponentIssueR2 componentIssueR2,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.SetMaterialListItemSettings(componentIssueR2, (ComponentIssueR2_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus actions = this.GetActions((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_LoadESigDetails_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.Load((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentIssueR2,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueR2_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentIssueR2) componentIssueR2, (ComponentIssueR2_Parameters) parameters, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      try
      {
        ComponentIssueR2Method[] methods = new ComponentIssueR2Method[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentIssueR2Service) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssueR2 cdo,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      try
      {
        return ((IComponentIssueR2Service) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentIssueR2_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentIssueR2) cdo, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.GetEnvironment((ComponentIssueR2) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssueR2 cdo,
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      result = (ComponentIssueR2_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueR2Service) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentIssueR2Method(cdo, ComponentIssueR2Methods.ExecuteTransaction, (ComponentIssueR2_Parameters) null));
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
        ComponentIssueR2_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentIssueR2) cdo, (ComponentIssueR2_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentIssueR2 cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentIssueR2_Request) null, out ComponentIssueR2_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssueR2_Request request,
      out ComponentIssueR2_Result result)
    {
      return this.ExecuteTransaction((ComponentIssueR2) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentIssueR2 cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentIssueR2Method(cdo, ComponentIssueR2Methods.AddDataTransaction, (ComponentIssueR2_Parameters) null));
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
        return this.AddDataTransaction((ComponentIssueR2) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
