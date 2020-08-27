// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIVirtualPageMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIVirtualPageMaintService : UIProviderComponentMaintBase
  {
    public UIVirtualPageMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIVirtualPageMaintService), userProfile);
    }

    public ResultStatus Delete(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).Delete(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Delete(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.Delete(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Delete(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.Delete(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).Freeze(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Freeze(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.Freeze(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Freeze(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.Freeze(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.GetWIPMsgs(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.GetWIPMsgs(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).Load(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Load(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.Load(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus Load(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.Load(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_LoadESigDetails_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).LoadESigDetails(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.LoadESigDetails, (UIVirtualPageMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UIVirtualPageMaint) null, (UIVirtualPageMaint_LoadESigDetails_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.LoadESigDetails(uIVirtualPageMaint, (UIVirtualPageMaint_LoadESigDetails_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.LoadESigDetails(uIVirtualPageMaint, (UIVirtualPageMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).New(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus New(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.New(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus New(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.New(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).NewCopy(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus NewCopy(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.NewCopy(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus NewCopy(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.NewCopy(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).SaveAs(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus SaveAs(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.SaveAs(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus SaveAs(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.SaveAs(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Parameters parameters,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).UnFreeze(this._UserProfile, uIVirtualPageMaint, parameters, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(uIVirtualPageMaint, UIVirtualPageMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uIVirtualPageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UIVirtualPageMaint) null, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus UnFreeze(UIVirtualPageMaint uIVirtualPageMaint)
    {
      return this.UnFreeze(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UIVirtualPageMaint uIVirtualPageMaint,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.UnFreeze(uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_LoadESigDetails_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.New((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.Load((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIVirtualPageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIVirtualPageMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIVirtualPageMaint) uIVirtualPageMaint, (UIVirtualPageMaint_Parameters) parameters, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      try
      {
        UIVirtualPageMaintMethod[] methods = new UIVirtualPageMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIVirtualPageMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIVirtualPageMaint cdo,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      try
      {
        return ((IUIVirtualPageMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIVirtualPageMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UIVirtualPageMaint) cdo, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.GetEnvironment((UIVirtualPageMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIVirtualPageMaint cdo,
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      result = (UIVirtualPageMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIVirtualPageMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIVirtualPageMaintMethod(cdo, UIVirtualPageMaintMethods.ExecuteTransaction, (UIVirtualPageMaint_Parameters) null));
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
        UIVirtualPageMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIVirtualPageMaint) cdo, (UIVirtualPageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIVirtualPageMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UIVirtualPageMaint_Request) null, out UIVirtualPageMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIVirtualPageMaint_Request request,
      out UIVirtualPageMaint_Result result)
    {
      return this.ExecuteTransaction((UIVirtualPageMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIVirtualPageMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIVirtualPageMaintMethod(cdo, UIVirtualPageMaintMethods.AddDataTransaction, (UIVirtualPageMaint_Parameters) null));
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
        return this.AddDataTransaction((UIVirtualPageMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
