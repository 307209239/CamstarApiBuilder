// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProductMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProductMaintService : RevisionedObjectMaintBase
  {
    public ProductMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProductMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).Delete(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Delete(ProductMaint productMaint)
    {
      return this.Delete(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Delete(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.Delete(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ProductMaint productMaint)
    {
      return this.DeleteAllRevisions(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.DeleteAllRevisions(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).Freeze(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Freeze(ProductMaint productMaint)
    {
      return this.Freeze(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Freeze(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.Freeze(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).GetWIPMsgs(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProductMaint productMaint)
    {
      return this.GetWIPMsgs(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.GetWIPMsgs(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).Load(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Load(ProductMaint productMaint)
    {
      return this.Load(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus Load(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.Load(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProductMaint productMaint,
      ProductMaint_LoadESigDetails_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).LoadESigDetails(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.LoadESigDetails, (ProductMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProductMaint) null, (ProductMaint_LoadESigDetails_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProductMaint productMaint)
    {
      return this.LoadESigDetails(productMaint, (ProductMaint_LoadESigDetails_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.LoadESigDetails(productMaint, (ProductMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).New(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus New(ProductMaint productMaint)
    {
      return this.New(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus New(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.New(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).NewCopy(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewCopy(ProductMaint productMaint)
    {
      return this.NewCopy(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.NewCopy(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).NewRev(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewRev(ProductMaint productMaint)
    {
      return this.NewRev(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewRev(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.NewRev(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).NewRevCopy(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewRevCopy(ProductMaint productMaint)
    {
      return this.NewRevCopy(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.NewRevCopy(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).SaveAs(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus SaveAs(ProductMaint productMaint)
    {
      return this.SaveAs(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.SaveAs(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).SaveAsRev(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus SaveAsRev(ProductMaint productMaint)
    {
      return this.SaveAsRev(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.SaveAsRev(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProductMaint productMaint,
      ProductMaint_Parameters parameters,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) productMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).UnFreeze(this._UserProfile, productMaint, parameters, request, out result) : this.AddMethod((Method) new ProductMaintMethod(productMaint, ProductMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) productMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProductMaint) null, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus UnFreeze(ProductMaint productMaint)
    {
      return this.UnFreeze(productMaint, (ProductMaint_Parameters) null, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProductMaint productMaint,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.UnFreeze(productMaint, (ProductMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProductMaint) productMaint, (ProductMaint_LoadESigDetails_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.New((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject productMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProductMaint) productMaint, (ProductMaint_Parameters) parameters, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      try
      {
        ProductMaintMethod[] methods = new ProductMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProductMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductMaint cdo,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      try
      {
        return ((IProductMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProductMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProductMaint) cdo, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.GetEnvironment((ProductMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProductMaint cdo,
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      result = (ProductMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProductMaintMethod(cdo, ProductMaintMethods.ExecuteTransaction, (ProductMaint_Parameters) null));
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
        ProductMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProductMaint) cdo, (ProductMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProductMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProductMaint_Request) null, out ProductMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProductMaint_Request request,
      out ProductMaint_Result result)
    {
      return this.ExecuteTransaction((ProductMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProductMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProductMaintMethod(cdo, ProductMaintMethods.AddDataTransaction, (ProductMaint_Parameters) null));
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
        return this.AddDataTransaction((ProductMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
