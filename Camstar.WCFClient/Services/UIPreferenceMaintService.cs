// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIPreferenceMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIPreferenceMaintService : NamedDataObjectMaintBase
  {
    public UIPreferenceMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIPreferenceMaintService), userProfile);
    }

    public ResultStatus Delete(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).Delete(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Delete(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.Delete(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Delete(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.Delete(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).Freeze(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Freeze(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.Freeze(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Freeze(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.Freeze(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.GetWIPMsgs(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.GetWIPMsgs(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).Load(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Load(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.Load(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus Load(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.Load(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_LoadESigDetails_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).LoadESigDetails(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.LoadESigDetails, (UIPreferenceMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UIPreferenceMaint) null, (UIPreferenceMaint_LoadESigDetails_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.LoadESigDetails(uIPreferenceMaint, (UIPreferenceMaint_LoadESigDetails_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.LoadESigDetails(uIPreferenceMaint, (UIPreferenceMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).New(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus New(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.New(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus New(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.New(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).NewCopy(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus NewCopy(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.NewCopy(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus NewCopy(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.NewCopy(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).SaveAs(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus SaveAs(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.SaveAs(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus SaveAs(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.SaveAs(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Parameters parameters,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).UnFreeze(this._UserProfile, uIPreferenceMaint, parameters, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(uIPreferenceMaint, UIPreferenceMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uIPreferenceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UIPreferenceMaint) null, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus UnFreeze(UIPreferenceMaint uIPreferenceMaint)
    {
      return this.UnFreeze(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UIPreferenceMaint uIPreferenceMaint,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.UnFreeze(uIPreferenceMaint, (UIPreferenceMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_LoadESigDetails_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.New((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.Load((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIPreferenceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPreferenceMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIPreferenceMaint) uIPreferenceMaint, (UIPreferenceMaint_Parameters) parameters, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      try
      {
        UIPreferenceMaintMethod[] methods = new UIPreferenceMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIPreferenceMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPreferenceMaint cdo,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      try
      {
        return ((IUIPreferenceMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIPreferenceMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UIPreferenceMaint) cdo, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.GetEnvironment((UIPreferenceMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIPreferenceMaint cdo,
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      result = (UIPreferenceMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPreferenceMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIPreferenceMaintMethod(cdo, UIPreferenceMaintMethods.ExecuteTransaction, (UIPreferenceMaint_Parameters) null));
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
        UIPreferenceMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIPreferenceMaint) cdo, (UIPreferenceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIPreferenceMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UIPreferenceMaint_Request) null, out UIPreferenceMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIPreferenceMaint_Request request,
      out UIPreferenceMaint_Result result)
    {
      return this.ExecuteTransaction((UIPreferenceMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIPreferenceMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIPreferenceMaintMethod(cdo, UIPreferenceMaintMethods.AddDataTransaction, (UIPreferenceMaint_Parameters) null));
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
        return this.AddDataTransaction((UIPreferenceMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
