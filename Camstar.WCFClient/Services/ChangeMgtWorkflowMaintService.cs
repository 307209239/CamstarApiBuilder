// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtWorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeMgtWorkflowMaintService : BusinessProcessWorkflowMaintBase
  {
    public ChangeMgtWorkflowMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeMgtWorkflowMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).Delete(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Delete(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.Delete(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Delete(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.Delete(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.DeleteAllRevisions(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.DeleteAllRevisions(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).Freeze(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Freeze(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.Freeze(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.Freeze(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.GetWIPMsgs(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.GetWIPMsgs(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).Load(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Load(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.Load(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus Load(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.Load(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_LoadESigDetails_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).LoadESigDetails(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.LoadESigDetails, (ChangeMgtWorkflowMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_LoadESigDetails_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.LoadESigDetails(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_LoadESigDetails_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.LoadESigDetails(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).New(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus New(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.New(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus New(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.New(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).NewCopy(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.NewCopy(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.NewCopy(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).NewRev(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewRev(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.NewRev(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewRev(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.NewRev(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).NewRevCopy(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.NewRevCopy(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.NewRevCopy(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).SaveAs(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.SaveAs(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.SaveAs(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).SaveAsRev(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.SaveAsRev(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.SaveAsRev(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Parameters parameters,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).UnFreeze(this._UserProfile, changeMgtWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(changeMgtWorkflowMaint, ChangeMgtWorkflowMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changeMgtWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangeMgtWorkflowMaint) null, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(ChangeMgtWorkflowMaint changeMgtWorkflowMaint)
    {
      return this.UnFreeze(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangeMgtWorkflowMaint changeMgtWorkflowMaint,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.UnFreeze(changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_LoadESigDetails_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeMgtWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeMgtWorkflowMaint) changeMgtWorkflowMaint, (ChangeMgtWorkflowMaint_Parameters) parameters, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      try
      {
        ChangeMgtWorkflowMaintMethod[] methods = new ChangeMgtWorkflowMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeMgtWorkflowMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtWorkflowMaint cdo,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      try
      {
        return ((IChangeMgtWorkflowMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeMgtWorkflowMaint) cdo, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.GetEnvironment((ChangeMgtWorkflowMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtWorkflowMaint cdo,
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      result = (ChangeMgtWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeMgtWorkflowMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(cdo, ChangeMgtWorkflowMaintMethods.ExecuteTransaction, (ChangeMgtWorkflowMaint_Parameters) null));
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
        ChangeMgtWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeMgtWorkflowMaint) cdo, (ChangeMgtWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeMgtWorkflowMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeMgtWorkflowMaint_Request) null, out ChangeMgtWorkflowMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeMgtWorkflowMaint_Request request,
      out ChangeMgtWorkflowMaint_Result result)
    {
      return this.ExecuteTransaction((ChangeMgtWorkflowMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeMgtWorkflowMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeMgtWorkflowMaintMethod(cdo, ChangeMgtWorkflowMaintMethods.AddDataTransaction, (ChangeMgtWorkflowMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangeMgtWorkflowMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
