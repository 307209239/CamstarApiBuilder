// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActionMaintService : NamedDataObjectMaintBase
  {
    public ActionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActionMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).Delete(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Delete(ActionMaint actionMaint)
    {
      return this.Delete(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Delete(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.Delete(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).Freeze(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Freeze(ActionMaint actionMaint)
    {
      return this.Freeze(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Freeze(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.Freeze(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActionMaint actionMaint)
    {
      return this.GetWIPMsgs(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.GetWIPMsgs(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).Load(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Load(ActionMaint actionMaint)
    {
      return this.Load(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus Load(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.Load(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActionMaint actionMaint,
      ActionMaint_LoadESigDetails_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).LoadESigDetails(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.LoadESigDetails, (ActionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActionMaint) null, (ActionMaint_LoadESigDetails_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActionMaint actionMaint)
    {
      return this.LoadESigDetails(actionMaint, (ActionMaint_LoadESigDetails_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.LoadESigDetails(actionMaint, (ActionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).New(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus New(ActionMaint actionMaint)
    {
      return this.New(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus New(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.New(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).NewCopy(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus NewCopy(ActionMaint actionMaint)
    {
      return this.NewCopy(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.NewCopy(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).SaveAs(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus SaveAs(ActionMaint actionMaint)
    {
      return this.SaveAs(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.SaveAs(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActionMaint actionMaint,
      ActionMaint_Parameters parameters,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) actionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).UnFreeze(this._UserProfile, actionMaint, parameters, request, out result) : this.AddMethod((Method) new ActionMaintMethod(actionMaint, ActionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) actionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActionMaint) null, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus UnFreeze(ActionMaint actionMaint)
    {
      return this.UnFreeze(actionMaint, (ActionMaint_Parameters) null, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActionMaint actionMaint,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.UnFreeze(actionMaint, (ActionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActionMaint) actionMaint, (ActionMaint_LoadESigDetails_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.New((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject actionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActionMaint) actionMaint, (ActionMaint_Parameters) parameters, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      try
      {
        ActionMaintMethod[] methods = new ActionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionMaint cdo,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      try
      {
        return ((IActionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActionMaint) cdo, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.GetEnvironment((ActionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActionMaint cdo,
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      result = (ActionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActionMaintMethod(cdo, ActionMaintMethods.ExecuteTransaction, (ActionMaint_Parameters) null));
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
        ActionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActionMaint) cdo, (ActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActionMaint_Request) null, out ActionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActionMaint_Request request,
      out ActionMaint_Result result)
    {
      return this.ExecuteTransaction((ActionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActionMaintMethod(cdo, ActionMaintMethods.AddDataTransaction, (ActionMaint_Parameters) null));
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
        return this.AddDataTransaction((ActionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
