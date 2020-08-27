// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIPersonalizationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UIPersonalizationMaintService : SubentityMaintenanceBase
  {
    public UIPersonalizationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUIPersonalizationMaintService), userProfile);
    }

    public ResultStatus Delete(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).Delete(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Delete(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.Delete(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Delete(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.Delete(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).Freeze(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Freeze(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.Freeze(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Freeze(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.Freeze(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.GetWIPMsgs(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.GetWIPMsgs(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).Load(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Load(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.Load(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus Load(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.Load(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_LoadESigDetails_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).LoadESigDetails(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.LoadESigDetails, (UIPersonalizationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UIPersonalizationMaint) null, (UIPersonalizationMaint_LoadESigDetails_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.LoadESigDetails(uIPersonalizationMaint, (UIPersonalizationMaint_LoadESigDetails_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.LoadESigDetails(uIPersonalizationMaint, (UIPersonalizationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).New(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus New(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.New(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus New(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.New(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).NewCopy(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus NewCopy(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.NewCopy(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus NewCopy(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.NewCopy(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).SaveAs(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus SaveAs(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.SaveAs(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus SaveAs(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.SaveAs(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Parameters parameters,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).UnFreeze(this._UserProfile, uIPersonalizationMaint, parameters, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(uIPersonalizationMaint, UIPersonalizationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uIPersonalizationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UIPersonalizationMaint) null, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus UnFreeze(UIPersonalizationMaint uIPersonalizationMaint)
    {
      return this.UnFreeze(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UIPersonalizationMaint uIPersonalizationMaint,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.UnFreeze(uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_LoadESigDetails_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.New((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.Load((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uIPersonalizationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UIPersonalizationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UIPersonalizationMaint) uIPersonalizationMaint, (UIPersonalizationMaint_Parameters) parameters, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      try
      {
        UIPersonalizationMaintMethod[] methods = new UIPersonalizationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUIPersonalizationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPersonalizationMaint cdo,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      try
      {
        return ((IUIPersonalizationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UIPersonalizationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UIPersonalizationMaint) cdo, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.GetEnvironment((UIPersonalizationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UIPersonalizationMaint cdo,
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      result = (UIPersonalizationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUIPersonalizationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UIPersonalizationMaintMethod(cdo, UIPersonalizationMaintMethods.ExecuteTransaction, (UIPersonalizationMaint_Parameters) null));
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
        UIPersonalizationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UIPersonalizationMaint) cdo, (UIPersonalizationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UIPersonalizationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UIPersonalizationMaint_Request) null, out UIPersonalizationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UIPersonalizationMaint_Request request,
      out UIPersonalizationMaint_Result result)
    {
      return this.ExecuteTransaction((UIPersonalizationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UIPersonalizationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UIPersonalizationMaintMethod(cdo, UIPersonalizationMaintMethods.AddDataTransaction, (UIPersonalizationMaint_Parameters) null));
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
        return this.AddDataTransaction((UIPersonalizationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
