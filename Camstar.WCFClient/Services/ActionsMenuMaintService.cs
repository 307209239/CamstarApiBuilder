// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActionsMenuMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActionsMenuMaintService : NamedDataObjectMaintBase
  {
    public ActionsMenuMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActionsMenuMaintService), userProfile);
    }

    public ResultStatus Delete(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).Delete(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Delete(ActionsMenuMaint actionsMenuMaint)
    {
      return this.Delete(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Delete(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.Delete(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).Freeze(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Freeze(ActionsMenuMaint actionsMenuMaint)
    {
      return this.Freeze(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Freeze(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.Freeze(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).GetWIPMsgs(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ActionsMenuMaint actionsMenuMaint)
    {
      return this.GetWIPMsgs(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.GetWIPMsgs(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).Load(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Load(ActionsMenuMaint actionsMenuMaint)
    {
      return this.Load(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus Load(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.Load(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_LoadESigDetails_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).LoadESigDetails(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.LoadESigDetails, (ActionsMenuMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ActionsMenuMaint) null, (ActionsMenuMaint_LoadESigDetails_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ActionsMenuMaint actionsMenuMaint)
    {
      return this.LoadESigDetails(actionsMenuMaint, (ActionsMenuMaint_LoadESigDetails_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.LoadESigDetails(actionsMenuMaint, (ActionsMenuMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).New(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus New(ActionsMenuMaint actionsMenuMaint)
    {
      return this.New(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus New(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.New(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).NewCopy(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus NewCopy(ActionsMenuMaint actionsMenuMaint)
    {
      return this.NewCopy(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus NewCopy(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.NewCopy(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).SaveAs(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus SaveAs(ActionsMenuMaint actionsMenuMaint)
    {
      return this.SaveAs(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus SaveAs(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.SaveAs(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Parameters parameters,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).UnFreeze(this._UserProfile, actionsMenuMaint, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(actionsMenuMaint, ActionsMenuMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) actionsMenuMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ActionsMenuMaint) null, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus UnFreeze(ActionsMenuMaint actionsMenuMaint)
    {
      return this.UnFreeze(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ActionsMenuMaint actionsMenuMaint,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.UnFreeze(actionsMenuMaint, (ActionsMenuMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_LoadESigDetails_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.New((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.Load((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject actionsMenuMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActionsMenuMaint) actionsMenuMaint, (ActionsMenuMaint_Parameters) parameters, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      try
      {
        ActionsMenuMaintMethod[] methods = new ActionsMenuMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActionsMenuMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionsMenuMaint cdo,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      try
      {
        return ((IActionsMenuMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActionsMenuMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ActionsMenuMaint) cdo, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.GetEnvironment((ActionsMenuMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActionsMenuMaint cdo,
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      result = (ActionsMenuMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActionsMenuMaintMethod(cdo, ActionsMenuMaintMethods.ExecuteTransaction, (ActionsMenuMaint_Parameters) null));
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
        ActionsMenuMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActionsMenuMaint) cdo, (ActionsMenuMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActionsMenuMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ActionsMenuMaint_Request) null, out ActionsMenuMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActionsMenuMaint_Request request,
      out ActionsMenuMaint_Result result)
    {
      return this.ExecuteTransaction((ActionsMenuMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActionsMenuMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActionsMenuMaintMethod(cdo, ActionsMenuMaintMethods.AddDataTransaction, (ActionsMenuMaint_Parameters) null));
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
        return this.AddDataTransaction((ActionsMenuMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
