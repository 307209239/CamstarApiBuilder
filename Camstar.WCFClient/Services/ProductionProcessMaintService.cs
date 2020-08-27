// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProductionProcessMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProductionProcessMaintService : RevisionedObjectMaintBase
  {
    public ProductionProcessMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProductionProcessMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).Delete(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Delete(ProductionProcessMaint productionProcessMaint)
    {
      return this.Delete(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Delete(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.Delete(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ProductionProcessMaint productionProcessMaint)
    {
      return this.DeleteAllRevisions(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.DeleteAllRevisions(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).Freeze(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Freeze(ProductionProcessMaint productionProcessMaint)
    {
      return this.Freeze(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Freeze(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.Freeze(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).GetWIPMsgs(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProductionProcessMaint productionProcessMaint)
    {
      return this.GetWIPMsgs(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.GetWIPMsgs(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).Load(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Load(ProductionProcessMaint productionProcessMaint)
    {
      return this.Load(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus Load(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.Load(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_LoadESigDetails_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).LoadESigDetails(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.LoadESigDetails, (ProductionProcessMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProductionProcessMaint) null, (ProductionProcessMaint_LoadESigDetails_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProductionProcessMaint productionProcessMaint)
    {
      return this.LoadESigDetails(productionProcessMaint, (ProductionProcessMaint_LoadESigDetails_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.LoadESigDetails(productionProcessMaint, (ProductionProcessMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).New(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus New(ProductionProcessMaint productionProcessMaint)
    {
      return this.New(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus New(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.New(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).NewCopy(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewCopy(ProductionProcessMaint productionProcessMaint)
    {
      return this.NewCopy(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.NewCopy(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).NewRev(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewRev(ProductionProcessMaint productionProcessMaint)
    {
      return this.NewRev(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewRev(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.NewRev(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).NewRevCopy(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewRevCopy(ProductionProcessMaint productionProcessMaint)
    {
      return this.NewRevCopy(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.NewRevCopy(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).SaveAs(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus SaveAs(ProductionProcessMaint productionProcessMaint)
    {
      return this.SaveAs(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.SaveAs(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).SaveAsRev(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus SaveAsRev(ProductionProcessMaint productionProcessMaint)
    {
      return this.SaveAsRev(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.SaveAsRev(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Parameters parameters,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).UnFreeze(this._UserProfile, productionProcessMaint, parameters, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(productionProcessMaint, ProductionProcessMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) productionProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProductionProcessMaint) null, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus UnFreeze(ProductionProcessMaint productionProcessMaint)
    {
      return this.UnFreeze(productionProcessMaint, (ProductionProcessMaint_Parameters) null, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProductionProcessMaint productionProcessMaint,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.UnFreeze(productionProcessMaint, (ProductionProcessMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_LoadESigDetails_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.New((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject productionProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductionProcessMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProductionProcessMaint) productionProcessMaint, (ProductionProcessMaint_Parameters) parameters, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      try
      {
        ProductionProcessMaintMethod[] methods = new ProductionProcessMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProductionProcessMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductionProcessMaint cdo,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      try
      {
        return ((IProductionProcessMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProductionProcessMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProductionProcessMaint) cdo, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.GetEnvironment((ProductionProcessMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProductionProcessMaint cdo,
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      result = (ProductionProcessMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductionProcessMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProductionProcessMaintMethod(cdo, ProductionProcessMaintMethods.ExecuteTransaction, (ProductionProcessMaint_Parameters) null));
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
        ProductionProcessMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProductionProcessMaint) cdo, (ProductionProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProductionProcessMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProductionProcessMaint_Request) null, out ProductionProcessMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProductionProcessMaint_Request request,
      out ProductionProcessMaint_Result result)
    {
      return this.ExecuteTransaction((ProductionProcessMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProductionProcessMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProductionProcessMaintMethod(cdo, ProductionProcessMaintMethods.AddDataTransaction, (ProductionProcessMaint_Parameters) null));
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
        return this.AddDataTransaction((ProductionProcessMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
