// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIProviderComponentMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIProviderComponentMaintService : NamedDataObjectMaintBase
  {
    public UIProviderComponentMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIProviderComponentMaintService), userProfile);
    }

    public ResultStatus Delete(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).Delete(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Delete(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.Delete(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Delete(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.Delete(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).Freeze(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Freeze(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.Freeze(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Freeze(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.Freeze(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.GetWIPMsgs(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.GetWIPMsgs(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).Load(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Load(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.Load(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus Load(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.Load(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_LoadESigDetails_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).LoadESigDetails(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.LoadESigDetails, (UIProviderComponentMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UIProviderComponentMaint) null, (UIProviderComponentMaint_LoadESigDetails_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.LoadESigDetails(uIProviderComponentMaint, (UIProviderComponentMaint_LoadESigDetails_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.LoadESigDetails(uIProviderComponentMaint, (UIProviderComponentMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).New(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus New(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.New(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus New(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.New(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).NewCopy(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus NewCopy(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.NewCopy(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus NewCopy(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.NewCopy(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).SaveAs(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus SaveAs(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.SaveAs(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus SaveAs(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.SaveAs(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Parameters parameters,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).UnFreeze(this._UserProfile, uIProviderComponentMaint, parameters, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(uIProviderComponentMaint, UIProviderComponentMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uIProviderComponentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UIProviderComponentMaint) null, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus UnFreeze(UIProviderComponentMaint uIProviderComponentMaint)
    {
      return this.UnFreeze(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UIProviderComponentMaint uIProviderComponentMaint,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.UnFreeze(uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_LoadESigDetails_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.New((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.Load((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIProviderComponentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIProviderComponentMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIProviderComponentMaint) uIProviderComponentMaint, (UIProviderComponentMaint_Parameters) parameters, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      try
      {
        UIProviderComponentMaintMethod[] methods = new UIProviderComponentMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIProviderComponentMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIProviderComponentMaint cdo,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      try
      {
        return ((IUIProviderComponentMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIProviderComponentMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UIProviderComponentMaint) cdo, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.GetEnvironment((UIProviderComponentMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIProviderComponentMaint cdo,
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      result = (UIProviderComponentMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIProviderComponentMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIProviderComponentMaintMethod(cdo, UIProviderComponentMaintMethods.ExecuteTransaction, (UIProviderComponentMaint_Parameters) null));
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
        UIProviderComponentMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIProviderComponentMaint) cdo, (UIProviderComponentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIProviderComponentMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UIProviderComponentMaint_Request) null, out UIProviderComponentMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIProviderComponentMaint_Request request,
      out UIProviderComponentMaint_Result result)
    {
      return this.ExecuteTransaction((UIProviderComponentMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIProviderComponentMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIProviderComponentMaintMethod(cdo, UIProviderComponentMaintMethods.AddDataTransaction, (UIProviderComponentMaint_Parameters) null));
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
        return this.AddDataTransaction((UIProviderComponentMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
