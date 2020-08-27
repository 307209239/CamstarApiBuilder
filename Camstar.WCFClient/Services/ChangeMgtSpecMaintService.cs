// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeMgtSpecMaintService : BusinessProcessSpecMaintBase
  {
    public ChangeMgtSpecMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeMgtSpecMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).Delete(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Delete(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.Delete(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Delete(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.Delete(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.DeleteAllRevisions(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.DeleteAllRevisions(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).Freeze(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Freeze(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.Freeze(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.Freeze(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.GetWIPMsgs(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.GetWIPMsgs(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).Load(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Load(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.Load(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus Load(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.Load(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).LoadESigDetails(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.LoadESigDetails, (ChangeMgtSpecMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_LoadESigDetails_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.LoadESigDetails(changeMgtSpecMaint, (ChangeMgtSpecMaint_LoadESigDetails_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.LoadESigDetails(changeMgtSpecMaint, (ChangeMgtSpecMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).New(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus New(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.New(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus New(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.New(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).NewCopy(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewCopy(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.NewCopy(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.NewCopy(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).NewRev(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewRev(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.NewRev(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewRev(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.NewRev(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).NewRevCopy(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.NewRevCopy(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.NewRevCopy(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).SaveAs(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus SaveAs(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.SaveAs(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.SaveAs(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).SaveAsRev(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.SaveAsRev(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.SaveAsRev(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Parameters parameters,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).UnFreeze(this._UserProfile, changeMgtSpecMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(changeMgtSpecMaint, ChangeMgtSpecMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changeMgtSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangeMgtSpecMaint) null, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(ChangeMgtSpecMaint changeMgtSpecMaint)
    {
      return this.UnFreeze(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangeMgtSpecMaint changeMgtSpecMaint,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.UnFreeze(changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_LoadESigDetails_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeMgtSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtSpecMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeMgtSpecMaint) changeMgtSpecMaint, (ChangeMgtSpecMaint_Parameters) parameters, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      try
      {
        ChangeMgtSpecMaintMethod[] methods = new ChangeMgtSpecMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeMgtSpecMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtSpecMaint cdo,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      try
      {
        return ((IChangeMgtSpecMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeMgtSpecMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeMgtSpecMaint) cdo, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.GetEnvironment((ChangeMgtSpecMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtSpecMaint cdo,
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      result = (ChangeMgtSpecMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtSpecMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(cdo, ChangeMgtSpecMaintMethods.ExecuteTransaction, (ChangeMgtSpecMaint_Parameters) null));
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
        ChangeMgtSpecMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeMgtSpecMaint) cdo, (ChangeMgtSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeMgtSpecMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeMgtSpecMaint_Request) null, out ChangeMgtSpecMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtSpecMaint_Request request,
      out ChangeMgtSpecMaint_Result result)
    {
      return this.ExecuteTransaction((ChangeMgtSpecMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeMgtSpecMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeMgtSpecMaintMethod(cdo, ChangeMgtSpecMaintMethods.AddDataTransaction, (ChangeMgtSpecMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangeMgtSpecMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
