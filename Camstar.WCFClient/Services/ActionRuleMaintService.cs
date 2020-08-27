// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActionRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActionRuleMaintService : NamedDataObjectMaintBase
  {
    public ActionRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActionRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).Delete(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Delete(ActionRuleMaint actionRuleMaint)
    {
      return this.Delete(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Delete(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.Delete(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).Freeze(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Freeze(ActionRuleMaint actionRuleMaint)
    {
      return this.Freeze(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.Freeze(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActionRuleMaint actionRuleMaint)
    {
      return this.GetWIPMsgs(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.GetWIPMsgs(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).Load(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Load(ActionRuleMaint actionRuleMaint)
    {
      return this.Load(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus Load(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.Load(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_LoadESigDetails_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.LoadESigDetails, (ActionRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActionRuleMaint) null, (ActionRuleMaint_LoadESigDetails_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActionRuleMaint actionRuleMaint)
    {
      return this.LoadESigDetails(actionRuleMaint, (ActionRuleMaint_LoadESigDetails_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.LoadESigDetails(actionRuleMaint, (ActionRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).New(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus New(ActionRuleMaint actionRuleMaint)
    {
      return this.New(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus New(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.New(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).NewCopy(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus NewCopy(ActionRuleMaint actionRuleMaint)
    {
      return this.NewCopy(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.NewCopy(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).SaveAs(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus SaveAs(ActionRuleMaint actionRuleMaint)
    {
      return this.SaveAs(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.SaveAs(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Parameters parameters,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).UnFreeze(this._UserProfile, actionRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(actionRuleMaint, ActionRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) actionRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActionRuleMaint) null, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(ActionRuleMaint actionRuleMaint)
    {
      return this.UnFreeze(actionRuleMaint, (ActionRuleMaint_Parameters) null, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActionRuleMaint actionRuleMaint,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.UnFreeze(actionRuleMaint, (ActionRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_LoadESigDetails_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject actionRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActionRuleMaint) actionRuleMaint, (ActionRuleMaint_Parameters) parameters, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      try
      {
        ActionRuleMaintMethod[] methods = new ActionRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActionRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionRuleMaint cdo,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      try
      {
        return ((IActionRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActionRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActionRuleMaint) cdo, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.GetEnvironment((ActionRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActionRuleMaint cdo,
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      result = (ActionRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActionRuleMaintMethod(cdo, ActionRuleMaintMethods.ExecuteTransaction, (ActionRuleMaint_Parameters) null));
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
        ActionRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActionRuleMaint) cdo, (ActionRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActionRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActionRuleMaint_Request) null, out ActionRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActionRuleMaint_Request request,
      out ActionRuleMaint_Result result)
    {
      return this.ExecuteTransaction((ActionRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActionRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActionRuleMaintMethod(cdo, ActionRuleMaintMethods.AddDataTransaction, (ActionRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((ActionRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
