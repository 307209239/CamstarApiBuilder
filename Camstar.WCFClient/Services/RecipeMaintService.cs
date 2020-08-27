// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecipeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecipeMaintService : DocumentMaintBase
  {
    public RecipeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecipeMaintService), userProfile);
    }

    public ResultStatus Delete(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).Delete(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Delete(RecipeMaint recipeMaint)
    {
      return this.Delete(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Delete(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.Delete(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(RecipeMaint recipeMaint)
    {
      return this.DeleteAllRevisions(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.DeleteAllRevisions(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus DownloadFile(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (DownloadFile), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).DownloadFile(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.DownloadFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DownloadFile), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DownloadFile()
    {
      return this.DownloadFile((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus DownloadFile(RecipeMaint recipeMaint)
    {
      return this.DownloadFile(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus DownloadFile(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.DownloadFile(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).Freeze(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Freeze(RecipeMaint recipeMaint)
    {
      return this.Freeze(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Freeze(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.Freeze(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RecipeMaint recipeMaint)
    {
      return this.GetWIPMsgs(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.GetWIPMsgs(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).Load(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Load(RecipeMaint recipeMaint)
    {
      return this.Load(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus Load(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.Load(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecipeMaint recipeMaint,
      RecipeMaint_LoadESigDetails_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).LoadESigDetails(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.LoadESigDetails, (RecipeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecipeMaint) null, (RecipeMaint_LoadESigDetails_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RecipeMaint recipeMaint)
    {
      return this.LoadESigDetails(recipeMaint, (RecipeMaint_LoadESigDetails_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.LoadESigDetails(recipeMaint, (RecipeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).New(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus New(RecipeMaint recipeMaint)
    {
      return this.New(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus New(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.New(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).NewCopy(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewCopy(RecipeMaint recipeMaint)
    {
      return this.NewCopy(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewCopy(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.NewCopy(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).NewRev(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewRev(RecipeMaint recipeMaint)
    {
      return this.NewRev(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewRev(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.NewRev(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).NewRevCopy(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewRevCopy(RecipeMaint recipeMaint)
    {
      return this.NewRevCopy(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.NewRevCopy(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).SaveAs(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus SaveAs(RecipeMaint recipeMaint)
    {
      return this.SaveAs(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus SaveAs(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.SaveAs(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).SaveAsRev(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus SaveAsRev(RecipeMaint recipeMaint)
    {
      return this.SaveAsRev(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.SaveAsRev(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) recipeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).UnFreeze(this._UserProfile, recipeMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(recipeMaint, RecipeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) recipeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RecipeMaint) null, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus UnFreeze(RecipeMaint recipeMaint)
    {
      return this.UnFreeze(recipeMaint, (RecipeMaint_Parameters) null, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.UnFreeze(recipeMaint, (RecipeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDownloadFile(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.DownloadFile((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecipeMaint) recipeMaint, (RecipeMaint_LoadESigDetails_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.New((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.Load((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recipeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecipeMaint) recipeMaint, (RecipeMaint_Parameters) parameters, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      try
      {
        RecipeMaintMethod[] methods = new RecipeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecipeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeMaint cdo,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      try
      {
        return ((IRecipeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RecipeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RecipeMaint) cdo, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.GetEnvironment((RecipeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecipeMaint cdo,
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      result = (RecipeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecipeMaintMethod(cdo, RecipeMaintMethods.ExecuteTransaction, (RecipeMaint_Parameters) null));
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
        RecipeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecipeMaint) cdo, (RecipeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecipeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RecipeMaint_Request) null, out RecipeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecipeMaint_Request request,
      out RecipeMaint_Result result)
    {
      return this.ExecuteTransaction((RecipeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecipeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecipeMaintMethod(cdo, RecipeMaintMethods.AddDataTransaction, (RecipeMaint_Parameters) null));
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
        return this.AddDataTransaction((RecipeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
