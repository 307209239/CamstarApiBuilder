// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProductFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProductFamilyMaintService : NamedDataObjectMaintBase
  {
    public ProductFamilyMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProductFamilyMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).Delete(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Delete(ProductFamilyMaint productFamilyMaint)
    {
      return this.Delete(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Delete(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.Delete(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).Freeze(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Freeze(ProductFamilyMaint productFamilyMaint)
    {
      return this.Freeze(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Freeze(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.Freeze(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).GetWIPMsgs(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProductFamilyMaint productFamilyMaint)
    {
      return this.GetWIPMsgs(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.GetWIPMsgs(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).Load(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Load(ProductFamilyMaint productFamilyMaint)
    {
      return this.Load(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus Load(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.Load(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_LoadESigDetails_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).LoadESigDetails(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.LoadESigDetails, (ProductFamilyMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProductFamilyMaint) null, (ProductFamilyMaint_LoadESigDetails_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProductFamilyMaint productFamilyMaint)
    {
      return this.LoadESigDetails(productFamilyMaint, (ProductFamilyMaint_LoadESigDetails_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.LoadESigDetails(productFamilyMaint, (ProductFamilyMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).New(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus New(ProductFamilyMaint productFamilyMaint)
    {
      return this.New(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus New(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.New(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).NewCopy(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(ProductFamilyMaint productFamilyMaint)
    {
      return this.NewCopy(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.NewCopy(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).SaveAs(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(ProductFamilyMaint productFamilyMaint)
    {
      return this.SaveAs(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.SaveAs(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Parameters parameters,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).UnFreeze(this._UserProfile, productFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(productFamilyMaint, ProductFamilyMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) productFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProductFamilyMaint) null, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(ProductFamilyMaint productFamilyMaint)
    {
      return this.UnFreeze(productFamilyMaint, (ProductFamilyMaint_Parameters) null, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProductFamilyMaint productFamilyMaint,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.UnFreeze(productFamilyMaint, (ProductFamilyMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_LoadESigDetails_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.New((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject productFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductFamilyMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProductFamilyMaint) productFamilyMaint, (ProductFamilyMaint_Parameters) parameters, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      try
      {
        ProductFamilyMaintMethod[] methods = new ProductFamilyMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProductFamilyMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductFamilyMaint cdo,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      try
      {
        return ((IProductFamilyMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProductFamilyMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProductFamilyMaint) cdo, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.GetEnvironment((ProductFamilyMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProductFamilyMaint cdo,
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      result = (ProductFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductFamilyMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProductFamilyMaintMethod(cdo, ProductFamilyMaintMethods.ExecuteTransaction, (ProductFamilyMaint_Parameters) null));
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
        ProductFamilyMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProductFamilyMaint) cdo, (ProductFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProductFamilyMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProductFamilyMaint_Request) null, out ProductFamilyMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProductFamilyMaint_Request request,
      out ProductFamilyMaint_Result result)
    {
      return this.ExecuteTransaction((ProductFamilyMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProductFamilyMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProductFamilyMaintMethod(cdo, ProductFamilyMaintMethods.AddDataTransaction, (ProductFamilyMaint_Parameters) null));
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
        return this.AddDataTransaction((ProductFamilyMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
