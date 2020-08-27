// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIPageFlowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIPageFlowMaintService : UIProviderComponentMaintBase
  {
    public UIPageFlowMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIPageFlowMaintService), userProfile);
    }

    public ResultStatus Delete(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).Delete(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Delete(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.Delete(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Delete(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.Delete(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).Freeze(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Freeze(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.Freeze(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Freeze(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.Freeze(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.GetWIPMsgs(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.GetWIPMsgs(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).Load(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Load(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.Load(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus Load(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.Load(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_LoadESigDetails_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).LoadESigDetails(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.LoadESigDetails, (UIPageFlowMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UIPageFlowMaint) null, (UIPageFlowMaint_LoadESigDetails_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.LoadESigDetails(uIPageFlowMaint, (UIPageFlowMaint_LoadESigDetails_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.LoadESigDetails(uIPageFlowMaint, (UIPageFlowMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).New(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus New(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.New(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus New(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.New(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).NewCopy(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus NewCopy(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.NewCopy(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus NewCopy(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.NewCopy(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).SaveAs(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus SaveAs(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.SaveAs(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus SaveAs(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.SaveAs(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Parameters parameters,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).UnFreeze(this._UserProfile, uIPageFlowMaint, parameters, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(uIPageFlowMaint, UIPageFlowMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uIPageFlowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UIPageFlowMaint) null, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus UnFreeze(UIPageFlowMaint uIPageFlowMaint)
    {
      return this.UnFreeze(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UIPageFlowMaint uIPageFlowMaint,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.UnFreeze(uIPageFlowMaint, (UIPageFlowMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_LoadESigDetails_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.New((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.Load((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIPageFlowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPageFlowMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIPageFlowMaint) uIPageFlowMaint, (UIPageFlowMaint_Parameters) parameters, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      try
      {
        UIPageFlowMaintMethod[] methods = new UIPageFlowMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIPageFlowMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPageFlowMaint cdo,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      try
      {
        return ((IUIPageFlowMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIPageFlowMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UIPageFlowMaint) cdo, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.GetEnvironment((UIPageFlowMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIPageFlowMaint cdo,
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      result = (UIPageFlowMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPageFlowMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIPageFlowMaintMethod(cdo, UIPageFlowMaintMethods.ExecuteTransaction, (UIPageFlowMaint_Parameters) null));
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
        UIPageFlowMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIPageFlowMaint) cdo, (UIPageFlowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIPageFlowMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UIPageFlowMaint_Request) null, out UIPageFlowMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIPageFlowMaint_Request request,
      out UIPageFlowMaint_Result result)
    {
      return this.ExecuteTransaction((UIPageFlowMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIPageFlowMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIPageFlowMaintMethod(cdo, UIPageFlowMaintMethods.AddDataTransaction, (UIPageFlowMaint_Parameters) null));
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
        return this.AddDataTransaction((UIPageFlowMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
