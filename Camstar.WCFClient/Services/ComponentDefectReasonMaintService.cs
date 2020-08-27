// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentDefectReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentDefectReasonMaintService : UserCodeMaintBase
  {
    public ComponentDefectReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentDefectReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).Delete(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.Delete(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.Delete(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).Freeze(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.Freeze(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.Freeze(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.GetWIPMsgs(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.GetWIPMsgs(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).Load(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Load(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.Load(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus Load(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.Load(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_LoadESigDetails_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.LoadESigDetails, (ComponentDefectReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_LoadESigDetails_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.LoadESigDetails(componentDefectReasonMaint, (ComponentDefectReasonMaint_LoadESigDetails_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.LoadESigDetails(componentDefectReasonMaint, (ComponentDefectReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).New(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus New(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.New(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus New(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.New(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).NewCopy(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.NewCopy(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.NewCopy(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).SaveAs(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.SaveAs(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.SaveAs(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Parameters parameters,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).UnFreeze(this._UserProfile, componentDefectReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(componentDefectReasonMaint, ComponentDefectReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) componentDefectReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ComponentDefectReasonMaint) null, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ComponentDefectReasonMaint componentDefectReasonMaint)
    {
      return this.UnFreeze(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ComponentDefectReasonMaint componentDefectReasonMaint,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.UnFreeze(componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_LoadESigDetails_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentDefectReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefectReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentDefectReasonMaint) componentDefectReasonMaint, (ComponentDefectReasonMaint_Parameters) parameters, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      try
      {
        ComponentDefectReasonMaintMethod[] methods = new ComponentDefectReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentDefectReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDefectReasonMaint cdo,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      try
      {
        return ((IComponentDefectReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentDefectReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentDefectReasonMaint) cdo, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.GetEnvironment((ComponentDefectReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDefectReasonMaint cdo,
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      result = (ComponentDefectReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(cdo, ComponentDefectReasonMaintMethods.ExecuteTransaction, (ComponentDefectReasonMaint_Parameters) null));
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
        ComponentDefectReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentDefectReasonMaint) cdo, (ComponentDefectReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentDefectReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentDefectReasonMaint_Request) null, out ComponentDefectReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDefectReasonMaint_Request request,
      out ComponentDefectReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ComponentDefectReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentDefectReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentDefectReasonMaintMethod(cdo, ComponentDefectReasonMaintMethods.AddDataTransaction, (ComponentDefectReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ComponentDefectReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
