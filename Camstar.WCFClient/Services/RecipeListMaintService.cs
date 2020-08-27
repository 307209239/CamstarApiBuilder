// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecipeListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecipeListMaintService : ProcessListMaintBase
  {
    public RecipeListMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecipeListMaintService), userProfile);
    }

    public ResultStatus Delete(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).Delete(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Delete(RecipeListMaint recipeListMaint)
    {
      return this.Delete(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Delete(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.Delete(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(RecipeListMaint recipeListMaint)
    {
      return this.DeleteAllRevisions(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.DeleteAllRevisions(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).Freeze(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Freeze(RecipeListMaint recipeListMaint)
    {
      return this.Freeze(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Freeze(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.Freeze(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).GetWIPMsgs(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RecipeListMaint recipeListMaint)
    {
      return this.GetWIPMsgs(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.GetWIPMsgs(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).Load(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Load(RecipeListMaint recipeListMaint)
    {
      return this.Load(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus Load(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.Load(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_LoadESigDetails_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).LoadESigDetails(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.LoadESigDetails, (RecipeListMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecipeListMaint) null, (RecipeListMaint_LoadESigDetails_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RecipeListMaint recipeListMaint)
    {
      return this.LoadESigDetails(recipeListMaint, (RecipeListMaint_LoadESigDetails_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.LoadESigDetails(recipeListMaint, (RecipeListMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).New(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus New(RecipeListMaint recipeListMaint)
    {
      return this.New(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus New(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.New(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).NewCopy(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewCopy(RecipeListMaint recipeListMaint)
    {
      return this.NewCopy(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewCopy(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.NewCopy(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).NewRev(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewRev(RecipeListMaint recipeListMaint)
    {
      return this.NewRev(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewRev(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.NewRev(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).NewRevCopy(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewRevCopy(RecipeListMaint recipeListMaint)
    {
      return this.NewRevCopy(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.NewRevCopy(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).SaveAs(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus SaveAs(RecipeListMaint recipeListMaint)
    {
      return this.SaveAs(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus SaveAs(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.SaveAs(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).SaveAsRev(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus SaveAsRev(RecipeListMaint recipeListMaint)
    {
      return this.SaveAsRev(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.SaveAsRev(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) recipeListMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).UnFreeze(this._UserProfile, recipeListMaint, parameters, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(recipeListMaint, RecipeListMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) recipeListMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RecipeListMaint) null, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus UnFreeze(RecipeListMaint recipeListMaint)
    {
      return this.UnFreeze(recipeListMaint, (RecipeListMaint_Parameters) null, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.UnFreeze(recipeListMaint, (RecipeListMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecipeListMaint) recipeListMaint, (RecipeListMaint_LoadESigDetails_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.New((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.Load((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recipeListMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeListMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecipeListMaint) recipeListMaint, (RecipeListMaint_Parameters) parameters, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      try
      {
        RecipeListMaintMethod[] methods = new RecipeListMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecipeListMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeListMaint cdo,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      try
      {
        return ((IRecipeListMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RecipeListMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RecipeListMaint) cdo, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.GetEnvironment((RecipeListMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecipeListMaint cdo,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      result = (RecipeListMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeListMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecipeListMaintMethod(cdo, RecipeListMaintMethods.ExecuteTransaction, (RecipeListMaint_Parameters) null));
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
        RecipeListMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecipeListMaint) cdo, (RecipeListMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecipeListMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RecipeListMaint_Request) null, out RecipeListMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result)
    {
      return this.ExecuteTransaction((RecipeListMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecipeListMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecipeListMaintMethod(cdo, RecipeListMaintMethods.AddDataTransaction, (RecipeListMaint_Parameters) null));
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
        return this.AddDataTransaction((RecipeListMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
