// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SetupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SetupMaintService : RevisionedObjectMaintBase
  {
    public SetupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISetupMaintService), userProfile);
    }

    public ResultStatus Delete(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).Delete(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Delete(SetupMaint setupMaint)
    {
      return this.Delete(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Delete(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.Delete(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SetupMaint setupMaint)
    {
      return this.DeleteAllRevisions(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.DeleteAllRevisions(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).Freeze(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Freeze(SetupMaint setupMaint)
    {
      return this.Freeze(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Freeze(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.Freeze(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SetupMaint setupMaint)
    {
      return this.GetWIPMsgs(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.GetWIPMsgs(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).Load(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Load(SetupMaint setupMaint)
    {
      return this.Load(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus Load(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.Load(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SetupMaint setupMaint,
      SetupMaint_LoadESigDetails_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).LoadESigDetails(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.LoadESigDetails, (SetupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SetupMaint) null, (SetupMaint_LoadESigDetails_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SetupMaint setupMaint)
    {
      return this.LoadESigDetails(setupMaint, (SetupMaint_LoadESigDetails_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.LoadESigDetails(setupMaint, (SetupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).New(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus New(SetupMaint setupMaint)
    {
      return this.New(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus New(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.New(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).NewCopy(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewCopy(SetupMaint setupMaint)
    {
      return this.NewCopy(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewCopy(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.NewCopy(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).NewRev(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewRev(SetupMaint setupMaint)
    {
      return this.NewRev(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewRev(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.NewRev(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).NewRevCopy(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewRevCopy(SetupMaint setupMaint)
    {
      return this.NewRevCopy(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.NewRevCopy(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).SaveAs(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus SaveAs(SetupMaint setupMaint)
    {
      return this.SaveAs(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus SaveAs(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.SaveAs(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).SaveAsRev(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus SaveAsRev(SetupMaint setupMaint)
    {
      return this.SaveAsRev(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.SaveAsRev(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SetupMaint setupMaint,
      SetupMaint_Parameters parameters,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) setupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).UnFreeze(this._UserProfile, setupMaint, parameters, request, out result) : this.AddMethod((Method) new SetupMaintMethod(setupMaint, SetupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) setupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SetupMaint) null, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus UnFreeze(SetupMaint setupMaint)
    {
      return this.UnFreeze(setupMaint, (SetupMaint_Parameters) null, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SetupMaint setupMaint,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.UnFreeze(setupMaint, (SetupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SetupMaint) setupMaint, (SetupMaint_LoadESigDetails_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.New((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.Load((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject setupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SetupMaint) setupMaint, (SetupMaint_Parameters) parameters, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      try
      {
        SetupMaintMethod[] methods = new SetupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISetupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SetupMaint cdo,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      try
      {
        return ((ISetupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SetupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SetupMaint) cdo, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.GetEnvironment((SetupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SetupMaint cdo,
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      result = (SetupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SetupMaintMethod(cdo, SetupMaintMethods.ExecuteTransaction, (SetupMaint_Parameters) null));
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
        SetupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SetupMaint) cdo, (SetupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SetupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SetupMaint_Request) null, out SetupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SetupMaint_Request request,
      out SetupMaint_Result result)
    {
      return this.ExecuteTransaction((SetupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SetupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SetupMaintMethod(cdo, SetupMaintMethods.AddDataTransaction, (SetupMaint_Parameters) null));
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
        return this.AddDataTransaction((SetupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
