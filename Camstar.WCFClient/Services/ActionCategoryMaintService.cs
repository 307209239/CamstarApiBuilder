// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActionCategoryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActionCategoryMaintService : NamedDataObjectMaintBase
  {
    public ActionCategoryMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActionCategoryMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).Delete(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Delete(ActionCategoryMaint actionCategoryMaint)
    {
      return this.Delete(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Delete(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.Delete(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).Freeze(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Freeze(ActionCategoryMaint actionCategoryMaint)
    {
      return this.Freeze(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Freeze(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.Freeze(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).GetWIPMsgs(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActionCategoryMaint actionCategoryMaint)
    {
      return this.GetWIPMsgs(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.GetWIPMsgs(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).Load(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Load(ActionCategoryMaint actionCategoryMaint)
    {
      return this.Load(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus Load(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.Load(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_LoadESigDetails_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).LoadESigDetails(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.LoadESigDetails, (ActionCategoryMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActionCategoryMaint) null, (ActionCategoryMaint_LoadESigDetails_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActionCategoryMaint actionCategoryMaint)
    {
      return this.LoadESigDetails(actionCategoryMaint, (ActionCategoryMaint_LoadESigDetails_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.LoadESigDetails(actionCategoryMaint, (ActionCategoryMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).New(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus New(ActionCategoryMaint actionCategoryMaint)
    {
      return this.New(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus New(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.New(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).NewCopy(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus NewCopy(ActionCategoryMaint actionCategoryMaint)
    {
      return this.NewCopy(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.NewCopy(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).SaveAs(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus SaveAs(ActionCategoryMaint actionCategoryMaint)
    {
      return this.SaveAs(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.SaveAs(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Parameters parameters,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).UnFreeze(this._UserProfile, actionCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(actionCategoryMaint, ActionCategoryMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) actionCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActionCategoryMaint) null, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus UnFreeze(ActionCategoryMaint actionCategoryMaint)
    {
      return this.UnFreeze(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActionCategoryMaint actionCategoryMaint,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.UnFreeze(actionCategoryMaint, (ActionCategoryMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_LoadESigDetails_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.New((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject actionCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionCategoryMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActionCategoryMaint) actionCategoryMaint, (ActionCategoryMaint_Parameters) parameters, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      try
      {
        ActionCategoryMaintMethod[] methods = new ActionCategoryMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActionCategoryMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionCategoryMaint cdo,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      try
      {
        return ((IActionCategoryMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActionCategoryMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActionCategoryMaint) cdo, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.GetEnvironment((ActionCategoryMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActionCategoryMaint cdo,
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      result = (ActionCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionCategoryMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActionCategoryMaintMethod(cdo, ActionCategoryMaintMethods.ExecuteTransaction, (ActionCategoryMaint_Parameters) null));
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
        ActionCategoryMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActionCategoryMaint) cdo, (ActionCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActionCategoryMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActionCategoryMaint_Request) null, out ActionCategoryMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActionCategoryMaint_Request request,
      out ActionCategoryMaint_Result result)
    {
      return this.ExecuteTransaction((ActionCategoryMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActionCategoryMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActionCategoryMaintMethod(cdo, ActionCategoryMaintMethods.AddDataTransaction, (ActionCategoryMaint_Parameters) null));
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
        return this.AddDataTransaction((ActionCategoryMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
